﻿using System;
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
    public partial class Form1 : Form
    {
        private Form2 Childform;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            Childform = new Form2();
            Childform.Show();
        }
    }
}
