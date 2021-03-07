using System.Diagnostics;

namespace RemoteControllerWithCommandPattern.Devices
{
    class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        private int Speed { get; set; }

        public string Name;

        public CeilingFan(string location)
        {
            Name = location;
            Off();
        }

        public void High()
        {
            Speed = HIGH;
            Debug.WriteLine("Ceiling Fan speed: HIGHT");
        }
        public void Medium()
        {
            Speed = MEDIUM;
            Debug.WriteLine("Ceiling Fan speed: MEDIUM");
        }
        public void Low()
        {
            Speed = LOW;
            Debug.WriteLine("Ceiling Fan speed: LOW");
        }
        public void Off()
        {
            Speed = OFF;
            Debug.WriteLine("Ceiling Fan speed: OFF");
        }

        public int GetSpeed() { return Speed; }
    }
}
