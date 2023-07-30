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
    public class Owner : User
    {

        #region Fields

        //  Cars
        public ObservableCollection<Car> Cars { get; set; }
        public ObservableCollection<Car> RentalCars { get; set; } = new ObservableCollection<Car>();

        //  Operations of budget
        public ObservableCollection<BudgetOperation> OperationsOfBudget { get; set; }
        #endregion

        #region Operations

        public Owner( string username, string password, BankCard card,
            ObservableCollection<Car> cars, ObservableCollection<BudgetOperation> operationsOfBudget)
            : base(username, password, card)
        {
            Cars = cars;
            foreach (var car in cars)
            {
                if (car.IsAvaible == false)
                {
                    RentalCars.Add(car);
                }
            }
            OperationsOfBudget = operationsOfBudget;
        }
        
        public Owner( string username, string password, BankCard card)
            : base(username, password, card) { }
        #endregion

    }
}
