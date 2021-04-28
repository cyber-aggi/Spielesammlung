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
        private Form_Highscore Childform_Highscore;
        private VierGewinntForm Childform_VierGewinnt;
        
        public Form1()
        {
            InitializeComponent();
            //Läd die Spiele direkt beim Start der Anwendung
            LoadGames();
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            //Erzeugt ein neues Fenster um den Highscore anzuzeigen
            Childform_Highscore = new Form_Highscore();
            Childform_Highscore.Show();
        }

        private void StartenButton_Click(object sender, EventArgs e)
        {
            //Erzeugt ein neues Fenster um das Spiel anzuzeigen
            if (Convert.ToString(Spiele_Liste.SelectedItem) == "Vier-Gewinnt")
            {
                Childform_VierGewinnt = new VierGewinntForm();
                Childform_VierGewinnt.Show();
                MessageBox.Show("Viel Spaß beim Spielen!");
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "Tic-Tac-Toe")
            {
                //TicTacToeForm Childform_TicTacToe = new TicTacToeForm();
                //Childform_TicTacToe.Show();
                MessageBox.Show("Viel Spaß beim Spielen!");
            }

        }

        private void LadenButton_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        //Methode zum Laden der Spiele
        private void LoadGames()
        {
            Spiele_Liste.Items.Clear();
            //Lesen der Spieleliste aus der Properties / Settings Datei
            string spiele = Properties.Settings.Default.spiele;
            String[] value = null;
            //Splitten der Informationen in ein Array
            value = spiele.Split(';');
            foreach (string v in value)
            {
                //Array zur Combobox hinzufügen, wenn der Arrayeintrag nicht leer ist
                if (v != "")
                {
                    Spiele_Liste.Items.Add(v);
                }
            }
        }

        private void RegelnButton_Click(object sender, EventArgs e)
        {
            //Fragt das Selected Item ab und zeigt dann die Spielregeln an
            if (Convert.ToString(Spiele_Liste.SelectedItem) == "Vier-Gewinnt")
            {
                MessageBox.Show
                    ("Spielregeln Vier-Gewinnt: \n\n" +
                    "Vor Beginn: \n" +
                    "1. Jeder Spieler hat 21 Spielchips zur Verfügung \n" +
                    "2. Der Spieler mit der Farbe rot/gelb darf anfangen \n\n" +
                    "So spielst du: \n" +
                    "1. Wirf einen deiner Steine von oben in eine der Reihen, dazu klickst du über eine der Reihen, der Stein plaziert sich dann automatisch. \n" +
                    "2. Jetzt ist dein Gegner dran. \n\n" +
                    "Das Ziel: \n" +
                    "1. Dein Spielziel ist es eine Viererreihe mit deinen Steinen zu erschaffen. Diese kann senkrecht, waagrecht oder diagonal liegen. \n\n" +
                    "Ende des Spieles: \n" +
                    "1. Einer der beiden Spieler hat eine viererreihe geschafft und damit gewonnen. \n" +
                    "2. Ihr habt alle eure Spielsteine aufgebraucht, das Spiel ist ein Unentschieden. \n\n" +
                    "Nachdem du jetzt die Regeln kennst, wünscht dir das ganze Team viel Spaß beim Spielen. \n");
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "")
            {
                MessageBox.Show("Bitte wähle ein Spiel aus.");
            }
        }
    }
}
