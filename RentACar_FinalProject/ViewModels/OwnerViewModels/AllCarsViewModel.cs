using RentACar_FinalProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    class AllCarsViewModel : INotifyPropertyChanged
    {
        #region Fields

        //  All Cars
        public ObservableCollection<Car> AllCars { get; set; }

        //  Selected Car
        private Car selectedCar;
        public Car SelectedCar
        {
            get => selectedCar;
            set
            {
                selectedCar = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Operations

        public AllCarsViewModel(ObservableCollection<Car> BusyCars)
        {
            this.AllCars = BusyCars;
            SelectedCar = this.AllCars[0];
        }


        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }

        #endregion
    }
}
