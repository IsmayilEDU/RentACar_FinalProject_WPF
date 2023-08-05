using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views.Owner.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    class UpdateCarViewModel
    {
        #region Fields

        TextBoxWithPlaceHolder _InputMake;
        TextBoxWithPlaceHolder _InputModel;
        TextBoxWithPlaceHolder _InputYear;
        TextBoxWithPlaceHolder _InputAmount;
        public Car SelectedCar { get; set; }
        public Owner SelectedOwner { get; set; }

        #endregion

        #region Operations

        public UpdateCarViewModel(TextBoxWithPlaceHolder InputMake, TextBoxWithPlaceHolder InputModel,
            TextBoxWithPlaceHolder InputYear, TextBoxWithPlaceHolder InputAmount, Car selectedCar, Owner selectedOwner) 
        { 
            _InputMake= InputMake;
            _InputModel= InputModel;
            _InputYear= InputYear;
            _InputAmount= InputAmount;
            SelectedCar= selectedCar;
            SelectedOwner = selectedOwner;
            UpdateCar = new RelayCommand(updateCar);
        }

        #endregion

        #region Commands

        public RelayCommand UpdateCar { get; set; }

        #endregion

        #region Functions of commands

        private void updateCar()
        {
            try
            {
                if ((_InputMake.Text.Length == 0) && (_InputModel.Text.Length == 0) &&
                    (_InputYear.Text.Length == 0) && (_InputAmount.Text.Length == 0))
                {
                    throw new Exception("Paramaeter can not be empty!");
                }

                int year = Convert.ToInt32(_InputYear.Text);
                double amount = Convert.ToDouble(_InputAmount.Text);

                SelectedCar.Make = _InputMake.Text;
                SelectedCar.Model = _InputModel.Text;
                SelectedCar.Year = year;
                SelectedCar.RentDayAmount = amount;

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
