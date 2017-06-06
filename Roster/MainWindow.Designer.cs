namespace Roster
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.załadujRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graczeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRosterDialog = new System.Windows.Forms.OpenFileDialog();
            this.randomPlayers = new System.Windows.Forms.Button();
            this.ResetRandom = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.loadRosterDialog = new System.Windows.Forms.OpenFileDialog();
            this.addResultButton = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailedResultTextbox = new System.Windows.Forms.TextBox();
            this.randomResultPlayers = new System.Windows.Forms.TextBox();
            this.detailedResultLabel = new System.Windows.Forms.Label();
            this.mainWindowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.graczeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.załadujRosterToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // załadujRosterToolStripMenuItem
            // 
            this.załadujRosterToolStripMenuItem.Name = "załadujRosterToolStripMenuItem";
            this.załadujRosterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.załadujRosterToolStripMenuItem.Text = "Załaduj roster";
            this.załadujRosterToolStripMenuItem.Click += new System.EventHandler(this.załadujRosterToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj wyniki";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // graczeToolStripMenuItem
            // 
            this.graczeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerMenuItem});
            this.graczeToolStripMenuItem.Name = "graczeToolStripMenuItem";
            this.graczeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.graczeToolStripMenuItem.Text = "Gracze";
            // 
            // addPlayerMenuItem
            // 
            this.addPlayerMenuItem.Name = "addPlayerMenuItem";
            this.addPlayerMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPlayerMenuItem.Text = "Dodaj gracza";
            this.addPlayerMenuItem.Click += new System.EventHandler(this.addPlayerMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // openRosterDialog
            // 
            this.openRosterDialog.FileName = "roster";
            this.openRosterDialog.Filter = "Roster files|*.csv;*.txt";
            // 
            // randomPlayers
            // 
            this.randomPlayers.Location = new System.Drawing.Point(97, 33);
            this.randomPlayers.Name = "randomPlayers";
            this.randomPlayers.Size = new System.Drawing.Size(164, 23);
            this.randomPlayers.TabIndex = 2;
            this.randomPlayers.Text = "Wylosuj graczy";
            this.randomPlayers.UseVisualStyleBackColor = true;
            this.randomPlayers.Click += new System.EventHandler(this.randomPlayers_Click);
            // 
            // ResetRandom
            // 
            this.ResetRandom.Location = new System.Drawing.Point(13, 32);
            this.ResetRandom.Name = "ResetRandom";
            this.ResetRandom.Size = new System.Drawing.Size(78, 24);
            this.ResetRandom.TabIndex = 4;
            this.ResetRandom.Text = "Resetuj";
            this.ResetRandom.UseVisualStyleBackColor = true;
            this.ResetRandom.Click += new System.EventHandler(this.ResetRandom_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(591, 36);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(137, 20);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Tabela Wyników";
            // 
            // loadRosterDialog
            // 
            this.loadRosterDialog.FileName = "roster";
            this.loadRosterDialog.Filter = "Roster files(.dat)|*.dat";
            // 
            // addResultButton
            // 
            this.addResultButton.Location = new System.Drawing.Point(1246, 58);
            this.addResultButton.Margin = new System.Windows.Forms.Padding(2);
            this.addResultButton.Name = "addResultButton";
            this.addResultButton.Size = new System.Drawing.Size(93, 660);
            this.addResultButton.TabIndex = 8;
            this.addResultButton.Text = "Dodaj wynik";
            this.addResultButton.UseVisualStyleBackColor = true;
            this.addResultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowDrop = true;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.faction,
            this.Points,
            this.wins,
            this.draws,
            this.loses});
            this.resultDataGrid.Location = new System.Drawing.Point(595, 58);
            this.resultDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.RowTemplate.Height = 24;
            this.resultDataGrid.Size = new System.Drawing.Size(644, 660);
            this.resultDataGrid.TabIndex = 7;
            this.resultDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGrid_CellValueChanged);
            // 
            // loses
            // 
            this.loses.DataPropertyName = "Loses";
            this.loses.HeaderText = "P";
            this.loses.Name = "loses";
            // 
            // draws
            // 
            this.draws.DataPropertyName = "Draws";
            this.draws.HeaderText = "R";
            this.draws.Name = "draws";
            // 
            // wins
            // 
            this.wins.DataPropertyName = "Wins";
            this.wins.HeaderText = "W";
            this.wins.Name = "wins";
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Punkty";
            this.Points.Name = "Points";
            // 
            // faction
            // 
            this.faction.DataPropertyName = "Faction";
            this.faction.HeaderText = "Frakcja";
            this.faction.Name = "faction";
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Gracz";
            this.PlayerName.Name = "PlayerName";
            // 
            // detailedResultTextbox
            // 
            this.detailedResultTextbox.Enabled = false;
            this.detailedResultTextbox.Location = new System.Drawing.Point(13, 400);
            this.detailedResultTextbox.Multiline = true;
            this.detailedResultTextbox.Name = "detailedResultTextbox";
            this.detailedResultTextbox.Size = new System.Drawing.Size(563, 317);
            this.detailedResultTextbox.TabIndex = 10;
            // 
            // randomResultPlayers
            // 
            this.randomResultPlayers.Location = new System.Drawing.Point(12, 62);
            this.randomResultPlayers.Multiline = true;
            this.randomResultPlayers.Name = "randomResultPlayers";
            this.randomResultPlayers.ReadOnly = true;
            this.randomResultPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.randomResultPlayers.Size = new System.Drawing.Size(563, 297);
            this.randomResultPlayers.TabIndex = 3;
            // 
            // detailedResultLabel
            // 
            this.detailedResultLabel.AutoSize = true;
            this.detailedResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailedResultLabel.Location = new System.Drawing.Point(9, 377);
            this.detailedResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detailedResultLabel.Name = "detailedResultLabel";
            this.detailedResultLabel.Size = new System.Drawing.Size(167, 20);
            this.detailedResultLabel.TabIndex = 11;
            this.detailedResultLabel.Text = "Szczegółowe wyniki";
            // 
            // mainWindowBindingSource1
            // 
            this.mainWindowBindingSource1.DataSource = typeof(Roster.MainWindow);
            // 
            // mainWindowBindingSource
            // 
            this.mainWindowBindingSource.DataSource = typeof(Roster.MainWindow);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.detailedResultLabel);
            this.Controls.Add(this.randomResultPlayers);
            this.Controls.Add(this.randomPlayers);
            this.Controls.Add(this.detailedResultTextbox);
            this.Controls.Add(this.ResetRandom);
            this.Controls.Add(this.addResultButton);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resultLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Roster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem załadujRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openRosterDialog;
        private System.Windows.Forms.Button randomPlayers;
        private System.Windows.Forms.Button ResetRandom;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.BindingSource mainWindowBindingSource;
        private System.Windows.Forms.BindingSource mainWindowBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadRosterDialog;
        private System.Windows.Forms.ToolStripMenuItem graczeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerMenuItem;
        private System.Windows.Forms.Button addResultButton;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn loses;
        private System.Windows.Forms.TextBox detailedResultTextbox;
        private System.Windows.Forms.TextBox randomResultPlayers;
        private System.Windows.Forms.Label detailedResultLabel;
    }
}

