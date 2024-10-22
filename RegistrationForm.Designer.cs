namespace PiggybankApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            signupButton = new Button();
            passwordTextBox = new TextBox();
            schoolIDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            linkToLogin = new LinkLabel();
            showPassword = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1175, 927);
            label4.Name = "label4";
            label4.Size = new Size(274, 31);
            label4.TabIndex = 15;
            label4.Text = "Already have an account?";
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.FromArgb(255, 128, 255);
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signupButton.ForeColor = Color.White;
            signupButton.Location = new Point(1032, 661);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(200, 60);
            signupButton.TabIndex = 14;
            signupButton.Text = "SIGNUP";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(1032, 540);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(668, 46);
            passwordTextBox.TabIndex = 13;
            // 
            // schoolIDTextBox
            // 
            schoolIDTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            schoolIDTextBox.Location = new Point(1032, 388);
            schoolIDTextBox.Multiline = true;
            schoolIDTextBox.Name = "schoolIDTextBox";
            schoolIDTextBox.Size = new Size(668, 46);
            schoolIDTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1032, 487);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1032, 329);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 10;
            label2.Text = "School ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 983);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 128, 255);
            label5.Location = new Point(321, 464);
            label5.Name = "label5";
            label5.Size = new Size(253, 54);
            label5.TabIndex = 2;
            label5.Text = "PIGGYBANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1032, 179);
            label1.Name = "label1";
            label1.Size = new Size(223, 54);
            label1.TabIndex = 16;
            label1.Text = "Get Started";
            // 
            // linkToLogin
            // 
            linkToLogin.AutoSize = true;
            linkToLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkToLogin.LinkColor = Color.Gray;
            linkToLogin.Location = new Point(1455, 927);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(104, 28);
            linkToLogin.TabIndex = 17;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "Login here";
            linkToLogin.VisitedLinkColor = Color.Gray;
            linkToLogin.LinkClicked += linkToLogin_LinkClicked;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            showPassword.ForeColor = Color.Gray;
            showPassword.Location = new Point(1507, 615);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(193, 35);
            showPassword.TabIndex = 18;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 983);
            Controls.Add(showPassword);
            Controls.Add(linkToLogin);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(signupButton);
            Controls.Add(passwordTextBox);
            Controls.Add(schoolIDTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button signupButton;
        private TextBox passwordTextBox;
        private TextBox schoolIDTextBox;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private LinkLabel linkToLogin;
        private CheckBox showPassword;
    }
}