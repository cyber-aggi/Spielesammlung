
namespace Spielesammlung
{
    partial class Form_Highscore
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
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_export = new System.Windows.Forms.Button();
            this.cB_spieleliste = new System.Windows.Forms.ComboBox();
            this.lW_Highscore = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Btn_load
            // 
            this.Btn_load.Location = new System.Drawing.Point(452, 12);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(136, 23);
            this.Btn_load.TabIndex = 0;
            this.Btn_load.Text = "Highscore laden";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_export
            // 
            this.Btn_export.Location = new System.Drawing.Point(452, 415);
            this.Btn_export.Name = "Btn_export";
            this.Btn_export.Size = new System.Drawing.Size(136, 23);
            this.Btn_export.TabIndex = 2;
            this.Btn_export.Text = "Daten als CSV exportieren";
            this.Btn_export.UseVisualStyleBackColor = true;
            this.Btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // cB_spieleliste
            // 
            this.cB_spieleliste.FormattingEnabled = true;
            this.cB_spieleliste.Location = new System.Drawing.Point(325, 14);
            this.cB_spieleliste.Name = "cB_spieleliste";
            this.cB_spieleliste.Size = new System.Drawing.Size(121, 21);
            this.cB_spieleliste.TabIndex = 3;
            // 
            // lW_Highscore
            // 
            this.lW_Highscore.HideSelection = false;
            this.lW_Highscore.Location = new System.Drawing.Point(41, 53);
            this.lW_Highscore.Name = "lW_Highscore";
            this.lW_Highscore.Size = new System.Drawing.Size(547, 318);
            this.lW_Highscore.TabIndex = 4;
            this.lW_Highscore.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.lW_Highscore);
            this.Controls.Add(this.cB_spieleliste);
            this.Controls.Add(this.Btn_export);
            this.Controls.Add(this.Btn_load);
            this.Name = "Form_Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_export;
        private System.Windows.Forms.ComboBox cB_spieleliste;
        private System.Windows.Forms.ListView lW_Highscore;
    }
}