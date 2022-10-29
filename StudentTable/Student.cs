using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTable
{
    public class Student
    {
        string surname;  // Фамилия
        string name;  // Имя
        string sName;  // Отчество
        int bDateD;  // Число ДР
        int bDateM;  //  Месяц ДР
        int bDateY;  // Год ДР
        string gender;  // Пол
        int s_number;  // № студенческого билета
        string l_base;  // основа обучения
        int? debts;  // количество задолженностей
        int note;  // примечание
        DateTime bDate;
        public bool IsFull { get; set; }
        public string Surname
        {
            get { return surname; }
            set 
            {
                if ((value == String.Empty) || (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$")))
                {
                    MessageBox.Show("Введите корректное имя");
                }
              else surname = value; 
            }
        }// Фамилия
    
        public string Name
        {
            get { return name; }
            set
            {
                if ((value == String.Empty) || (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$")))
                {
                    MessageBox.Show("Введите корректную фамилию");
                }
                else name = value;
            }
        }    
            // Имя
        public string SName
        {
            get { return sName; }
            set
            {
                if ((value == String.Empty) || (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$")))
                {
                    MessageBox.Show("Введите корректное отчество");
                }
                else sName = value;
            }
        }// Отчество
        public int BDateD;  // Число ДР
        public int BDateM;  //  Месяц ДР
        public int BDateY;  // Год ДР
       public DateTime BDate
        {
            get { return bDate; }
            set { bDate = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }// Пол
        public int S_number
        {
              get { return s_number; }
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^[0-9]+$"))
                {
                    MessageBox.Show("Введите корректный табельный номер");
                }
                else s_number = value;
            }
        }
        // № студенческого билета
        public string L_base
        {
            get { return l_base; }
            set
            {
                l_base = value;
            }
        }// основа обучения
        public int? Debts
        {
            get { return debts; }
            set
            {
                debts = value;
            }
        }// количество задолженностей
        public int Note
        {
            get { return note; }
            set { note = value; }
        }// примечание
    }
}

