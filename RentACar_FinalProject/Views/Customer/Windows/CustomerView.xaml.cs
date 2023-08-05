using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes;
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
using System.Windows.Shapes;
using RentACar_FinalProject.Views.SharedPages;

namespace RentACar_FinalProject.Views.Customer.Windows
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        public CustomerView(Models.Classes.UserClasses.Customer SelectedCustomer)
        {
            InitializeComponent();
            DataContext = new ViewModels.CustomerViewModels.CustomerViewModel(CustomerFrame, SelectedCustomer);
            var AllAvailableCarsList = MyDatabase.AllCars.Where((car) => car.IsAvaible == true).ToList();
            ObservableCollection<Car> AllAvailableCars = new(AllAvailableCarsList);
            CustomerFrame.Navigate(new Views.Customer.Pages.AllCarsPage());
            ProfileInfoFrame.Navigate(new ProfileInfoPage(SelectedCustomer));
        }

        
    }
}
