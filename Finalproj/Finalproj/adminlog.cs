using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproj
{
    public partial class adminlog : Form
    {
        public adminlog()
        {
            InitializeComponent();
        }

        private void aback(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f;
            f = new Form1();
            f.ShowDialog();
        }

        private void loginclick(object sender, EventArgs e)
        {
            //textBox1.Text == "ADMIN" || textBox2.Text == "mobile"
            if (true)
            {
                this.Hide();
                adminwrk aw;
                aw = new adminwrk();
                aw.ShowDialog();
            }
            else {
                MessageBox.Show("WRONG PASS or NAME");
            }
        }
    }
}
