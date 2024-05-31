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
    public partial class SalesCategory : Form
    {
        private string ConnectionString = loginform.ConnectionString;
        public SalesCategory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void addrecord_Click(object sender, EventArgs e)
        {

            string expensecategory = salescategorytextbox.Text;

            if (string.IsNullOrEmpty(expensecategory))
            {
                MessageBox.Show("Please fill in the category TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        sqlConnection.Open();
                        string query = "INSERT INTO expenseCategory (CategoryName) VALUES (@expensecategory)";
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@expensecategory", expensecategory);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Category Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearData()
        {
            salescategorytextbox.Text = null;
            comboBox1.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ExpenseCategory = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(ExpenseCategory))
            {
                MessageBox.Show("Please select a category to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
                {
                    sqlconnection.Open();
                    string Query = "delete from expensecategory where CategoryName=@ExpenseCategory";
                    SqlCommand cmd = new SqlCommand(Query, sqlconnection);
                    cmd.Parameters.AddWithValue("@ExpenseCategory", ExpenseCategory);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalesCategory_Load(object sender, EventArgs e)
        {
            comboboxshow();
        }
        public void comboboxshow()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT CategoryName FROM expenseCategory ";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                comboBox1.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                sqlConnection.Close();
            }

        }
    }
}
