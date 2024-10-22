namespace PiggybankApp
{
    partial class PiggybankForm
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
            groupBox1 = new GroupBox();
            twentyFiveCentsBtn = new Button();
            twentyPesoBtn = new Button();
            tenPesoBtn = new Button();
            fivePesoBtn = new Button();
            onePesoBtn = new Button();
            fiveCentsBtn = new Button();
            groupBox2 = new GroupBox();
            oneThousandBillsBtn = new Button();
            twoHundredBillsBtn = new Button();
            fiftyBillsBtn = new Button();
            fiveHundredBillsBtn = new Button();
            oneHundredBillsBtn = new Button();
            twentyBillsBtn = new Button();
            totalAmount = new Label();
            pictureBox7 = new PictureBox();
            addButton = new Button();
            gcashButton = new Button();
            logoutButton = new Button();
            studentIdLabel = new Label();
            studentIdLabel1 = new Label();
            transactionBtn = new Button();
            calculateButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(twentyFiveCentsBtn);
            groupBox1.Controls.Add(twentyPesoBtn);
            groupBox1.Controls.Add(tenPesoBtn);
            groupBox1.Controls.Add(fivePesoBtn);
            groupBox1.Controls.Add(onePesoBtn);
            groupBox1.Controls.Add(fiveCentsBtn);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "COIN";
            // 
            // twentyFiveCentsBtn
            // 
            twentyFiveCentsBtn.BackgroundImage = Properties.Resources._25_cents;
            twentyFiveCentsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            twentyFiveCentsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            twentyFiveCentsBtn.ForeColor = Color.Lime;
            twentyFiveCentsBtn.Location = new Point(183, 87);
            twentyFiveCentsBtn.Name = "twentyFiveCentsBtn";
            twentyFiveCentsBtn.Size = new Size(126, 105);
            twentyFiveCentsBtn.TabIndex = 11;
            twentyFiveCentsBtn.UseVisualStyleBackColor = true;
            twentyFiveCentsBtn.Click += twentyFiveCentsBtn_Click1;
            // 
            // twentyPesoBtn
            // 
            twentyPesoBtn.BackgroundImage = Properties.Resources._20_peso;
            twentyPesoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            twentyPesoBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            twentyPesoBtn.ForeColor = Color.Lime;
            twentyPesoBtn.Location = new Point(890, 25);
            twentyPesoBtn.Name = "twentyPesoBtn";
            twentyPesoBtn.Size = new Size(203, 167);
            twentyPesoBtn.TabIndex = 10;
            twentyPesoBtn.UseVisualStyleBackColor = true;
            twentyPesoBtn.Click += twentyPesoBtn_Click;
            // 
            // tenPesoBtn
            // 
            tenPesoBtn.BackgroundImage = Properties.Resources._10_peso;
            tenPesoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            tenPesoBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            tenPesoBtn.ForeColor = Color.Lime;
            tenPesoBtn.Location = new Point(702, 37);
            tenPesoBtn.Name = "tenPesoBtn";
            tenPesoBtn.Size = new Size(168, 155);
            tenPesoBtn.TabIndex = 9;
            tenPesoBtn.UseVisualStyleBackColor = true;
            tenPesoBtn.Click += tenPesoBtn_Click;
            // 
            // fivePesoBtn
            // 
            fivePesoBtn.BackgroundImage = Properties.Resources._5_peso;
            fivePesoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            fivePesoBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            fivePesoBtn.ForeColor = Color.Lime;
            fivePesoBtn.Location = new Point(516, 58);
            fivePesoBtn.Name = "fivePesoBtn";
            fivePesoBtn.Size = new Size(151, 134);
            fivePesoBtn.TabIndex = 8;
            fivePesoBtn.UseVisualStyleBackColor = true;
            fivePesoBtn.Click += fivePesoBtn_Click;
            // 
            // onePesoBtn
            // 
            onePesoBtn.BackgroundImage = Properties.Resources._1_peso;
            onePesoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            onePesoBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            onePesoBtn.ForeColor = Color.Lime;
            onePesoBtn.Location = new Point(339, 69);
            onePesoBtn.Name = "onePesoBtn";
            onePesoBtn.Size = new Size(148, 123);
            onePesoBtn.TabIndex = 7;
            onePesoBtn.UseVisualStyleBackColor = true;
            onePesoBtn.Click += onePesoBtn_Click;
            // 
            // fiveCentsBtn
            // 
            fiveCentsBtn.BackgroundImage = Properties.Resources._5_cents;
            fiveCentsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            fiveCentsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            fiveCentsBtn.ForeColor = Color.Lime;
            fiveCentsBtn.Location = new Point(36, 97);
            fiveCentsBtn.Name = "fiveCentsBtn";
            fiveCentsBtn.Size = new Size(120, 95);
            fiveCentsBtn.TabIndex = 0;
            fiveCentsBtn.UseVisualStyleBackColor = true;
            fiveCentsBtn.Click += fiveCentsBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(oneThousandBillsBtn);
            groupBox2.Controls.Add(twoHundredBillsBtn);
            groupBox2.Controls.Add(fiftyBillsBtn);
            groupBox2.Controls.Add(fiveHundredBillsBtn);
            groupBox2.Controls.Add(oneHundredBillsBtn);
            groupBox2.Controls.Add(twentyBillsBtn);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(32, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1110, 725);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BILLS";
            // 
            // oneThousandBillsBtn
            // 
            oneThousandBillsBtn.BackgroundImage = Properties.Resources._1000_papers;
            oneThousandBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            oneThousandBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            oneThousandBillsBtn.ForeColor = Color.Lime;
            oneThousandBillsBtn.Location = new Point(610, 521);
            oneThousandBillsBtn.Name = "oneThousandBillsBtn";
            oneThousandBillsBtn.Size = new Size(484, 198);
            oneThousandBillsBtn.TabIndex = 6;
            oneThousandBillsBtn.UseVisualStyleBackColor = true;
            oneThousandBillsBtn.Click += oneThousandBillsBtn_Click;
            // 
            // twoHundredBillsBtn
            // 
            twoHundredBillsBtn.BackgroundImage = Properties.Resources._200_papers;
            twoHundredBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            twoHundredBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            twoHundredBillsBtn.ForeColor = Color.Lime;
            twoHundredBillsBtn.Location = new Point(610, 308);
            twoHundredBillsBtn.Name = "twoHundredBillsBtn";
            twoHundredBillsBtn.Size = new Size(441, 179);
            twoHundredBillsBtn.TabIndex = 5;
            twoHundredBillsBtn.UseVisualStyleBackColor = true;
            twoHundredBillsBtn.Click += twoHundredBillsBtn_Click;
            // 
            // fiftyBillsBtn
            // 
            fiftyBillsBtn.BackgroundImage = Properties.Resources._50_papers;
            fiftyBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            fiftyBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            fiftyBillsBtn.ForeColor = Color.Lime;
            fiftyBillsBtn.Location = new Point(610, 84);
            fiftyBillsBtn.Name = "fiftyBillsBtn";
            fiftyBillsBtn.Size = new Size(390, 162);
            fiftyBillsBtn.TabIndex = 4;
            fiftyBillsBtn.UseVisualStyleBackColor = true;
            fiftyBillsBtn.Click += fiftyBillsBtn_Click;
            // 
            // fiveHundredBillsBtn
            // 
            fiveHundredBillsBtn.BackgroundImage = Properties.Resources._500_papers;
            fiveHundredBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            fiveHundredBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            fiveHundredBillsBtn.ForeColor = Color.Lime;
            fiveHundredBillsBtn.Location = new Point(16, 521);
            fiveHundredBillsBtn.Name = "fiveHundredBillsBtn";
            fiveHundredBillsBtn.Size = new Size(484, 198);
            fiveHundredBillsBtn.TabIndex = 3;
            fiveHundredBillsBtn.UseVisualStyleBackColor = true;
            fiveHundredBillsBtn.Click += fiveHundredBillsBtn_Click;
            // 
            // oneHundredBillsBtn
            // 
            oneHundredBillsBtn.BackgroundImage = Properties.Resources._100_papers;
            oneHundredBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            oneHundredBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            oneHundredBillsBtn.ForeColor = Color.Lime;
            oneHundredBillsBtn.Location = new Point(16, 308);
            oneHundredBillsBtn.Name = "oneHundredBillsBtn";
            oneHundredBillsBtn.Size = new Size(441, 179);
            oneHundredBillsBtn.TabIndex = 2;
            oneHundredBillsBtn.UseVisualStyleBackColor = true;
            oneHundredBillsBtn.Click += oneHundredBillsBtn_Click;
            // 
            // twentyBillsBtn
            // 
            twentyBillsBtn.BackgroundImage = Properties.Resources._20_papers;
            twentyBillsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            twentyBillsBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            twentyBillsBtn.ForeColor = Color.Lime;
            twentyBillsBtn.Location = new Point(16, 84);
            twentyBillsBtn.Name = "twentyBillsBtn";
            twentyBillsBtn.Size = new Size(390, 162);
            twentyBillsBtn.TabIndex = 1;
            twentyBillsBtn.UseVisualStyleBackColor = true;
            twentyBillsBtn.Click += twentyBillsBtn_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmount.ForeColor = Color.DeepPink;
            totalAmount.Location = new Point(1219, 159);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(205, 38);
            totalAmount.TabIndex = 2;
            totalAmount.Text = "Total Amount:";
            totalAmount.Click += totalAmount_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.piggylogo;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(1224, 256);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(502, 423);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(255, 128, 255);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(1224, 713);
            addButton.Name = "addButton";
            addButton.Size = new Size(200, 75);
            addButton.TabIndex = 8;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // gcashButton
            // 
            gcashButton.BackColor = Color.FromArgb(255, 128, 255);
            gcashButton.FlatStyle = FlatStyle.Flat;
            gcashButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            gcashButton.ForeColor = Color.White;
            gcashButton.Location = new Point(1526, 713);
            gcashButton.Name = "gcashButton";
            gcashButton.Size = new Size(200, 75);
            gcashButton.TabIndex = 9;
            gcashButton.Text = "SEND TO GCASH";
            gcashButton.UseVisualStyleBackColor = false;
            gcashButton.Click += gcashButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(255, 128, 255);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(1526, 808);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 75);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "LOGOUT";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentIdLabel.ForeColor = Color.DeepPink;
            studentIdLabel.Location = new Point(1219, 25);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(0, 38);
            studentIdLabel.TabIndex = 11;
            // 
            // studentIdLabel1
            // 
            studentIdLabel1.AutoSize = true;
            studentIdLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentIdLabel1.ForeColor = Color.DeepPink;
            studentIdLabel1.Location = new Point(1219, 25);
            studentIdLabel1.Name = "studentIdLabel1";
            studentIdLabel1.Size = new Size(138, 38);
            studentIdLabel1.TabIndex = 12;
            studentIdLabel1.Text = "Welcome";
            // 
            // transactionBtn
            // 
            transactionBtn.BackColor = Color.FromArgb(255, 128, 255);
            transactionBtn.FlatStyle = FlatStyle.Flat;
            transactionBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            transactionBtn.ForeColor = Color.White;
            transactionBtn.Location = new Point(1224, 83);
            transactionBtn.Name = "transactionBtn";
            transactionBtn.Size = new Size(502, 53);
            transactionBtn.TabIndex = 13;
            transactionBtn.Text = "VIEW TRANSACTION HISTORY";
            transactionBtn.UseVisualStyleBackColor = false;
            transactionBtn.Click += transactionBtn_Click;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(255, 128, 255);
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.White;
            calculateButton.Location = new Point(1224, 808);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(200, 75);
            calculateButton.TabIndex = 14;
            calculateButton.Text = "CALCULATE";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // PiggybankForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 983);
            Controls.Add(calculateButton);
            Controls.Add(transactionBtn);
            Controls.Add(studentIdLabel1);
            Controls.Add(studentIdLabel);
            Controls.Add(logoutButton);
            Controls.Add(gcashButton);
            Controls.Add(addButton);
            Controls.Add(pictureBox7);
            Controls.Add(totalAmount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PiggybankForm";
            Text = "PiggybankForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label totalAmount;
        private PictureBox pictureBox7;
        private Button addButton;
        private Button gcashButton;
        private Button logoutButton;
        private Button fiveCentsBtn;
        private Button twentyPesoBtn;
        private Button tenPesoBtn;
        private Button fivePesoBtn;
        private Button onePesoBtn;
        private Button oneThousandBillsBtn;
        private Button twoHundredBillsBtn;
        private Button fiftyBillsBtn;
        private Button fiveHundredBillsBtn;
        private Button oneHundredBillsBtn;
        private Button twentyBillsBtn;
        private Button twentyFiveCentsBtn;
        private Label studentIdLabel;
        private Label studentIdLabel1;
        private Button transactionBtn;
        private Button calculateButton;
    }
}