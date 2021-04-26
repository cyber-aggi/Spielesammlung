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
    public partial class VierGewinntForm : Form
    {

        private Color[,] bgColors = new Color[7, 6];

        public VierGewinntForm()
        {
            InitializeComponent();
            Colorfill();
        }

        private void Spalte1Button_Click(object sender, EventArgs e)
        {
            //column: 0 ,row: 1
            bgColors[0, 1] = Color.Red;
            VierGewinntTableLayoutPanel.Refresh();
        }

        private void Spalte2Button_Click(object sender, EventArgs e)
        {

        }

        private void Spalte3Button_Click(object sender, EventArgs e)
        {

        }

        private void Spalte4Button_Click(object sender, EventArgs e)
        {

        }

        private void Spalte5Button_Click(object sender, EventArgs e)
        {

        }

        private void Spalte6Button_Click(object sender, EventArgs e)
        {

        }

        private void Spalte7Button_Click(object sender, EventArgs e)
        {

        }

        private void VierGewinntTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Column, e.Row]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        private void Colorfill()
        {
            //Tiefe füllen mit dem SystemColors.Control
            for(int depth = 0; depth < bgColors.GetLength(0); depth++)
            {
                //Breite füllen mit dem SystemColors.Control
                for (int width = 0; width < bgColors.GetLength(1); width++)
                {
                    bgColors[depth, width] = SystemColors.Control;
                }
            }
        }

    }
}
