using RemoteController.Devices;

using System.Windows;
using System.Windows.Controls;

namespace RemoteController
{
    public partial class RemoteControl : UserControl
    {
        // Devices
        Light Light;
        GarageDoor GarageDoor;
        OutdoorLight OutdoorLight;

        public RemoteControl()
        {
            InitializeComponent();
            Light = new Light();
            GarageDoor = new GarageDoor();
            OutdoorLight = new OutdoorLight();

            _uiSlot0.Text = Light.Name;
            _uiSlot1.Text = GarageDoor.Name;
            _uiSlot2.Text = OutdoorLight.Name;
        }

        private void OnLightON(object sender, RoutedEventArgs e) { Light.On(); }
        private void OnLightOFF(object sender, RoutedEventArgs e) { Light.Off(); }

        private void OnGarageDoorOPEN(object sender, RoutedEventArgs e) { GarageDoor.LightOn(); GarageDoor.Up(); }
        private void OnGarageDoorClose(object sender, RoutedEventArgs e) { GarageDoor.Down(); GarageDoor.LightOff(); }

        private void OnOutdoorLightON(object sender, RoutedEventArgs e) { OutdoorLight.On(); }
        private void OnOutdoorLightOFF(object sender, RoutedEventArgs e) { OutdoorLight.Off(); }

    }
}
