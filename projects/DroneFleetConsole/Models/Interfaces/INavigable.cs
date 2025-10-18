namespace DroneFleetConsole.Models.Interfaces
{
    internal interface INavigable
    {
        void SetWaypoint(double lat, double lon);
        (double lat, double lon)? CurrentWaypoint { get; }
    }
}
