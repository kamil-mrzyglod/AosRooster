using System.Collections.Generic;
using System.Windows.Forms;

namespace Roster
{
    public partial class AddPlayer : Form
    {
        private IList<Player> _players;
        private MainWindow _mainWindow;

        public AddPlayer()
        {
            InitializeComponent();
        }

        internal void AddPlayers(IList<Player> players)
        {
            _players = players;
        }

        internal void SetMainWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        private void addNewPlayerButton_Click(object sender, System.EventArgs e)
        {
            _mainWindow.AddNewPlayer(newPlayerName.Text, newPlayerFaction.Text);

            Hide();
        }
    }
}
