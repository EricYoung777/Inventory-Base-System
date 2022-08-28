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

        void Populate()
        {
            try
            {
                Ucon.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Ucon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                usersGV.DataSource = ds.Tables[0];
                Ucon.Close();
            }

            catch
            {
               
            }
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
            }
            catch
            {
               
            }
        }

       

        private void UsersPage_Load(object sender, EventArgs e)
        {
            Populate();
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
                string myquery = "delete from UserTbl where Uphone='" + phoneTb.Text + "', ";
                SqlCommand cmd = new SqlCommand(myquery, Ucon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Details Successfully Deleted");
                Ucon.Close();
                Populate();
            }
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usernameTb.Text = usersGV.SelectedRows[0].Cells[0].Value.ToString();
            fnameTb.Text = usersGV.SelectedRows[0].Cells[1].Value.ToString();
            phoneTb.Text = usersGV.SelectedRows[0].Cells[2].Value.ToString();
            passwordTb.Text = usersGV.SelectedRows[0].Cells[3].Value.ToString();
        }


       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ucon.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname = '" + usernameTb.Text + "', Ufullname='" + fnameTb.Text + "', Uphone= '" + phoneTb.Text +"', Upassword= '" + passwordTb.Text + "' where Uphone= '" + phoneTb.Text + "' ", Ucon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully UpDated");
                Ucon.Close();
            }
            catch
            {

            }
        }
    }
}
