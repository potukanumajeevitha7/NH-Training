﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Power_B_Desktop_for_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(textBox1.Text);
            int sn = Convert.ToInt32(textBox2.Text);
            int power = Convert.ToInt32(Math.Pow(fn, sn));

            textBox3.Text = power.ToString();

        }
    }
}
