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
    public partial class Form_Highscore : Form
    {
        public Form_Highscore()
        {
            InitializeComponent();
            //Lesen der Spieleliste aus der Properties / Settings Datei
            string spiele = Properties.Settings.Default.spiele;
            String[] value = null;
            //Splitten der Informationen in ein Array
            value = spiele.Split(';');
            foreach(string v in value)
            {
                //Array zur Combobox hinzufügen, wenn der Arrayeintrag nicht leer ist
                if (v != "")
                {
                    cB_spieleliste.Items.Add(v);
                }
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Leert die Listbox bevor neue Einträge aus der Datenbank geholt werden
            lW_Highscore.Items.Clear();

            //Holen der Einträge aus der Datenbank
            //cB_spieleliste.Text



            //Eintragen der Datensätze in die Listbox
            lW_Highscore.Items.Add("Test Eintrag");

            MessageBox.Show("Daten wurden erfolgreich geladen!", "Information");
        }

        //Möglichkeit zum exportieren von  den Highscore Datensätzen
        private void btn_export_Click(object sender, EventArgs e)
        {
            if (lW_Highscore.Items.Count == 0)
            {
                MessageBox.Show("Bitte lade zuerst den aktuellen Highscore aus der Datenbank!", "Fehlermeldung");
            }
            else
            {
                //Öffnet Dateiexplorer zum Speichern dieser Datei
                SaveFileDialog sFD = new SaveFileDialog();

                sFD.Filter = "CSV-Datei (*.csv)|*.csv|TXT-Datei (*.txt)|*.txt";
                sFD.FilterIndex = 1;
                sFD.RestoreDirectory = true;

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
                            writer.WriteLine(item);
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
