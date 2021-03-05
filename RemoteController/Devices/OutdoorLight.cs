using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RemoteController.Devices
{
    public class OutdoorLight
    {
        public string Name = "Outdoor Light";

        public void On() { MessageBox.Show("Outdoor Light is ON"); }
        public void Off() { MessageBox.Show("Outdoor Light is OFF"); }
    }
}
