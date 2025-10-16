using PetShelter.Classes;
using PetShelter.Interfaces;

namespace PetShelter;

internal class Program
{
    private static List<Animal> animals = new();
    private static int _nextId = 1;
    private static int NextId() => _nextId++;

    static void Main(string[] args)
    {
        animals.Add(new Dog { Id = NextId(), Age = 5, IntakeDate = DateTime.Now, IsTrained = true, Name = "Sparky" });
        animals.Add(new Cat { Id = NextId(), Age = 1, IntakeDate = DateTime.Now, Name = "Pussy", IsIndoor = true });
        animals.Add(new Bird { Id = NextId(), Age = 7, IntakeDate = DateTime.Now, Name = "Birdy", WingSpanCm = 150 });

        RunMenu();
    }

    private static void RunMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("--- Pet Shelter app ---");
            Console.WriteLine("1. Add Dog");
            Console.WriteLine("2. Add Cat");
            Console.WriteLine("3. Add Bird");
            Console.WriteLine("4. List Animals");
            Console.WriteLine("5. Feed All");
            Console.WriteLine("6. Speak All");
            Console.WriteLine("7. Adopt (by Id)");
            Console.WriteLine("8. Exit");

            var choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddDog();
                    break;
                case "2":
                    AddCat();
                    break;
                case "3":
                    AddBird();
                    break;
                case "4":
                    ListAnimals();
                    break;
                case "5":
                    FeedAll();
                    break;
                case "6":
                    SpeakAll();
                    break;
                case "7":
                    AdoptById();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void AdoptById()
    {
        Console.WriteLine("Here is the list of animals. Choose the id of the one you wish to adopt: ");
        ListAnimals();
        Console.Write("Id: ");
        if (!int.TryParse(Console.ReadLine(), out var id))
        {
            Console.WriteLine("Invalid id.");
            return;
        }

        var animal = animals.FirstOrDefault(animal => animal.Id == id);
        if (animal is null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }
        animals.Remove(animal);
        Console.WriteLine($"{animal.Name} has been adopted.");
    }

    private static void SpeakAll()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("No animals in the shelter.");
            return;
        }
        foreach (var animal in animals)
        {
            animal.Speak();
            if (animal is IFlyable flyable) flyable.Fly();
        }
    }

    private static void FeedAll()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("No animals to feed.");
            return;
        }

        var count = 0;
        foreach (var animal in animals)
        {
            if (animal is IFeedable feedable)
            {
                feedable.Feed();
                count++;
            }
        }
        Console.WriteLine($"{count} animals have been fed.");
    }

    private static void ListAnimals()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("no animals yet");
            return;
        }
        Console.WriteLine("Id\t|Type\t|Name\t|Age\t|Extra\t|DailyCost");
        foreach (var animal in animals)
        {
            var extra = animal switch
            {
                Dog d => $"IsTrained={d.IsTrained}",
                Cat c => $"IsIndoor={c.IsIndoor}",
                Bird b => $"WingSpan={b.WingSpanCm}cm",
                _ => "-"
            };
            Console.WriteLine($"{animal.Id}\t|{animal.GetType().Name}\t|{animal.Name}\t|{animal.Age}\t|{extra}\t|{animal.DailyCareCost()}");
        }
    }

    private static void AddBird()
    {
        var bird = new Bird
        {
            Id = NextId(),
            Name = ReadString("Name"),
            Age = ReadInt("Age"),
            WingSpanCm = ReadInt("Wingspan (cm)"),
            IntakeDate = DateTime.Now
        };
        animals.Add(bird);
        Console.WriteLine("Bird added.");
    }

    private static void AddCat()
    {
        var cat = new Cat
        {
            Id = NextId(),
            Name = ReadString("Name"),
            Age = ReadInt("Age"),
            IsIndoor = ReadBool("Is Indoor (y/n)"),
            IntakeDate = DateTime.Now
        };
        animals.Add(cat);
        Console.WriteLine("Cat added.");
    }

    private static void AddDog()
    {
        var dog = new Dog
        {
            Id = NextId(),
            Name = ReadString("Name"),
            Age = ReadInt("Age"),
            IsTrained = ReadBool("Is Trained (y/n)"),
            IntakeDate = DateTime.Now
        };
        animals.Add(dog);
        Console.WriteLine("Dog added.");
    }

    private static bool ReadBool(string label)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            var input = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (input is "y" or "yes") return true;
            if (input is "n" or "no") return false;
            Console.WriteLine("Please answer with y/n.");
        }
    }

    private static int ReadInt(string label)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            var input = Console.ReadLine();

            if (label == "Age" && int.TryParse(input, out var value) && value >= 0)
            {
                if (int.TryParse(input, out value)) return value;
            }
            else if (label == "Wingspan (cm)" && int.TryParse(input, out value) && value > 0)
            {
                if (int.TryParse(input, out value)) return value;
            }
            else Console.WriteLine("Please enter a valid integer.");
        }
    }

    private static string ReadString(string label)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) return input.Trim();
            Console.WriteLine("Please enter a value.");
        }
    }
}