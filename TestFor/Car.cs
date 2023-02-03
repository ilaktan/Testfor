using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string brand, string model, int year, double price, String color, int miles, string registrationNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Color = color;
            this.Miles = miles;
            this.RegistrationNumber = registrationNumber;

        }

        public string toString()
        {
            return "Car{" +
                    "Brand='" + Brand + '\'' +
                    ", Model='" + Model + '\'' +
                    ", Year=" + Year +
                    ", Price=" + Price +
                    ", Color='" + Color + '\'' +
                    ", Miles=" + Miles +
                    ", RegistrationNumber=" + RegistrationNumber +
                    '}';
        }

    }
}
