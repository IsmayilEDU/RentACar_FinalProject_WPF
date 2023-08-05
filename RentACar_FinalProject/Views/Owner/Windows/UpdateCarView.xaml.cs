using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.ViewModels.OwnerViewModels;
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

namespace RentACar_FinalProject.Views.Owner.Windows
{
    /// <summary>
    /// Interaction logic for UpdateCarView.xaml
    /// </summary>
    public partial class UpdateCarView : Window
    {
        public UpdateCarView(Car selectedCar, Models.Classes.UserClasses.Owner SelectedOwner)
        {
            InitializeComponent();
            DataContext = new UpdateCarViewModel(InputMake, InputModel,InputYear, InputAmount, selectedCar, SelectedOwner);
        }
    }
}
