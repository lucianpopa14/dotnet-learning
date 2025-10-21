using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    internal class DeliveryDrone : Drone, INavigable, ICargoCarrier
    {
        public (double lat, double lon)? CurrentWaypoint { get; set; }

        public double CurrentLoadKg { get; set; }

        public double CapacityKg { get; set; }

        public bool Load(double kg)
        {
            if (kg < CapacityKg && kg + CurrentLoadKg <= CapacityKg)
            {
                CurrentLoadKg += kg;
                return true;
            }
            else
            {
                Console.WriteLine("The load you want to add is too big");
                return false;
            }
        }

        public void SetWaypoint(double lat, double lon)
        {
            if (CurrentWaypoint.HasValue)
            {
                var current = CurrentWaypoint.Value;
                CurrentWaypoint = (current.lat + lat, current.lon + lon);
            }
            else
            {
                CurrentWaypoint = (lat, lon);
            }
            Console.WriteLine($"Waypoints lat: {lat}, lon: {lon} have been set.");
        }

        public void UnloadAll()
        {
            CurrentLoadKg = 0;
            Console.WriteLine("The weight has been unloaded.");
        }
    }
}
