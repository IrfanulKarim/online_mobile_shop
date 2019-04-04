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
    public partial class guestpage : Form
    {
        public guestpage() //constructor
        {
            InitializeComponent();
        }

        private void gback(object sender, EventArgs e) //back
        {
            this.Hide();
            Form1 f;
            f = new Form1();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //combobox
        {
            if (comboBox1.Text == "APPLE")
            {
                this.Hide();
                applepage apl = new applepage();
                apl.ShowDialog();

            }
            if (comboBox1.Text == "SAMSUNG")
            {
                this.Hide();
                samsungpage smp = new samsungpage();
                smp.ShowDialog();

            }
            if (comboBox1.Text == "XIOMI")
            {
                this.Hide();
                XIOMI xip = new XIOMI();
                xip.ShowDialog();

            }
            if (comboBox1.Text == "OPPO")
            {
                this.Hide();
                oppo op = new oppo();
                op.ShowDialog();

            }
            if (comboBox1.Text == "HTC")
            {
                this.Hide();
                HTC htcp = new HTC();
                htcp.ShowDialog();

            }
        }

        private void comboclick(object sender, EventArgs e) //for option in combo
        {
            comboBox1.Items.Add("APPLE");
            comboBox1.Items.Add("SAMSUNG");
            comboBox1.Items.Add("XIOMI");
            comboBox1.Items.Add("OPPO");
            comboBox1.Items.Add("HTC");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
