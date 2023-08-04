using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.ViewModels.OwnerViewModels;
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


namespace RentACar_FinalProject.Views.Owner.Pages
{
    /// <summary>
    /// Interaction logic for BusyCarsPage.xaml
    /// </summary>
    public partial class BusyCarsPage : Page
    {
        BusyCarsViewModel busyCarsViewModel;
        public BusyCarsPage(ObservableCollection<Car> BusyCars)
        {
            InitializeComponent();
            busyCarsViewModel = new BusyCarsViewModel(BusyCars);
            DataContext = busyCarsViewModel;
        }

        private void BusyCarListItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            busyCarsViewModel.SelectedBusyCar = BusyCarListItems.SelectedItem as Car;
        }
    }
}
