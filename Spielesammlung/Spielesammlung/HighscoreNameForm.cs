//Name: Paul Rosenberg
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
    public partial class HighscoreNameForm : Form
    {
        //Übergabe des Spielers für den ein richtiger Name angegeben werden soll
        public HighscoreNameForm(string gewinner)
        {
            InitializeComponent();
            //Erstellt einen Infotext für den Anwender
            label_Infotext.Text = "Bitte gebe einen Namen für " + gewinner + " an.\nWenn du auf den Button bestätigen klickst, wird unter diesem Namen der Highscore eingetragen.\nMit Abbrechen wird kein Highscoreeintrag vorgenommen.";
            label_Name.Text = gewinner;
        }
    }
}
