using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    internal class SurveyDrone : Drone, INavigable, IPhotoCapture
    {
        public (double lat, double lon)? CurrentWaypoint { get; set; }

        public int PhotoCount { get; set; }

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

        public void TakePhoto()
        {
            if (!IsAirborne) { Console.WriteLine("Cannot take photo while grounded."); return; }
            PhotoCount++;
            Console.WriteLine("Took photo.");
        }

    }
}
