using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views.Owner.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    internal class AddCarViewModel
    {
        #region Fields

        TextBoxWithPlaceHolder _InputMake;
        TextBoxWithPlaceHolder _InputModel;
        TextBoxWithPlaceHolder _InputYear;
        TextBoxWithPlaceHolder _InputAmount;
        public Owner SelectedOwner { get; set; }

        #endregion

        #region Operations

        public AddCarViewModel(TextBoxWithPlaceHolder InputMake, TextBoxWithPlaceHolder InputModel,
            TextBoxWithPlaceHolder InputYear, TextBoxWithPlaceHolder InputAmount, Owner selectedOwner)
        {
            _InputMake = InputMake;
            _InputModel = InputModel;
            _InputYear = InputYear;
            _InputAmount = InputAmount;
            SelectedOwner= selectedOwner;
            AddCar = new RelayCommand(addCar);
        }
        #endregion

        #region Commands

        public RelayCommand AddCar { get; set; }

        #endregion

        #region Functions of commands

        private void addCar()
        {
            try
            {
                int year = Convert.ToInt32(_InputYear.Text);
                double amount = Convert.ToDouble(_InputAmount.Text);
                Car NewCar = new Car(_InputMake.Text, _InputModel.Text, year, amount);
                SelectedOwner.Cars.Add(NewCar);
                MyDatabase.AllCars.Add(NewCar);

                Application.Current.MainWindow.Hide();
                OwnerView ownerView = new(SelectedOwner);
                Application.Current.MainWindow = ownerView;
                ownerView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
