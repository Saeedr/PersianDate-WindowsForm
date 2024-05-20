using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FreeControls;

namespace TestPrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//            persianDateTimePicker2.Value = (PersianDate)DateTime.Now;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persianDateTimePicker3 .Value = FreeControls.PersianDate.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (persianDateTimePicker2.Visible)
            persianDateTimePicker2.Visible = false;
            else
                persianDateTimePicker2.Visible = true;
        }

    }
}
