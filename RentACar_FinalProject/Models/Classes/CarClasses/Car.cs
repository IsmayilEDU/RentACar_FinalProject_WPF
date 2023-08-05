using RentACar_FinalProject.Functions;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes
{
    public class Car : IiD
    {

        
        #region Fields

        //  ID
        public Guid ID { get; init; }

        //  Available
        public bool IsAvaible { get; set; }


        //  Make
        private string _make;
        public string Make
        {
            get { return _make; }
            set 
            {
                if (MyRegex.CheckLettersStartWithUppercase(value))
                {
                    _make = value;
                }
                else
                {
                    throw new Exception("Make should be start with upper case!");
                }
            }
        }

        //  Model
        private string _model;
        public string Model
        {
            get { return _model; }
            set 
            {
                _model= value;
            }
        }

        //  Year
        private int _year;
        public int Year
        {
            get { return _year; }
            set 
            {
                if (value >= 2000)
                {
                    _year = value;
                }
                else
                {
                    throw new Exception("Year should be more than 2000!");
                }
            }
        }

        //  Location
        public Location location { get; set; }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }




        //  Amount of total rent
        private double _RentDayAmount;
        public double RentDayAmount
        {
            get { return _RentDayAmount; }
            set
            {
                if (value > 0)
                {
                    _RentDayAmount = value;
                }
                else
                {
                    throw new Exception("Amount of RentDay should be positive number!");
                }
            }
        }


        //  Day of rent
        private int _RentDayCount;
        public int RentDayCount
        {
            get { return _RentDayCount; }
            set
            {
               _RentDayCount = value;
            }
        }
        

        //  ID of customer
        public string CustomerName { get; set; }

        #endregion

        #region Operations
        
        public Car (string make, string model, int year, double rentDayAmount, int rentDayCount = 0, string customerName = null!)
        {
            ID = Guid.NewGuid();
            Make = make;
            Model = model;
            Year = year;
            RentDayAmount = rentDayAmount;
            IsAvaible = true;
            
            RentDayCount = rentDayCount;
            if (rentDayCount > 0)
            {
                IsAvaible = false;
                CustomerName = customerName;
                location = MyDatabase.GetRandomLocation();
                Location = location.Longitude.ToString()+ ", " + location.Latitude.ToString();
            }
        }

        
        #endregion

    }


}
