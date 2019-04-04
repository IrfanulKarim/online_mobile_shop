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
    public partial class orders : Form
    {
        DataGridViewRow row;
        public orders()
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata() //linq
        {

            DataClasses1DataContext custor = new DataClasses1DataContext();
            var getdata = (from x in custor.custs
                           
                           select x);
            dataGridView1.DataSource = getdata;
        }

        private void button3_Click(object sender, EventArgs e) //back
        {
            this.Hide();
            adminwrk adw = new adminwrk();
            adw.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //gridview
            row = this.dataGridView1.Rows[e.RowIndex];
        }

        private void button1_Click(object sender, EventArgs e) //shipping
        {
            MessageBox.Show("Shipping ON");
        }

        private void button2_Click(object sender, EventArgs e) //reject
        {
            DataClasses1DataContext dataContx = new DataClasses1DataContext();
            var getdata = (from x in dataContx.custs
                           where x.Serial == Convert.ToInt32(row.Cells["Serial"].Value)
                           select x
                ).ToList().Last();
            dataContx.custs.DeleteOnSubmit(getdata);
            try
            {
                dataContx.SubmitChanges();
                MessageBox.Show("DELETE THIS");
                Loaddata();
                
            }
            catch
            {
            }
        }

        private void orders_Load(object sender, EventArgs e)
        {

        }
    }
}
