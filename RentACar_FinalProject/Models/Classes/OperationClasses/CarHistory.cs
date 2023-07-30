using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.OperationClasses
{
    public class CarHistory 
    {
        //  ID of Car
        public Guid CarID { get; init; }

        //  Make of car
        public string Make { get; init; }
        
        //  Model of car
        public string Model { get; init; }

        //  Day count of rent
        public int RentDayCount { get; set; }

        public CarHistory(Car car)
        {
            CarID = car.ID;
            Make = car.Make;
            Model = car.Model;
            RentDayCount= car.RentDayCount;
        }


    }
}
