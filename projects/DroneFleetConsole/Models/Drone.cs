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
            Console.WriteLine("Drone has landed.");
        }

        public bool RunSelfTest()
        {
            if (BatteryPercent >= 20)
            {
                Console.WriteLine("Self test passed.");
                return true;
            }
            else
            {
                Console.WriteLine("Self test not passed.");
                return false;
            }
        }

        public void TakeOff()
        {
            Console.WriteLine("Drone has taken off.");
        }
    }

}
