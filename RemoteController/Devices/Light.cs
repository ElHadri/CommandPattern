using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RemoteController.Devices
{
    public class Light
    {
        public string Name = "Light";

        public void On() { MessageBox.Show("Light is ON"); }
        public void Off() { MessageBox.Show("Light is OFF"); }
    }
}
