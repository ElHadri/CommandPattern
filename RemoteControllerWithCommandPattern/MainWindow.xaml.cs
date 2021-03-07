using RemoteControllerWithCommandPattern.Commands;
using RemoteControllerWithCommandPattern.Devices;

using System.Collections.Generic;
using System.Diagnostics;
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
            var ceilingFan = new CeilingFan("Living Room Fan");

            // create remote control
            var remoteControl = new RemoteControl();

            // parameterize remote control
            remoteControl.SetCommand((0, 0), new LightOnCommand(kitchenLight), "");
            remoteControl.SetCommand((0, 1), new LightOffCommand(kitchenLight), kitchenLight.Name);

            remoteControl.SetCommand((1, 0), new LightOnCommand(livingRoomLight), "");
            remoteControl.SetCommand((1, 1), new LightOffCommand(livingRoomLight), livingRoomLight.Name);

            remoteControl.SetCommand((2, 0), new GarageDoorOpenCommand(garageDoor), "");
            remoteControl.SetCommand((2, 1), new GarageDoorCloseCommand(garageDoor), garageDoor.Name);

            remoteControl.SetCommand((3, 0), new OutdoorLightOnCommand(outdoorLight), "");
            remoteControl.SetCommand((3, 1), new OutdoorLightOffCommand(outdoorLight), outdoorLight.Name);

            remoteControl.SetCommand((4, 0), new CeilingFanHighCommand(ceilingFan), "");
            remoteControl.SetCommand((4, 1), new CeilingFanOffCommand(ceilingFan), ceilingFan.Name + " High");
            remoteControl.SetCommand((5, 0), new CeilingFanMediumCommand(ceilingFan), "");
            remoteControl.SetCommand((5, 1), new CeilingFanOffCommand(ceilingFan), ceilingFan.Name + " Medium");

            List<IMyCommand> OnCommands = new List<IMyCommand>();
            OnCommands.Add(new GarageDoorOpenCommand(garageDoor));
            OnCommands.Add(new LightOnCommand(livingRoomLight));
            remoteControl.SetCommand((6, 0), new MacroOnCommand(OnCommands), "");
            List<IMyCommand> OffCommands = new List<IMyCommand>();
            OffCommands.Add(new GarageDoorCloseCommand(garageDoor));
            OffCommands.Add(new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand((6, 1), new MacroOffCommand(OffCommands), "Macro Command");

            _grid.Children.Add(remoteControl);

            // console
            //MessageBox.Show(remoteControl.ToString()); 
            Debug.WriteLine(remoteControl.ToString());
        }
    }
}
