using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteControllerWithCommandPattern.Devices
{
    public class Light
    {
        public string Name = "Light";

        public void On() { MessageBox.Show("Light is ON"); }
        public void Off() { MessageBox.Show("Light is OFF"); }
    }
}
