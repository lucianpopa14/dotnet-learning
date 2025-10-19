using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    internal class DeliveryDrone : Drone, INavigable, ICargoCarrier
    {
        public (double lat, double lon)? CurrentWaypoint { get; set; }

        public double CurrentLoadKg { get; set; }

        public double CurrentCapacityKg { get; set; }

        public bool Load(double kg)
        {
            if (kg < CurrentCapacityKg && kg + CurrentLoadKg <= CurrentCapacityKg)
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
            throw new NotImplementedException();
        }

        public void UnloadAll()
        {
            throw new NotImplementedException();
        }
    }
}
