using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Administrator : Form
    {
        DBworker database = new();
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(txtQuery.Text, connection);
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new();
                        table.Load(reader);
                        dgName.DataSource = table;
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Неправильно введен запрос");
                }
            }
        }
        public SqlConnection GetConnection()
        {

            SqlConnection connection = new();
            //создаём экземпляр класса
            SqlConnectionStringBuilder sqlConnectionString = new();

            sqlConnectionString.DataSource = @"(LocalDB)\MSSQLLocalDB";
            sqlConnectionString.AttachDBFilename = database.getPath();
            sqlConnectionString.IntegratedSecurity = true;
            sqlConnectionString.ConnectTimeout = 30;

            //передаём в виде текста конекшену
            connection.ConnectionString = sqlConnectionString.ToString();
            return connection;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var pasportUser = pasportOfUserTxtBox.Text;
            var loginUser = usernameTxtBox.Text;
            var passUser = passwordTxtBox.Text;

            if (loginUser == "" || passUser == "" || passUser == "")
            {
                MessageBox.Show("Все значения должны быть заполнены", "Пустые значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select UserKey, [user], password, admin from [users] where [pasport] = '{pasportUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть (по паспорту)", "Паспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            querystring = $@"select pasport from [Guest] where [pasport] = '{pasportUser}'";
            adapter = new SqlDataAdapter();
            command = new SqlCommand(querystring, database.GetConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет такого гостя в базе", "Паспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            querystring = $@"select UserKey, [user], password, admin from [users] where [user] = '{loginUser}' and password = '{passUser}'";
            adapter = new SqlDataAdapter();
            command = new SqlCommand(querystring, database.GetConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) {
                MessageBox.Show("Такой пользователь уже есть. Измените username или password", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                querystring = $@"isert into [users] ([user], password, pasport, admin) values ('{loginUser}','{passUser}','{pasportUser}',false)";
                adapter = new SqlDataAdapter();
                command = new SqlCommand(querystring, database.GetConnection());
                //table = new DataTable();
                adapter.SelectCommand = command;
                MessageBox.Show("Успешно введен пользователь", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
