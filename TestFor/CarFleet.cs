using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor
{
    public class CarFleet
    {
        private List<Car> cars = new List<Car>();
        private string? brand;
        private string? model;
        private int year;
        private double price;
        private string? color;
        private int miles;
        private string registrationNumber;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public string RegistrationNumber { get; set; }

        public CarFleet(string? brand, string? model, int year, double price, string? color, int miles, string registrationNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Color = color;
            this.Miles = miles;
            this.RegistrationNumber = registrationNumber;

        }

        public CarFleet()
        {
        }

        public List<Car> AddCar(string brand, string model, int year, double price, string color, int miles, string registrationNumber)
        {
            Car car = new Car(brand, model, year, price, color, miles, registrationNumber);
            cars.Add(car);

            return cars;
        }

        public List<Car> GetAllCars()
        {
            Console.WriteLine(cars[0].ToString());

            return cars;
        }
        public List<Car> Modify(Car car)
        {
            var modifyCar = cars.FindIndex(c => c.RegistrationNumber == car.RegistrationNumber);
            cars[modifyCar] = car;

            return cars;
        }

        public List<Car> Delete(Car car)
        {
            var deleteCar = cars.FindIndex(c => c.RegistrationNumber == car.RegistrationNumber);
            cars.Remove(cars[deleteCar]);

            return cars;
        }
        public int AllCars()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].GetToString());
            }

            return cars.Count;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nBrand: \t{Brand}\nModel: \t{Model}\nYear: \t\t{Year}\nPrice: \t{Price}\nColor: \t{Color}\nMiles: \t{Miles}\nRegistrationNumber: \t{RegistrationNumber}\n");
        }
        public List<Car> ModifyFleeet(Car car)
        {
            var modifyCar = cars.FindIndex(c => c.RegistrationNumber == car.RegistrationNumber);
            cars[modifyCar] = car;

            return cars;
        }

        internal void ModifyFleeet()
        {
            throw new NotImplementedException();
        }
    }

}
