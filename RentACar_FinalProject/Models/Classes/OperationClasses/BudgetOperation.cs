using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.OperationClasses
{
    public class BudgetOperation
    {

        #region Fields

        //  Hadisenin bash verdiyi tarix
        public DateTime DateOfOccurrence { get; set; }


        //  About of operation
        public string About { get; set; }
        
        //  Expence or income
        public bool IsExpense { get; init; }


        //  Amount of operation
        private double _amount;
        public double Amount
        {
            get { return _amount; }
            set 
            {
                if (value > 0)
                {
                    _amount= value;
                }
                else 
                {
                    throw new Exception("Amount should be only positive number!");
                }
            }
        }


        #endregion

        #region Operations
        public BudgetOperation(string about, double amount, bool isExpence)
        {
            About = about;
            Amount = amount;
            IsExpense = isExpence;
            DateOfOccurrence = DateTime.Now;
        }
        #endregion

    }
}
