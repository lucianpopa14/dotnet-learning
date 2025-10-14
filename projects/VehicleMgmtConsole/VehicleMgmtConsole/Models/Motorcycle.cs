using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMgmtConsole.Models
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar;
        public override void StartEngine() => Console.WriteLine("The motorcycle engine starts with a button.");
        public override void Drive() =>
            Console.WriteLine("The motorcycle is zipping through traffic.");
    }
}
