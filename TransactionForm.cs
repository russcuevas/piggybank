using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiggybankApp
{
    public partial class TransactionForm : Form
    {
        private string DatabaseConnection = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=piggybank;Trusted_Connection=True;";
        public string? StudentId { get; set; }

        public TransactionForm()
        {
            InitializeComponent();
            this.Load += TransactionForm_Load;
        }

        private void TransactionForm_Load(object? sender, EventArgs e)
        {
            studentIdLabel1.Text = $"Student ID: {StudentId ?? "N/A"}";
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConnection))
                {
                    string query = @"
            SELECT 
                t.transaction_id,
                t.transaction_date,
                t.transaction_time,
                t.amount
            FROM 
                transactions t
            LEFT JOIN 
                users u ON t.student_id = u.student_id
            WHERE 
                u.student_id = @StudentId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", StudentId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable transactionsTable = new DataTable();
                        adapter.Fill(transactionsTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();
                        dataGridView1.DataSource = transactionsTable;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.RowHeadersVisible = false;

                        dataGridView1.Columns[0].HeaderText = "Transaction ID";
                        dataGridView1.Columns[1].HeaderText = "Transaction Date";
                        dataGridView1.Columns[2].HeaderText = "Transaction Time";
                        dataGridView1.Columns[3].HeaderText = "Amount";

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }

                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DeepPink;
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
                        dataGridView1.EnableHeadersVisualStyles = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            PiggybankForm piggybankForm = new PiggybankForm
            {
                StudentId = this.StudentId,
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location,
                Size = this.Size,
                WindowState = this.WindowState
            };

            piggybankForm.Show();
            this.Hide();
        }
    }
}
