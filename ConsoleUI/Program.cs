using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();


            var vehicle = new List<Vehicle>();

            var car = new Car()
            {
                HasTrunk = true, 
                Year = "2016",
                Make = "Volkswagon",
                Model = "Beetle",
            };


            var motorcycle = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2018",
                Make = "Kawasaki",
                Model = "Ninja",
            };


            Vehicle dirtbike = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2006",
                Make = "Suzuki",
                Model = "Nija",

            };

            Vehicle toycar = new Car()
            {

                HasTrunk = false,
                Year = "1997",
                Make = "Matchbox",
                Model = "Mustang",
            };


            vehicle.Add(dirtbike);
            vehicle.Add(car);
            vehicle.Add(motorcycle);
            vehicle.Add(toycar);


            foreach (var item in vehicle)
            {
                Console.WriteLine(item.Year, item.Make, item.Model);

            }










        }
    }
}
