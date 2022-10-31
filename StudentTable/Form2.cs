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
    public partial class Form2 : Form
    {
        List<Student> students;
        public Form2()
        {
            
            InitializeComponent();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = Owner as Form1;
            Text = "Список группы";
         
        }
    }
}
