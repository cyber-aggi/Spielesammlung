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
        private bool[,] TLPcolor = new bool[7, 6];
        //False entspricht Spieler 1
        //true entspricht Spieler 2
        private bool spieler_bool = false;


        public VierGewinntForm()
        {
            InitializeComponent();
            Colorfill();
            spieler_start();
        }

        private void Spalte1Button_Click(object sender, EventArgs e)
        {
            //column: 0 ,row: 1
            DrawBlock(0);
        }

        private void Spalte2Button_Click(object sender, EventArgs e)
        {
            //column: 1 ,row: 1
            DrawBlock(1);
        }

        private void Spalte3Button_Click(object sender, EventArgs e)
        {
            //column: 2 ,row: 1
            DrawBlock(2);
        }

        private void Spalte4Button_Click(object sender, EventArgs e)
        {
            //column: 3 ,row: 1
            DrawBlock(3);
        }

        private void Spalte5Button_Click(object sender, EventArgs e)
        {
            //column: 4 ,row: 1
            DrawBlock(4);
        }

        private void Spalte6Button_Click(object sender, EventArgs e)
        {
            //column: 5 ,row: 1
            DrawBlock(5);
        }

        private void Spalte7Button_Click(object sender, EventArgs e)
        {
            //column: 6 ,row: 1
            DrawBlock(6);
        }

        private void VierGewinntTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //Füllt die Rechtecke aus.
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

            //Füllt das Boolean Feld
            for (int i = 0; i < TLPcolor.GetLength(0); i++)
            {
                for(int j = 0; j < TLPcolor.GetLength(1); j++)
                {
                    TLPcolor[i, j] = false;
                }
            }
        }

        private int Endstop_for_block(int col)
        {
            //Schaut in der Spalte von unten nach oben nach ob ein Block schon gesetzt wurde
            for(int row = TLPcolor.GetLength(0)-2; row > 0; row--)
            {              
                //gibt die unterste stelle aus der spalte zurück an der sich noch kein Block befindet
                if (TLPcolor[col, row] == false)
                    {
                    //setzt im array den wert auf true, dass dort nun ein Block ist
                        TLPcolor[col, row] = true;
                        return row; 
                    }
            }
            return 0;            
        }

        public void DrawBlock(int col)
        {

            /*Noch zu machen:
             * 2 Spieler hinzufügen
             * Abschwechseln zwischen Rot und Gelb
             * Überprüfung welcher Spieler dran ist
             */
            //setzt für die Blöcke die Farbe Rot
            //Wenn Spieler 1 dann Rot
            if (spieler_bool == false)
            {
                bgColors[col, Endstop_for_block(col)] = Color.Red;
                Spielerwechsel();
                VierGewinntTableLayoutPanel.Refresh();
                return;
            }
            //Wenn Spieler 2 dann Gelb
            if (spieler_bool == true)
            {
                bgColors[col, Endstop_for_block(col)] = Color.Yellow;
                Spielerwechsel();
                VierGewinntTableLayoutPanel.Refresh();
                return;
            }
            //Lädt das Grid neu
            
        }

        private void Spielerwechsel()
        {
            if (spieler_bool == false)
            {
                AnzeigeLabel.Text = "Es ist dran: Spieler 2";
                spieler_bool = true;
                return;
            }

            if (spieler_bool == true)
            {
                AnzeigeLabel.Text = "Es ist dran: Spieler 1";
                spieler_bool = false;
                return;
            }
        }

        private int random_start(int i)
        {
            var rand = new Random();
            return rand.Next(i);
        }

        private void spieler_start()
        {
            if (random_start(101)%2 == 0)
            {
                Spielerwechsel();
            }

        }
    }
}
