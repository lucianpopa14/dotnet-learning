using PetShelter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Classes
{
    internal class Cat : Animal, IFeedable
    {
        public bool IsIndoor { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public override decimal DailyCareCost()
        {
            return base.DailyCareCost() + 2;
        }

        public void Feed()
        {
            Console.WriteLine($"Cat {Name} has been fed.");
        }
    }
}
