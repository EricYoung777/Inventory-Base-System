using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class ProductsPage : Form
    {   
        public ProductsPage()
        {
            InitializeComponent();
        }

        SqlConnection Ucon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\young\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        void Dense()
        {
           
                Ucon.Open();
                string Myquery = "select * from ProductsTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Ucon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Ucon.Close();
           

 
        }


        private void CustomersPage_Load(object sender, EventArgs e)
        {
            Dense();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom1 = new HomePage();
            this.Hide();
            hom1.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Ucon.Open();
                SqlCommand comd = new SqlCommand("insert into ProductsTbl values('" + productName.Text + "', '" + productDescrip.Text + "', '" + productPrice.Text + "',  '" + productCategory.Text + "')", Ucon);
                comd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Ucon.Close();
                Dense();
            
        }

        private void productDescrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void productPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (productId.Text == "")
            {

                MessageBox.Show("Please Enter the ProductId");
            }
            else
            {
                Ucon.Open();
                string myquery = "delete from ProductsTbl where ProductId ='" + productId.Text + "' ";
                SqlCommand cmd = new SqlCommand(myquery, Ucon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Details Successfully Deleted");
                Ucon.Close();
                Dense();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ucon.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProductName = '" + productName.Text + "', ProductDescription='" + productDescrip.Text + "', ProductPrice= '" + productPrice.Text + "', ProductCategory= '" + productCategory.Text + "' where ProductId= '" + productId.Text + "' ", Ucon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully UpDated");
                Ucon.Close();
                Dense();
            }
            catch
            {

            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
            productId.Text = row.Cells["ProductId"].Value.ToString();
            productName.Text = row.Cells["ProductName"].Value.ToString();
            productDescrip.Text = row.Cells["ProductDescription"].Value.ToString();
            productCategory.Text = row.Cells["ProductCategory"].Value.ToString();
        }
    }
}
