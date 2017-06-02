using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rooster
{
    public partial class MainWindow : Form
    {
        private static readonly Random Random = new Random();
        private static bool _isRoosterLoaded;

        private readonly SortableBindingList<Player> _bindingSource = new SortableBindingList<Player>();
        private IList<Player> _players;

        public MainWindow()
        {
            InitializeComponent();

            addResultButton.Enabled = false;
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpWindow = new Help();
            helpWindow.Show();
        }

        private void załadujRoosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isRoosterLoaded)
            {
                MessageBox.Show("Rooster jest obecnie załadowany. Jeśli chcesz załadować go ponownie, musisz zrestartować aplikację.",
                    "Rooster załadowany",
                    MessageBoxButtons.OK);
                return;
            }

            if (openRoosterDialog.ShowDialog() == DialogResult.OK)
            {
                var content = File.ReadAllText(openRoosterDialog.FileName, GetEncoding(openRoosterDialog.FileName));
                ReadRoosterFile(content);
                EnableAddResultButton();
                EnableAddPlayerButton();
                _isRoosterLoaded = true;
            }
        }

        private void EnableAddResultButton()
        {
            addResultButton.Enabled = true;
        }

        private void EnableAddPlayerButton()
        {
            addPlayerMenuItem.Enabled = true;
        }

        private void ReadRoosterFile(string content)
        {
            var players = content.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            _players = new List<Player>();
            foreach (var player in players)
            {
                var playerData = player.Split(';');
                _players.Add(new Player { PlayerName = playerData[0], Faction = playerData[1]});
                _bindingSource.Add(new Player { PlayerName = playerData[0], Faction = playerData[1] });
            }

            resultDataGrid.DataSource = _bindingSource;

        }

        private void randomPlayers_Click(object sender, EventArgs e)
        {
            var finished = false;

            if(_players == null) return;
            if (_players.Count % 2 != 0)
            {
                MessageBox.Show("Nie można losować graczy przy ich nieparzystej ilości.", "Nieprawidłowa ilość graczy",
                    MessageBoxButtons.OK);
                return;
            }

            var copiedPlayers = new List<Player>(_players);

            while (finished == false)
            {
                if (copiedPlayers.Count == 0) return;

                var playerIndex = Random.Next(0, copiedPlayers.Count - 1);
                var player = copiedPlayers[playerIndex];

                randomResultPlayers.Text += $"{player.PlayerName} ({player.Faction}) vs ";
                copiedPlayers.RemoveAt(playerIndex);

                var secondPlayerIndex = Random.Next(0, copiedPlayers.Count - 1);
                var secondPlayer = copiedPlayers[secondPlayerIndex];

                randomResultPlayers.Text += $"{secondPlayer.PlayerName} ({secondPlayer.Faction}){Environment.NewLine}";
                copiedPlayers.RemoveAt(secondPlayerIndex);

                if (copiedPlayers.Count == 0)
                {
                    randomResultPlayers.Text += "==================" + Environment.NewLine;
                    finished = true;
                }
            }
           
        }

        private void ResetRandom_Click(object sender, EventArgs e)
        {
            randomResultPlayers.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addResult = new AddResult();
            addResult.AddPlayers(_players);
            addResult.SetMainWindow(this);
            addResult.Show();
        }

        internal void AddResult(Player player1, Player player2, int result1, int result2)
        {
            if (result1 < result2)
            {
                player1.Loses += 1;
                player2.Wins += 1;
            }
            else if (result1 == result2)
            {
                player1.Draws += 1;
                player2.Draws += 1;
            }
            else
            {
                player1.Wins += 1;
                player2.Loses += 1;
            }

            player1.Points += result1;
            player2.Points += result2;

            for (var i = 0; i <= resultDataGrid.Rows.Count - 1; i++)
            {
                var row = resultDataGrid.Rows[i];
                var playerName = row.Cells[0].Value;

                if (playerName == null) continue;
                var playerNameText = playerName.ToString();

                if (player1.PlayerName == playerNameText)
                {
                    resultDataGrid.Rows[i].SetValues(new object[]
                    {
                        player1.PlayerName, player1.Faction, player1.Points, player1.Wins, player1.Draws, player1.Loses
                    });
                }

                if (player2.PlayerName == playerNameText)
                {
                    resultDataGrid.Rows[i].SetValues(new object[]
                    {
                        player2.PlayerName, player2.Faction, player2.Points, player2.Wins, player2.Draws, player2.Loses
                    });
                }
            }

            File.AppendAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\rooster.dat", $"{player1.PlayerName}|{result1}|{player2.PlayerName}|{result2}{Environment.NewLine}");

            detailedResultTextbox.Text += $"{player1.PlayerName} vs {player2.PlayerName} ({result1}:{result2}) {Environment.NewLine}";
            resultDataGrid.Sort(resultDataGrid.Columns[2], ListSortDirection.Descending);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadRoosterDialog.ShowDialog() == DialogResult.OK)
            {
                var content = File.ReadAllText(loadRoosterDialog.FileName);
                ReadResultsFile(content);
            }
        }

        private void ReadResultsFile(string content)
        {
            var data = content.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var entry in data)
            {
                var entryData = entry.Split('|');
                var player1Points = int.Parse(entryData[1]);
                var player2Points = int.Parse(entryData[3]);

                UpdatePlayer(player1Points, player2Points, entryData[0], player1Points);
                UpdatePlayer(player2Points, player1Points, entryData[2], player2Points);

                detailedResultTextbox.Text += $"{entryData[0]} vs {entryData[2]} ({entryData[1]}:{entryData[3]}) {Environment.NewLine}";
            }
        }

        private void UpdatePlayer(int player1Points, int player2Pointer, string player, int points)
        {
            for (var i = 0; i <= resultDataGrid.Rows.Count - 1; i++)
            {
                var row = resultDataGrid.Rows[i];
                var playerName = row.Cells[0].Value;

                if (playerName == null) continue;
                var playerNameText = playerName.ToString();

                var playerPoints = (int)row.Cells[2].Value;
                var playerWins = (int)row.Cells[3].Value;
                var playerDraws = (int)row.Cells[4].Value;
                var playerLoses = (int)row.Cells[5].Value;

                if (player1Points < player2Pointer)
                {
                    playerLoses += 1;
                }
                else if (player1Points == player2Pointer)
                {
                    playerDraws += 1;
                }
                else
                {
                    playerWins += 1;
                }

                if (player == playerNameText)
                {
                    resultDataGrid.Rows[i].SetValues(new object[]
                    {
                        playerNameText, resultDataGrid.Rows[i].Cells[1].Value, playerPoints + points, playerWins, playerDraws, playerLoses
                    });
                }
            }
        }

        /// <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endianness fails.
        /// </summary>
        /// <param name="filename">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        /// Taken from https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;
        }

        private void addPlayerMenuItem_Click(object sender, EventArgs e)
        {
            var addResult = new AddPlayer();
            addResult.AddPlayers(_players);
            addResult.SetMainWindow(this);
            addResult.Show();
        }

        public void AddNewPlayer(string playerName, string playerFaction)
        {
            var player = new Player
            {
                Draws = 0,
                Faction = playerFaction,
                Loses = 0,
                PlayerName = playerName,
                Points = 0,
                Wins = 0
            };

            _players.Add(player);
            _bindingSource.Add(player);
        }

        private void resultDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            var playerInTable = _bindingSource[e.RowIndex];
            var player = _players.First(_ => _.PlayerName == playerInTable.PlayerName);
            player.Draws = playerInTable.Draws;
            player.Loses = playerInTable.Loses;
            player.Points = playerInTable.Points;
            player.Wins = playerInTable.Wins;
        }
    }
}
