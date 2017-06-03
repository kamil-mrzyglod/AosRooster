namespace Rooster
{
    partial class AddResult
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
            this.player1ComboBox = new System.Windows.Forms.ComboBox();
            this.addResultBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player2ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result1TextBox = new System.Windows.Forms.TextBox();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // player1ComboBox
            // 
            this.player1ComboBox.FormattingEnabled = true;
            this.player1ComboBox.Location = new System.Drawing.Point(10, 11);
            this.player1ComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1ComboBox.Name = "player1ComboBox";
            this.player1ComboBox.Size = new System.Drawing.Size(195, 21);
            this.player1ComboBox.TabIndex = 0;
            // 
            // addResultBtn
            // 
            this.addResultBtn.Enabled = false;
            this.addResultBtn.Location = new System.Drawing.Point(10, 146);
            this.addResultBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addResultBtn.Name = "addResultBtn";
            this.addResultBtn.Size = new System.Drawing.Size(194, 48);
            this.addResultBtn.TabIndex = 1;
            this.addResultBtn.Text = "Dodaj wynik";
            this.addResultBtn.UseVisualStyleBackColor = true;
            this.addResultBtn.Click += new System.EventHandler(this.addResultBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "vs";
            // 
            // player2ComboBox
            // 
            this.player2ComboBox.FormattingEnabled = true;
            this.player2ComboBox.Location = new System.Drawing.Point(10, 48);
            this.player2ComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2ComboBox.Name = "player2ComboBox";
            this.player2ComboBox.Size = new System.Drawing.Size(195, 21);
            this.player2ComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wynik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result1TextBox
            // 
            this.result1TextBox.Location = new System.Drawing.Point(10, 102);
            this.result1TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result1TextBox.Name = "result1TextBox";
            this.result1TextBox.Size = new System.Drawing.Size(76, 20);
            this.result1TextBox.TabIndex = 5;
            // 
            // result2TextBox
            // 
            this.result2TextBox.Location = new System.Drawing.Point(129, 102);
            this.result2TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.Size = new System.Drawing.Size(76, 20);
            this.result2TextBox.TabIndex = 6;
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 212);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.result1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addResultBtn);
            this.Controls.Add(this.player1ComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddResult";
            this.Text = "Dodaj wynik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox player1ComboBox;
        private System.Windows.Forms.Button addResultBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox player2ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result1TextBox;
        private System.Windows.Forms.TextBox result2TextBox;
    }
}