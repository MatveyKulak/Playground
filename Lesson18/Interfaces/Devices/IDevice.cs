namespace Lesson18.Interfaces.Devices
{
    public interface IDevice
    {
        string Name { get; set; }
        bool IsOn { get; }

        void TurnOn ();
        void TurnOff ();

        static void ShowDeviceType ()
        {
            Console.WriteLine("Это интерфейс IDevice.");
        }
    }
}