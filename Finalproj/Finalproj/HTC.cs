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
    public partial class HTC : Form
    {
        DataGridViewRow row;
        public HTC() //constructor
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata()
        {

            DataClasses1DataContext htcd = new DataClasses1DataContext();
            var getdata = (from x in htcd.users
                           where x.BRAND == "HTC"
                           select x);
            dataGridView1.DataSource = getdata;
            dataGridView1.RowTemplate.Height = 50;
        }
         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //girdview
        {
            row = this.dataGridView1.Rows[e.RowIndex];
        }

        private void backclick(object sender, EventArgs e) //back
        {

            this.Hide();
            guestpage gpage;
            gpage = new guestpage();
            gpage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //buy
        {
            DataClasses1DataContext samcon = new DataClasses1DataContext();
            var getdata = (from x in samcon.users
                           where x.NO == Convert.ToInt32(row.Cells["NO"].Value)
                           select x).First();
            /*getdata.PRICE = Convert.ToInt32(textBox5.Text);
            getdata.QUANTITY = Convert.ToInt32(textBox6.Text);*/


            try
            {
                samcon.SubmitChanges();
                MessageBox.Show("WELCOME TO OUR ONLINE SHOP");

                this.Hide();
                agreemnts agr = new agreemnts();


                agr.ShowDialog();
            }
            catch
            {
                MessageBox.Show("NO UPDATE");
            }
        }

        private void HTC_Load(object sender, EventArgs e)
        {

        }
    }
}
