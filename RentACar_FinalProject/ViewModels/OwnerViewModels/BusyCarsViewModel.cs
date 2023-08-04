using RentACar_FinalProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RentACar_FinalProject.ViewModels.OwnerViewModels
{
    class BusyCarsViewModel : INotifyPropertyChanged
    {
        #region Fields

        //  Busy Cars
        public ObservableCollection<Car> BusyCars { get; set; }

        //  Selected Car
        private Car selectedBusyCar;
        public Car SelectedBusyCar { get => selectedBusyCar;
            set
            {
                selectedBusyCar = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Operations

        public BusyCarsViewModel(ObservableCollection<Car> BusyCars)
        {
            this.BusyCars = BusyCars;
            SelectedBusyCar = this.BusyCars[0];
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
