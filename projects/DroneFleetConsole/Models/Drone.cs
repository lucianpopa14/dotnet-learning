using DroneFleetConsole.Models.Interfaces;

namespace DroneFleetConsole.Models
{
    public abstract class Drone : ISelfTest, IFlightControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BatteryPercent { get; set; }
        public bool IsAirborne { get; set; } = false;

        public void Land()
        {
            if (!IsAirborne)
            {
                Console.WriteLine("Drone is not airborne. ");
                return;
            }
            else
            {
                IsAirborne = false;
                Console.WriteLine($"{Name} landed. Battery {BatteryPercent}%");
            }
        }

        public bool RunSelfTest()
        {
            if (BatteryPercent >= 20)
            {
                Console.WriteLine($"{Id}-{Name} self test passed.");
                return true;
            }
            else
            {
                Console.WriteLine($"{Id}-{Name} self test not passed.");
                return false;
            }
        }

        public void TakeOff()
        {
            if (BatteryPercent >= 20)
            {
                if (IsAirborne)
                {
                    Console.WriteLine("Drone is already airborne.");
                }
                else
                {
                    BatteryPercent -= 5;
                    IsAirborne = true;
                    Console.WriteLine($"{Name} took off. Battery {BatteryPercent}%");
                }
            }

            else
            {
                Console.WriteLine("Battery too low.");
                return;
            }
        }
    }

}
