using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class Course__Fee_Teacher_Salary : Form
    {
        public Course__Fee_Teacher_Salary()
        {
            InitializeComponent();
        }

        private void Course__Fee_Teacher_Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet4.money' table. You can move, or remove it, as needed.
            this.moneyTableAdapter.Fill(this.studentDataSet4.money);

        }

        private void money_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void money_button_Click(object sender, EventArgs e)
        {
            
        }

        private void money_textBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
