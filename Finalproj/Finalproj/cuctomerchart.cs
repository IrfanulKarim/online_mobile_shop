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
    public partial class cuctomerchart : Form
    {
        public cuctomerchart()  //constructor
        {
            InitializeComponent();
        }
       

        private void cuctomerchart_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)  ///CONFIRM
        {
            cust newCust = new cust();
            newCust.FULL_NAME = textBox1.Text;
            newCust.ADDRESS = textBox2.Text;
            newCust.PHONE_NO = textBox3.Text;
            newCust.MAIL = textBox4.Text;
            newCust.BLOOD_GROUP = textBox5.Text;

            DataClasses1DataContext custdb = new DataClasses1DataContext();
            custdb.custs.InsertOnSubmit(newCust);
            try
            {
                custdb.SubmitChanges();
                MessageBox.Show("ok");
                this.Hide();
                Form1 fr = new Form1();
                fr.ShowDialog();

               // Loaddata();

            }
            catch
            {
                MessageBox.Show("inception");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
