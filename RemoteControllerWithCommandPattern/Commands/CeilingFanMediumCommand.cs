using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class CeilingFanMediumCommand : IMyCommand
    {
        int PrevSpeed;

        CeilingFan CeilingFan;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
            PrevSpeed = ceilingFan.GetSpeed(); // In the case where we call Undo directly
        }

        public void Execute()
        {
            PrevSpeed = CeilingFan.GetSpeed(); // l'ordre est important
            CeilingFan.Medium();
        }

        public void Undo()
        {
            if (PrevSpeed == CeilingFan.HIGH) { CeilingFan.High(); }
            else if (PrevSpeed == CeilingFan.MEDIUM) { CeilingFan.Medium(); }
            else if (PrevSpeed == CeilingFan.LOW) { CeilingFan.Low(); }
            else if (PrevSpeed == CeilingFan.OFF) { CeilingFan.Off(); };
        }
    }
}
