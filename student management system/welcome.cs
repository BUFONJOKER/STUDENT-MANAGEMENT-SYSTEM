using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void student_button_Click(object sender, EventArgs e)
        {
            student_form student = new student_form();
            student.Show();
        }

        private void teacher_button_Click(object sender, EventArgs e)
        {
            teacher_form teacher = new teacher_form();
            teacher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Student_Data student_data_form = new View_Student_Data();
            student_data_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Teacher_Data teacher_data_form = new View_Teacher_Data();
            teacher_data_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Course__Fee_Teacher_Salary money = new Course__Fee_Teacher_Salary();
            money.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
