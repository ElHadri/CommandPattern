using RemoteControllerWithCommandPattern.Devices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControllerWithCommandPattern.Commands
{
    class LightOffCommand : IMyCommand
    {
        Light Light;
        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }
    }
}
