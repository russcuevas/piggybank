namespace PiggybankApp
{
    partial class LoginForm
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
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            schoolIDTextBox = new TextBox();
            passwordTextBox = new TextBox();
            showPassword = new CheckBox();
            loginButton = new Button();
            label4 = new Label();
            linkToRegister = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 983);
            panel1.TabIndex = 0;
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
            label1.Location = new Point(1019, 183);
            label1.Name = "label1";
            label1.Size = new Size(289, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1034, 326);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 2;
            label2.Text = "School ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1034, 485);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // schoolIDTextBox
            // 
            schoolIDTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            schoolIDTextBox.Location = new Point(1034, 373);
            schoolIDTextBox.Multiline = true;
            schoolIDTextBox.Name = "schoolIDTextBox";
            schoolIDTextBox.Size = new Size(668, 46);
            schoolIDTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(1034, 537);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(668, 46);
            passwordTextBox.TabIndex = 5;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            showPassword.ForeColor = Color.Gray;
            showPassword.Location = new Point(1509, 605);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(193, 35);
            showPassword.TabIndex = 6;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 128, 255);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(1034, 662);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 60);
            loginButton.TabIndex = 7;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1172, 929);
            label4.Name = "label4";
            label4.Size = new Size(246, 31);
            label4.TabIndex = 8;
            label4.Text = "Dont have an account?";
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkToRegister.LinkColor = Color.Gray;
            linkToRegister.Location = new Point(1424, 929);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(125, 28);
            linkToRegister.TabIndex = 9;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Register here";
            linkToRegister.VisitedLinkColor = Color.Gray;
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 983);
            Controls.Add(linkToRegister);
            Controls.Add(label4);
            Controls.Add(loginButton);
            Controls.Add(showPassword);
            Controls.Add(passwordTextBox);
            Controls.Add(schoolIDTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox schoolIDTextBox;
        private TextBox passwordTextBox;
        private CheckBox showPassword;
        private Button loginButton;
        private Label label4;
        private LinkLabel linkToRegister;
        private Label label5;
    }
}