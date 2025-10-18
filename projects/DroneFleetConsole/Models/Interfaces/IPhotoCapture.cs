namespace DroneFleetConsole.Models.Interfaces
{
    internal interface IPhotoCapture
    {
        void TakePhoto();
        int PhotoCount { get; }
    }
}
