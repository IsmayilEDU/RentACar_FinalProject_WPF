using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Views;
using RentACar_FinalProject.Views.Owner.Pages;
using RentACar_FinalProject.Views.SharedPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    internal class OwnerViewModel
    {
        #region Fields

        private Frame _OwnerFrame;
        public Owner SelectedOwner { get; set; }

        #endregion

        #region Operations

        public OwnerViewModel(Frame ownerFrame, Owner selectedOwner)
        {
            SelectedOwner = selectedOwner;
            _OwnerFrame= ownerFrame;
            BusyCars = new RelayCommand(busyCars);
            AllCars = new RelayCommand(allCars);
            BudgetHistory = new RelayCommand(budgetHistory);
            Exit = new RelayCommand(exit);
        }

        #endregion

        #region Commands

        public RelayCommand BusyCars { get; set; }
        public RelayCommand AllCars { get; set; }
        public RelayCommand BudgetHistory { get; set; }
        public RelayCommand Exit { get; set; }

        #endregion

        #region Functions of commands

        private void busyCars()
        {
            
            
        }
        private void allCars()
        {
            _OwnerFrame.DataContext = new AllCarsPage();
        }
        private void budgetHistory()
        {
            _OwnerFrame.DataContext = new BudgetOperationsPage();
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
