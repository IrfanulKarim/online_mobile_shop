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
    public partial class applepage : Form
    {

        DataGridViewRow row;
        public applepage()
        {
            InitializeComponent();
            loadappl();
        }

        private void loadappl()
        {
            DataClasses1DataContext aplcon = new DataClasses1DataContext();
            var getdata = (from x in aplcon.users
                           where x.BRAND == "APPLE"
                           select x);
            dataGridView1.DataSource = getdata; dataGridView1.RowTemplate.Height = 40;
        }
        private void applepage_Load(object sender, EventArgs e)
        {

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = this.dataGridView1.Rows[e.RowIndex];
        }

        private void backclick(object sender, EventArgs e)
        {
            this.Hide();
            guestpage gpage;
            gpage = new guestpage();
            gpage.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext appcon = new DataClasses1DataContext();
            var getdata = (from x in appcon.users
                           where x.NO == Convert.ToInt32(row.Cells["NO"].Value)
                           select x).First();
            /*getdata.PRICE = Convert.ToInt32(textBox5.Text);
            getdata.QUANTITY = Convert.ToInt32(textBox6.Text);*/


            try
            {
                appcon.SubmitChanges();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
