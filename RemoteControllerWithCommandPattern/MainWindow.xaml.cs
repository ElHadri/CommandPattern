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
            var noDevice = new NoDevice();

            // commands (parameterize)
            var commands = new IMyCommand[,]
            {
                {new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight)},
                {new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight)},
                {new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor)},
                {new OutdoorLightOnCommand(outdoorLight), new OutdoorLightOffCommand(outdoorLight)},
                {new NoCommand(noDevice),new NoCommand(noDevice)},
                {new NoCommand(noDevice),new NoCommand(noDevice)},
                {new NoCommand(noDevice),new NoCommand(noDevice)}
            };

            // UI slot names (parameterize)
            var uiSlots = new string[]
            {
                kitchenLight.Name,
                livingRoomLight.Name,
                garageDoor.Name,
                outdoorLight.Name,
                noDevice.Name,
                noDevice.Name,
                noDevice.Name
            };

            var remoteControl = new RemoteControl();
            remoteControl.SetCommands(commands, uiSlots);

            _grid.Children.Add(remoteControl);
        }
    }
}
