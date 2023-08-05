using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.ViewModels.CustomerViewModels;
using System;
using System.Collections.Generic;
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

namespace RentACar_FinalProject.Views.Customer.Windows
{
    /// <summary>
    /// Interaction logic for RentCarView.xaml
    /// </summary>
    public partial class RentCarView : Window
    {
        public RentCarView(Models.Classes.UserClasses.Customer selectedCustomer, Car selectedCar)
        {
            InitializeComponent();
            DataContext = new RentCarViewModel(selectedCustomer, selectedCar, InputDay);
        }
    }
}
