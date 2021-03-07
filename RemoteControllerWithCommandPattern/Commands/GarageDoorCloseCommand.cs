using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class GarageDoorCloseCommand : IMyCommand
    {
        GarageDoor GarageDoor;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor.Down();
            GarageDoor.LightOff();
        }

        public void Undo()
        {
            GarageDoor.LightOn();
            GarageDoor.Up();
        }
    }
}
