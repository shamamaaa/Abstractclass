using System;
using System.IO;

namespace AbstractClass13._10.Models
{
	public abstract class Vehicle
	{

		public string FactoryName { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public decimal DriveTime { get; set; }
		public decimal DrivePath { get; set; }
		public DateTime ProductionDate { get;}


        public Vehicle(string factoryname, string model, string color, decimal drivetime, decimal drivepath)
        {
            FactoryName = factoryname;
            Model = model;
            Color = color;
            DriveTime = drivetime;
            DrivePath = drivepath;
        }

        public abstract void DefineNatureHarmness();

        public decimal AverageSpeed()
        {
            return DrivePath / DriveTime;       
        }

        public virtual void GetInfo()
		{
            Console.WriteLine($"Factory name: {FactoryName}\nModel: {Model}\nColor: {Color}\nDrive time: {DriveTime} hours\nDrive path: {DrivePath}\nProduction date: {ProductionDate}");
        }

        public override string ToString()
        {
            return $"{FactoryName}-{Model}";
        }

    }
}

