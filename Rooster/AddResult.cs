using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rooster
{
    public partial class AddResult : Form
    {
        private readonly BindingSource _bindingSourcePlayer1 = new BindingSource();
        private readonly BindingSource _bindingSourcePlayer2 = new BindingSource();

        private IList<Player> _players;
        private MainWindow _mainWindow;

        public AddResult()
        {
            InitializeComponent();

            result1TextBox.KeyUp += Result1TextBoxOnKeyDown;
            result2TextBox.KeyUp += Result1TextBoxOnKeyDown;
        }

        private void Result1TextBoxOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            int result1;
            int result2;
            if (int.TryParse(result1TextBox.Text, out result1) && int.TryParse(result2TextBox.Text, out result2))
            {
                addResultBtn.Enabled = true;
            }
            else
            {
                addResultBtn.Enabled = false;
            }
        }

        internal void AddPlayers(IList<Player> players)
        {
            _players = players;

            foreach (var player in players)
            {
                _bindingSourcePlayer1.Add(player);
                _bindingSourcePlayer2.Add(player);
            }

            player1ComboBox.DataSource = _bindingSourcePlayer1;
            player1ComboBox.DisplayMember = "PlayerName";
            player2ComboBox.DataSource = _bindingSourcePlayer2;
            player2ComboBox.DisplayMember = "PlayerName";
        }

        internal void SetMainWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        private void addResultBtn_Click(object sender, EventArgs e)
        {
            if (player1ComboBox.SelectedIndex == player2ComboBox.SelectedIndex) return;

            _mainWindow.AddResult((Player) player1ComboBox.SelectedItem, (Player) player2ComboBox.SelectedItem,
                int.Parse(result1TextBox.Text),
                int.Parse(result2TextBox.Text));
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
