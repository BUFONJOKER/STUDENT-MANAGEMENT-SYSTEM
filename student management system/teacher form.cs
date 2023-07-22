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
    public partial class teacher_form : Form
    {
        public teacher_form()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teacherName_textBox.Text))
            {
                MessageBox.Show("Enter student name");
            }

            else if (string.IsNullOrWhiteSpace(teacherContact_textBox.Text))
            {
                MessageBox.Show("Enter student contact no");
            }

            else if (string.IsNullOrWhiteSpace(teacherEmail_textBox.Text))
            {
                MessageBox.Show("Enter student email");
            }

            else if (string.IsNullOrWhiteSpace(teacherAddress_textBox.Text))
            {
                MessageBox.Show("Enter Student address");
            }

            else if (teacherMale_radioButton.Checked == false && teacherFemale_radioButton.Checked == false)
            {
                MessageBox.Show("Select gender");
            }

            else if (teacher_dateTimePicker.Value == null)
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

                sql = "insert into teacher_data  (Name,Contact_No,Email,Address,Gender,Date_Of_Birth,Course,Qualification,Salary)" +
                    " values(@Name,@Contact_No,@Email,@Address,@Gender,@Date_Of_Birth,@Course,@Qualification,@Salary)";
                command = new SqlCommand(sql, cnn);



                command.Parameters.AddWithValue("@Name", teacherName_textBox.Text);

                command.Parameters.AddWithValue("@Contact_No", teacherContact_textBox.Text);

                command.Parameters.AddWithValue("Email", teacherEmail_textBox.Text);

                command.Parameters.AddWithValue("@Address", teacherAddress_textBox.Text);

                if (teacherMale_radioButton.Checked == true)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else
                {
                    command.Parameters.AddWithValue("@Gender", "FeMale");
                }

                command.Parameters.AddWithValue("@Date_Of_Birth", teacher_dateTimePicker.Text);

                command.Parameters.AddWithValue("@Course", teacher_comboBox.Text);
                command.Parameters.AddWithValue("@Qualification", teacherQualificationtextBox.Text);
                command.Parameters.AddWithValue("@Salary", addTeacherSalary_textBox.Text);

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();


                command.Dispose();
                cnn.Close();
                MessageBox.Show("Teacher Data Added Successfully");
                teacher_comboBox.Text = "Select Course";
                teacherMale_radioButton.Checked = false;
                teacherFemale_radioButton.Checked = false;
                teacherContact_textBox.Clear();
                teacherAddress_textBox.Clear();
                teacherEmail_textBox.Clear();
                teacherName_textBox.Clear();
                teacherQualificationtextBox.Clear();
                addTeacherSalary_textBox.Clear();
            }
        }

        private void teacher_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.teacher_data' table. You can move, or remove it, as needed.
            this.teacher_dataTableAdapter.Fill(this.studentDataSet1.teacher_data);
            // TODO: This line of code loads data into the 'studentDataSet.teacher_data' table. You can move, or remove it, as needed.


        }

        private void deleteStudent_button_Click(object sender, EventArgs e)
        {
           
           

        }

        private void delTeacher_button_Click(object sender, EventArgs e)
        {
            string connection;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
            cnn = new SqlConnection(connection);
            cnn.Open();
            string teacher = deleteTeacher_comboBox.Text;

            sql = "delete teacher_data where Name = " + "'" + teacher +"'" + "";

            command = new SqlCommand(sql, cnn);
          
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Teacher Data Deleted Successfully");
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string teacher = updateTeacher_comboBox.Text;

            string connection;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            connection = "Data Source = Joker\\SQlEXPRESS;Initial Catalog = student;Integrated Security = True";
            cnn = new SqlConnection(connection);
            cnn.Open();

            if (updateTeacherContact_textBox.Text != "")
            {
                

                string contact = updateTeacherContact_textBox.Text;
       
                sql = "update teacher_data set Contact_No =" + "'" + contact + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
               
            }

            if (updateTeacherQualification_textBox.Text != "")
            {


                string qualification = updateTeacherQualification_textBox.Text;

                sql = "update teacher_data set Qualification =" + "'" +qualification + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();

            }
            if (updateTeacherEmail_textBox.Text != "")
            {
               
                string email = updateTeacherEmail_textBox.Text;
            
                sql = "update teacher_data set Email =" + "'" + email + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
               
            }

            if (updateTeacherAddress_textBox.Text != "")
            {
               

               
                string address = updateTeacherAddress_textBox.Text;
              
                sql = "update teacher_data set Address =" + "'" + address + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                
            }

            if (updateTeacherMale_radioButton.Checked == true)
            {
             


                sql = "update teacher_data set Gender = " + "'" + "Male" + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                
            }

            if (updateTeacherFeMale_radioButton.Checked == true)
            {
               

               

                sql = "update Teacher_data set Gender = " + "'" + "FeMale" + "'" + "where Name = " + "'" + teacher + "'" + "";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                
            }


            if (updateTeacherCourse_comboBox.Text != "Select Course")
            {
                string course = updateTeacherCourse_comboBox.Text;
                sql = "update teacher_data set Course = " + "'" + course + "'" + "where Name = " + "'" + teacher + "'" + "";

                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();


            }


            string date_of_birth = updateTeacher_dateTimePicker.Text;
            

            sql = "update teacher_data set Date_Of_Birth = " + "'" + date_of_birth + "'" + "where Name = " + "'" + teacher + "'" + "";
            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Teacher Data Updated Successfully");
            updateTeacherAddress_textBox.Clear();
            updateTeacherContact_textBox.Clear();
            updateTeacherFeMale_radioButton.Checked = false;
            updateTeacherFeMale_radioButton.Checked = false;
            updateTeacherQualification_textBox.Clear();
            updateTeacherSalary_textBox.Clear();
            updateTeacherCourse_comboBox.Text = "";
            updateTeacherEmail_textBox.Clear();
            updateTeacherCourse_comboBox.Text = "Select Course";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateTeacherCourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateTeacherCourse_comboBox.Text == "python")
            {
                updateTeacherSalary_textBox.Text = "50000";
            }

            else if (updateTeacherCourse_comboBox.Text == "javascript")
            {
                updateTeacherSalary_textBox.Text = "60000";
            }

            else if (updateTeacherCourse_comboBox.Text == "java")
            {
                updateTeacherSalary_textBox.Text = "70000";
            }

            else if (updateTeacherCourse_comboBox.Text == "c#")
            {
                updateTeacherSalary_textBox.Text = "80000";
            }
            updateTeacherSalary_textBox.ReadOnly = true;
        }

        private void teacher_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teacher_comboBox.Text == "python")
            {
                addTeacherSalary_textBox.Text = "50000";
            }

            else if (teacher_comboBox.Text == "javascript")
            {
                addTeacherSalary_textBox.Text = "60000";
            }

            else if (teacher_comboBox.Text == "java")
            {
                addTeacherSalary_textBox.Text = "70000";
            }

            else if (teacher_comboBox.Text == "c#")
            {
                addTeacherSalary_textBox.Text = "80000";
            }
            addTeacherSalary_textBox.ReadOnly = true;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}