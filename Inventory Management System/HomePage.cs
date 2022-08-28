using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductsPage pp = new ProductsPage();
            pp.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsersPage up = new UsersPage();
            up.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrdersPage op = new OrdersPage();
            op.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriesPage cp = new CategoriesPage();
            cp.Show();
            this.Hide();
        }
    }
}
