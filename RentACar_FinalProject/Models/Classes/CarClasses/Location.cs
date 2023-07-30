using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes
{
    public class Location
    {
        public Location(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        //  Uzunluq
        public double Longitude { get; set; }

        //  En
        public double Latitude { get; set; }
    }
}
