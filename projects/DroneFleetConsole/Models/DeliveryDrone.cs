using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    internal class DeliveryDrone : Drone, INavigable, ICargoCarrier
    {
        public (double lat, double lon)? CurrentWaypoint => throw new NotImplementedException();

        public double CurrentLoadKg => throw new NotImplementedException();

        public double CurrentCapacityKg => throw new NotImplementedException();

        public bool Load(double kg)
        {
            throw new NotImplementedException();
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
