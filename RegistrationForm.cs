using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PiggybankApp
{
    public partial class RegistrationForm : Form
    {

        //Database Connection
        private string DatabaseConnection = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=piggybank;Trusted_Connection=True;";


        //Registration Form
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //Show Password Checker
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = showPassword.Checked;
        }


        //Navigate to Login Form
        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location,
                Size = this.Size,
                WindowState = this.WindowState
            };

            loginForm.Show();
            this.Close();
        }


        //Signup Button
        private void signupButton_Click(object sender, EventArgs e)
        {
            string studentId = schoolIDTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both School ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DatabaseConnection))
            {
                string checkQuery = "SELECT COUNT(*) FROM users WHERE student_id = @StudentId";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@StudentId", studentId);
                    connection.Open();

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This School ID is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(DatabaseConnection))
            {
                string insertQuery = "INSERT INTO users (student_id, password) VALUES (@StudentId, @Password)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registration successful! You can now login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        schoolIDTextBox.Clear();
                        passwordTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
