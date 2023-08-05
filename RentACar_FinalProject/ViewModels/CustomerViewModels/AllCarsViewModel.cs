using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Views.Customer.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.CustomerViewModels
{
    internal class AllCarsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Car> AllCars { get; set; }

        public Customer SelectedCustomer { get; set; }

        private Car _SelectedCar;
        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set 
            { 
                _SelectedCar = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand Rent { get; set; }

        public AllCarsViewModel(ObservableCollection<Car> allCars, Customer selectedCustomer)
        {
            AllCars = allCars;
            SelectedCar = AllCars[0];
            SelectedCustomer = selectedCustomer;
            Rent = new RelayCommand(rent);
        }


        private void rent()
        {
            Application.Current.MainWindow.Hide();
            RentCarView rentCarView = new(SelectedCustomer,SelectedCar);
            Application.Current.MainWindow = rentCarView;
            rentCarView.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }
    }
}
