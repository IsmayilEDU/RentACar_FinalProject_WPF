using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RentACar_FinalProject.ViewModels
{
    internal class RegisterViewModel
    {
        #region Fields

        private RadioButton _IsOwner;
        private TextBoxWithPlaceHolder _InputUsername;
        private TextBoxWithPlaceHolder _InputPassword;
        private TextBoxWithPlaceHolder _InputNameOfBank;
        private TextBoxWithPlaceHolder _InputCardNumber;
        private TextBoxWithPlaceHolder _InputDay;
        private TextBoxWithPlaceHolder _InputMonth;
        private TextBoxWithPlaceHolder _InputYear;
        private TextBoxWithPlaceHolder _InputCVC;
        private TextBoxWithPlaceHolder _InputBalance;

        #endregion

        #region Commands

        public RelayCommand Register { get; set; }
        public RelayCommand Home { get; set; }

        #endregion

        #region Functions of commands

        private void home()
        {
            Application.Current.MainWindow.Hide();
            LoginView loginView= new LoginView();
            Application.Current.MainWindow= loginView;
            loginView.Show();
        }

        private void register()
        {
            
            //  Create expiration date
            int year = Convert.ToInt32(_InputYear.Text);
            int month = Convert.ToInt32(_InputMonth.Text);
            int day = Convert.ToInt32(_InputDay.Text);
            DateTime expirationDate = new (year, month, day);

            //  Create bankcard
            double balance = Convert.ToDouble(_InputBalance.Text);
            BankCard bankCard = new(_InputNameOfBank.Text, _InputCardNumber.Text, expirationDate, _InputCVC.Text, balance);

            //  Check owner
            if (_IsOwner.IsChecked == true)
            {
                //  Create owner
                MyDatabase.Owners.Add(new Owner(_InputUsername.Text, _InputPassword.Text, bankCard));
            }
            else
            {
                MyDatabase.Customers.Add(new Customer(_InputUsername.Text, _InputPassword.Text, bankCard));
            }

            Application.Current.MainWindow.Hide();
            LoginView loginView = new LoginView();
            Application.Current.MainWindow = loginView;
            loginView.Show();
        }

        #endregion

        #region Operations
        public RegisterViewModel (RadioButton isOwner, TextBoxWithPlaceHolder inputUsername,
            TextBoxWithPlaceHolder inputPassword, TextBoxWithPlaceHolder InputNameOfBank,
            TextBoxWithPlaceHolder InputCardNumber, TextBoxWithPlaceHolder InputDay,
            TextBoxWithPlaceHolder InputMonth, TextBoxWithPlaceHolder InputYear,
            TextBoxWithPlaceHolder InputCVC, TextBoxWithPlaceHolder InputBalance
            )
        {
            _IsOwner = isOwner;
            _InputUsername= inputUsername;
            _InputPassword= inputPassword;
            _InputNameOfBank = InputNameOfBank;
            _InputCardNumber = InputCardNumber;
            _InputDay = InputDay;
            _InputMonth = InputMonth;
            _InputYear = InputYear;
            _InputCVC= InputCVC;
            _InputBalance = InputBalance;
            Register = new RelayCommand(register);
            Home = new RelayCommand(home);
        }
        #endregion
    }
}
