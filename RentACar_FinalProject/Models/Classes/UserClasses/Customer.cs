using RentACar_FinalProject.Models.Classes.AbstractClasses;
using RentACar_FinalProject.Models.Classes.OperationClasses;
using RentACar_FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.UserClasses
{
    public class Customer : User
    {

        #region Fields

        //  History of rent cars
        public ObservableCollection<CarHistory> HistoryOfCars { get; set; }

        //  History of rent cars
        public ObservableCollection<BudgetOperation> OperationsOfBudget { get; set; }

        #endregion

        #region Operations

        public Customer(string username, string password, BankCard card,
            ObservableCollection<CarHistory> historyOfCars, ObservableCollection<BudgetOperation> operationsOfBudget)
            : base(username, password, card)
        {
            HistoryOfCars = historyOfCars;
            OperationsOfBudget = operationsOfBudget;
        }

        public Customer(string username, string password, BankCard card)
            : base(username, password, card) { }

        #endregion

    }
}
