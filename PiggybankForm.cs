using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiggybankApp
{
    public partial class PiggybankForm : Form
    {
        private decimal totalAmountValue = 0;
        public string? StudentId { get; set; }

        private string DatabaseConnection = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=piggybank;Trusted_Connection=True;";

        public PiggybankForm()
        {
            InitializeComponent();
            this.Load += PiggybankForm_Load;
        }

        private void PiggybankForm_Load(object? sender, EventArgs e)
        {
            studentIdLabel1.Text = $"Welcome, Student ID: {StudentId ?? "N/A"}";
        }

        private void MarkButtonText(Button targetButton)
        {
            targetButton.Text = targetButton.Text == "✓" ? "" : "✓";
        }

        private void fiveCentsBtn_Click(object sender, EventArgs e) => MarkButtonText(fiveCentsBtn);
        private void twentyFiveCentsBtn_Click1(object sender, EventArgs e) => MarkButtonText(twentyFiveCentsBtn);
        private void onePesoBtn_Click(object sender, EventArgs e) => MarkButtonText(onePesoBtn);
        private void fivePesoBtn_Click(object sender, EventArgs e) => MarkButtonText(fivePesoBtn);
        private void tenPesoBtn_Click(object sender, EventArgs e) => MarkButtonText(tenPesoBtn);
        private void twentyPesoBtn_Click(object sender, EventArgs e) => MarkButtonText(twentyPesoBtn);
        private void twentyBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(twentyBillsBtn);
        private void fiftyBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(fiftyBillsBtn);
        private void oneHundredBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(oneHundredBillsBtn);
        private void twoHundredBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(twoHundredBillsBtn);
        private void fiveHundredBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(fiveHundredBillsBtn);
        private void oneThousandBillsBtn_Click(object sender, EventArgs e) => MarkButtonText(oneThousandBillsBtn);

        private void ClearButtonTexts()
        {
            fiveCentsBtn.Text = "";
            twentyFiveCentsBtn.Text = "";
            onePesoBtn.Text = "";
            fivePesoBtn.Text = "";
            tenPesoBtn.Text = "";
            twentyPesoBtn.Text = "";
            twentyBillsBtn.Text = "";
            fiftyBillsBtn.Text = "";
            oneHundredBillsBtn.Text = "";
            twoHundredBillsBtn.Text = "";
            fiveHundredBillsBtn.Text = "";
            oneThousandBillsBtn.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (fiveCentsBtn.Text == "✓") totalAmountValue += 0.05m;
            if (twentyFiveCentsBtn.Text == "✓") totalAmountValue += 0.25m;
            if (onePesoBtn.Text == "✓") totalAmountValue += 1.00m;
            if (fivePesoBtn.Text == "✓") totalAmountValue += 5.00m;
            if (tenPesoBtn.Text == "✓") totalAmountValue += 10.00m;
            if (twentyPesoBtn.Text == "✓") totalAmountValue += 20.00m;
            if (twentyBillsBtn.Text == "✓") totalAmountValue += 20.00m;
            if (fiftyBillsBtn.Text == "✓") totalAmountValue += 50.00m;
            if (oneHundredBillsBtn.Text == "✓") totalAmountValue += 100.00m;
            if (twoHundredBillsBtn.Text == "✓") totalAmountValue += 200.00m;
            if (fiveHundredBillsBtn.Text == "✓") totalAmountValue += 500.00m;
            if (oneThousandBillsBtn.Text == "✓") totalAmountValue += 1000.00m;

            totalAmount.Text = $"Total Amount: {totalAmountValue:C}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (totalAmountValue <= 0)
            {
                MessageBox.Show("Please calculate a total amount before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DatabaseConnection))
            {
                string query = "INSERT INTO transactions (student_id, transaction_date, transaction_time, amount) " +
                               "VALUES (@StudentId, @TransactionDate, @TransactionTime, @Amount)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", StudentId);
                    command.Parameters.AddWithValue("@TransactionDate", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@TransactionTime", DateTime.Now.ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@Amount", totalAmountValue);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Money added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearButtonTexts();
                }
            }

            totalAmountValue = 0;
            totalAmount.Text = "Total Amount: 0.00";
        }


        private void totalAmount_Click(object sender, EventArgs e)
        {

        }

        private void gcashButton_Click(object sender, EventArgs e)
        {
            if (totalAmountValue <= 0)
            {
                MessageBox.Show("Please calculate a total amount before submitting to gcash", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Successfully sent to GCash: {totalAmountValue:C}", "GCash Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearButtonTexts();
        }

        private void logoutButton_Click(object sender, EventArgs e)
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



        private void transactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm
            {
                StudentId = this.StudentId,
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location,
                Size = this.Size,
                WindowState = this.WindowState
            };

            transactionForm.Show();
            this.Hide();
        }
    }
}
