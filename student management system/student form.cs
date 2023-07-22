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
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabControl1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void addStudentData_label_Click(object sender, EventArgs e)
        {

        }

        private void studentPersonalDetails_label_Click(object sender, EventArgs e)
        {

        }

        private void studentEducationDetails_label_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void studentName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentContact_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studentAddress_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentAddress_label_Click(object sender, EventArgs e)
        {

        }

        private void studentEmail_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fees_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_label_Click(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(studentName_textBox.Text))
            {
                MessageBox.Show("Enter student name");
            }

            else if(string.IsNullOrWhiteSpace(studentContact_textBox.Text) )
            {
                MessageBox.Show("Enter student contact no");
            }

            else if (string.IsNullOrWhiteSpace(studentEmail_textBox.Text))
            {
                MessageBox.Show("Enter student email");
            }

            else if (string.IsNullOrWhiteSpace(studentAddress_textBox.Text))
            {
                MessageBox.Show("Enter Student address");
            }

            else if (male_radioButton.Checked == false && female_radioButton.Checked==false)
            {
                MessageBox.Show("Select gender");
            }

            else if(dateOfBirth_dateTimePicker.Value == null)
            {
                MessageBox.Show("Select date of birth");
            }
            else
            {
                string connection;
                SqlConnection cnn;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql;

                connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
                cnn = new SqlConnection(connection);
                cnn.Open();

                sql = "insert into student_data  (Name,Contact_No,Email,Address,Gender,Date_Of_Birth,Course,Fees)" +
                    " values(@Name,@Contact_No,@Email,@Address,@Gender,@Date_Of_Birth,@Course,@Fees)";
                command = new SqlCommand(sql, cnn);



                command.Parameters.AddWithValue("@Name", studentName_textBox.Text);

                command.Parameters.AddWithValue("@Contact_No", studentContact_textBox.Text);

                command.Parameters.AddWithValue("Email", studentEmail_textBox.Text);

                command.Parameters.AddWithValue("@Address", studentAddress_textBox.Text);

                if(male_radioButton.Checked == true)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if(female_radioButton.Checked == true)
                {
                    command.Parameters.AddWithValue("@Gender", "FeMale");
                }

                command.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth_dateTimePicker.Text);

                command.Parameters.AddWithValue("@Course", addStudent_comboBox.Text);
                
                command.Parameters.AddWithValue("@Fees", studentFees_textBox.Text);
                
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();


                command.Dispose();
                cnn.Close();
                MessageBox.Show("Student Data Added Successfully");
                studentName_textBox.Clear();
                studentContact_textBox.Clear();
                studentAddress_textBox.Clear();
                studentEmail_textBox.Clear();
                addStudent_comboBox.Text = "Select Course";
                studentFees_textBox.Clear();
                male_radioButton.Checked = false;
                female_radioButton.Checked = false;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string student = selectStudent_comboBox.Text;
            string connection;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
            cnn = new SqlConnection(connection);
            cnn.Open();

            if (updateStudentContactNo_textBox.Text != "")
            {
                
                
                string contact = updateStudentContactNo_textBox.Text;
            
                sql = "update student_data set Contact_No =" + "'" + contact + "'" + "where Name = " + "'" + student + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
               
            }
                
            if(updateStudentEmail_textBox.Text != "")
            {
                
                string email = updateStudentEmail_textBox.Text;
               
                sql = "update student_data set Email =" + "'" + email + "'" + "where Name = " + "'" + student + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
            }

            if(updateStudentAddress_textBox.Text != "")
            {
                
                string address = updateStudentAddress_textBox.Text;
                sql = "update student_data set Address =" + "'" + address + "'" + "where Name = " + "'" + student + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                
            }

            if(updateStudentMale_radioButton.Checked == true)
            {
                
               
               
                sql = "update student_data set Gender = " + "'" + "Male" + "'" + "where Name = " + "'" + student + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
               
            }

            if (updateStudentFeMale_radioButton.Checked == true)
            {
                

               
                sql = "update student_data set Gender = " + "'" + "FeMale" + "'" + "where Name = " + "'" + student + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
               
            }
            

            if (updateStudent_comboBox.Text!="Select Course")
            {
                string course = updateStudent_comboBox.Text;
                sql = "update student_data set " + "Course = " + "'" + course + "'" + "," +
           
                " Fees = " + "'" + updateStudentFees_textBox.Text + "'" +
                " where Name = " + "'" + student + "'" + "";

                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                

            }
                
            string date_of_birth = updateStudent_dateTimePicker.Text;
               
            sql = "update student_data set " +
                " Date_Of_Birth = " + "'" + date_of_birth + "'" +

                " where Name = " + "'" + student + "'" + "";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            
            
            MessageBox.Show("Student Data Updated Successfully");
            updateStudentContactNo_textBox.Clear();
            updateStudentAddress_textBox.Clear();
            updateStudentEmail_textBox.Clear();
            updateStudentFees_textBox.Clear();
            updateStudentFeMale_radioButton.Checked = false;
            updateStudentMale_radioButton.Checked = false;
            updateStudent_comboBox.Text = "Select Course";
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.student_data' table. You can move, or remove it, as needed.
            this.student_dataTableAdapter.Fill(this.studentDataSet1.student_data);

            // TODO: This line of code loads data into the 'schoolDataSet._class' table. You can move, or remove it, as needed.


        }

        private void deleteStudent_button_Click(object sender, EventArgs e)
        {
            string connection;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
            cnn = new SqlConnection(connection);
            cnn.Open();
            string student = deleteStudent_comboBox.Text;

            sql = "delete student_data where Name = " + "'"+student +"'"+ "";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Student Data Deleted Successfully");
        }

        private void addStudent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addStudent_comboBox.Text == "python")
            {
                studentFees_textBox.Text = "100000";
            }

            else if (addStudent_comboBox.Text == "javascript")
            {
                studentFees_textBox.Text = "200000";
            }

            else if (addStudent_comboBox.Text == "java")
            {
                studentFees_textBox.Text = "300000";
            }

            else if (addStudent_comboBox.Text == "c#")
            {
                studentFees_textBox.Text = "400000";
            }
            studentFees_textBox.ReadOnly = true;
        }

        private void updateStudent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateStudent_comboBox.Text == "python")
            {
                updateStudentFees_textBox.Text = "100000";
            }

            else if (updateStudent_comboBox.Text == "javascript")
            {
                updateStudentFees_textBox.Text = "200000";
            }

            else if (updateStudent_comboBox.Text == "java")
            {
                updateStudentFees_textBox.Text = "300000";
            }

            else if (updateStudent_comboBox.Text == "c#")
            {
                updateStudentFees_textBox.Text = "400000";
            }
            updateStudentFees_textBox.ReadOnly = true;

        }

        private void selectStudent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
