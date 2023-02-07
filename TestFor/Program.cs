
using TestFor;


CarFleet carFleet = new CarFleet();
string brand, model, color, registrationNumber;
int year,miles;
double price;

EnterCarDetails();
carFleet.AddCar(brand, model, year, price, color, miles, registrationNumber);

EnterCarDetails();
carFleet.AddCar(brand, model, year, price, color, miles, registrationNumber);
ShowAllCar();

Console.WriteLine("Enter car detail for modifying");
EnterCarDetails();
carFleet.Modify(new Car(brand, model, year, price, color, miles, registrationNumber));
ShowAllCar();

DeletingCar();  
carFleet.Delete(new Car("BMW", "X5", 2020, 67350, "black", 12000, registrationNumber));
ShowAllCar();

DeletingCar();
carFleet.Delete(new Car("BMW", "X5", 2020, 67350, "black", 12000, registrationNumber));
ShowAllCar();

Console.WriteLine("How many cars exist? ");
ShowAllCar();

void EnterCarDetails()
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
}

void DeletingCar()
{
    Console.WriteLine("Enter car detail for deleting");
    Console.Write("What is car registrationNumber ");
    registrationNumber = Console.ReadLine();
}

void ShowAllCar()
{
    Console.WriteLine($"We have {carFleet.AllCars()} car  in the system");
    Console.WriteLine("-----------------------");
}