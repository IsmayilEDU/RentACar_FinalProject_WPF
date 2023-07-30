using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RentACar_FinalProject.Models.Classes;

namespace RentACar_FinalProject.Functions
{
    public static class MyJson
    {
        public static void WriteToFile<T>(ObservableCollection<T> list, string FileName)
        {
            System.Text.Json.JsonSerializerOptions op = new System.Text.Json.JsonSerializerOptions();
            op.WriteIndented = true;
            File.WriteAllText($"{FileName}.json", System.Text.Json.JsonSerializer.Serialize(list, op));
        }

        public static ObservableCollection<T> ReadFromFile<T>(string FileName)
        {
            //using FileStream fs = new FileStream($"{FileName}.json", FileMode.Open);
            var fs = File.ReadAllText($"{FileName}.json");
            ObservableCollection<T>? list = System.Text.Json.JsonSerializer.Deserialize<ObservableCollection<T>>(fs);
            return list!;
        }

        
    }
}
