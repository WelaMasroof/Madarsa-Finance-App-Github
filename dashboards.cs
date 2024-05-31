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
using static madarsa_aaplication.loginform;

namespace madarsa_aaplication
{
    public partial class dashboards : Form
    {
        private static string ConnectionString = loginform.ConnectionString;
        public dashboards()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void getincome()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    string Query = "SELECT SUM(ExpenseAmount) FROM Expenses";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
                        {
                            totalsalelabel.Text = dataTable.Rows[0][0].ToString();
                        }
                        else
                        {
                            totalsalelabel.Text = "0"; // Assuming you want to display "Rs 0" if no sales are found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getexpense()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    string Query = "SELECT SUM(IncomeAmount) FROM Income";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
                        {
                            totalexpenselabel.Text = dataTable.Rows[0][0].ToString();
                        }
                        else
                        {
                            totalexpenselabel.Text = "0"; // Assuming you want to display "Rs 0" if no sales are found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getprofit()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    // Query to get the total income amount
                    string incomeQuery = "SELECT SUM(IncomeAmount) FROM Income";
                    // Query to get the total expense amount
                    string expenseQuery = "SELECT SUM(ExpenseAmount) FROM Expenses";

                    decimal totalIncome = 0;
                    decimal totalExpenses = 0;

                    using (SqlCommand incomeCommand = new SqlCommand(incomeQuery, sqlConnection))
                    {
                        object incomeResult = incomeCommand.ExecuteScalar();
                        if (incomeResult != DBNull.Value && incomeResult != null)
                        {
                            totalIncome = Convert.ToDecimal(incomeResult);
                        }
                    }

                    using (SqlCommand expenseCommand = new SqlCommand(expenseQuery, sqlConnection))
                    {
                        object expenseResult = expenseCommand.ExecuteScalar();
                        if (expenseResult != DBNull.Value && expenseResult != null)
                        {
                            totalExpenses = Convert.ToDecimal(expenseResult);
                        }
                    }

                    // Calculate the net amount (total income - total expenses)
                    decimal netAmount = totalIncome - totalExpenses;

                    // Display the net amount in the label
                    lastprofitlabel.Text = "Rs " + netAmount.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dashboards_Load(object sender, EventArgs e)
        {
            getexpense();
            getincome();
            getprofit();
        }
    }
}
