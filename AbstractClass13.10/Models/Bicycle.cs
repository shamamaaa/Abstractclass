using System;
namespace AbstractClass13._10.Models
{
	public class Bicycle:Vehicle
	{
        public string Type { get; set; }

        public Bicycle(string factoryname, string model, string color, decimal drivetime, decimal drivepath, string type) : base(factoryname, model, color, drivetime, drivepath)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine($"{FactoryName} {Model}-Nature harmness: None");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory name: {FactoryName}\nModel: {Model}\nColor: {Color}\nDrive time: {DriveTime} hours\nDrive path: {DrivePath}\nProduction date: {ProductionDate}\nType: {Type}");
        }

    }
}

