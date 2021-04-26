using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class Form1 : Form
    {
        private Form_Highscore Childform;
        private VierGewinntForm ViGeform;
        
        
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

    }
}
