using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    public abstract class Drone : ISelfTest, IFlightControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BatteryPercent { get; set; }
        public bool IsAirborne { get; set; }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }

}
