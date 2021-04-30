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
            this.SuspendLayout();
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.Location = new System.Drawing.Point(549, 177);
            this.HighscoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(212, 43);
            this.HighscoreButton.TabIndex = 0;
            this.HighscoreButton.Text = "Highscore öffnen";
            this.HighscoreButton.UseVisualStyleBackColor = true;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // Spiele_Liste
            // 
            this.Spiele_Liste.FormattingEnabled = true;
            this.Spiele_Liste.ItemHeight = 16;
            this.Spiele_Liste.Location = new System.Drawing.Point(91, 115);
            this.Spiele_Liste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Spiele_Liste.Name = "Spiele_Liste";
            this.Spiele_Liste.Size = new System.Drawing.Size(420, 308);
            this.Spiele_Liste.TabIndex = 1;
            this.Spiele_Liste.SelectedIndexChanged += new System.EventHandler(this.Spiele_Liste_SelectedIndexChanged);
            // 
            // StartenButton
            // 
            this.StartenButton.Location = new System.Drawing.Point(547, 115);
            this.StartenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartenButton.Name = "StartenButton";
            this.StartenButton.Size = new System.Drawing.Size(213, 40);
            this.StartenButton.TabIndex = 2;
            this.StartenButton.Text = "Spiel starten";
            this.StartenButton.UseVisualStyleBackColor = true;
            this.StartenButton.Click += new System.EventHandler(this.StartenButton_Click);
            // 
            // LadenButton
            // 
            this.LadenButton.Location = new System.Drawing.Point(353, 58);
            this.LadenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LadenButton.Name = "LadenButton";
            this.LadenButton.Size = new System.Drawing.Size(156, 36);
            this.LadenButton.TabIndex = 3;
            this.LadenButton.Text = "Spieleliste neuladen";
            this.LadenButton.UseVisualStyleBackColor = true;
            this.LadenButton.Click += new System.EventHandler(this.LadenButton_Click);
            // 
            // RegelnButton
            // 
            this.RegelnButton.Location = new System.Drawing.Point(549, 244);
            this.RegelnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegelnButton.Name = "RegelnButton";
            this.RegelnButton.Size = new System.Drawing.Size(211, 48);
            this.RegelnButton.TabIndex = 4;
            this.RegelnButton.Text = "Spielregeln";
            this.RegelnButton.UseVisualStyleBackColor = true;
            this.RegelnButton.Click += new System.EventHandler(this.RegelnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 554);
            this.Controls.Add(this.RegelnButton);
            this.Controls.Add(this.LadenButton);
            this.Controls.Add(this.StartenButton);
            this.Controls.Add(this.Spiele_Liste);
            this.Controls.Add(this.HighscoreButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Spielesammlung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.ListBox Spiele_Liste;
        private System.Windows.Forms.Button StartenButton;
        private System.Windows.Forms.Button LadenButton;
        private System.Windows.Forms.Button RegelnButton;
    }
}

