using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    internal class SurveyDrone : Drone, INavigable, IPhotoCapture
    {
        public (double lat, double lon)? CurrentWaypoint {  get; set; }

        public int PhotoCount {  get; set; }

        public void SetWaypoint(double lat, double lon)
        {
            throw new NotImplementedException();
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
