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
            this.VierGewinntButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.Location = new System.Drawing.Point(570, 151);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(157, 26);
            this.HighscoreButton.TabIndex = 0;
            this.HighscoreButton.Text = "Highscore öffnen";
            this.HighscoreButton.UseVisualStyleBackColor = true;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // VierGewinntButton
            // 
            this.VierGewinntButton.Location = new System.Drawing.Point(574, 205);
            this.VierGewinntButton.Name = "VierGewinntButton";
            this.VierGewinntButton.Size = new System.Drawing.Size(153, 23);
            this.VierGewinntButton.TabIndex = 1;
            this.VierGewinntButton.Text = "Vier Gewinnt öffnen";
            this.VierGewinntButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VierGewinntButton);
            this.Controls.Add(this.HighscoreButton);
            this.Name = "Form1";
            this.Text = "Spielesammlung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.Button VierGewinntButton;
    }
}

