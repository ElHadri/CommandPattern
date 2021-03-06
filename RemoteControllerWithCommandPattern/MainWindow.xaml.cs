using RemoteControllerWithCommandPattern.Commands;
using RemoteControllerWithCommandPattern.Devices;

using System.Windows;

namespace RemoteControllerWithCommandPattern
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // devices (are specifis devices. Ex: Light in the living room)
            var kitchenLight = new Light("Kitchen Light");
            var livingRoomLight = new Light("Living Room Light");
            var garageDoor = new GarageDoor();
            var outdoorLight = new OutdoorLight();

            // create remote control
            var remoteControl = new RemoteControl();

            // parameterize remote cpntrol
            remoteControl.SetCommand((0,0), new LightOnCommand(kitchenLight), kitchenLight.Name);
            remoteControl.SetCommand((0,1), new LightOffCommand(kitchenLight), kitchenLight.Name);

            remoteControl.SetCommand((1,0), new LightOnCommand(livingRoomLight), livingRoomLight.Name);
            remoteControl.SetCommand((1,1), new LightOffCommand(livingRoomLight), livingRoomLight.Name);

            remoteControl.SetCommand((2,0), new GarageDoorOpenCommand(garageDoor), garageDoor.Name);
            remoteControl.SetCommand((2,1), new GarageDoorCloseCommand(garageDoor), garageDoor.Name);

            remoteControl.SetCommand((3,0), new OutdoorLightOnCommand(outdoorLight), outdoorLight.Name);
            remoteControl.SetCommand((3,1), new OutdoorLightOffCommand(outdoorLight), outdoorLight.Name);

            _grid.Children.Add(remoteControl);

            // console
            MessageBox.Show(remoteControl.ToString()); 
        }
    }
}
