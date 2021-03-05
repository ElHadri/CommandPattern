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

            // devices
            var light = new Light();
            var garageDoor = new GarageDoor();
            var outdoorLight = new OutdoorLight();

            // commands (parameterize)
            var commands = new IMyCommand[,]
            {
                {new LightOnCommand(light), new LightOffCommand(light)},
                {new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor)},
                {new OutdoorLightOnCommand(outdoorLight), new OutdoorLightOffCommand(outdoorLight)},
                {null,null},
                {null,null},
                {null,null},
                {null,null}
            };

            // UI slot names (parameterize)
            var uiSlots = new string[]
            {
                light.Name,
                garageDoor.Name,
                outdoorLight.Name,
                "Empty",
                "Empty",
                "Empty",
                "Empty"
            };

            _grid.Children.Add(new RemoteControl(commands, uiSlots));
        }
    }
}
