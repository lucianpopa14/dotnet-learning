using DroneFleetConsole.Models;

internal class Program
{
    private static List<Drone> drones = new();
    private static int _nextId = 1;
    private static int NextId() => _nextId++;

    static void Main(string[] args)
    {
        drones.Add(new SurveyDrone { Id = NextId(), Name = "surveyDrone", BatteryPercent = 50, IsAirborne = false, PhotoCount = 3 });
        drones.Add(new DeliveryDrone { Id = NextId(), Name = "cargoDrone", BatteryPercent = 50, IsAirborne = false, CurrentCapacityKg = 25, CurrentLoadKg = 12 });
        drones.Add(new RacingDrone { Id = NextId(), Name = "racingDrone", BatteryPercent = 90, IsAirborne = false, SpeedKmh = 25 });

        RunMenu();
    }

    private static void RunMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("---DRONE FLEET---");
            Console.WriteLine("1. List Drones");
            Console.WriteLine("2. Add Drone");
            Console.WriteLine("3. Pre-flight check (all)");
            Console.WriteLine("4. Take off / Land");
            Console.WriteLine("5. Set waypoint");
            Console.WriteLine("6. Capability actions");
            Console.WriteLine("7. Charge battery");
            Console.WriteLine("8. Exit");

            var choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ListDrones();
                    break;
                case "2":
                    AddDrone();
                    break;
                case "3":
                    PreflightCheck();
                    break;
                case "4":
                    TakeoffOrLand();
                    break;
                case "5":
                    SetWaypoint();
                    break;
                case "6":
                    CapabilityActions();
                    break;
                case "7":
                    ChargeBattery();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void ChargeBattery()
    {
        throw new NotImplementedException();
    }

    private static void CapabilityActions()
    {
        throw new NotImplementedException();
    }

    private static void SetWaypoint()
    {
        throw new NotImplementedException();
    }

    private static void TakeoffOrLand()
    {
        throw new NotImplementedException();
    }

    private static void PreflightCheck()
    {
        throw new NotImplementedException();
    }

    private static void AddDrone()
    {
        var droneType = ReadString("Type (Survey/Delivery/Racing)");
        switch (droneType)
        {
            case "survey":
                var surveyDrone = new SurveyDrone
                {
                    Id = NextId(),
                    Name = ReadString("Name")
                };
                drones.Add(surveyDrone);
                Console.WriteLine($"Added #{surveyDrone.Id} SurveyDrone {surveyDrone.Name}");
                break;
            case "delivery":
                var deliveryDrone = new DeliveryDrone
                {
                    Id = NextId(),
                    Name = ReadString("Name")
                };
                drones.Add(deliveryDrone);
                Console.WriteLine($"Added #{deliveryDrone.Id} SurveyDrone {deliveryDrone.Name}");
                break;
            case "racing":
                var racingDrone = new DeliveryDrone
                {
                    Id = NextId(),
                    Name = ReadString("Name")
                };
                drones.Add(racingDrone);
                Console.WriteLine($"Added #{racingDrone.Id} SurveyDrone {racingDrone.Name}");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    private static void ShowExtra() { throw new NotImplementedException(); }

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
            if (int.TryParse(input, out int value)) return value;
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

    private static void ListDrones()
    {
        Console.WriteLine("Id\t|Name\t|Battery\t|Airborne\t|Extra\t");

        foreach (var drone in drones)
        {
            Console.WriteLine($"{drone.Id}\t|{drone.Name}\t|{drone.BatteryPercent}\t|{drone.IsAirborne}\t|extra");
        }
    }
}