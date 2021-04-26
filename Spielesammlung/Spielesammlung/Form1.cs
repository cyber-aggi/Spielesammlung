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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            //Erzeugt ein neues Fenster
            Childform = new Form_Highscore();
            Childform.Show();
            MessageBox.Show("Hier ein neues Fenster!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Tik_Tak_Toe toe   = new Tik_Tak_Toe();
            toe.Show();


        }
    }
}
