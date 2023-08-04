using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes.AbstractClasses;
using RentACar_FinalProject.Views.SharedWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.SharedPagesViewModels
{
    class ProfileInfoViewModel
    {
        public User SelectedUser { get; set; }

        public RelayCommand AddBalance { get; set; }
        public ProfileInfoViewModel(User SelectedUser)
        {
            this.SelectedUser = SelectedUser;
            AddBalance = new RelayCommand(addBalance);
        }

        private void addBalance()
        {
            Application.Current.MainWindow.Hide();
            AddBalanceView addBalanceView = new(SelectedUser);
            Application.Current.MainWindow = addBalanceView;
            addBalanceView.Show();
        }
    }
}
