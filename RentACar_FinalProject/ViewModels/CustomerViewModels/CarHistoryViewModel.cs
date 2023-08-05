using RentACar_FinalProject.Models.Classes.OperationClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.ViewModels.CustomerViewModels
{
    internal class CarHistoryViewModel
    {
        public ObservableCollection<CarHistory> CarHistories { get; set; }
        public CarHistoryViewModel( ObservableCollection<CarHistory> carHistories) 
        {
            CarHistories= carHistories;
        }
    }
}
