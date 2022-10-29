using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        public Student[] students = new Student[20];

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            students[i] = new Student
            {
                Surname = textBox1.Text,
                Name = textBox2.Text,
                SName = textBox3.Text,
                BDateD = dateTimePicker1.Value.Day,
                BDateM = dateTimePicker1.Value.Month,
                BDateY = dateTimePicker1.Value.Year,
                Gender = comboBox1.Text,
                S_number = Convert.ToInt16(textBox4.Text),
                L_base = comboBox2.Text,
                Note = textBox6.Text,
                Debts = Convert.ToInt16(textBox5.Text),
            };
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
