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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace madarsa_aaplication
{
    public partial class enterearning : Form
    {
        private static string ConnectionString = loginform.ConnectionString;
        public enterearning()
        {
            InitializeComponent();
        }

        private void enterearning_Load(object sender, EventArgs e)
        {
            loadcategory();
        }

        private void loadcategory()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT CategoryName FROM IncomeCategory";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                expensecombobox.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                sqlConnection.Close();
            }

        }

        private void addrecordbutton_Click(object sender, EventArgs e)
        {
            string earning = expensetextbox.Text;
            string category = expensecombobox.SelectedItem?.ToString();
            string amount = priceperunittextbox.Text;
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string description = descriptionbox.Text;

            if (string.IsNullOrEmpty(earning) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate amount and price inputs
            if (!decimal.TryParse(amount, out decimal parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO Income (IncomeName, IncomeType, IncomeDate, IncomeAmount, Description) " +
                                   "VALUES (@earning, @category, @date, @amount, @description)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@earning", earning);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@amount", parsedAmount);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.ExecuteNonQuery();
                    }

                    ClearData();
                    MessageBox.Show($"{category} Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ClearData()
        {
            expensetextbox.Text = "";
            descriptionbox.Text = "";
            priceperunittextbox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            expensecombobox.SelectedItem = null;
        }

        private void expensetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
