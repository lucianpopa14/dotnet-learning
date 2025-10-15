namespace PetShelter.Classes
{
    internal abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime IntakeDate { get; set; }

        public abstract void Speak();
        public virtual decimal DailyCareCost() => 5m;

    }
}
