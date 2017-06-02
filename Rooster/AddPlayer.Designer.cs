namespace Rooster
{
    partial class AddPlayer
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
            this.newPlayerName = new System.Windows.Forms.TextBox();
            this.newPlayerFaction = new System.Windows.Forms.TextBox();
            this.addPlayerLabel = new System.Windows.Forms.Label();
            this.newPlayerFactionLabel = new System.Windows.Forms.Label();
            this.addNewPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPlayerName
            // 
            this.newPlayerName.Location = new System.Drawing.Point(12, 35);
            this.newPlayerName.Name = "newPlayerName";
            this.newPlayerName.Size = new System.Drawing.Size(216, 20);
            this.newPlayerName.TabIndex = 0;
            // 
            // newPlayerFaction
            // 
            this.newPlayerFaction.Location = new System.Drawing.Point(12, 90);
            this.newPlayerFaction.Name = "newPlayerFaction";
            this.newPlayerFaction.Size = new System.Drawing.Size(216, 20);
            this.newPlayerFaction.TabIndex = 1;
            // 
            // addPlayerLabel
            // 
            this.addPlayerLabel.AutoSize = true;
            this.addPlayerLabel.Location = new System.Drawing.Point(12, 19);
            this.addPlayerLabel.Name = "addPlayerLabel";
            this.addPlayerLabel.Size = new System.Drawing.Size(61, 13);
            this.addPlayerLabel.TabIndex = 2;
            this.addPlayerLabel.Text = "Imię gracza";
            // 
            // newPlayerFactionLabel
            // 
            this.newPlayerFactionLabel.AutoSize = true;
            this.newPlayerFactionLabel.Location = new System.Drawing.Point(12, 74);
            this.newPlayerFactionLabel.Name = "newPlayerFactionLabel";
            this.newPlayerFactionLabel.Size = new System.Drawing.Size(42, 13);
            this.newPlayerFactionLabel.TabIndex = 3;
            this.newPlayerFactionLabel.Text = "Frakcja";
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.Location = new System.Drawing.Point(15, 139);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(213, 23);
            this.addNewPlayerButton.TabIndex = 4;
            this.addNewPlayerButton.Text = "Dodaj gracza";
            this.addNewPlayerButton.UseVisualStyleBackColor = false;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 175);
            this.Controls.Add(this.addNewPlayerButton);
            this.Controls.Add(this.newPlayerFactionLabel);
            this.Controls.Add(this.addPlayerLabel);
            this.Controls.Add(this.newPlayerFaction);
            this.Controls.Add(this.newPlayerName);
            this.Name = "AddPlayer";
            this.Text = "Dodaj gracza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPlayerName;
        private System.Windows.Forms.TextBox newPlayerFaction;
        private System.Windows.Forms.Label addPlayerLabel;
        private System.Windows.Forms.Label newPlayerFactionLabel;
        private System.Windows.Forms.Button addNewPlayerButton;
    }
}