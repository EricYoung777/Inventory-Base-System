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
    public partial class OrdersPage : Form
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        SqlConnection Ucon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\young\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            HomePage od = new HomePage();
            od.Show();
            this.Hide();
        }


        void Dense()
        {

            Ucon.Open();
            string Myquery = "select * from OrderTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var dts = new DataSet();
            da.Fill(dts);
            OrdersGV.DataSource = dts.Tables[0];
            Ucon.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OrdersPage_Load(object sender, EventArgs e)
        {
            Dense();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucon.Open();
            SqlCommand cmd = new SqlCommand("insert into OrderTbl values('" + id.Text + "', '" + prodCateg.Text + "', '" + date.Text + "' )", Ucon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Added");
            Ucon.Close();
            Dense();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ucon.Open();
            SqlCommand cd = new SqlCommand("update OrderTbl set OrderId = '" + id.Text + "', ProductCategory='" + prodCateg.Text + "', ProductDate= '" + date.Text + "' ", Ucon);
            cd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully UpDated");
            Ucon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {

                MessageBox.Show("Please Enter the Order ID");
            }
            else
            {
                Ucon.Open();
                string myquerY = "delete from OrderTbl where OrderId='" + id.Text + "' ";
                SqlCommand cmmd = new SqlCommand(myquerY, Ucon);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("Order has been Deleted successfully. Thank You");
                Ucon.Close();
                Dense();
            }
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate grid with data from database
            DataGridViewRow row = OrdersGV.Rows[e.RowIndex];
            id.Text = row.Cells["OrderId"].Value.ToString();
            prodCateg.Text = row.Cells["ProductCategory"].Value.ToString();
            date.Text = row.Cells["ProductDate"].Value.ToString();
            
        }
    }
}
