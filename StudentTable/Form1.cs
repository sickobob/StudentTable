using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTable
{
    public partial class Form1 : Form
    {
        static List<int> tabNums = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        public List<Student> Students = new List<Student>();
        Form2 frm2;

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
           if(CheckInitials(textBox1,textBox2,textBox3) && CheckComboBoxes(comboBox1, comboBox2) && CheckDate(dateTimePicker1) && CheckTabNum(textBox4)&&CheckDebts(textBox5))
            {
                if (tabNums.Contains(int.Parse(textBox4.Text))) MessageBox.Show("Табельный номер уже есть в базе");
                else
                {
                    Student student = new();


                    student.Surname = textBox1.Text;
                    student.Name = textBox2.Text;
                    student.SName = textBox3.Text;
                    student.BDate = dateTimePicker1.Value.Date;
                    student.Gender = comboBox1.Text;
                    student.S_number = Convert.ToInt16(textBox4.Text);
                    student.L_base = comboBox2.Text;
                    student.Note = textBox6.Text;
                    student.Debts = Convert.ToInt16(textBox5.Text);

                    Students.Add(student);
                    label10.Text = $"Количество записей: {Students.Count}";
                    tabNums.Add(int.Parse(textBox4.Text));
                }
              
            }
        }
        
        /// <summary>
        /// Проверяет правильность заполнения полей с инициалами
        /// </summary>
        /// <param name="textBox1"></param>
        /// <param name="textBox2"></param>
        /// <param name="textBox3"></param>
        /// <returns></returns>
        bool CheckInitials(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || (!Regex.IsMatch(textBox1.Text, @"^[a-zA-Zа-яА-Я]+$")) || String.IsNullOrEmpty(textBox2.Text) || (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Zа-яА-Я]+$")) || String.IsNullOrEmpty(textBox3.Text) || (!Regex.IsMatch(textBox3.Text, @"^[a-zA-Zа-яА-Я]+$")))
            {
                return false;
            }
            else return true;

        }
        /// <summary>
        /// проверка табельногго номера 
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        bool CheckDebts(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out int b))
            {
                MessageBox.Show("Введите корректное число долгов");
                return false;
            }
            else return true;
        }
        /// <summary>
        /// Проверяет правильность заполнения полей с выбором ответа
        /// </summary>
        /// <param name="comboBox1"></param>
        /// <param name="comboBox2"></param>
        /// <returns></returns>
        bool CheckComboBoxes(ComboBox comboBox1,ComboBox comboBox2)
        {
            if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox2.Text)) return false;
            else return true;
        }
        /// <summary>
        /// проверяет дату и сравнивает с текущей
        /// </summary>
        /// <param name="dateTimePicker"></param>
        /// <returns></returns>
        bool CheckDate(DateTimePicker dateTimePicker)
        {
            if(dateTimePicker.Value.Date == DateTime.Now.Date) return false;
            else return true;
        }
        /// <summary>
        /// проверяет табельный номер на корректность и уникальность
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        bool CheckTabNum(TextBox textBox) 
        {
            if (String.IsNullOrEmpty(textBox.Text) || !Regex.IsMatch(textBox.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Введите корректный табельный номер");
                return false;
            }
            else
          return true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Терешкин Алексей Александрович ЭПБ-211";
            frm2 = new Form2();
            frm2.Owner = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.dataGridView1.DataSource = Students;
            frm2.dataGridView1.Columns[0].HeaderText = "ФИО";

            frm2.ShowDialog();
            
        }
    }
}
