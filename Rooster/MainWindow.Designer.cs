namespace Rooster
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
            this.załadujRoosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRoosterDialog = new System.Windows.Forms.OpenFileDialog();
            this.randomPlayers = new System.Windows.Forms.Button();
            this.randomResultPlayers = new System.Windows.Forms.TextBox();
            this.ResetRandom = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.detailedResultTextbox = new System.Windows.Forms.TextBox();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRoosterDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.załadujRoosterToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // załadujRoosterToolStripMenuItem
            // 
            this.załadujRoosterToolStripMenuItem.Name = "załadujRoosterToolStripMenuItem";
            this.załadujRoosterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.załadujRoosterToolStripMenuItem.Text = "Załaduj rooster";
            this.załadujRoosterToolStripMenuItem.Click += new System.EventHandler(this.załadujRoosterToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // openRoosterDialog
            // 
            this.openRoosterDialog.FileName = "rooster";
            this.openRoosterDialog.Filter = "Rooster files|*.csv;*.txt";
            // 
            // randomPlayers
            // 
            this.randomPlayers.Location = new System.Drawing.Point(10, 28);
            this.randomPlayers.Name = "randomPlayers";
            this.randomPlayers.Size = new System.Drawing.Size(164, 23);
            this.randomPlayers.TabIndex = 2;
            this.randomPlayers.Text = "Wylosuj graczy";
            this.randomPlayers.UseVisualStyleBackColor = true;
            this.randomPlayers.Click += new System.EventHandler(this.randomPlayers_Click);
            // 
            // randomResultPlayers
            // 
            this.randomResultPlayers.Location = new System.Drawing.Point(10, 58);
            this.randomResultPlayers.Multiline = true;
            this.randomResultPlayers.Name = "randomResultPlayers";
            this.randomResultPlayers.ReadOnly = true;
            this.randomResultPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.randomResultPlayers.Size = new System.Drawing.Size(758, 124);
            this.randomResultPlayers.TabIndex = 3;
            // 
            // ResetRandom
            // 
            this.ResetRandom.Location = new System.Drawing.Point(182, 28);
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
            this.resultLabel.Location = new System.Drawing.Point(9, 189);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(137, 20);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Tabela Wyników";
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
            this.resultDataGrid.Location = new System.Drawing.Point(10, 210);
            this.resultDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.RowTemplate.Height = 24;
            this.resultDataGrid.Size = new System.Drawing.Size(606, 258);
            this.resultDataGrid.TabIndex = 7;
            this.resultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Gracz";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // faction
            // 
            this.faction.DataPropertyName = "Faction";
            this.faction.HeaderText = "Frakcja";
            this.faction.Name = "faction";
            this.faction.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Punkty";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // wins
            // 
            this.wins.DataPropertyName = "Wins";
            this.wins.HeaderText = "W";
            this.wins.Name = "wins";
            this.wins.ReadOnly = true;
            // 
            // draws
            // 
            this.draws.DataPropertyName = "Draws";
            this.draws.HeaderText = "R";
            this.draws.Name = "draws";
            this.draws.ReadOnly = true;
            // 
            // loses
            // 
            this.loses.DataPropertyName = "Loses";
            this.loses.HeaderText = "P";
            this.loses.Name = "loses";
            this.loses.ReadOnly = true;
            // 
            // addResultButton
            // 
            this.addResultButton.Location = new System.Drawing.Point(621, 210);
            this.addResultButton.Margin = new System.Windows.Forms.Padding(2);
            this.addResultButton.Name = "addResultButton";
            this.addResultButton.Size = new System.Drawing.Size(146, 258);
            this.addResultButton.TabIndex = 8;
            this.addResultButton.Text = "Dodaj wynik";
            this.addResultButton.UseVisualStyleBackColor = true;
            this.addResultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szczegółowe wyniki";
            // 
            // detailedResultTextbox
            // 
            this.detailedResultTextbox.Enabled = false;
            this.detailedResultTextbox.Location = new System.Drawing.Point(13, 502);
            this.detailedResultTextbox.Multiline = true;
            this.detailedResultTextbox.Name = "detailedResultTextbox";
            this.detailedResultTextbox.Size = new System.Drawing.Size(753, 187);
            this.detailedResultTextbox.TabIndex = 10;
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj wyniki";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // loadRoosterDialog
            // 
            this.loadRoosterDialog.FileName = "rooster";
            this.loadRoosterDialog.Filter = "Rooster files(.dat)|*.dat";
            // 
            // mainWindowBindingSource1
            // 
            this.mainWindowBindingSource1.DataSource = typeof(Rooster.MainWindow);
            // 
            // mainWindowBindingSource
            // 
            this.mainWindowBindingSource.DataSource = typeof(Rooster.MainWindow);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 701);
            this.Controls.Add(this.detailedResultTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addResultButton);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ResetRandom);
            this.Controls.Add(this.randomResultPlayers);
            this.Controls.Add(this.randomPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Rooster";
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
        private System.Windows.Forms.ToolStripMenuItem załadujRoosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openRoosterDialog;
        private System.Windows.Forms.Button randomPlayers;
        private System.Windows.Forms.TextBox randomResultPlayers;
        private System.Windows.Forms.Button ResetRandom;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.BindingSource mainWindowBindingSource;
        private System.Windows.Forms.BindingSource mainWindowBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn loses;
        private System.Windows.Forms.Button addResultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detailedResultTextbox;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadRoosterDialog;
    }
}

