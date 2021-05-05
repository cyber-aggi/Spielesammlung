namespace Spielesammlung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.HighscoreButton = new System.Windows.Forms.Button();
            this.Spiele_Liste = new System.Windows.Forms.ListBox();
            this.StartenButton = new System.Windows.Forms.Button();
            this.LadenButton = new System.Windows.Forms.Button();
            this.RegelnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Spieler1Name_TextBox = new System.Windows.Forms.TextBox();
            this.Spieler2Name_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.Location = new System.Drawing.Point(685, 102);
            this.HighscoreButton.Margin = new System.Windows.Forms.Padding(6);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(286, 57);
            this.HighscoreButton.TabIndex = 4;
            this.HighscoreButton.Text = "Highscore öffnen";
            this.HighscoreButton.UseVisualStyleBackColor = true;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // Spiele_Liste
            // 
            this.Spiele_Liste.FormattingEnabled = true;
            this.Spiele_Liste.ItemHeight = 25;
            this.Spiele_Liste.Location = new System.Drawing.Point(136, 179);
            this.Spiele_Liste.Name = "Spiele_Liste";
            this.Spiele_Liste.Size = new System.Drawing.Size(628, 479);
            this.Spiele_Liste.TabIndex = 0;
            this.Spiele_Liste.DoubleClick += new System.EventHandler(this.Spiele_Liste_DoubleClick);
            // 
            // StartenButton
            // 
            this.StartenButton.Location = new System.Drawing.Point(797, 533);
            this.StartenButton.Name = "StartenButton";
            this.StartenButton.Size = new System.Drawing.Size(339, 125);
            this.StartenButton.TabIndex = 2;
            this.StartenButton.Text = "Spiel starten";
            this.StartenButton.UseVisualStyleBackColor = true;
            this.StartenButton.Click += new System.EventHandler(this.StartenButton_Click);
            // 
            // LadenButton
            // 
            this.LadenButton.Location = new System.Drawing.Point(136, 102);
            this.LadenButton.Name = "LadenButton";
            this.LadenButton.Size = new System.Drawing.Size(234, 57);
            this.LadenButton.TabIndex = 5;
            this.LadenButton.Text = "Spieleliste neuladen";
            this.LadenButton.UseVisualStyleBackColor = true;
            this.LadenButton.Click += new System.EventHandler(this.LadenButton_Click);
            // 
            // RegelnButton
            // 
            this.RegelnButton.Location = new System.Drawing.Point(390, 102);
            this.RegelnButton.Name = "RegelnButton";
            this.RegelnButton.Size = new System.Drawing.Size(272, 57);
            this.RegelnButton.TabIndex = 3;
            this.RegelnButton.Text = "Spielregeln";
            this.RegelnButton.UseVisualStyleBackColor = true;
            this.RegelnButton.Click += new System.EventHandler(this.RegelnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spieler 2";
            // 
            // Spieler1Name_TextBox
            // 
            this.Spieler1Name_TextBox.Location = new System.Drawing.Point(150, 48);
            this.Spieler1Name_TextBox.Name = "Spieler1Name_TextBox";
            this.Spieler1Name_TextBox.Size = new System.Drawing.Size(163, 31);
            this.Spieler1Name_TextBox.TabIndex = 0;
            // 
            // Spieler2Name_TextBox
            // 
            this.Spieler2Name_TextBox.Location = new System.Drawing.Point(150, 105);
            this.Spieler2Name_TextBox.Name = "Spieler2Name_TextBox";
            this.Spieler2Name_TextBox.Size = new System.Drawing.Size(163, 31);
            this.Spieler2Name_TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Spieler1Name_TextBox);
            this.groupBox1.Controls.Add(this.Spieler2Name_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(797, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spielernamen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RegelnButton);
            this.Controls.Add(this.LadenButton);
            this.Controls.Add(this.StartenButton);
            this.Controls.Add(this.Spiele_Liste);
            this.Controls.Add(this.HighscoreButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Spielesammlung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.ListBox Spiele_Liste;
        private System.Windows.Forms.Button StartenButton;
        private System.Windows.Forms.Button LadenButton;
        private System.Windows.Forms.Button RegelnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Spieler1Name_TextBox;
        private System.Windows.Forms.TextBox Spieler2Name_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

