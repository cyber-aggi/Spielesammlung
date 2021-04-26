
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
            this.btn_load = new System.Windows.Forms.Button();
            this.lB_Highscore = new System.Windows.Forms.ListBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.cB_spieleliste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(452, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(136, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Highscore laden";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lB_Highscore
            // 
            this.lB_Highscore.FormattingEnabled = true;
            this.lB_Highscore.Location = new System.Drawing.Point(25, 52);
            this.lB_Highscore.Name = "lB_Highscore";
            this.lB_Highscore.Size = new System.Drawing.Size(563, 264);
            this.lB_Highscore.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(452, 415);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(136, 23);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Daten als CSV exportieren";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // cB_spieleliste
            // 
            this.cB_spieleliste.FormattingEnabled = true;
            this.cB_spieleliste.Location = new System.Drawing.Point(325, 14);
            this.cB_spieleliste.Name = "cB_spieleliste";
            this.cB_spieleliste.Size = new System.Drawing.Size(121, 21);
            this.cB_spieleliste.TabIndex = 3;
            // 
            // Form_Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.cB_spieleliste);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lB_Highscore);
            this.Controls.Add(this.btn_load);
            this.Name = "Form_Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox lB_Highscore;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ComboBox cB_spieleliste;
    }
}