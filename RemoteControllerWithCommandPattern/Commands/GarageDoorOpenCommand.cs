using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class GarageDoorOpenCommand : IMyCommand
    {
        GarageDoor GarageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor.LightOn();
            GarageDoor.Up();
        }

        public void Undo()
        {
            GarageDoor.Down();
            GarageDoor.LightOff();
        }
    }
}
