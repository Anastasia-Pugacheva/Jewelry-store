using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataReader reader;

            string login = textBox1.Text;
            string pass = textBox2.Text;

            string connectStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\!Обмен\УП 01.01\отчеты\Пугачева\УП 08\Jewelry Store\Jewelry Store\Ювелирный магазин.accdb";

            string query = $"SELECT * FROM Вход WHERE Логин = '{login}' AND Пароль = '{pass}'";

            connection = new OleDbConnection(connectStr);
            connection.Open();

            command = new OleDbCommand(query, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Добро пожаловать");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            connection.Close();
        }
    }
}
