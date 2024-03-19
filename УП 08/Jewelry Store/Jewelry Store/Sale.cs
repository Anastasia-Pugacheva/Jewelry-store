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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void продажаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продажаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ювелирный_магазинDataSet);

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирный_магазинDataSet.Продажа". При необходимости она может быть перемещена или удалена.
            this.продажаTableAdapter.Fill(this.ювелирный_магазинDataSet.Продажа);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
