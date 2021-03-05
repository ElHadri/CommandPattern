using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteControllerWithCommandPattern.Devices
{
    public class OutdoorLight
    {
        public string Name = "Outdoor Light";

        public void On() { MessageBox.Show("Outdoor Light is ON"); }
        public void Off() { MessageBox.Show("Outdoor Light is OFF"); }
    }
}
