using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Views.Owner.Pages;
using RentACar_FinalProject.Views.SharedPages;
using RentACar_FinalProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Collections.ObjectModel;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;

namespace RentACar_FinalProject.ViewModels.CustomerViewModels
{
    class CustomerViewModel
    {
        #region Fields

        private Frame _CustomerFrame;
        public Customer SelectedCustomer { get; set; }

        #endregion

        #region Operations

        public CustomerViewModel(Frame CustomerFrame, Customer selectedCustomer)
        {
            SelectedCustomer = selectedCustomer;
            _CustomerFrame = CustomerFrame;
            AllCars = new RelayCommand(allCars);
            BudgetHistory = new RelayCommand(budgetHistory);
            CarHistory = new RelayCommand(carHistory);
            Exit = new RelayCommand(exit);
        }

        #endregion

        #region Commands

        public RelayCommand AllCars { get; set; }
        public RelayCommand BudgetHistory { get; set; }
        public RelayCommand CarHistory { get; set; }
        public RelayCommand Exit { get; set; }

        #endregion

        #region Functions of commands

        
        public void allCars()
        {
            var AllAvailableCarsList = MyDatabase.AllCars.Where((car) => car.IsAvaible == true).ToList();
            ObservableCollection<Car> AllAvailableCars = new(AllAvailableCarsList);
            _CustomerFrame.Navigate(new Views.Customer.Pages.AllCarsPage());
        }
        public void budgetHistory()
        {
            _CustomerFrame.Navigate(new Views.SharedPages.BudgetOperationsPage(SelectedCustomer));
        }
        public void carHistory()
        {
        }

        private void exit()
        {
            Application.Current.MainWindow.Hide();
            LoginView loginView = new LoginView();
            Application.Current.MainWindow = loginView;
            loginView.ShowDialog();
        }

        #endregion
    }
}
