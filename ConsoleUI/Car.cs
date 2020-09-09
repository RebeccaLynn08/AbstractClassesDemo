using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle is virtually in drive.");
        }

        public bool HasTrunk { get; set; }

      
    }
}
