using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Finalproj
{
    public partial class adminwrk : Form
    {
        DataGridViewRow row;
        DataClasses1DataContext dataContx = new DataClasses1DataContext();
        public adminwrk()
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata() {
            var getdata = (from x in dataContx.users
                           select x);
            dataGridView1.DataSource = getdata;
        }

        private void button1_Click(object sender, EventArgs e) ///INSERT
        {
            user newUser = new user();
            newUser.NO = Convert.ToInt32(textBox1.Text);
            newUser.BRAND = textBox2.Text;
            newUser.TYPE = textBox3.Text;
            newUser.MODEL= textBox4.Text;
            newUser.PRICE= Convert.ToInt32(textBox5.Text) ;
            newUser.QUANTITY= Convert.ToInt32(textBox6.Text);
            newUser.IMAGE= pictureBox1.ImageLocation;
            newUser.DETAILS= textBox8.Text;
            DataClasses1DataContext dbctx = new DataClasses1DataContext();
            dbctx.users.InsertOnSubmit(newUser);
            try {
                dbctx.SubmitChanges();
                MessageBox.Show("ok irfan");
                Loaddata();

            }
            catch {
                MessageBox.Show("inception irfan");
            }
        }

        private void button3_Click(object sender, EventArgs e)  ///ALL ITEMS
        {
            DataClasses1DataContext dataContx = new DataClasses1DataContext();
            var getdata= (from x in dataContx.users
                          select x);
            dataGridView1.RowTemplate.Height = 100;
            
            
            var getImage = (from x in dataContx.users
                           select x);


           
            Bitmap img;
            img = new Bitmap(@"C:\Users\User\Desktop\download.JPG");
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            dataGridView1.Columns.Insert(8, iconColumn);
            
            iconColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
            iconColumn.Image = img;
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        ///DATAGIRDVIEW
        {
            row = this.dataGridView1.Rows[e.RowIndex];
         
            textBox2.Text = row.Cells["BRAND"].Value.ToString();
            textBox3.Text = row.Cells["TYPE"].Value.ToString();
            textBox4.Text = row.Cells["MODEL"].Value.ToString();
            textBox5.Text = row.Cells["PRICE"].Value.ToString();
            textBox6.Text = row.Cells["QUANTITY"].Value.ToString();
            textBox7.Text = row.Cells["IMAGE"].Value.ToString();
            textBox8.Text = row.Cells["DETAILS"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)  ///EDIT
        {
            DataClasses1DataContext dataContx = new DataClasses1DataContext();
            var getdata = (from x in dataContx.users
                           where x.NO == Convert.ToInt32(row.Cells["NO"].Value)
                           select x).First();
            getdata.PRICE = Convert.ToInt32(textBox5.Text);
            getdata.QUANTITY = Convert.ToInt32(textBox6.Text);
            

            try
            {
                dataContx.SubmitChanges();
                MessageBox.Show("updated!");
                Loaddata();
            }
            catch
            {
                MessageBox.Show("NO UPDATE");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  ///DELETE
        {
            DataClasses1DataContext dataContx = new DataClasses1DataContext();
            var getdata = (from x in dataContx.users
                           where x.NO == Convert.ToInt32(row.Cells["NO"].Value)
                           select x
                ).ToList().Last();
            dataContx.users.DeleteOnSubmit(getdata);
            try
            {
                dataContx.SubmitChanges();
                Loaddata();
                MessageBox.Show("ok");
            }
            catch 
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)  ///IMAGE BROWSE
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg";

               if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    textBox7.Text = imageLocation;

                   pictureBox1.ImageLocation = imageLocation;

                }
            }
            catch (Exception ) {
                MessageBox.Show("Exception Found in Image");
            }
        }

        private void button6_Click(object sender, EventArgs e)  ///LOG OUT
        {
            this.Hide();
            Form1 f;
            f = new Form1();
            f.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)  ///SEE MY ORDERS
        {
            this.Hide();
            orders ord = new orders();
            ord.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  ///PICTUREBOX
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void adminwrk_Load(object sender, EventArgs e) ///ADMINWRKLOAD
        {

        }

        private void label8_Click(object sender, EventArgs e) ///DETAILS
        {

        }

        private void label1_Click(object sender, EventArgs e)   ///NO
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) ///NO
        {

        }
    }
}
