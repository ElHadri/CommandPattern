using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class NoCommand : IMyCommand
    {
        NoDevice NoDevice;
        public NoCommand(NoDevice noDevice)
        {
            NoDevice = noDevice;
        }

        public void Execute()
        {
            NoDevice.DoNothing();
        }
    }
}
