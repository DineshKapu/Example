using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello and welcome to Tasks....");
        }
        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader=new StreamReader("Example.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(50000);

            }
            return count;
        }
        //the below event works Synchronously
        private void btnClick_Click(object sender, EventArgs e)
        {
            int z = CountCharacters();
            textBox1.Text = "Processing File Counting Job,Please wait";
            textBox1.Text = z.ToString();
        } 
    }
}
