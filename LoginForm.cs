using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiggybankApp
{
    public partial class LoginForm : Form
    {
        private string DatabaseConnection = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=piggybank;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = showPassword.Checked;
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location,
                Size = this.Size,
                WindowState = this.WindowState
            };

            registrationForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string studentId = schoolIDTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both School ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DatabaseConnection))
            {
                string query = "SELECT COUNT(*) FROM users WHERE student_id = @StudentId AND password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        PiggybankForm piggybankForm = new PiggybankForm
                        {
                            StartPosition = FormStartPosition.CenterParent,
                            Location = this.Location,
                            Size = this.Size,
                            WindowState = this.WindowState,
                            StudentId = studentId
                        };

                        piggybankForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid School ID or Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
