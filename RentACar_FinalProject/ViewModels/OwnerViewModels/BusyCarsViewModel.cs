using RentACar_FinalProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    class BusyCarsViewModel
    {
        #region Fields

        public ObservableCollection<Car> BusyCars { get; set; }

        public Car SelectedBusyCar { get; set; }

        #endregion

        #region Operations

        public BusyCarsViewModel(ObservableCollection<Car> BusyCars)
        {
            this.BusyCars = BusyCars;
            SelectedBusyCar = this.BusyCars[0];
        }


        #endregion
    }
}
