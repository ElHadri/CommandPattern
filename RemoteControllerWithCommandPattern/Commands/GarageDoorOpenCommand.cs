using RemoteControllerWithCommandPattern.Devices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
