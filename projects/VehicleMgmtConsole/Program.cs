using System;
using System.Collections.Generic;
using VehicleMgmtConsole.Interfaces;
using VehicleMgmtConsole.Models;

namespace VehicleMgmtConsole
{
    internal class Program
    {
        private static readonly List<Vehicle> vehicles = new();

        static void Main(string[] args)
        {
            vehicles.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2018, NumberOfDoors = 4 });
            vehicles.Add(new Motorcycle { Brand = "Yamaha", Model = "MT-07", Year = 2021, HasSidecar = false });
            vehicles.Add(new Truck { Brand = "Volvo", Model = "FH16", Year = 2020, CargoCapacity = 24000 });

            RunMenu();
        }

        private static void RunMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("--- Vehicle Management ---");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Add Motorcycle");
                Console.WriteLine("3. Add Truck");
                Console.WriteLine("4. List Vehicles");
                Console.WriteLine("5. Start & Drive All (polymorphism demo)");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        AddMotorcycle();
                        break;
                    case "3":
                        AddTruck();
                        break;
                    case "4":
                        ListVehicles();
                        break;
                    case "5":
                        StartAndDriveAll();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void AddCar()
        {
            var car = new Car
            {
                Brand = ReadString("Brand"),
                Model = ReadString("Model"),
                Year = ReadInt("Year"),
                NumberOfDoors = ReadInt("Number of doors")
            };
            vehicles.Add(car);
            Console.WriteLine("Car added.");
        }

        private static void AddMotorcycle()
        {
            var moto = new Motorcycle
            {
                Brand = ReadString("Brand"),
                Model = ReadString("Model"),
                Year = ReadInt("Year"),
                HasSidecar = ReadBool("Has sidecar (y/n)")
            };
            vehicles.Add(moto);
            Console.WriteLine("Motorcycle added.");
        }

        private static void AddTruck()
        {
            var truck = new Truck
            {
                Brand = ReadString("Brand"),
                Model = ReadString("Model"),
                Year = ReadInt("Year"),
                CargoCapacity = ReadInt("Cargo capacity (kg)")
            };
            vehicles.Add(truck);
            Console.WriteLine("Truck added.");
        }

        private static void ListVehicles()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles yet.");
                return;
            }

            Console.WriteLine("Vehicles:");
            for (int i = 0; i < vehicles.Count; i++)
            {
                var v = vehicles[i];
                Console.Write($"{i + 1}. [{v.GetType().Name}] {v.Brand} {v.Model} ({v.Year})");

                switch (v)
                {
                    case Car c:
                        Console.Write($" | Doors: {c.NumberOfDoors}");
                        break;
                    case Motorcycle m:
                        Console.Write($" | Sidecar: {(m.HasSidecar ? "Yes" : "No")}");
                        break;
                    case Truck t:
                        Console.Write($" | Capacity: {t.CargoCapacity} kg");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void StartAndDriveAll()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles to start/drive.");
                return;
            }

            foreach (var v in vehicles)
            {
                v.StartEngine();

                if (v is IDriveable d)
                {
                    d.Drive();
                }
            }
        }

        private static string ReadString(string label)
        {
            while (true)
            {
                Console.Write($"{label}: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) return input.Trim();
                Console.WriteLine("Please enter a value.");
            }
        }

        private static int ReadInt(string label)
        {
            while (true)
            {
                Console.Write($"{label}: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value)) return value;
                Console.WriteLine("Please enter a valid integer.");
            }
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
    }
}
