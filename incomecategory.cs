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
    public partial class incomecategory : Form
    {
        private string ConnectionString = loginform.ConnectionString;
        public incomecategory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void incomecategory_Load(object sender, EventArgs e)
        {
            comboboxshow();
        }

        private void addrecord_Click(object sender, EventArgs e)
        {
            string incomecategory = salescategorytextbox.Text;

            if (string.IsNullOrEmpty(incomecategory))
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
                        string query = "INSERT INTO IncomeCategory (CategoryName) VALUES (@incomecategory)";
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@incomecategory", incomecategory);
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
                    string Query = "delete from IncomeCategory where CategoryName=@ExpenseCategory";
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
        public void comboboxshow()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT CategoryName FROM IncomeCategory ";

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
