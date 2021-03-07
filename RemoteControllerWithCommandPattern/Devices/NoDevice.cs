using System.Diagnostics;
using System.Windows;

namespace RemoteControllerWithCommandPattern.Devices
{
    public class NoDevice
    {
        public string Name = "No Device";

        public void DoNothing() { Debug.WriteLine("Nothing to do !!"); }
        //public void DoNothing() { MessageBox.Show("Nothing to do !!"); }
    }
}
