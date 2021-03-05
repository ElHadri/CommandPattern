using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RemoteController.Devices
{
    public class GarageDoor
    {
        public string Name = "Garage Door";

        public void Up() { MessageBox.Show("Garage Door is UP"); }
        public void Down() { MessageBox.Show("Garage Door is DOWN"); }
        public void Stop() { MessageBox.Show("Garage Door is STOP"); }
        public void LightOn() { MessageBox.Show("Garage Door is LIGHT ON"); }
        public void LightOff() { MessageBox.Show("Garage Door is LIGHT OFF"); }
    }
}
