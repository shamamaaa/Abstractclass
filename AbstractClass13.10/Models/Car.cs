using System;
namespace AbstractClass13._10.Models
{
	public class Car:Vehicle
	{

        public Car(string factoryname, string model, string color, decimal drivetime, decimal drivepath, int doorcount, bool iselectriccar) : base(factoryname, model, color, drivetime, drivepath)
        {
            DoorCount = doorcount;
            IsElectricCar = iselectriccar;
        }

        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }


        public override void DefineNatureHarmness()
        {

            if (IsElectricCar)
            {
                Console.WriteLine($"{FactoryName} {Model}-Nature harmness: Low");
            }
            else
            {
                Console.WriteLine($"{FactoryName} {Model}-Nature harmness: High");
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory name:{FactoryName}\nModel:{Model}\nColor:{Color}\nDrive time:{DriveTime} hours\nDrive path:{DrivePath}\nProduction date:{ProductionDate}\nDoor count:{DoorCount}\nElectric car: {IsElectricCar}");

        }

    }

    
}

