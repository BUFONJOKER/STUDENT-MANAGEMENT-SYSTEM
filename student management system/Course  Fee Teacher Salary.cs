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
            // TODO: This line of code loads data into the 'studentDataSet2.money' table. You can move, or remove it, as needed.
            this.moneyTableAdapter.Fill(this.studentDataSet2.money);
            string sql, connection;
            SqlConnection cnn;
            SqlDataReader reader;
            SqlCommand command;

            connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
            cnn = new SqlConnection(connection);
            cnn.Open();
            sql = "select * from money";
            command = new SqlCommand(sql, cnn);
            reader = command.ExecuteReader();
           
            string newline = Environment.NewLine;
            money_textBox.AppendText("Course" + "\t\t" + "Course Fee" + "\t" + "Teacher Salary"); 
            while (reader.Read())
            {

                money_textBox.AppendText(newline + (reader.GetString(0) + "\t\t" + reader.GetString(1) +
                    "\t\t" + reader.GetString(2)));

            }
            money_textBox.ReadOnly = true;
            reader.Close();
            command.Dispose();
            cnn.Close();


        }

        private void money_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void money_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
