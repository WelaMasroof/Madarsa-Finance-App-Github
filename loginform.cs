
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madarsa_aaplication
{
    public partial class loginform : Form
    {
        public static string ConnectionString = "Data Source=WELA-MASROOF\\SQLEXPRESS;Initial Catalog=madarsa;Integrated Security=True;Encrypt=False";
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = USERNAMEBOX.Text;
            string password = PASSWORDBOX.Text;

            if (username == "admin" && password == "123")
            {
               
                main form1 = new main();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
