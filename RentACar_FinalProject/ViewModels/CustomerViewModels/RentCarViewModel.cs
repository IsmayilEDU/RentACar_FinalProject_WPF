using GalaSoft.MvvmLight.Command;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes.OperationClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Templates.UserControls;
using RentACar_FinalProject.Views.Customer.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace RentACar_FinalProject.ViewModels.CustomerViewModels
{
    class RentCarViewModel
    {

        public Customer SelectedCustomer { get; set; }
        public Car SelectedCar { get; set; }

        public RelayCommand Rent { get; set; }

        TextBoxWithPlaceHolder _InputDay;

        public RentCarViewModel(Customer selectedCustomer, Car selectedCar, TextBoxWithPlaceHolder InputDay)
        {
            SelectedCustomer= selectedCustomer;
            SelectedCar= selectedCar;
            Rent = new RelayCommand(rent);
            _InputDay = InputDay;
        }

        private void rent()
        {
            try
            {
                int day = Convert.ToInt32(_InputDay.Text);
                if (day*SelectedCar.RentDayAmount > SelectedCustomer.Card.Balance)
                {
                    throw new Exception("Total amount can not be more than balance!");
                }
                SelectedCustomer.Card.Balance -= day * SelectedCar.RentDayAmount;
                SelectedCar.CustomerName = SelectedCustomer.Username;
                SelectedCar.RentDayCount = day;
                SelectedCar.location = MyDatabase.GetRandomLocation();
                SelectedCar.IsAvaible = false;

                SelectedCustomer.OperationsOfBudget.Add(new BudgetOperation("Mashin kirayesi", day * SelectedCar.RentDayAmount, true));
                SelectedCustomer.HistoryOfCars.Add(new CarHistory(SelectedCar));

                Application.Current.MainWindow.Hide();
                CustomerView customerView = new(SelectedCustomer);
                Application.Current.MainWindow = customerView;
                customerView.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
