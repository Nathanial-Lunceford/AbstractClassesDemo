using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();



            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car newCarOne = new Car(true, "2009", "Honda", "Accord");
            Motorcycle newMotorOne = new Motorcycle(true, "2020", "Harley-Davidson", "Street Glide");

            Vehicle newVehicleOne = new Car(false, "1998", "Chevrolet", "Pontiac");
            Vehicle newVehicleTwo = new Motorcycle(false, "2015", "Yamaha", "Tracer 9");

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(newCarOne);
            vehicles.Add(newMotorOne);
            vehicles.Add(newVehicleOne);
            vehicles.Add(newVehicleTwo);
            
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: " +
                    $"{vehicle.Year}");
            }
            // Call each of the drive methods for one car and one motorcycle

            Console.WriteLine($"Abstract and Virtual Drive for Car:");
            newCarOne.DriveAbstract();
            newCarOne.DriveVirtual();

            Console.WriteLine();

            Console.WriteLine($"Abstract and Virtual Drive for Motorcycles:");
            newMotorOne.DriveAbstract();
            newMotorOne.DriveVirtual();

            #endregion

        }
    }
}
