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
    public partial class CategoriesPage : Form
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        SqlConnection Ucon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\young\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        void Dense()
        {

            Ucon.Open();
            string Myquery = "select * from CategTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var dts = new DataSet();
            da.Fill(dts);
            CategoriesGV.DataSource = dts.Tables[0];
            Ucon.Close();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom1 = new HomePage();
            this.Hide();
            hom1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucon.Open();
            SqlCommand cmd = new SqlCommand("insert into CategTbl values('" + catId.Text + "', '" + catName.Text + "' )", Ucon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category has been Successfully Added");
            Ucon.Close();
            Dense();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ucon.Open();
            SqlCommand cd = new SqlCommand("update CategTbl set CategoryId = '" + catId.Text + "', CategoryName='" + catName.Text + "' ", Ucon);
            cd.ExecuteNonQuery();
            MessageBox.Show("Category has been Successfully UpDated");
            Ucon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (catId.Text == "")
            {

                MessageBox.Show("Please Enter the Category's ID");
            }
            else
            {
                Ucon.Open();
                string myquerY = "delete from CategTbl where CategoryId='" + catId.Text + "' ";
                SqlCommand cmmd = new SqlCommand(myquerY, Ucon);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("The category has been Deleted successfully");
                Ucon.Close();
                Dense();
            }
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = CategoriesGV.Rows[e.RowIndex];
            catId.Text = row.Cells["CategoryId"].Value.ToString();
            catName.Text = row.Cells["CategoryName"].Value.ToString();
           
        }

        private void CategoriesPage_Load(object sender, EventArgs e)
        {
            Dense();
        }
    }
}
