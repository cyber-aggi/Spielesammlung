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
        {   // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton1.Text == "X" || tikbutton1.Text == "O")
            {                           
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton1.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton1.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }           
        }
        // Button 2 des Spielfeldes
        private void tikbutton2_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton2.Text == "X" || tikbutton2.Text == "O")
            {             
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton2.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton2.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 3 des Spielfeldes
        private void tikbutton3_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton3.Text == "X" || tikbutton3.Text == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton3.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton3.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 4 des Spielfeldes
        private void tikbutton4_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton6.Text == "X" || tikbutton6.Text == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton6.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton6.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 5 des Spielfeldes
        private void tikbutton5_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton5.Text == "X" || tikbutton5.Text == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton5.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton5.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 6 des Spielfeldes
        private void tikbutton6_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton4.Text == "X" || tikbutton4.Text == "O")
            {
              
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton4.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton4.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }            
        }
        // Button 7 des Spielfeldes
        private void tikbutton7_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton9.Text == "X" || tikbutton9.Text == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist
                if (zähler == 1)
                {
                    tikbutton9.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton9.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 8 des Spielfeldes
        private void tikbutton8_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton8.Text == "X" || tikbutton8.Text == "O")
            {
            }
            else
            {
                if (zähler == 1)
                {
                    tikbutton8.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton8.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }
        }
        // Button 9 des Spielfeldes
        private void tikbutton9_Click(object sender, EventArgs e)
        {    // If-Abfrage prüft ob im Namen des Buttons bereits X oder O steht.
            if (tikbutton7.Text == "X" || tikbutton7.Text == "O")
            {
            }
            else
            {   //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist        
                if (zähler == 1)
                {
                    tikbutton7.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    tikbutton7.Text = "O";
                    zähler = 1;
                }
                textschreiben();
            }           
        }
        // Gibt an welcher Spieler dran ist
        private void textschreiben()
        {
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
                if(tikbutton1.Text == "X" && tikbutton2.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton4.Text == "X" && tikbutton5.Text == "X" && tikbutton6.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton7.Text == "X" && tikbutton8.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton1.Text == "X" && tikbutton5.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton7.Text == "X" && tikbutton5.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton2.Text == "X" && tikbutton5.Text == "X" && tikbutton8.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton3.Text == "X" && tikbutton6.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                if (tikbutton1.Text == "X" && tikbutton4.Text == "X" && tikbutton7.Text == "X")
                {
                    MessageBox.Show("Spieler 1 hat gewonnen!");
                }
                //Prüft ob Spieler 2 gewonnen hat
                if (tikbutton1.Text == "O" && tikbutton2.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton4.Text == "O" && tikbutton5.Text == "O" && tikbutton6.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton7.Text == "O" && tikbutton8.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton1.Text == "O" && tikbutton5.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton7.Text == "O" && tikbutton5.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton2.Text == "O" && tikbutton5.Text == "O" && tikbutton8.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton3.Text == "O" && tikbutton6.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
                if (tikbutton1.Text == "O" && tikbutton4.Text == "O" && tikbutton7.Text == "O")
                {
                    MessageBox.Show("Spieler 2 hat gewonnen!");
                }
            }
        } 
    }
}
