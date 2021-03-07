using RemoteControllerWithCommandPattern.Devices;

namespace RemoteControllerWithCommandPattern.Commands
{
    class CeilingFanHighCommand : IMyCommand
    {
        int PrevSpeed;

        CeilingFan CeilingFan;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
            PrevSpeed = ceilingFan.GetSpeed(); // In the case where we call Undo directly
        }

        public void Execute()
        {
            PrevSpeed = CeilingFan.GetSpeed(); // l'ordre est important
            CeilingFan.High();
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
