using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class NoCommand : IMyCommand
    {
        NoDevice NoDevice;
        public NoCommand()
        {
            NoDevice = new NoDevice();
        }

        public void Execute()
        {
            NoDevice.DoNothing();
        }
    }
}
