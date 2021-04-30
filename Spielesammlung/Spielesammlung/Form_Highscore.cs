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
using static Spielesammlung.Highscore;

namespace Spielesammlung
{
    public partial class Form_Highscore : Form
    {
        public Form_Highscore(string spielname = "")
        {
            InitializeComponent();
            //Lesen der Spieleliste aus der Properties / Settings Datei
            string spiele = Properties.Settings.Default.spiele;
            //Splitten der Informationen in ein Array
            String[] value = spiele.Split(';');
            Array.Sort(value);
            foreach(string v in value)
            {
                //Array zur Combobox hinzufügen, wenn der Arrayeintrag nicht leer ist
                if (v != "")
                {
                    cB_spieleliste.Items.Add(v);
                }
            }

            //Wenn ein Spielname übergeben wird, wird dieser direkt ausgewählt
            if(spielname != "")
            {
                cB_spieleliste.Text = spielname;
            }
            
            //Hinzufügen von Tabellenüberschriften
            lW_Highscore.Columns.Clear();
            lW_Highscore.Columns.Add("Spielername");
            lW_Highscore.Columns.Add("Datum");
            lW_Highscore.Columns.Add("Punktestand");
            lW_Highscore.View = View.Details;
            lW_Highscore.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            if (cB_spieleliste.Text == "")
            {
                MessageBox.Show("Bitte wähle zuerst ein Spiel aus, um dir den Highscore anzeigen zu lassen!", "Fehlermeldung");
            }
            else
            {
                //Leert die Listbox bevor neue Einträge aus der Datenbank geholt werden
                lW_Highscore.Items.Clear();

                //Holen der Einträge aus der Datenbank
                string[][] list = datenLesen(cB_spieleliste.Text);
                foreach (string[] row in list)
                {
                    ListViewItem item = new ListViewItem(row[0]);
                    item.SubItems.Add(row[2]);
                    item.SubItems.Add(row[1]);
                    lW_Highscore.Items.Add(item);
                }
                
                //Rückmeldung an den Benutzer
                MessageBox.Show("Daten wurden erfolgreich geladen!", "Information");
            }
        }

        //Möglichkeit zum exportieren von  den Highscore Datensätzen
        private void Btn_export_Click(object sender, EventArgs e)
        {
            if (lW_Highscore.Items.Count == 0)
            {
                MessageBox.Show("Bitte lade zuerst den aktuellen Highscore aus der Datenbank!", "Fehlermeldung");
            }
            else
            {
                //Öffnet Dateiexplorer zum Speichern dieser Datei
                SaveFileDialog sFD = new SaveFileDialog
                {
                    Filter = "CSV-Datei (*.csv)|*.csv|TXT-Datei (*.txt)|*.txt",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                    FileName = "Highscore_" + cB_spieleliste.Text
                };

                //Wenn auf Speichern geklickt wurde, wird die Datei geschrieben
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Öffnen der Datei in der gespeichert werden soll
                        StreamWriter writer = new StreamWriter(sFD.FileName + sFD.DefaultExt);

                        //Füge jeden Eintrag in der Listbox zur Datei hinzu
                        foreach (ListViewItem item in lW_Highscore.Items)
                        {
                            string output = "";
                            int temp = 0;
                            foreach (ListViewItem.ListViewSubItem row in item.SubItems)
                            {
                                if (temp == 0)
                                {
                                    output += row.Text.ToString();
                                }
                                else
                                {
                                    output += ";" + row.Text.ToString();
                                }
                                temp += 1;
                            }
                            writer.WriteLine(output);
                        }
                        //Schließen der Datei
                        writer.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Es gab einen Fehler: " + error.Message, "Fehlermeldung");
                    }
                    //Bestätigt den erfolgreichen Export der Daten aus dem ListView
                    MessageBox.Show("Highscore wurde erfolgreich exportiert!", "Information");
                }
            }
        }
    }
}
