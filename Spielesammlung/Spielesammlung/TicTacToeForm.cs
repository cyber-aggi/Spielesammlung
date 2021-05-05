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
//////////////////////////////////////////////////////////////////////////////////////////

namespace Spielesammlung
{
    public partial class TicTacToeForm : Form
    {
        int zähler = 1;
        int zug = 0;
        string gewinner = "";
        private string namespieler1;
        private string namespieler2;
        private string spielename;
        public TicTacToeForm(string p_spielename = "TicTacToe", string spieler1 = "Spieler 1", string spieler2 = "Spieler 2")
        {
            InitializeComponent();
            //Spielernamen in Variablen übertragen (falls keine Übergeben wurden, Platzhalter einfügen)
            if(spieler1 == "" || spieler1 is null || spieler2 == "" || spieler2 is null)
            {
                namespieler1 = "Spieler 1";
                namespieler2 = "Spieler 2";
            } else
            {
                namespieler1 = spieler1;
                namespieler2 = spieler2;
            }
            Amzuganzeige.Text = namespieler1 + " ist dran!";
        }


        
        // Button 1 des Spielfeldes
        private void tikbutton1_Click(object sender, EventArgs e)
        {
            tikbutton1.Text = setzespielstein(tikbutton1.Text);
            textschreiben();
        }
        // Button 2 des Spielfeldes
        private void tikbutton2_Click(object sender, EventArgs e)
        {
            tikbutton2.Text = setzespielstein(tikbutton2.Text);
            textschreiben();
        }
        // Button 3 des Spielfeldes
        private void tikbutton3_Click(object sender, EventArgs e)
        {
            tikbutton3.Text = setzespielstein(tikbutton3.Text);
            textschreiben();
        }
        // Button 4 des Spielfeldes
        private void tikbutton4_Click(object sender, EventArgs e)
        {
            tikbutton4.Text = setzespielstein(tikbutton4.Text);
            textschreiben();
        }
        // Button 5 des Spielfeldes
        private void tikbutton5_Click(object sender, EventArgs e)
        {
            tikbutton5.Text = setzespielstein(tikbutton5.Text);
            textschreiben();
        }
        // Button 6 des Spielfeldes
        private void tikbutton6_Click(object sender, EventArgs e)
        {
            tikbutton6.Text = setzespielstein(tikbutton6.Text);
            textschreiben();
        }
        // Button 7 des Spielfeldes
        private void tikbutton7_Click(object sender, EventArgs e)
        {
            tikbutton7.Text = setzespielstein(tikbutton7.Text);
            textschreiben();
        }
        // Button 8 des Spielfeldes
        private void tikbutton8_Click(object sender, EventArgs e)
        {
            tikbutton8.Text = setzespielstein(tikbutton8.Text);
            textschreiben();
        }
        // Button 9 des Spielfeldes
        private void tikbutton9_Click(object sender, EventArgs e)
        {
            tikbutton9.Text = setzespielstein(tikbutton9.Text);
            textschreiben();
        }
        // Gibt an welcher Spieler dran ist
        private void textschreiben()
        {
            zug++;
            gewonnen();
            if (zähler == 1)
            {
                Amzuganzeige.Text = namespieler1 + " ist dran!";
            }
            else if (zähler == 2)
            {
                Amzuganzeige.Text = namespieler2 + " ist dran!";
            }
        }
        // Setzt einen Spielstein auf das ausgesuchte Spielfeld
        private string setzespielstein(string feldname)
        {
            if(feldname != "")
            {
                if (feldname == "X")
                {
                    zug--;
                    return "X";
                }
                else if (feldname == "O")
                {
                    zug--;
                    return "O";
                }
            }
            else
            {   
                //Zählerstand wird überprüft um zu ermitteln, welcher Spieler an der Reihe ist        
                if (zähler == 1)
                {
                    zähler = 2;
                    return "X";
                }
                else if (zähler == 2)
                {
                    zähler = 1;
                    return "O";
                }
            }
            return "Stimmt was nicht";
        }
        //Prüft ob ein Spieler gewonnen hat
        private void gewonnen()
        {
            
            if (zug >= 5)
            {
                //prüft ob Spieler 1 gewonnen hat
                if (tikbutton1.Text == "X" && tikbutton2.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton4.Text == "X" && tikbutton5.Text == "X" && tikbutton6.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton7.Text == "X" && tikbutton8.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton1.Text == "X" && tikbutton5.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton7.Text == "X" && tikbutton5.Text == "X" && tikbutton3.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton2.Text == "X" && tikbutton5.Text == "X" && tikbutton8.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton3.Text == "X" && tikbutton6.Text == "X" && tikbutton9.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                if (tikbutton1.Text == "X" && tikbutton4.Text == "X" && tikbutton7.Text == "X")
                {
                    MessageBox.Show(namespieler1 + " hat gewonnen!");
                    gewinner = namespieler1;
                    zurücksetzen();
                }
                //Prüft ob Spieler 2 gewonnen hat
                if (tikbutton1.Text == "O" && tikbutton2.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton4.Text == "O" && tikbutton5.Text == "O" && tikbutton6.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton7.Text == "O" && tikbutton8.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton1.Text == "O" && tikbutton5.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton7.Text == "O" && tikbutton5.Text == "O" && tikbutton3.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton2.Text == "O" && tikbutton5.Text == "O" && tikbutton8.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton3.Text == "O" && tikbutton6.Text == "O" && tikbutton9.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
                if (tikbutton1.Text == "O" && tikbutton4.Text == "O" && tikbutton7.Text == "O")
                {
                    MessageBox.Show(namespieler2 + " hat gewonnen!");
                    gewinner = namespieler2;
                    zurücksetzen();
                }
            }
            if(zug == 9)
            {
                MessageBox.Show("Unentschieden!");
                gewinner = "";
                zurücksetzen();
            }
        }
       


        //Nach dem Spielende wird das Spielfeld zurückgesetzt;
        private void zurücksetzen()
        {
            if (gewinner == "Spieler 1")
            {
                //Öffnet ein Dialogfeld, um einen Namen für Spieler 1 (Gewinner einzutragen)
                HighscoreNameForm DialogHighscore = new HighscoreNameForm(gewinner);
                if (DialogHighscore.ShowDialog() == DialogResult.OK)
                {
                    gewinner = DialogHighscore.tB_name.Text;
                }
                //Setzt den Gewinner auf "" damit kein Highscoreeinrag ausgeführt wird
                else
                {
                    gewinner = "";
                }
                DialogHighscore.Dispose();
            }
            else if (gewinner == "Spieler 2")
            {
                //Öffnet ein Dialogfeld, um einen Namen für Spieler 1 (Gewinner einzutragen)
                HighscoreNameForm DialogHighscore = new HighscoreNameForm(gewinner);
                if (DialogHighscore.ShowDialog() == DialogResult.OK)
                {
                    gewinner = DialogHighscore.tB_name.Text;
                }
                //Setzt den Gewinner auf "" damit kein Highscoreeinrag ausgeführt wird
                else
                {
                    gewinner = "";
                }
                DialogHighscore.Dispose();
            }
            if(gewinner != "") 
            { 
                Highscore.datenEinfuegen(spielename, gewinner, Punktzahl()); 
            }
            zähler = 1;
            zug = 0;
            textschreiben();
            zug = 0;
            foreach (object x in this.Controls)
            {
                if (x is Button)
                {
                    Button bla = (Button)x;
                    bla.Text = "";
                }
            }
        }
        public int Punktzahl()
        {
            int punkte = 0;
            punkte = 100 / zug; 
            return punkte;
        }
    }
}