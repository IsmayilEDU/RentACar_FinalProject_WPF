using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Views.Owner.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    class AllCarsViewModel : INotifyPropertyChanged
    {
        #region Fields

        //  All Cars
        public Owner SelectedOwner { get; set; }

        //  Selected Car
        private Car selectedCar;
        public Car SelectedCar
        {
            get => selectedCar;
            set
            {
                selectedCar = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public RelayCommand AddCar { get; set; }
        public RelayCommand UpdateCar { get; set; }
        public RelayCommand DeleteCar { get; set; }
        #endregion

        #region Operations

        public AllCarsViewModel(Owner selectedOwner)
        {
            SelectedOwner = selectedOwner;
            SelectedCar = selectedOwner.Cars[0];
            AddCar = new RelayCommand(addCar);
            UpdateCar = new RelayCommand(updateCar);
            DeleteCar = new RelayCommand(deleteCar);
        }

        #endregion

        #region Functions of commands

        public void addCar()
        {
            Application.Current.MainWindow.Hide();
            AddCarView addCarView = new(SelectedOwner);
            Application.Current.MainWindow = addCarView;
            addCarView.Show();
        }

        public void updateCar()
        {

        }

        public void deleteCar()
        {

        }
        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }

        #endregion
    }
}
