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
    public partial class agreemnts : Form
    {
        public agreemnts() ///CONSTRUCTOR
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //DONT AGREE
        {
            this.Hide();
            Form1 ab = new Form1();
            ab.ShowDialog();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            cuctomerchart ch = new cuctomerchart();
            ch.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
