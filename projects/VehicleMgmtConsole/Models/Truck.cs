using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMgmtConsole.Models
{
    internal class Truck : Vehicle
    {
        public int CargoCapacity;
        public override void StartEngine() => Console.WriteLine("The truck engine rumbles to life.");
        public override void Drive() =>
            Console.WriteLine("The truck is hauling cargo on the highway.");
    }
}
