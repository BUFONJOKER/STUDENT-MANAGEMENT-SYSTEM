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
    public partial class View_Teacher_Data : Form
    {
        public View_Teacher_Data()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Teacher_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.teacher_data' table. You can move, or remove it, as needed.
            this.teacher_dataTableAdapter.Fill(this.studentDataSet.teacher_data);
            // TODO: This line of code loads data into the 'studentDataSet.student_data' table. You can move, or remove it, as needed.


        }
    }
}
