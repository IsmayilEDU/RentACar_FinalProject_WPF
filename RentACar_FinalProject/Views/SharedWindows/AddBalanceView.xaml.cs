using RentACar_FinalProject.Models.Classes.AbstractClasses;
using RentACar_FinalProject.ViewModels.SharedPagesViewModels;
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

namespace RentACar_FinalProject.Views.SharedWindows
{
    /// <summary>
    /// Interaction logic for AddBalanceView.xaml
    /// </summary>
    public partial class AddBalanceView : Window
    {
        public AddBalanceView(User SelectedUser)
        {
            InitializeComponent();
            DataContext = new AddBalanceViewModel(InputAmount, SelectedUser);

        }
    }
}
