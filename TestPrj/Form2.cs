﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPrj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ss = new Form1();
            Form fc = Application.OpenForms["Form1"];
            if (fc == null)
            {
                ss.Show();
            }
            else
            ss.BringToFront();
        }
    }
}
