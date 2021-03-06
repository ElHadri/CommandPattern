using RemoteControllerWithCommandPattern.Commands;

using System.Windows;
using System.Windows.Controls;

namespace RemoteControllerWithCommandPattern
{
    public partial class RemoteControl : UserControl
    {
        // Slots
        IMyCommand[,] Commands = new IMyCommand[7, 2];
        string[] UiSlots = new string[7];

        public RemoteControl()
        {
            InitializeComponent();
        }

        public void SetCommands(IMyCommand[,] commands, string[] uiSlots)
        {
            UiSlots = uiSlots;
            _uiSlot1.Text = UiSlots[0];
            _uiSlot2.Text = UiSlots[1];
            _uiSlot3.Text = UiSlots[2];
            _uiSlot4.Text = UiSlots[3];
            _uiSlot5.Text = UiSlots[4];
            _uiSlot6.Text = UiSlots[5];
            _uiSlot7.Text = UiSlots[6];

            Commands = commands;
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
    }
}
