using PetShelter.Interfaces;

namespace PetShelter.Classes
{
    internal class Bird : Animal, IFeedable, IFlyable
    {
        public double WingSpanCm { get; set; }

        public override void Speak()
        {
            Console.WriteLine("Chirp!");
        }

        public override decimal DailyCareCost()
        {
            return base.DailyCareCost() + 1;
        }

        public void Feed()
        {
            Console.WriteLine($"Bird {Name} has been fed.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies with a {WingSpanCm} cm wingspan");
        }
    }
}
