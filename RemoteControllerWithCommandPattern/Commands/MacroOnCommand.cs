using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControllerWithCommandPattern.Commands
{
    class MacroOnCommand : IMyCommand
    {
        List<IMyCommand> Commands;
        public MacroOnCommand(List<IMyCommand> commands)
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
