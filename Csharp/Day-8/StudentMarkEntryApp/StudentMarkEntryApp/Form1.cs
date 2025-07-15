using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkEntryApp.Model;

namespace StudentMarkEntryApp
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = int.Parse(textBox1.Text);
            student.StudentName = (textBox3.Text);
            student.StudentMarks = int.Parse(textBox2.Text);
            if(student!=null)
            {
                studentList.Add(student);
                MessageBox.Show("Record Added!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                Console.WriteLine("Not Valid Input");
            }
            foreach (var item in studentList)
            {
                Console.WriteLine(item.StudentName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(studentList);
            f2.Show();
        }
    }
}
