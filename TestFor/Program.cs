
using TestFor;
List<CarFleet> carFleets = new List<CarFleet>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* CarFleet management App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();
do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {carFleets.Count} carfleet(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register carFleet");
    Console.WriteLine("2: View all carFleet");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Modify data");
    Console.WriteLine("6: Delete data");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    
    switch (userSelection)
    {
        case "1":
            Utilities.RegisterCarFleet(carFleets);
            break;
        case "2":
            Utilities.ViewAllCarFleets(carFleets);
            break;
        case "3":
            Utilities.SaveCarFleets(carFleets);
            break;
        case "4":
            Utilities.LoadCarFleets(carFleets);
            break;
        case "5":
            Utilities.ModifyCarFleets(carFleets);
            break;
        case "6":
            Utilities.DeleteCarFleets(carFleets);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
    
}
while (userSelection != "9");

Console.WriteLine("Thanks for using the application");







/*
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

DeleteCar();  
carFleet.Delete(new Car("BMW", "X5", 2020, 67350, "black", 12000, registrationNumber));
ShowAllCar();

DeleteCar();
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

void DeleteCar()
{
    Console.WriteLine("Enter car detail for deleting");
    Console.Write("What is car registrationNumber ");
    registrationNumber = Console.ReadLine();
}

void ShowAllCar()
{
    Console.WriteLine($"We have {carFleet.AllCars()} car  in the system");
    Console.WriteLine("-----------------------");
}*/