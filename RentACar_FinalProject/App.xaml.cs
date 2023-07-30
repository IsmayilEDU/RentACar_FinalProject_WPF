using RentACar_FinalProject.Functions;
using RentACar_FinalProject.Models.Classes;
using RentACar_FinalProject.Models.Classes.DatabaseClasses;
using RentACar_FinalProject.Models.Classes.OperationClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace RentACar_FinalProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            MyDatabase.LoadedDatas();
        }
    }
}

