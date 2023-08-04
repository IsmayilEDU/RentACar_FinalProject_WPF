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
    /// Interaction logic for AllCarsPage.xaml
    /// </summary>
    public partial class AllCarsPage : Page
    {
        AllCarsViewModel allCarsViewModel;
        public AllCarsPage(ObservableCollection<Car> allCars)
        {
            InitializeComponent();
            allCarsViewModel = new AllCarsViewModel(allCars);
            DataContext = allCarsViewModel;
        }

        private void AllCarsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            allCarsViewModel.SelectedCar = AllCarsList.SelectedItem as Car;
        }

        private void AllCarsList_Loaded(object sender, RoutedEventArgs e)
        {
            AllCarsList.SelectedIndex = 0;
        }
    }
}
