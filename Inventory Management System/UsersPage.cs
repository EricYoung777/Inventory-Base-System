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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        SqlConnection Ucon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\young\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom1 = new HomePage();
            hom1.Show();
            this.Hide();
        }

        void Dense()
        {
           
                Ucon.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Ucon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var dts = new DataSet();
                da.Fill(dts);
                usersGV.DataSource = dts.Tables[0];
                Ucon.Close();            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ucon.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('"+usernameTb.Text+"', '"+fnameTb.Text+"', '"+phoneTb.Text+"', '"+passwordTb.Text+"')", Ucon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Ucon.Close();
                Dense();
            }
            catch
            {
               
            }
        }

       

        private void UsersPage_Load(object sender, EventArgs e)
        {
            Dense();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(phoneTb.Text == "")
            {
                
                MessageBox.Show("Please Enter the Users Phone Number");
            }
             else
            {
                Ucon.Open();
                string myquerY = "delete from UserTbl where Uphone='" + phoneTb.Text + "' ";
                SqlCommand cmmd = new SqlCommand(myquerY, Ucon);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("User Details has been Deleted successfully");
                Ucon.Close();
                Dense();
            }
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = usersGV.Rows[e.RowIndex];
            usernameTb.Text = row.Cells["Uname"].Value.ToString();
            fnameTb.Text = row.Cells["Ufullname"].Value.ToString();
            phoneTb.Text = row.Cells["Uphone"].Value.ToString();
            passwordTb.Text = row.Cells["Upassword"].Value.ToString();


        }


       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ucon.Open();
                SqlCommand cd = new SqlCommand("update UserTbl set Uname = '" + usernameTb.Text + "', Ufullname='" + fnameTb.Text + "', Uphone= '" + phoneTb.Text +"', Upassword= '" + passwordTb.Text + "' where Uphone= '" + phoneTb.Text + "' ", Ucon);
                cd.ExecuteNonQuery();
                MessageBox.Show("User Successfully UpDated");
                Ucon.Close();
                
            }
            catch
            {

            }
        }

      
    }
}
