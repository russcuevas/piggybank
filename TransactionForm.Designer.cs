namespace PiggybankApp
{
    partial class TransactionForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            goBackBtn = new Button();
            studentIdLabel1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(456, 62);
            label1.TabIndex = 13;
            label1.Text = "Transaction History";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1504, 623);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // goBackBtn
            // 
            goBackBtn.BackColor = Color.FromArgb(255, 128, 255);
            goBackBtn.FlatStyle = FlatStyle.Flat;
            goBackBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            goBackBtn.ForeColor = Color.White;
            goBackBtn.Location = new Point(1062, 798);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(502, 53);
            goBackBtn.TabIndex = 15;
            goBackBtn.Text = "GO BACK";
            goBackBtn.UseVisualStyleBackColor = false;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // studentIdLabel1
            // 
            studentIdLabel1.AutoSize = true;
            studentIdLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentIdLabel1.ForeColor = Color.DeepPink;
            studentIdLabel1.Location = new Point(60, 99);
            studentIdLabel1.Name = "studentIdLabel1";
            studentIdLabel1.Size = new Size(138, 38);
            studentIdLabel1.TabIndex = 16;
            studentIdLabel1.Text = "Welcome";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 878);
            Controls.Add(studentIdLabel1);
            Controls.Add(goBackBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button goBackBtn;
        private Label studentIdLabel1;
    }
}