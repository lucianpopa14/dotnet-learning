namespace DroneFleetConsole.Models.Interfaces
{
    internal interface ICargoCarrier
    {
        void UnloadAll();
        bool Load(double kg);
        double CurrentLoadKg { get; }
        double CapacityKg { get; }
    }
}
