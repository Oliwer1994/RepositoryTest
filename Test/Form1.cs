﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            lbText.Text = "Hello World";
            MessageBox.Show("sfds");
            //Dodany nowy obiekt
            A nowaKlasaA = new A();
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
