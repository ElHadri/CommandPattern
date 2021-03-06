using RemoteControllerWithCommandPattern.Commands;

using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RemoteControllerWithCommandPattern
{
    public partial class RemoteControl : UserControl
    {
        IMyCommand[,] Commands;

        public RemoteControl()
        {
            InitializeComponent();

            Commands = new IMyCommand[7, 2];
            for (int i = 0; i < Commands.GetLength(0); i++)
                for (int j = 0; j < Commands.GetLength(1); j++)
                    Commands[i, j] = new NoCommand();

            _uiSlot0.Text = "Empty";
            _uiSlot1.Text = "Empty";
            _uiSlot2.Text = "Empty";
            _uiSlot3.Text = "Empty";
            _uiSlot4.Text = "Empty";
            _uiSlot5.Text = "Empty";
            _uiSlot6.Text = "Empty";

        }

        public void SetCommand((int, int) position, IMyCommand command, string uiSlot)
        {
            switch (position.Item1)
            {
                case 0:
                    _uiSlot0.Text = uiSlot;
                    break;
                case 1:
                    _uiSlot1.Text = uiSlot;
                    break;
                case 2:
                    _uiSlot2.Text = uiSlot;
                    break;
                case 3:
                    _uiSlot3.Text = uiSlot;
                    break;
                case 4:
                    _uiSlot4.Text = uiSlot;
                    break;
                case 5:
                    _uiSlot5.Text = uiSlot;
                    break;
                case 6:
                    _uiSlot6.Text = uiSlot;
                    break;

                default:
                    break;
            }

            Commands[position.Item1, position.Item2] = command;
        }

        private (int, int) _helperSwitcher(string buttonName)
        {
            switch (buttonName)
            {
                case "_onButton1":
                    return (0, 0);
                case "_offButton1":
                    return (0, 1);
                case "_onButton2":
                    return (1, 0);
                case "_offButton2":
                    return (1, 1);
                case "_onButton3":
                    return (2, 0);
                case "_offButton3":
                    return (2, 1);
                case "_onButton4":
                    return (3, 0);
                case "_offButton4":
                    return (3, 1);
                case "_onButton5":
                    return (4, 0);
                case "_offButton5":
                    return (4, 1);
                case "_onButton6":
                    return (5, 0);
                case "_offButton6":
                    return (5, 1);
                case "_onButton7":
                    return (6, 0);
                case "_offButton7":
                    return (6, 1);

                default:
                    return (-1, -1);
            }
        }

        private void _onButtonPushed(object sender, RoutedEventArgs e)
        {
            int x = _helperSwitcher(((Button)e.Source).Name).Item1;
            int y = _helperSwitcher(((Button)e.Source).Name).Item2;
            Commands[x, y].Execute();
        }


        // Console------------------------------------
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < Commands.GetLength(0); i++)
            {
                for (int j = 0; j < Commands.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        stringBuilder.Append("[slot " + i + "] " + Commands[i, j].GetType().Name);
                    }
                    if (j == 1)
                    {
                        stringBuilder.Append("----" + Commands[i, j].GetType().Name + "\n");
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }
}

