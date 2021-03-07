using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteControllerWithCommandPattern.Devices
{
    public class Light
    {
        public string Name;

        public Light(string location)
        {
            Name = location;
        }

        //public void On() { MessageBox.Show("Light is ON"); }
        //public void Off() { MessageBox.Show("Light is OFF"); }
        public void On() { Debug.WriteLine("Light is ON"); }
        public void Off() { Debug.WriteLine("Light is OFF"); }
    }
}
