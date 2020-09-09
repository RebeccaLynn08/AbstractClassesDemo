using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"This vehicle is virtually in drive.");
        }


        






    }
}
