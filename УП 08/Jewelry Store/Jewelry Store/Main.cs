using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Enter enter = new Enter();
            enter.Show();
            this.Hide();
        }
    }
}
