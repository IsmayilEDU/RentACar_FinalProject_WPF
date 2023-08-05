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
using System.Windows.Shapes;

namespace RentACar_FinalProject.Views.Owner.Windows
{
    /// <summary>
    /// Interaction logic for AddCarView.xaml
    /// </summary>
    public partial class AddCarView : Window
    {
        public AddCarView(Models.Classes.UserClasses.Owner SelectedOwner)
        {
            InitializeComponent();
            DataContext = new AddCarViewModel(InputMake, InputModel, InputYear, InputAmount, SelectedOwner);
        }
    }
}
