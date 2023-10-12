using System.Reflection;
using AbstractClass13._10.Models;

namespace AbstractClass13._10;
class Program
{
    static void Main(string[] args)
    {

        Vehicle[] vehicles = new Vehicle[0];
        Car Car1 = new Car("Toyota", "Camry", "White", 9, 450, 4, false);
        Car Car2 = new Car("Tesla", "Model S", "Black", 10, 550, 4, true);
        Bicycle bicycle1 = new Bicycle("Trek", "Domane SL 5", "Red", 3, 40, "Road bike");
        Bicycle bicycle2 = new Bicycle("Giant", "Anthem X Advanced 29", "Blue", 2, 30, "Mountain bike");


        AddVehicle(ref vehicles,Car1);
        AddVehicle(ref vehicles, Car2);
        AddVehicle(ref vehicles, bicycle1);
        AddVehicle(ref vehicles, bicycle2);

        Print(vehicles);

        //Car1.GetInfo();  
        //Car2.GetInfo();
        //bicycle1.GetInfo();                  Hamisini acmadim qarisiq olurdu...
        //bicycle2.GetInfo();

        //Car1.DefineNatureHarmness();
        //Car2.DefineNatureHarmness();
        //bicycle1.DefineNatureHarmness();
        //Console.WriteLine($"{Car1.FactoryName}-{Car1.Model}: {Car1.AverageSpeed()}km/h ");
    }



    public static void AddVehicle(ref Vehicle[] vehicles, Vehicle vehicle)
    {
        Array.Resize(ref vehicles, vehicles.Length+1);
        vehicles[vehicles.Length - 1] = vehicle;
    }

    public static void Print(Vehicle[] vehicles)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}

