using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine("Your motorcycle is in drive");
        }

        public bool HasSideCart { get; set; }

        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine("This motorcycle is now in drive.");
               
        }





    }
}
