using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jeevitha7library;
//****************************************************************
  //  Author: JEEVITHA
    //Purpose: windows application
//*****************************************************************

namespace MyWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            int Factorial = Mathematics1.Factorial(input);
            textBox2.Text = Factorial.ToString();
        }
    }
}
