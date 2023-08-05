using RentACar_FinalProject.Models.Classes.OperationClasses;
using RentACar_FinalProject.Models.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.DatabaseClasses
{
    public static class MyDatabase
    {
        public static ObservableCollection<Owner> Owners { get; set; }
        public static ObservableCollection<Customer> Customers { get; set; }

        public static ObservableCollection<Location> Locations { get; set; }
        public static ObservableCollection<Car> Cars { get; set; }

        public static Location GetRandomLocation()
        {
            int index = Random.Shared.Next(0, 9);
            return Locations[index];
        }

        public static void LoadedDatas()
        {
            MyDatabase.Locations = new ObservableCollection<Location>()
            {

                new Location(40.4093,49.8671),
                new Location(40.5855,49.6317),
                new Location(40.6879,46.3723),
                new Location(40.0394,48.9203),
                new Location(41.1125,45.4477),
                new Location(41.0971,45.3516),
                new Location(40.1024,46.0365),
                new Location(40.3630,49.2737),
                new Location(41.3643,48.5261),

            };


            ObservableCollection<Car> cars = new ObservableCollection<Car>()
            {
                new Car("BMW", "M6", 2012, 100),
                new Car("Mercedes", "C180", 2015, 80),
                new Car("Kia", "Rio", 2020, 120),
                new Car("Hyundai", "Sonata", 2012, 70),
                new Car("Lada", "Priora", 2008, 45),
                new Car("BMW", "M3 turbo", 2015, 150),
                new Car("Lada", "Vesta", 2012, 100,2, "huseyn"),
                new Car("Lada", "Kalina", 2015, 80,3, "huseyn"),
                new Car("Kia", "Rio", 2020, 120,2, "huseyn"),
                new Car("Hyundai", "Sonata", 2012,3, 70, "huseyn"),
                new Car("Lada", "Priora", 2008, 45,4, "huseyn"),
                new Car("BMW", "M3 turbo", 2015, 150,5, "huseyn"),
            };



            



            MyDatabase.Owners = new ObservableCollection<Owner>()
            {
                new Owner("ismayil", "ismayil",
                            new BankCard("Unibank","1234567891234567",
                                new DateTime(2025,1,1),
                                "987",500),cars)
            };

            MyDatabase.Owners[0].OperationsOfBudget.Add(new BudgetOperation("Temir", 80, true));
            MyDatabase.Owners[0].OperationsOfBudget.Add(new BudgetOperation("Balansin artirilmasi", 100, false));

            ObservableCollection<Car> cars1 = new ObservableCollection<Car>()
            {

                new Car("Lada", "Vesta", 2012, 100,2, "huseyn"),
                new Car("Lada", "Kalina", 2015, 80,3, "huseyn"),
                new Car("Kia", "Rio", 2020, 120,2, "huseyn"),
                new Car("Hyundai", "Sonata", 2012,3, 70, "huseyn"),
                new Car("Lada", "Priora", 2008, 45,4, "huseyn"),
                new Car("BMW", "M3 turbo", 2015, 150,5, "huseyn"),
            };



            ObservableCollection<CarHistory> historyOfCars = new ObservableCollection<CarHistory>();
            foreach (Car car in cars1)
            {
                historyOfCars.Add(new CarHistory(car));
            }


            MyDatabase.Customers = new ObservableCollection<Customer>()
                        {
                            new Customer("huseyn", "huseyn",
                                new BankCard("ATB", "1234567891234567",
                                    new DateTime(2025,2,2),
                                    "867",
                                    1000
                                ),historyOfCars
                                )
                        };

        }
    }
}
