using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class OutdoorLightOffCommand : IMyCommand
    {
        OutdoorLight OutdoorLight;
        public OutdoorLightOffCommand(OutdoorLight outdoorLight)
        {
            OutdoorLight = outdoorLight;
        }

        public void Execute()
        {
            OutdoorLight.Off();
        }
    }
}
