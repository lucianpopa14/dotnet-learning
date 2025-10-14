using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMgmtConsole.Interfaces;

namespace VehicleMgmtConsole.Models
{
    internal class Vehicle : IDriveable

    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void  StartEngine() => Console.WriteLine("The vehicle engine starts.");
        public virtual void Drive() => Console.WriteLine("The vehicle is driving on the road.");
    }
}
