using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Hyundai";
        public string Model { get; set; } = "Veracruz";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("You are driving a vehicle virtually");
        }
    }

    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public Car(bool hasTrunk, string year, string make, string model)
        {
            this.HasTrunk = hasTrunk;
            this.Year = year;
            this.Make = make;
            this.Model = model;
        }

        override public void DriveAbstract()
        {
            Console.WriteLine($"You are driving a {this.Year} {this.Make} {this.Model} car in an abstract way");
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool hasSideCar { get; set; } = true;

        public Motorcycle(bool hasSideCar, string year, string make, string model)
        {
            this.hasSideCar = hasSideCar;
            this.Year = year;
            this.Make = make;
            this.Model = model;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving a {this.Year} {this.Make} {this.Model} motorcycle in an abstract way");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"You are driving a {this.Year} {this.Make} {this.Model} motorcycle in an virtual way");
        }
    }
}
