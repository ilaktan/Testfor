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
        public  List<Car> EnterCarDetail(string brand, string model, int year, double price, string color, int miles, string registrationNumber)
        {
            CarFleet carFleet = new CarFleet();
            Console.WriteLine("Enter first car detail ");
            Console.Write("What is car brand ");
            brand = Console.ReadLine();
            Console.Write("What is car model ");
            model = Console.ReadLine();
            Console.Write("What is car year ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is car price ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is car color ");
            color = Console.ReadLine();
            Console.Write("What is car miles ");
            miles = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is car registrationNumber ");
            registrationNumber = Console.ReadLine();
            return carFleet.AddCar(brand, model, year, price, color, miles, registrationNumber);
        }

    }

}
