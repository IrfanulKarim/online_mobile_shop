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
    public partial class samsungpage : Form
    {
        DataGridViewRow row;
        public samsungpage() //load
        {
            
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata()
        {

            DataClasses1DataContext dtsam = new DataClasses1DataContext();
            var getdata = (from x in dtsam.users
                           where x.BRAND == "SAMSUNG"
                           select x );
            dataGridView1.DataSource = getdata;
        }
        private void samsungpage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //gridview
            row = this.dataGridView1.Rows[e.RowIndex];
            
        }

        private void button1_Click(object sender, EventArgs e) //back
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
