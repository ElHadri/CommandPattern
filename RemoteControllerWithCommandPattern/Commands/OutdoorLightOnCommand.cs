using RemoteControllerWithCommandPattern.Devices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControllerWithCommandPattern.Commands
{
    class OutdoorLightOnCommand : IMyCommand
    {
        OutdoorLight OutdoorLight;
        public OutdoorLightOnCommand(OutdoorLight outdoorLight)
        {
            OutdoorLight = outdoorLight;
        }

        public void Execute()
        {
            OutdoorLight.On();
        }
    }
}
