using System;
using System.Collections;
using TestFor;

namespace TestForTest
{
    [TestClass]
    public class CarTest
    {
        CarFleet carFleet = new CarFleet();
        
        [TestMethod]
        public void AddCarTest()
        {
            string brandExpected = "Toyota", modelExpected = "Camry", colorExpected = "Gray", registrationNumberExpected = "XYZ1235";
            int yearExpected = 2020, milesExpected = 123456;
            double priceExpected = 20000;

            //Given: User adding car        
            carFleet.AddCar("Toyota", "Camry", 2020, 20000, "Gray", 123456, "XYZ1235");

            //Then: User verify car details
            Assert.AreEqual(brandExpected, carFleet.GetAllCars()[0].Brand);
            Assert.AreEqual(modelExpected, carFleet.GetAllCars()[0].Model);
            Assert.AreEqual(yearExpected, carFleet.GetAllCars()[0].Year);
            Assert.AreEqual(priceExpected, carFleet.GetAllCars()[0].Price);
            Assert.AreEqual(colorExpected, carFleet.GetAllCars()[0].Color);
            Assert.AreEqual(milesExpected, carFleet.GetAllCars()[0].Miles);
            Assert.AreEqual(registrationNumberExpected, carFleet.GetAllCars()[0].RegistrationNumber);

        }

        [TestMethod]
        public void ModifyTest()
        {
            //Given: User adding car          
            carFleet.AddCar("Tesla", "Model S", 2022, 94990, "Red", 0, "XYZ1236");

            //And: User modifying car
            carFleet.Modify(new Car("Tesla", "Model S", 2022, 500, "Red",300000, "XYZ1236"));

            //Then:User verify car price modifyed 
            double expectedMessage = 500;
            double actualMessage = carFleet.GetAllCars()[0].Price;
            Assert.AreEqual(expectedMessage, actualMessage);

            //Then:User verify car miles modifyed 
            int expectedMessageMiles = 300000;
            int actualMessageMiles = carFleet.GetAllCars()[0].Miles;
            Assert.AreEqual(expectedMessageMiles, actualMessageMiles);

        }
        [TestMethod]
        public void DeleteTest()
        {
            //Given: User adding car      
            carFleet.AddCar("BMW", "X5", 2020, 67350, "black", 12000, "XYZ1237");

            //And: User deleting car
            carFleet.Delete(new Car("BMW", "X5", 2020, 67350, "black", 12000, "XYZ1237"));

            //Then:User verify allCars in the system
            int expectedMessage = 0;
            double actualMessage = carFleet.AllCars();
            Assert.AreEqual(expectedMessage, actualMessage);          

        }
       
    }
}