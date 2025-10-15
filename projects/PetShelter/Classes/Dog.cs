using PetShelter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Classes
{
    internal class Dog : Animal, IFeedable
    {
        public bool IsTrained { get; set; }

        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public override decimal DailyCareCost()
        {
            return base.DailyCareCost() + 3;
        }

        public void Feed()
        {
            Console.WriteLine($"Dog {Name} has been fed.");
        }
    }
}
