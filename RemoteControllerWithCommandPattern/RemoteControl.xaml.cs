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

        public RemoteControl(IMyCommand[,] commands, string[] uiSlots)
        {
            InitializeComponent();

            Commands = commands;
            UiSlots = uiSlots;

            _uiSlot1.Text = UiSlots[0];
            _uiSlot2.Text = UiSlots[1];
            _uiSlot3.Text = UiSlots[2];
            _uiSlot4.Text = UiSlots[3];
            _uiSlot5.Text = UiSlots[4];
            _uiSlot6.Text = UiSlots[5];
            _uiSlot7.Text = UiSlots[6];
        }

        private void _onButton1_Click(object sender, RoutedEventArgs e)
        {
            Commands[0, 0].Execute();
        }

        private void _offButton1_Click(object sender, RoutedEventArgs e)
        {
            Commands[0, 1].Execute();
        }

        private void _onButton2_Click(object sender, RoutedEventArgs e)
        {
            Commands[1, 0].Execute();
        }

        private void _offButton2_Click(object sender, RoutedEventArgs e)
        {
            Commands[1, 1].Execute();
        }

        private void _onButton3_Click(object sender, RoutedEventArgs e)
        {
            Commands[2, 0].Execute();
        }

        private void _offButton3_Click(object sender, RoutedEventArgs e)
        {
            Commands[2, 1].Execute();
        }

        private void _onButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _offButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _onButton5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _offButton5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _onButton6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _offButton6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _onButton7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _offButton7_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
