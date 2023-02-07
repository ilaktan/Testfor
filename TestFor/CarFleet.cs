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
        

    }

}
