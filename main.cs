
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel.Controls.Add(f);
            this.panel.Tag = f;
            f.Show();

        }

        private void uhshsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new dashboards());
        }

        private void خرچہToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new enterexpense() );
        }

        private void آمدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new enterearning());
        }

        private void آمدنتفصیلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new salesview());
        }

        private void اخراجاتتفصیلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new show_expense());
        }

        private void مدعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new SalesCategory());
        }

        private void خرچمداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new incomecategory());
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
