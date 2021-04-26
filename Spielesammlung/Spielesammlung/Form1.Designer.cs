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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.Location = new System.Drawing.Point(760, 186);
            this.HighscoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(209, 32);
            this.HighscoreButton.TabIndex = 0;
            this.HighscoreButton.Text = "Highscore öffnen";
            this.HighscoreButton.UseVisualStyleBackColor = true;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tik Tak Toe Spielen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HighscoreButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Spielesammlung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.Button button1;
    }
}

