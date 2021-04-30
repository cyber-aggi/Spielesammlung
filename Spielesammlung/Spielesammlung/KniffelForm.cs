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
    public partial class KniffelForm : Form
    {
        private string[] spieler1 = new string[19];
        private string[] spieler2 = new string[19];
        private int aktuellerspieler = 1;
        private string namespieler1;
        private string namespieler2;
        private string spielename;

        public KniffelForm(string p_spielename = "Kniffel", string spieler1 = "Spieler 1", string spieler2 = "Spieler 2")
        {
            InitializeComponent();

            this.spielename = p_spielename;

            //Spielernamen in Variablen übertragen
            if(spieler1 == "" || spieler1 is null || spieler2 == "" || spieler2 is null)
            {
                namespieler1 = "Spieler 1";
                namespieler2 = "Spieler 2";
            } else
            {
                namespieler1 = spieler1;
                namespieler2 = spieler2;
            }
            label_spieler.Text = namespieler1;

            //Deaktiviert standardmäßig die Würfelcheckboxen
            cB_Wuerfel1.Enabled = false;
            cB_Wuerfel2.Enabled = false;
            cB_Wuerfel3.Enabled = false;
            cB_Wuerfel4.Enabled = false;
            cB_Wuerfel5.Enabled = false;
            //Deaktiviert standardmäßig alle Felder (Verhindert das unbeabsichtige Eintragen in Felder, ohne gewürfelt zu haben)
            AktiviereFelder(false);
            //Setzt einen Text für das Würfel-Label
            label_wurf.Text = "Wurf: 0";

            //Setze die Punktelabels auf ""
            label_punkte_gesamt.Text = "";
            label_punkte_oben.Text = "";
            label_punkte_unten.Text = "";
            label_punkte_oben_nachbonus.Text = "";
            label_punkte_oben_vorbonus.Text = "";
        }

        //Würfel-Engine -> für nicht ausgewählte Würfel, wird ein neuer Zufallswert gebildet
        private void Btn_Wuerfeln_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (!cB_Wuerfel1.Checked)
            {
                label_Wuerfel1.Text = Convert.ToString(rnd.Next(1, 7));
            }
            if (!cB_Wuerfel2.Checked)
            {
                label_Wuerfel2.Text = Convert.ToString(rnd.Next(1, 7));
            }
            if (!cB_Wuerfel3.Checked)
            {
                label_Wuerfel3.Text = Convert.ToString(rnd.Next(1, 7));
            }
            if (!cB_Wuerfel4.Checked)
            {
                label_Wuerfel4.Text = Convert.ToString(rnd.Next(1, 7));
            }
            if (!cB_Wuerfel5.Checked)
            {
                label_Wuerfel5.Text = Convert.ToString(rnd.Next(1, 7));
            }
            label_wurf.Text = "Wurf: " + Convert.ToString(Convert.ToInt32(label_wurf.Text.Split(' ')[1]) + 1);
            //Aktiviert die Checkboxen, wenn bereits gewürfelt wurde
            if(label_wurf.Text != "Wurf: 0")
            {
                cB_Wuerfel1.Enabled = true;
                cB_Wuerfel2.Enabled = true;
                cB_Wuerfel3.Enabled = true;
                cB_Wuerfel4.Enabled = true;
                cB_Wuerfel5.Enabled = true;
            }
            //Deaktiviert nach dem Würfel die Felder zum Eintragen (Verhindert einen Eintrag, bevor überhaupt gewürfelt wurde
            AktiviereFelder(true);
            //Deaktiviert den Würfel Button, wenn bereits 3 mal gewürfelt wurde
            if(Convert.ToInt32(label_wurf.Text.Split(' ')[1]) == 3)
            {
                Btn_Wuerfeln.Enabled = false;
            }
        }

        //Zählt die Anzahl der Würfel, die den Parameter Zahl haben
        private int Anzahl_Wuerfel(int zahl)
        {
            int anzahl = 0;
            if (label_Wuerfel1.Text == Convert.ToString(zahl))
            {
                anzahl += 1;
            }
            if (label_Wuerfel2.Text == Convert.ToString(zahl))
            {
                anzahl += 1;
            }
            if (label_Wuerfel3.Text == Convert.ToString(zahl))
            {
                anzahl += 1;
            }
            if (label_Wuerfel4.Text == Convert.ToString(zahl))
            {
                anzahl += 1;
            }
            if (label_Wuerfel5.Text == Convert.ToString(zahl))
            {
                anzahl += 1;
            }
            return anzahl;
        }

        //Berechnet die Punktzahl für den oberen Bereich und ob der Spieler einen Bonus bekommt
        private void CheckBonus()
        {
            int summe = 0;
            if(Btn_Oben_1.Text != "" && Btn_Oben_1.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_1.Text);
            }
            if (Btn_Oben_2.Text != "" && Btn_Oben_2.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_2.Text);
            }
            if (Btn_Oben_3.Text != "" && Btn_Oben_3.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_3.Text);
            }
            if (Btn_Oben_4.Text != "" && Btn_Oben_4.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_4.Text);
            }
            if (Btn_Oben_5.Text != "" && Btn_Oben_5.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_5.Text);
            }
            if (Btn_Oben_6.Text != "" && Btn_Oben_6.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Oben_6.Text);
            }
            label_punkte_oben_vorbonus.Text = Convert.ToString(summe);
            //Wenn die Summe größer oder gleich 63 ist, bekommt man einen Bonus von 35
            if(summe >= 63)
            {
                label_bonus.Text = Convert.ToString("35");
                summe += 35;
            }
            label_punkte_oben_nachbonus.Text = Convert.ToString(summe);
            label_punkte_oben.Text = Convert.ToString(summe);
            SummeGesamt();
        }

        //Berechnung der Punkte für den unteren Teil
        private void SummeUnten()
        {
            int summe = 0;
            if (Btn_Unten_DreierPasch.Text != "" && Btn_Unten_DreierPasch.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_DreierPasch.Text);
            }
            if (Btn_Unten_ViererPasch.Text != "" && Btn_Unten_ViererPasch.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_ViererPasch.Text);
            }
            if (Btn_Unten_FullHouse.Text != "" && Btn_Unten_FullHouse.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_FullHouse.Text);
            }
            if (Btn_Unten_KleineStrasse.Text != "" && Btn_Unten_KleineStrasse.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_KleineStrasse.Text);
            }
            if (Btn_Unten_GrosseStrasse.Text != "" && Btn_Unten_GrosseStrasse.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_GrosseStrasse.Text);
            }
            if (Btn_Unten_Kniffel.Text != "" && Btn_Unten_Kniffel.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_Kniffel.Text);
            }
            if (Btn_Unten_Chance.Text != "" && Btn_Unten_Chance.Text != "-")
            {
                summe += Convert.ToInt32(Btn_Unten_Chance.Text);
            }

            label_punkte_unten.Text = Convert.ToString(summe);
            SummeGesamt();
        }

        //Ermittelt aus dem oberen und unterem Teil die Gesamtpunktzahl
        private void SummeGesamt()
        {
            if(label_punkte_oben.Text != "" && label_punkte_unten.Text != "") {
                label_punkte_gesamt.Text = Convert.ToString(Convert.ToInt32(label_punkte_unten.Text) + Convert.ToInt32(label_punkte_oben.Text));
            }
        }

        //Ändert den Status der Felder
        private void AktiviereFelder(bool aktivieren)
        {
            Button[] felder = new Button[] { Btn_Oben_1, Btn_Oben_2, Btn_Oben_3, Btn_Oben_4, Btn_Oben_5, Btn_Oben_6, Btn_Unten_DreierPasch, Btn_Unten_ViererPasch, Btn_Unten_FullHouse, Btn_Unten_KleineStrasse, Btn_Unten_GrosseStrasse, Btn_Unten_Kniffel, Btn_Unten_Chance };

            if (aktivieren)
            {
                //Aktiviert die Buttons keinen Inhalt haben und deaktiviert die anderen
                foreach (Button t in felder)
                {
                    //Prüft ob diese Felder leer sind und aktiviert diese dann (ansonsten werden diese deaktivert)
                    //Man kann nur einmal in ein Feld schreiben
                    if (t.Text == "")
                    {
                        t.Enabled = true;
                    }
                    else
                    {
                        t.Enabled = false;
                    }
                }
            }
            else
            {
                //Deaktiviert, falls false übergeben wurde alle Felder
                foreach (Button t in felder)
                {
                    t.Enabled = false;
                }
            }
        }

        private void NextPlayer()
        {
            //Deaktiviert den Würfelbutton
            Btn_Wuerfeln.Enabled = false;
            //Warte 2,5 Sekunden (2500 Milliseconds) bevor der Spielstand des anderen Spielers geladen wird
            System.Threading.Thread.Sleep(2500);

            //Überprüft, ob der nächste Spieler noch freie Felder hat
            bool fertig = false;
            if(aktuellerspieler == 1)
            {
                fertig = true;
                foreach (string it in spieler2)
                {
                    if(it == "" || it is null)
                    {
                        fertig = false;
                    }
                }
            }
            else
            {
                fertig = true;
                foreach (string it in spieler1)
                {
                    if (it == "" || it is null)
                    {
                        fertig = false;
                    }
                }
            }
            //Fürs testen
            fertig = true;

            if(fertig)
            {
                string output = "";
                string gewinner;
                int punkte_sieger = 0;
                if(spieler1[18] == spieler2[18])
                {
                    output = "Es steht unentschieden mit " + spieler1[18] + " Punkten.\nHerzlichen Glückwunsch!";
                    gewinner = "";
                } else if(Convert.ToInt32(spieler1[18]) > Convert.ToInt32(spieler2[18]))
                {
                    output = namespieler1 + " hat mit " + spieler1[18] + " Punkten gegen " + namespieler2 + " mit " + spieler2[18] + " Punkten gewonnen!\nHerzlichen Glückwunsch!";
                    gewinner = namespieler1;
                    punkte_sieger = Convert.ToInt32(spieler1[18]);
                }
                else
                {
                    output = namespieler2 + " hat mit " + spieler2[18] + " Punkten gegen " + namespieler1 + " mit " + spieler1[18] + " Punkten gewonnen!\nHerzlichen Glückwunsch!";
                    gewinner = namespieler2;
                    punkte_sieger = Convert.ToInt32(spieler2[18]);
                }
                //Formular zur Eingabe von einem Namen für den Highscore
                if (gewinner == "Spieler 1")
                {
                    
                    
                }
                else if(gewinner == "Spieler 2")
                {
                    

                }

                //Wenn das Spiel Unendschieden ist, gibt wird kein Highscoreeintrag erstellt
                if (gewinner == "")
                {
                    MessageBox.Show("Das Spiel ist zu Ende!\n\n" + output + "\n\nDer Punktestand wird in den Highscore eingetragen!", "Spiel beendet");
                }
                else
                {
                    Highscore.datenEinfuegen(spielename, gewinner, punkte_sieger);
                    MessageBox.Show("Das Spiel ist zu Ende!\n\n" + output + "\n\nDer Punktestand wurde in den Highscore eingetragen!", "Spiel beendet");
                }
            }
            else
            {
                if(aktuellerspieler == 1)
                {
                    //Speichert die Werte von Spieler1 aus dem Formular im Array
                    spieler1[0] = Btn_Oben_1.Text;
                    spieler1[1] = Btn_Oben_2.Text;
                    spieler1[2] = Btn_Oben_3.Text;
                    spieler1[3] = Btn_Oben_4.Text;
                    spieler1[4] = Btn_Oben_5.Text;
                    spieler1[5] = Btn_Oben_6.Text;
                    spieler1[6] = label_punkte_oben_vorbonus.Text;
                    spieler1[7] = label_bonus.Text;
                    spieler1[8] = label_punkte_oben_nachbonus.Text;
                    spieler1[9] = Btn_Unten_DreierPasch.Text;
                    spieler1[10] = Btn_Unten_ViererPasch.Text;
                    spieler1[11] = Btn_Unten_FullHouse.Text;
                    spieler1[12] = Btn_Unten_KleineStrasse.Text;
                    spieler1[13] = Btn_Unten_GrosseStrasse.Text;
                    spieler1[14] = Btn_Unten_Kniffel.Text;
                    spieler1[15] = Btn_Unten_Chance.Text;
                    spieler1[16] = label_punkte_oben.Text;
                    spieler1[17] = label_punkte_unten.Text;
                    spieler1[18] = label_punkte_gesamt.Text;
                    //Werte von Spieler2 in das Formular eintragen
                    Btn_Oben_1.Text = spieler2[0];
                    Btn_Oben_2.Text = spieler2[1];
                    Btn_Oben_3.Text = spieler2[2];
                    Btn_Oben_4.Text = spieler2[3];
                    Btn_Oben_5.Text = spieler2[4];
                    Btn_Oben_6.Text = spieler2[5];
                    label_punkte_oben_vorbonus.Text = spieler2[6];
                    label_bonus.Text = spieler2[7];
                    label_punkte_oben_nachbonus.Text = spieler2[8];
                    Btn_Unten_DreierPasch.Text = spieler2[9];
                    Btn_Unten_ViererPasch.Text = spieler2[10];
                    Btn_Unten_FullHouse.Text = spieler2[11];
                    Btn_Unten_KleineStrasse.Text = spieler2[12];
                    Btn_Unten_GrosseStrasse.Text = spieler2[13];
                    Btn_Unten_Kniffel.Text = spieler2[14];
                    Btn_Unten_Chance.Text = spieler2[15];
                    label_punkte_oben.Text = spieler2[16];
                    label_punkte_unten.Text = spieler2[17];
                    label_punkte_gesamt.Text = spieler2[18];
                    //Änderungen der Spielernamen in der Label-Anzeige
                    label_spieler.Text = namespieler2;
                }
                else
                {
                    //Werte von Spieler 2 aus dem Formular in das Array schreiben
                    spieler2[0] = Btn_Oben_1.Text;
                    spieler2[1] = Btn_Oben_2.Text;
                    spieler2[2] = Btn_Oben_3.Text;
                    spieler2[3] = Btn_Oben_4.Text;
                    spieler2[4] = Btn_Oben_5.Text;
                    spieler2[5] = Btn_Oben_6.Text;
                    spieler2[6] = label_punkte_oben_vorbonus.Text;
                    spieler2[7] = label_bonus.Text;
                    spieler2[8] = label_punkte_oben_nachbonus.Text;
                    spieler2[9] = Btn_Unten_DreierPasch.Text;
                    spieler2[10] = Btn_Unten_ViererPasch.Text;
                    spieler2[11] = Btn_Unten_FullHouse.Text;
                    spieler2[12] = Btn_Unten_KleineStrasse.Text;
                    spieler2[13] = Btn_Unten_GrosseStrasse.Text;
                    spieler2[14] = Btn_Unten_Kniffel.Text;
                    spieler2[15] = Btn_Unten_Chance.Text;
                    spieler2[16] = label_punkte_oben.Text;
                    spieler2[17] = label_punkte_unten.Text;
                    spieler2[18] = label_punkte_gesamt.Text;
                    //Werte von Spieler1 in das Formular eintragen
                    Btn_Oben_1.Text = spieler1[0];
                    Btn_Oben_2.Text = spieler1[1];
                    Btn_Oben_3.Text = spieler1[2];
                    Btn_Oben_4.Text = spieler1[3];
                    Btn_Oben_5.Text = spieler1[4];
                    Btn_Oben_6.Text = spieler1[5];
                    label_punkte_oben_vorbonus.Text = spieler1[6];
                    label_bonus.Text = spieler1[7];
                    label_punkte_oben_nachbonus.Text = spieler1[8];
                    Btn_Unten_DreierPasch.Text = spieler1[9];
                    Btn_Unten_ViererPasch.Text = spieler1[10];
                    Btn_Unten_FullHouse.Text = spieler1[11];
                    Btn_Unten_KleineStrasse.Text = spieler1[12];
                    Btn_Unten_GrosseStrasse.Text = spieler1[13];
                    Btn_Unten_Kniffel.Text = spieler1[14];
                    Btn_Unten_Chance.Text = spieler1[15];
                    label_punkte_oben.Text = spieler1[16];
                    label_punkte_unten.Text = spieler1[17];
                    label_punkte_gesamt.Text = spieler1[18];
                    //Änderungen der Spielernamen in der Label-Anzeige
                    label_spieler.Text = namespieler1;
                }

                //Deaktiviert standardmäßig alle Felder, bis einmal gewürfelt wurde
                AktiviereFelder(false);

                //Wechsel des Spielers in der aktuellerSpieler Variablen
                aktuellerspieler = (aktuellerspieler%2)+1;

                //Zurücksetzen aller entsprechenden Buttons und Labels
                cB_Wuerfel1.Checked = false;
                cB_Wuerfel2.Checked = false;
                cB_Wuerfel3.Checked = false;
                cB_Wuerfel4.Checked = false;
                cB_Wuerfel5.Checked = false;
                //Setzt die Namen der Würfel-Labels auf den Ursprungszustand zurück
                label_Wuerfel1.Text = "Würfel 1";
                label_Wuerfel2.Text = "Würfel 2";
                label_Wuerfel3.Text = "Würfel 3";
                label_Wuerfel4.Text = "Würfel 4";
                label_Wuerfel5.Text = "Würfel 5";
                //Deaktiviert die Checkboxen der Würfel, um Fehleingaben zu verhindern
                cB_Wuerfel1.Enabled = false;
                cB_Wuerfel2.Enabled = false;
                cB_Wuerfel3.Enabled = false;
                cB_Wuerfel4.Enabled = false;
                cB_Wuerfel5.Enabled = false;
                //Zurücksetzen der restlichen Würfelobjekten
                label_wurf.Text = "Wurf: 0";
                Btn_Wuerfeln.Enabled = true;
            }
        }

        //Zählt alle Würfel mit der Zahl 1 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_1_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(1);
            Btn_Oben_1.Text = Convert.ToString(anzahl);
            Btn_Oben_1.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Zählt alle Würfel mit der Zahl 2 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_2_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(2);
            Btn_Oben_2.Text = Convert.ToString(anzahl*2);
            Btn_Oben_2.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Zählt alle Würfel mit der Zahl 3 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_3_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(3);
            Btn_Oben_3.Text = Convert.ToString(anzahl*3);
            Btn_Oben_3.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Zählt alle Würfel mit der Zahl 4 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_4_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(4);
            Btn_Oben_4.Text = Convert.ToString(anzahl*4);
            Btn_Oben_4.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Zählt alle Würfel mit der Zahl 5 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_5_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(5);
            Btn_Oben_5.Text = Convert.ToString(anzahl*5);
            Btn_Oben_5.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Zählt alle Würfel mit der Zahl 6 und ermittelt damit die entsprechende Punktzahl und trägt diese ein
        private void Btn_Oben_6_Click(object sender, EventArgs e)
        {
            int anzahl = Anzahl_Wuerfel(6);
            Btn_Oben_6.Text = Convert.ToString(anzahl*6);
            Btn_Oben_6.Enabled = false;
            CheckBonus();
            NextPlayer();
        }

        //Bildet die Summe alle Würfelaugen
        private int ZaehleWuerfel()
        {
            int summe = 0;
            if (label_Wuerfel1.Text != "")
            {
                summe += Convert.ToInt32(label_Wuerfel1.Text);
            }
            if (label_Wuerfel2.Text != "")
            {
                summe += Convert.ToInt32(label_Wuerfel2.Text);
            }
            if (label_Wuerfel3.Text != "")
            {
                summe += Convert.ToInt32(label_Wuerfel3.Text);
            }
            if (label_Wuerfel4.Text != "")
            {
                summe += Convert.ToInt32(label_Wuerfel4.Text);
            }
            if (label_Wuerfel5.Text != "")
            {
                summe += Convert.ToInt32(label_Wuerfel5.Text);
            }
            //Gibt die Summe zurück
            return summe;
        }

        private void Btn_Unten_DreierPasch_Click(object sender, EventArgs e)
        {
            //Prüft ob ein Dreierpasch vorliegt und trägt die Punktzahl ein
            if(Anzahl_Wuerfel(1) >= 3 || Anzahl_Wuerfel(2) >= 3 || Anzahl_Wuerfel(3) >= 3 || Anzahl_Wuerfel(4) >= 3 || Anzahl_Wuerfel(5) >= 3 || Anzahl_Wuerfel(6) >= 3)
            {
                Btn_Unten_DreierPasch.Text = Convert.ToString(ZaehleWuerfel());
            }
            //falls kein Dreierpasch vorliegt, wird stattdessen das Feld gestrichen
            else
            {
                Btn_Unten_DreierPasch.Text = "-";
            }
            Btn_Unten_DreierPasch.Enabled = false;
            SummeUnten();
            NextPlayer();
        }

        private void Btn_Unten_ViererPasch_Click(object sender, EventArgs e)
        {
            //Prüft ob ein Viererpasch vorliegt und trägt die Punktzahl ein
            if (Anzahl_Wuerfel(1) >= 4 || Anzahl_Wuerfel(2) >= 4 || Anzahl_Wuerfel(3) >= 4 || Anzahl_Wuerfel(4) >= 4 || Anzahl_Wuerfel(5) >= 4 || Anzahl_Wuerfel(6) >= 4)
            {
                Btn_Unten_ViererPasch.Text = Convert.ToString(ZaehleWuerfel());
            }
            //falls kein Viererpasch vorliegt, wird stattdessen das Feld gestrichen
            else
            {
                Btn_Unten_ViererPasch.Text = "-";
            }
            Btn_Unten_ViererPasch.Enabled = false;
            SummeUnten();
            NextPlayer();
        }


        private void Btn_Unten_Kniffel_Click(object sender, EventArgs e)
        {
            //Prüft ob ein Kniffel vorliegt und trägt die Punktzahl ein (alle Würfel mit der gleichen Zahl)
            if (Anzahl_Wuerfel(1) == 5 || Anzahl_Wuerfel(2) == 5 || Anzahl_Wuerfel(3) == 5 || Anzahl_Wuerfel(4) == 5 || Anzahl_Wuerfel(5) == 5 || Anzahl_Wuerfel(6) == 5)
            {
                Btn_Unten_Kniffel.Text = "50";
            }
            //falls kein Kniffel vorliegt, wird stattdessen das Feld gestrichen
            else
            {
                Btn_Unten_Kniffel.Text = "-";
            }
            Btn_Unten_Kniffel.Enabled = false;
            SummeUnten();
            NextPlayer();
        }

        private void Btn_Unten_Chance_Click(object sender, EventArgs e)
        {
            //Trägt die Summe aller Würfelaugen in das Feld ein
            Btn_Unten_Chance.Text = Convert.ToString(ZaehleWuerfel());
            Btn_Unten_Chance.Enabled = false;
            SummeUnten();
            NextPlayer();
        }

        private void Btn_Unten_FullHouse_Click(object sender, EventArgs e)
        {
            //Prüft ob ein Fullhouse vorliegt (ZahlA kommt dreimal vor und ZahlB zweimal)
            //Prüft ob eine Zahl genau 3 mal vorkommt
            bool fullhouse = false;
            if(Anzahl_Wuerfel(1) == 3 || Anzahl_Wuerfel(2) == 3 || Anzahl_Wuerfel(3) == 3 || Anzahl_Wuerfel(4) == 3 || Anzahl_Wuerfel(5) == 3 || Anzahl_Wuerfel(6) == 3)
            {
                //Prüft ob eine Zahl genau zweimal vorkommt
                if(Anzahl_Wuerfel(1) == 2 || Anzahl_Wuerfel(2) == 2 || Anzahl_Wuerfel(3) == 2 || Anzahl_Wuerfel(4) == 2 || Anzahl_Wuerfel(5) == 2 || Anzahl_Wuerfel(6) == 2)
                {
                    //Setzt den Wert der Variablen auf True -> es werden Punkte eingetragen
                    fullhouse = true;
                }
            }

            //Überprüfen ob die Würfel ein Fullhouse sind und entsprechend das Feld füllen
            if(fullhouse)
            {
                Btn_Unten_FullHouse.Text = "25";
            }
            else
            {
                Btn_Unten_FullHouse.Text = "-";
            }
            Btn_Unten_FullHouse.Enabled = false;
            SummeUnten();
            NextPlayer();
        }

        private void Btn_Unten_KleineStrasse_Click(object sender, EventArgs e)
        {
            //Überprüft ob eine Kleine Straße (4 der 5 Würfel in einer Reihe) vorliegt
            bool kleinestrasse = false;
            for (int i = 0; i <= 2; i++)
            {
                if (Anzahl_Wuerfel(1 + i) >= 1 && Anzahl_Wuerfel(2 + i) >= 1 && Anzahl_Wuerfel(3 + i) >= 1 && Anzahl_Wuerfel(4 + i) >= 1)
                {
                    kleinestrasse = true;
                }
            }

            //Trägt falls kleinestrasse true ist, 30 Punkte in das Feld ein
            if (kleinestrasse)
            {
                Btn_Unten_KleineStrasse.Text = "30";
            }
            else
            {
                Btn_Unten_KleineStrasse.Text = "-";
            }
            Btn_Unten_KleineStrasse.Enabled = false;
            SummeUnten();
            NextPlayer();
        }

        private void Btn_Unten_GrosseStrasse_Click(object sender, EventArgs e)
        {
            //Überprüft ob eine Große Straße vorliegt (alle Würfel in einer Reihe)
            bool grossestrasse = false;
            for (int i = 0; i <= 1; i++)
            {
                if (Anzahl_Wuerfel(1 + i) >= 1 && Anzahl_Wuerfel(2 + i) >= 1 && Anzahl_Wuerfel(3 + i) >= 1 && Anzahl_Wuerfel(4 + i) >= 1 && Anzahl_Wuerfel(5 + i) >= 1)
                {
                    grossestrasse = true;
                }
            }

            //Trägt falls grossetrasse true ist 40 Punkte in das Feld ein
            if (grossestrasse)
            {
                Btn_Unten_GrosseStrasse.Text = "40";
            }
            else
            {
                Btn_Unten_GrosseStrasse.Text = "-";
            }
            Btn_Unten_GrosseStrasse.Enabled = false;
            SummeUnten();
            NextPlayer();
        }
    }
}
