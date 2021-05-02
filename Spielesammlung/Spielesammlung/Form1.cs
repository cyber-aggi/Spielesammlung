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
                VierGewinntForm Childform_VierGewinnt = new VierGewinntForm();
                Childform_VierGewinnt.Show();
                MessageBox.Show("Viel Spaß beim Spielen!");
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "Tic-Tac-Toe")
            {
                TicTacToeForm Childform_TicTacToe = new TicTacToeForm();
                Childform_TicTacToe.Show();
                MessageBox.Show("Viel Spaß beim Spielen!");
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "Kniffel")
            {
                KniffelForm Childform_Kniffel = new KniffelForm();
                Childform_Kniffel.Show();
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
            Array.Sort(value);
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
                    "2. Spieler 1 beginnt. \n\n" +
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
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "Tic-Tac-Toe")
            {
                MessageBox.Show
                    ("Spielregeln Tic-Tac-Toe: \n\n" +
                    "Vor Beginn: \n" +
                    "1. Das Spielfeld ist drei mal drei Felder groß. \n\n" +
                    "So spielst du: \n" +
                    "1. Klicke auf das Feld, dass du besetzen möchtest. \n" +
                    "2. Jetzt ist dein Gegner dran. \n\n" +
                    "Das Ziel: \n" +
                    "1. Dein Spielziel ist es eine Dreierreihe mit deinen Steinen zu erschaffen. Diese kann senkrecht, waagrecht oder diagonal liegen. \n\n" +
                    "Ende des Spieles: \n" +
                    "1. Einer der beiden Spieler hat eine dreierreihe geschafft und damit gewonnen. \n" +
                    "2. Ihr habt alle eure Spielsteine aufgebraucht, das Spiel ist ein Unentschieden. \n\n" +
                    "Nachdem du jetzt die Regeln kennst, wünscht dir das ganze Team viel Spaß beim Spielen. \n");
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "Kniffel")
            {
                MessageBox.Show
                    ("Spielregeln Kniffel: \n\n" +
                    "Vor Beginn: \n" +
                    "1. Gespielt wird mit fünf Würfeln \n\n" +
                    "So spielst du: \n" +
                    "1. Mit drei Würfen pro Spielrunde veruchst du das punkthöchste Ergebnis zu erreichen. \n" +
                    "2. Nach jedem Wurf kannst du auswählen welche Würfel du behalten willst, mit den anderen würfelst du erneut. \n" +
                    "3. Hast du alle drei Würfe in einer Runde gemacht, wählst du das Feld aus, in dem deine Punkte gutgeschrieben werden sollen. \n" +
                    " Keine Sorge, den richtigen Wert berechnen wir dir dann. \n" +
                    "4. Hast du im oberen Teil mindestens 63 Punkte erreicht, berechnen wir dir einen 35 Punkte Bonus. \n" +
                    "5. Kannst du mal kein Feld füllen, klickst du einfach ein anderes unausgefülltes Feld an, es wird nun ausgegraut und mit 0 Punkten berechnet. \n\n" +
                    "Die Felder: \n" +
                    "1. Oberer Bereich - Zahlenfelder, bedeuten die benannten Zahlen.Im Einser Feld zählen z.B.nur die Einser die du gewürfelt hast. \n" +
                    "2. Dreierpasch - alle Zahlen zählen, es müssen aber mindestens drei gleiche Zahlen dabei sein. \n" +
                    "3. Viererpasch - alle Zahlen zählen, es müssen aber mindestens vier gleiche Zahlen dabei sein. \n" +
                    "4. Full - House - 25 Punkte, du brauchst einmal drei gleiche und einmal zwei gleiche Zahlen. \n" +
                    "5. kleine Straße - 30 Punkte, du brauchst vier aufeinanderfolgende Zahlen. \n" +
                    "6. große Straße - 40 Punkte, du brauchst fünf aufeinanderfolgende Zahlen. \n" +
                    "7. Kniffel - 50 Punkte, alle Zahlen auf allen fünf Würfeln müssen gleich sein. \n" +
                    "8. Chance - alle zahlen zählen, hat dich das Glück verlassen ? Dann ist dieses Feld das richtige für dich, es gibt keine Einschränkungen. \n \n" +
                    "Das Ziel: \n" +
                    "1. Dein Spielziel ist es das Glück herauszufordern und die höchste Punktzahl zu erreichen. \n \n" +
                    "Ende des Spiels: \n" +
                    "1. Jeder Spieler hat alle Punktefelder gefüllt, die Person mit der höchsten Endsumme gewinnt das Spiel."
                    );
            }
            else if (Convert.ToString(Spiele_Liste.SelectedItem) == "")
            {
                MessageBox.Show("Bitte wähle ein Spiel aus!");
            }
        }


        
    }
}
