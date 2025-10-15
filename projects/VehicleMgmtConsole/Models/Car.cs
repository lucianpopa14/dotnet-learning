using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMgmtConsole.Models
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get;set; }

        public override void StartEngine() => Console.WriteLine("The car engine starts with a key.");
        public override void Drive() => Console.WriteLine("The car is driving on the road");
    }
}
