using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes.AbstractClasses;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views;
using RentACar_FinalProject.Views.Customer.Windows;
using RentACar_FinalProject.Views.Owner.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RentACar_FinalProject.ViewModels
{
    internal class LoginViewModel
    {

        #region Fields

        private TextBoxWithPlaceHolder _username;
        private TextBoxWithPlaceHolder _password;
        private RadioButton _IsOwner;

        #endregion

        #region Commands

        public RelayCommand Login { get; set; }
        public RelayCommand Register { get; set; }

        #endregion

        #region Operations
        public LoginViewModel(TextBoxWithPlaceHolder username,TextBoxWithPlaceHolder password, RadioButton isOwner)
        {
            Login = new RelayCommand(login);
            Register = new RelayCommand(register);
            
            _username = username;
            _password = password;
            _IsOwner = isOwner;
        }

        private Owner SearchedOwner()
        {
            Owner? SearchedOwner = null;

            foreach (Owner owner in MyDatabase.Owners)
            {
                if (_username.Text == owner.Username && _password.Text == owner.Password)
                {
                    SearchedOwner = owner;
                }
            }
            return SearchedOwner!;
        }
        
        private Customer SearchedCustomer()
        {
            Customer? SearchedCustomer = null;

            foreach (Customer customer in MyDatabase.Customers)
            {
                if (_username.Text == customer.Username && _password.Text == customer.Password)
                {
                    SearchedCustomer = customer;
                }
            }
            return SearchedCustomer!;
        }

        #endregion

        #region Functions of commands

        private void register()
        {
            Application.Current.MainWindow.Hide();
            RegisterView registerView = new(_IsOwner);
            Application.Current.MainWindow= registerView;
            registerView.Show();
        }

        private void login()
        {
            try
            {
                if (_IsOwner.IsChecked == true)
                {
                    Owner SearchedOwner = this.SearchedOwner();
                    if (SearchedOwner == null)
                    {
                        throw new Exception("Username or password invalid!");
                    }

                    Application.Current.MainWindow.Hide();
                    OwnerView ownerView = new(SearchedOwner);
                    Application.Current.MainWindow = ownerView;
                    ownerView.Show();

                }
                else
                {
                    Customer SearchedCustomer = this.SearchedCustomer();
                    if (SearchedCustomer == null)
                    {
                        throw new Exception("Username or password invalid!");
                    }

                    Application.Current.MainWindow.Hide();
                    CustomerView customerView = new(SearchedCustomer);
                    Application.Current.MainWindow = customerView;
                    customerView.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
