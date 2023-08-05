using RentACar_FinalProject.Models.Classes.OperationClasses;
using RentACar_FinalProject.ViewModels.CustomerViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RentACar_FinalProject.Views.Customer.Pages
{
    /// <summary>
    /// Interaction logic for CarHistoryPage.xaml
    /// </summary>
    public partial class CarHistoryPage : Page
    {
        public CarHistoryPage(ObservableCollection<CarHistory> carHistories)
        {
            InitializeComponent();
            DataContext = new CarHistoryViewModel(carHistories);
        }
    }
}
