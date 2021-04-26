using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class Form1 : Form
    {
        private Form_Highscore Childform;
        private VierGewinntForm Childform2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            //Erzeugt ein neues Fenster um den Highscore anzuzeigen
            Childform = new Form_Highscore();
            Childform.Show();
            MessageBox.Show("Hier ein neues Fenster!");
        }

        private void StartenButton_Click(object sender, EventArgs e)
        {
            //Erzeugt ein neues Fenster um das Spiel anzuzeigen
            if (Convert.ToString(Spiele_Liste.SelectedItem) == "Vier gewinnt")
            {
                Childform2 = new VierGewinntForm();
                Childform2.Show();
                MessageBox.Show("Viel Spaß beim Spielen!");
            }
            
        }

        private void LadenButton_Click(object sender, EventArgs e)
        {
            //Schreibt die Spiele aus einer Datei in die ListBox
            StreamReader dateipointer = new StreamReader("");
            for (int i = 0; i < 3; i++)
            {
                string zeile = dateipointer.ReadLine();

                Spiele_Liste.Items.Add(zeile);
            }
            
        }
    }
}
