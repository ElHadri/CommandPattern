using System.Collections.Generic;

namespace RemoteControllerWithCommandPattern.Commands
{
    class MacroOffCommand : IMyCommand
    {
        List<IMyCommand> Commands;
        public MacroOffCommand(List<IMyCommand> commands)
        {
            Commands = commands;
        }
        public void Execute()
        {
            foreach (var item in Commands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            for (int i = Commands.Count - 1; i >= 0; i--)
            {
                Commands[i].Undo();
            }
        }
    }
}
