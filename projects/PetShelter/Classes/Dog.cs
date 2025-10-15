using PetShelter.Interfaces;

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
