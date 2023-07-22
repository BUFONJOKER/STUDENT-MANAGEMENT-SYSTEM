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
    public partial class userCredentials_Form : Form
    {
        public userCredentials_Form()
        {
            InitializeComponent();
        }

        private void logIn_button_Click(object sender, EventArgs e)
        {
            string user = userName_textBox.Text;
            string password = password_textBox.Text;
            if(String.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter user name and password");
            }
            else if(String.IsNullOrEmpty(password)) {
                MessageBox.Show("Enter user name and password");
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

                sql = "insert into user_id (email,password) values(@email,@password)";
                command = new SqlCommand(sql, cnn);



                command.Parameters.AddWithValue("@email", user);


                command.Parameters.AddWithValue("@password", password);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();


                command.Dispose();
                cnn.Close();

                welcome newForm = new welcome();
                newForm.Show();
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            password_textBox.UseSystemPasswordChar = true;
        }

        private void userCredentials_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
