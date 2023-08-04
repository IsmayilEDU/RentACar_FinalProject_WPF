using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes.AbstractClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views.Owner.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar_FinalProject.ViewModels.SharedPagesViewModels
{
    class AddBalanceViewModel
    {
        public User SelectedUser { get; set; }
        private TextBoxWithPlaceHolder _InputAmount;

        public RelayCommand Add { get; set; }
        public AddBalanceViewModel(TextBoxWithPlaceHolder InputAmount, User SelectedUser) 
        { 
            this.SelectedUser = SelectedUser;
            _InputAmount= InputAmount;
            Add = new RelayCommand(add);
        }

        private void add()
        {
            try
            {
                if (_InputAmount.Text != null)
                {
                    double inputAmount = Convert.ToDouble(_InputAmount.Text);
                    SelectedUser.Card.Balance += inputAmount;

                    Application.Current.MainWindow.Hide();
                    OwnerView ownerView = new(SelectedUser as Owner);
                    Application.Current.MainWindow = ownerView;
                    ownerView.Show();
                }
                else
                {
                    throw new Exception("Amount should be only positive number!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
