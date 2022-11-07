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
        string gender;  // Пол
        int s_number;  // № студенческого билета
        string l_base;  // основа обучения
        int? debts;  // количество задолженностей
        string note;  // примечание
        DateTime bDate;
        public string Surname
        {
            get { return surname; }
            set 
            {
                surname = value; 
            }
        }// Фамилия
    
        public string Name
        {
            get { return name; }
            set
            {
               
              name = value;
            }
        }    
            // Имя
        public string SName
        {
            get { return sName; }
            set
            {
             sName = value;
            }
        }// Отчество
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
              s_number = value;
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
        public string Note
        {
            get { return note; }
            set { note = value; }
        }// примечание
    }
}

