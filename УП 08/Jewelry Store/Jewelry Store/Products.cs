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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void продуктыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продуктыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ювелирный_магазинDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирный_магазинDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.ювелирный_магазинDataSet.Продукты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
