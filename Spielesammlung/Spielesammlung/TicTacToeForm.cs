using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////////////////////////////////////////////////////////////////////////
// Letzte Änderung: 30.04.2021
// Benjamin Meindl
// Sebastian Taglieber
// TicTacToeForm.cs
/////////////////////////////////////////////////////////////////////////////////////////

namespace Spielesammlung
{
    public partial class TicTacToeForm : Form
    {
        int zähler = 1;
        int zug = 0;
        public TicTacToeForm()
        {
            InitializeComponent();
        }


        // Button 1 des Spielfeldes
        private void tikbutton1_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton1.Text);
        }
        // Button 2 des Spielfeldes
        private void tikbutton2_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton2.Text);
        }
        // Button 3 des Spielfeldes
        private void tikbutton3_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton3.Text);
        }
        // Button 4 des Spielfeldes
        private void tikbutton4_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton4.Text);
        }
        // Button 5 des Spielfeldes
        private void tikbutton5_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton5.Text);
        }
        // Button 6 des Spielfeldes
        private void tikbutton6_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton6.Text);
        }
        // Button 7 des Spielfeldes
        private void tikbutton7_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton7.Text);
        }
        // Button 8 des Spielfeldes
        private void tikbutton8_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton8.Text);
        }
        // Button 9 des Spielfeldes
        private void tikbutton9_Click(object sender, EventArgs e)
        {
            setzespielstein(tikbutton9.Text);   
        }
        // Gibt an welcher Spieler dran ist
        private void textschreiben()
        {
            //if (DialogHighscore.tB_name.Text != )
            zug++;
            gewonnen();
            if (zähler == 1)
            {
                Amzuganzeige.Text = "Spieler 1 ist dran!";
            }
            else if (zähler == 2)
            {
                Amzuganzeige.Text = "Spieler 2 ist dran!";
            }
        }
        //Prüft ob ein Spieler gewonnen hat
        private void gewonnen()
        {
            if (zug >= 5)
            {
                //prüft ob Spieler 1 gewonnen hat
                if (tikbutton1.Text == "X" && tikbutton2.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton4.Text == "X" && tikbutton5.Text == "X" && tikbutton6.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton7.Text == "X" && tikbutton8.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton1.Text == "X" && tikbutton5.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton7.Text == "X" && tikbutton5.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton2.Text == "X" && tikbutton5.Text == "X" && tikbutton8.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton3.Text == "X" && tikbutton6.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton1.Text == "X" && tikbutton4.Text == "X" && tikbutton7.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                    zurücksetzen();
                }
                //Prüft ob Spieler 2 gewonnen hat
                if (tikbutton1.Text == "O" && tikbutton2.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton4.Text == "O" && tikbutton5.Text == "O" && tikbutton6.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton7.Text == "O" && tikbutton8.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton1.Text == "O" && tikbutton5.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton7.Text == "O" && tikbutton5.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton2.Text == "O" && tikbutton5.Text == "O" && tikbutton8.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton3.Text == "O" && tikbutton6.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
                if (tikbutton1.Text == "O" && tikbutton4.Text == "O" && tikbutton7.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                    zurücksetzen();
                }
            }
        }
        // Setzt einen Spielstein auf das ausgesuchte Spielfeld
        private void setzespielstein(string feldname)
        {
            if (feldname == "X" || feldname == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist        
                if (zähler == 1)
                {
                    feldname = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    feldname = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        //Nach dem Spielende wird das Spielfeld zurückgesetzt;
        private void zurücksetzen()
        {


            zähler = 1;
            zug = 0;
            textschreiben();
            foreach(object x in this.Controls)
            {
                if(x is Button)
                {
                    Button bla = (Button)x;
                    bla.Text = "";
                }
            }

        }
    }
}