﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static madarsa_aaplication.loginform;
using System.Windows.Forms;

namespace madarsa_aaplication
{
    public partial class show_expense : Form
    {
        private string ConnectionString = loginform.ConnectionString;
        public show_expense()
        {
            InitializeComponent();
        }

        private void show_expense_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DateTime startDate;
            DateTime endDate;

            // Parse the dates from text boxes and validate
            if (!DateTime.TryParse(fromdate.Text, out startDate) || !DateTime.TryParse(todate.Text, out endDate))
            {
                MessageBox.Show("Invalid date format. Please enter valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if start date is after end date
            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if end date is greater than today's date
            if (endDate > DateTime.Now.Date)
            {
                MessageBox.Show("End date cannot be greater than today's date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT ExpenseName, ExpenseType, ExpenseDate, ExpenseAmount, Description FROM Expenses WHERE (@Category IS NULL OR ExpenseType = @Category) AND [ExpenseDate] BETWEEN @StartDate AND @EndDate";
                SqlCommand command = new SqlCommand(query, connection);

                // Add category parameter only if a category is selected
                if (!string.IsNullOrEmpty(salescombobox.Text))
                {
                    command.Parameters.AddWithValue("@Category", salescombobox.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@Category", DBNull.Value);
                }

                // Set parameter values for the date range
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            salesrecord.DataSource = dataTable;
        }
        private void LoadDataIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT distinct ExpenseType FROM Expenses"; // Modify query according to your database structure
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        salescombobox.Items.Add(reader["ExpenseType"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data into the ComboBox: " + ex.Message);
            }
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT ExpenseName, ExpenseType, ExpenseDate, ExpenseAmount, Description FROM Expenses";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            salesrecord.DataSource = dataTable;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete selected rows from the database and DataGridView
                foreach (DataGridViewRow row in salesrecord.SelectedRows)
                {
                    string sales = Convert.ToString(row.Cells["ExpenseName"].Value);
                    string Category = Convert.ToString(row.Cells["ExpenseType"].Value);
                    string Description = Convert.ToString(row.Cells["Description"].Value);
                    int Amount = Convert.ToInt32(row.Cells["ExpenseAmount"].Value);

                    // Delete row from database
                    DeleteRowFromDatabase(sales, Category, Amount, Description);

                    // Remove row from DataGridView
                    salesrecord.Rows.Remove(row);
                }

                MessageBox.Show("Selected row(s) deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRowFromDatabase(string sales, string Category, int Amount, string Description)
        {
            // Delete row from database based on the given Idsss
            string query = "DELETE FROM Expenses WHERE ExpenseName = @sales and ExpenseType = @Category and ExpenseAmount=@Amount and Description=@Description";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sales", sales);
                command.Parameters.AddWithValue("@Category", Category);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@Description", Description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
