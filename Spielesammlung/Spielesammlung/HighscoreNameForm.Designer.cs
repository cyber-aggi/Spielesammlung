
namespace Spielesammlung
{
    partial class HighscoreNameForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label_Infotext = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(325, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Highscore eintragen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(340, 213);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(182, 31);
            this.tB_name.TabIndex = 1;
            // 
            // label_Infotext
            // 
            this.label_Infotext.Location = new System.Drawing.Point(32, 47);
            this.label_Infotext.Name = "label_Infotext";
            this.label_Infotext.Size = new System.Drawing.Size(568, 141);
            this.label_Infotext.TabIndex = 2;
            this.label_Infotext.Text = "Bitte gebe einen Namen für \" + gewinner + \" an.\\nWenn du auf den Button bestätige" +
    "n klickst, wird unter diesem Namen der Highscore eingetragen.\\nMit Abbrechen wir" +
    "d kein Highscoreeintrag vorgenommen.";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(37, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vorgang abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(120, 216);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 25);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "label1";
            // 
            // HighscoreNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 422);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_Infotext);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.button1);
            this.Name = "HighscoreNameForm";
            this.Text = "Highscore eintragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label label_Infotext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Name;
    }
}