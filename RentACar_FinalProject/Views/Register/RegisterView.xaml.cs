using RentACar_FinalProject.ViewModels;
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

namespace RentACar_FinalProject.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public RegisterView(RadioButton isOwner)
        {
            InitializeComponent();
            DataContext = new RegisterViewModel(isOwner, InputUsername, InputPassword, InputNameOfBank,
                InputCardNumber, InputDay,InputMonth,InputYear,
                InputCVC, InputBalance);
        }
    }
}
