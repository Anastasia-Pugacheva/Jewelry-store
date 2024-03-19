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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void категории_продуктовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.категории_продуктовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ювелирный_магазинDataSet);

        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирный_магазинDataSet.Категории_продуктов". При необходимости она может быть перемещена или удалена.
            this.категории_продуктовTableAdapter.Fill(this.ювелирный_магазинDataSet.Категории_продуктов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
