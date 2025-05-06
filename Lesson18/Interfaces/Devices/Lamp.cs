namespace Lesson18.Interfaces.Devices
{
    public class Lamp : IDevice
    {
        public string Name { get; set; }
        public bool IsOn { get; private set; }

        public void TurnOn () => IsOn = true;
        public void TurnOff () => IsOn = false;
    }
}