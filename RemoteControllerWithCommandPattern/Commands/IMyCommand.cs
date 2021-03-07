namespace RemoteControllerWithCommandPattern.Commands
{
    public interface IMyCommand
    {
        public void Execute();
        public void Undo();

        /* for logging */
        //public void Store();
        //public void Load();
    }
}
