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
    public partial class Form_Highscore : Form
    {
        public Form_Highscore()
        {
            InitializeComponent();
            string spiele = Properties.Settings.Default.spiele;
            String[] value = null;
            value = spiele.Split(';');
            foreach(string v in value)
            {
                if (v != "")
                {
                    cB_spieleliste.Items.Add(v);
                }
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Leert die Listbox bevor neue Einträge aus der Datenbank geholt werden
            lB_Highscore.Items.Clear();

            //Holen der Einträge aus der Datenbank



            //Eintragen der Datensätze in die Listbox
            lB_Highscore.Items.Add("");

            MessageBox.Show("Daten wurden erfolgreich geladen!", "Information");
        }

        //Möglichkeit zum exportieren von  den Highscore Datensätzen
        private void btn_export_Click(object sender, EventArgs e)
        {
            //Öffnet Dateiexplorer zum Speichern dieser Datei
            SaveFileDialog sFD = new SaveFileDialog();

            sFD.Filter = "CSV-Datei (*.csv)|*.csv|TXT-Datei (*.txt)|*.txt";
            sFD.FilterIndex = 1;
            sFD.RestoreDirectory = true;

            //Wenn auf Speichern geklickt wurde, wird die Datei geschrieben
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                //export_table(sFD.FileName + sFD.DefaultExt);
                MessageBox.Show("Daten wurden erfolgreich exportiert!", "Information");
            }
        }
    }
}
