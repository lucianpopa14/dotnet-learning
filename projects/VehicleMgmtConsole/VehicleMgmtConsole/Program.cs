using VehicleMgmtConsole.Models;

class Program
{
    static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Car { Brand = "VW", Model = "Golf", Year = 2018, NumberOfDoors = 4 },
            new Motorcycle { Brand = "Honda", Model = "CB500F", Year = 2022, HasSidecar = false },
            new Truck { Brand = "Volvo", Model = "FH", Year = 2020, CargoCapacity = 18000 }
        };
        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
            vehicle.GetType();
            vehicle.Drive();
        }
    }
}