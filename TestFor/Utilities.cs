using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using static System.Net.WebRequestMethods;
using System.Runtime.ConstrainedExecution;

namespace TestFor
{
    internal class Utilities
    {
        private static string directory = @"C:\data2\TestFor\";
        private static string fileName = "CarFleets.txt";

        //private List<CarFleet> carFleets = new List<CarFleet>();

        internal static void RegisterCarFleet(List<CarFleet> carFleets)
        {
            Console.WriteLine("Creating an carFleet");

            Console.Write("Enter the brand name: ");
            string brand = Console.ReadLine();

            Console.Write("Enter the model name: ");
            string model = Console.ReadLine();

            Console.Write("Enter the year: ");
            string year = Console.ReadLine();
            int carYear = int.Parse(year);

            Console.Write("Enter the price: ");
            string price = Console.ReadLine();
            double carPrice = double.Parse(price);

            Console.Write("Enter the color: ");
            string color = Console.ReadLine();

            Console.Write("Enter the miles: ");
            int miles = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the registration number: ");
            string registrationNumber = Console.ReadLine();
           


            CarFleet carFleet = null;
            carFleet = new CarFleet(brand, model, carYear, carPrice, color, miles, registrationNumber);
            carFleets.Add(carFleet);


        }

        internal static void CheckForExistingEmployeeFile()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string path = $"{directory}{fileName}";

            bool existingFileFound = System.IO.File.Exists(path);
            if (existingFileFound)
            {
                Console.WriteLine("An existing file with CarFleet data is found.");
            }
            else
            {
                //Create the airectory already
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(directory);
                Console.WriteLine("Directory is ready for saving files.");
            }
            Console.ForegroundColor = ConsoleColor.Blue;

        }
        internal static void ViewAllCarFleets(List<CarFleet> carFleets)
        {
            for (int i = 0; i < carFleets.Count; i++)
            {
                carFleets[i].DisplayEmployeeDetails();
            }
        }



        internal static void ModifyCarFleets(List<CarFleet> carFleets)
        {
            Console.WriteLine("Creating an carFleet");

            Console.Write("Enter the brand name: ");
            string brand = Console.ReadLine();

            Console.Write("Enter the model name: ");
            string model = Console.ReadLine();

            Console.Write("Enter the year: ");
            string year = Console.ReadLine();
            int carYear = int.Parse(year);

            Console.Write("Enter the price: ");
            string price = Console.ReadLine();
            double carPrice = double.Parse(price);

            Console.Write("Enter the color: ");
            string color = Console.ReadLine();

            Console.Write("Enter the miles: ");
            int miles = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the registration number: ");
            string registrationNumber = Console.ReadLine();

            CarFleet carFleet = new CarFleet();
            carFleet = new CarFleet(brand, model, carYear, carPrice, color, miles, registrationNumber);
            
            var modifyCar = carFleets.FindIndex(c => c.RegistrationNumber == carFleet.RegistrationNumber);
            carFleets[modifyCar] = carFleet;

            for (int i = 0; i < carFleets.Count; i++)
            {
                carFleets[i].DisplayEmployeeDetails();
            }

        }
        internal static void DeleteCarFleets(List<CarFleet> carFleets)
        {
            

            Console.Write("Enter the registration number: ");
            string registrationNumber = Console.ReadLine();


            var deleteCar = carFleets.FindIndex(c => c.RegistrationNumber == registrationNumber);
            carFleets.Remove(carFleets[deleteCar]);
            

            for (int i = 0; i < carFleets.Count; i++)
            {
                carFleets[i].DisplayEmployeeDetails();
            }

        }


        internal static void LoadCarFleets(List<CarFleet> carFleets)
        {
            string path = $"{directory}{fileName}";
            if (System.IO.File.Exists(path))
            {
                carFleets.Clear();

                //now read the file
                string[] carFleetsAsString = System.IO.File.ReadAllLines(path);
                for (int i = 0; i < carFleetsAsString.Length; i++)
                {
                    string[] carFleetSplits = carFleetsAsString[i].Split(';');
                    string brand = carFleetSplits[0].Substring(carFleetSplits[0].IndexOf(':') + 1);
                    string model = carFleetSplits[1].Substring(carFleetSplits[1].IndexOf(':') + 1);
                    int year = int.Parse(carFleetSplits[2].Substring(carFleetSplits[2].IndexOf(':') + 1));
                    double price = double.Parse(carFleetSplits[3].Substring(carFleetSplits[3].IndexOf(':') + 1));
                    string color = carFleetSplits[4].Substring(carFleetSplits[4].IndexOf(':') + 1);
                    int miles =int.Parse (carFleetSplits[5].Substring(carFleetSplits[5].IndexOf(':') + 1));
                    string registrationNumber = carFleetSplits[5].Substring(carFleetSplits[5].IndexOf(':') + 1);
                    CarFleet carFleet = null;
                    carFleet = new CarFleet(brand, model, year, price, color, miles, registrationNumber);



                    carFleets.Add(carFleet);

                }

            }
        }
        internal static void SaveCarFleets(List<CarFleet> carFleets)
        {
            //First, we are going to convert employee data to a string
            //Alternatively, we could again use JSON.NET and store them as JSON

            string path = $"{directory}{fileName}";
            StringBuilder sb = new StringBuilder();

            foreach (var carFleet in carFleets)
            {
                //string type = GetEmployeeType(carFleet);

                sb.Append($"Brand:{carFleet.Brand};");
                sb.Append($"Model:{carFleet.Model};");
                sb.Append($"Year:{carFleet.Year};");
                sb.Append($"Price:{carFleet.Price};");
                sb.Append($"Color:{carFleet.Color};");
                sb.Append($"Miles:{carFleet.Miles};");
                sb.Append($"RegistrationNumber:{carFleet.RegistrationNumber};");
                sb.Append(Environment.NewLine);
            }

            System.IO.File.WriteAllText(path, sb.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved Cars successfully");
            Console.ResetColor();
        }

      
       
    }
}
