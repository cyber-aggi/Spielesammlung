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
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Leert die Listbox bevor neue Einträge aus der Datenbank geholt werden
            lB_Highscore.Items.Clear();

            //Holen der Einträge aus der Datenbank



            //Eintragen der Datensätze in die Listbox
            lB_Highscore.Items.Add("");

        }
    }
}
