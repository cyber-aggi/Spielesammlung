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
    public partial class Tik_Tak_Toe : Form
    {
        public int zähler = 1;
        public Tik_Tak_Toe()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            
            

            
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            



        }

        private void Tik_Tak_Toe_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "X" || button3.Text == "O")
            {

            }
            if(zähler == 1)
            {
                button3.Text = "X";
                zähler = 2;
            }
            else if(zähler == 2)
            {
                button3.Text = "O";
                zähler = 1;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button1.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button1.Text = "O";
                zähler = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button2.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button2.Text = "O";
                zähler = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button6.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button6.Text = "O";
                zähler = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button5.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button5.Text = "O";
                zähler = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button4.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button4.Text = "O";
                zähler = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {

            }
            if (zähler == 1)
            {
                button9.Text = "X";
                zähler = 2;
            }
            else if (zähler == 2)
            {
                button9.Text = "O";
                zähler = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" || button8.Text == "O")
            {


                if (zähler == 1)
                {
                    button8.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    button8.Text = "O";
                    zähler = 1;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" || button7.Text == "O")
            {

            
                if (zähler == 1)
                {
                    button7.Text = "X";
                    zähler = 2;
                }
                else if (zähler == 2)
                {
                    button7.Text = "O";
                    zähler = 1;
                }
            }
        }
    }
}
