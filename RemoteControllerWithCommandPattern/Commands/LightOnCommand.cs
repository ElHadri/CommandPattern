using RemoteControllerWithCommandPattern.Devices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControllerWithCommandPattern.Commands
{
    class LightOnCommand : IMyCommand
    {
        Light Light;
        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }
    }
}
