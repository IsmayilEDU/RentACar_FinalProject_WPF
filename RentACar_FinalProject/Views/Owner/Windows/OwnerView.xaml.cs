using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.ViewModels.OwnerViewModels;
using RentACar_FinalProject.Views.Owner.Pages;
using RentACar_FinalProject.Views.SharedPages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;


namespace RentACar_FinalProject.Views.Owner.Windows
{
    /// <summary>
    /// Interaction logic for OwnerView.xaml
    /// </summary>
    public partial class OwnerView : Window
    {
        public OwnerView(Models.Classes.UserClasses.Owner SelectedOwner)
        {
            InitializeComponent();
            List<Car> BusyCarsList = SelectedOwner.Cars.Where(car=> car.IsAvaible== false).ToList();
            ObservableCollection<Car> BusyCars = new ObservableCollection<Car>(BusyCarsList);
            OwnerFrame.Navigate(new BusyCarsPage(BusyCars));
            ProfileInfoFrame.Navigate(new ProfileInfoPage(SelectedOwner));
            DataContext = new OwnerViewModel(OwnerFrame, SelectedOwner);
        }




    }
}
