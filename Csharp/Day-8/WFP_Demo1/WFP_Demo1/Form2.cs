﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP_Demo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = num1 + num2;
            label3.Text = num3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = num1 - num2;
            label3.Text = num3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = num1 * num2;
            label3.Text = num3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = num1 / num2;
            label3.Text = num3.ToString();
        }
    }
}
