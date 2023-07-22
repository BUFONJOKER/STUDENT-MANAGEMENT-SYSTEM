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
    public partial class View_Student_Data : Form
    {
        public View_Student_Data()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void View_Student_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.student_data' table. You can move, or remove it, as needed.
            this.student_dataTableAdapter.Fill(this.studentDataSet1.student_data);
            // TODO: This line of code loads data into the 'studentDataSet1.student_data' table. You can move, or remove it, as needed.
            this.student_dataTableAdapter.Fill(this.studentDataSet1.student_data);
            // TODO: This line of code loads data into the 'studentDataSet.student_data' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'studentDataSet.student_data' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'studentDataSet.student_data' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'studentDataSet.student_data' table. You can move, or remove it, as needed.


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
