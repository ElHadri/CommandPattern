using RemoteControllerWithCommandPattern.Devices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControllerWithCommandPattern.Commands
{
    class CeilingFanOffCommand : IMyCommand
    {
        int PrevSpeed;

        CeilingFan CeilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
            PrevSpeed = ceilingFan.GetSpeed(); // In the case where we call Undo directly
        }

        public void Execute()
        {
            PrevSpeed = CeilingFan.GetSpeed(); // l'ordre est important
            CeilingFan.Off();
        }

        public void Undo()
        {
            if (PrevSpeed == CeilingFan.HIGH) { CeilingFan.High(); }
            else if (PrevSpeed == CeilingFan.MEDIUM) { CeilingFan.Medium(); }
            else if (PrevSpeed == CeilingFan.LOW) { CeilingFan.Low(); }
            else if (PrevSpeed == CeilingFan.OFF) { CeilingFan.Off(); }
        }

    }
}
