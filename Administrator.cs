using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBProject
{
    public partial class Administrator : Form
    {
        DBworker database = new();
        int selectedRow;
        string selectedUpdateTable;
        public Administrator()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select [OrgKey]
      ,[Features]
      ,[OrgName] from [Organization]";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            organizationsGridView.DataSource = table;
            orgNumComboBox.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                orgNumComboBox.Items.Add(table.Rows[i].Field<int>("OrgKey"));
            }
            adapter = new SqlDataAdapter();
            table = new DataTable();

            querystring = $@"select [NumRoom] from [Room]";

            command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            numRoomComboBox.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                numRoomComboBox.Items.Add(table.Rows[i].Field<Int16>("NumRoom"));
            }
            adapter = new SqlDataAdapter();
            table = new DataTable();

            querystring = $@"select [NumBed] from [Bed]";

            command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            bedComboBox.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                bedComboBox.Items.Add(table.Rows[i].Field<byte>("NumBed"));
            }
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
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть. Измените username или password", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                querystring = $@"insert into users([user], password, pasport, admin) values ('{loginUser}','{passUser}','{pasportUser}',0)";
                database.openConnection();
                command = new SqlCommand(querystring, database.GetConnection());
                //table = new DataTable();
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Успешно введен пользователь", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var pasport = pasportOrderTxtBox.Text;
            var numbed = bedComboBox.SelectedItem;
            var dateArrival = arrivalDatePicker.Value.ToString("yyyy/MM/dd");
            var dateDeparture = departureDatePicker.Value.ToString("yyyy/MM/dd");
            if (arrivalDatePicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Нельзя фиксировать проживание на будущее. Измените дату приезда", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (arrivalDatePicker.Value >= departureDatePicker.Value)
            {
                MessageBox.Show("Дата приезда не может быть позже отъезда. Измените даты", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string querystring = $@"insert into [Order](Pasport, NumBed, ArrivalDate, DepartureDate) values ('{pasport}',N'{numbed}','{dateArrival}','{dateDeparture}')";
            database.openConnection();
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("Успешно введена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tableDeleteComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            var selectedTable = tableDeleteComboBox.SelectedItem.ToString();

            string querystring = $@"select * from [{selectedTable}]";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            deletedDataGridView.ClearSelection();
            deletedDataGridView.DataSource = table;
            deletedComboBox.Items.Clear();
            deletedComboBox.SelectedItem = null;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                deletedComboBox.Items.Add(table.Rows[i][0]);
            }
            labelDeletedKey.Text = table.Columns[0].ColumnName;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedTable = tableDeleteComboBox.SelectedItem.ToString();
            var selectedKey = deletedComboBox.SelectedItem.ToString();
            var keyName = labelDeletedKey.Text;
            string querystring = $@"DELETE FROM [{selectedTable}] WHERE [{keyName}] = {selectedKey}";
            database.openConnection();
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("Успешно удалена запись", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tableDeleteComboBox_SelectedValueChanged(sender, e);
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            var selectedOrg = orgNumComboBox.SelectedItem.ToString();
            var arrivalTime = arrivalTimePicker.Value.ToString("yyyy/MM/dd");
            var departureTime = departureTimePicker.Value.ToString("yyyy/MM/dd");
            var numRoom = numRoomComboBox.SelectedItem.ToString();
            var now = DateTime.Now.ToString("yyyy/MM/dd");
            if (arrivalTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Дата приезда не может быть запланирована в прошлом. Измените дату приезда", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (arrivalDatePicker.Value >= departureDatePicker.Value)
            {
                MessageBox.Show("Дата приезда не может быть позже отъезда. Измените даты", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            database.openConnection();
            string querystring = $@"insert into [Reservation](OrgKey, NumRoom, ArrivalTime, DepartureTime, ReserveTime) values ('{selectedOrg}',N'{numRoom}','{arrivalTime}','{departureTime}','{now}')";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("Успешно введена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void updateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = dgvLocationMain.Rows[selectedRow];

                //tbIdLocation.Text = row.Cells[0].Value.ToString();
                //cbCountryLocation.Text = row.Cells[2].Value.ToString();
                //cbCityLocation.Text = row.Cells[1].Value.ToString();

            }
        }

        private void updateTableComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            var selectedTable = updateTableComboBox.SelectedItem.ToString();
            selectedUpdateTable = selectedTable;

            string querystring = $@"select * from [{selectedTable}]";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            updateGridView.ClearSelection();
            updateGridView.DataSource = table;
            clearAllBoxes();
            if (selectedTable == "Order")
            {
                labelComboBox1.Text = "Паспорт:";
                labelComboBox2.Text = "Кровать:";
                labelComboBox1.Visible = true; labelComboBox2.Visible = true;
                comboBox1.Visible = true; comboBox2.Visible = true;
                labelfrom.Visible = true;
                labelto.Visible = true;
                dateTimePickerFrom.Visible = true;
                dateTimePickerTo.Visible = true;
            }
            else if (selectedTable == "Room")
            {
                labelComboBox1.Text = "Кол-во кроватей:";
                labelComboBox1.Visible = true;
                comboBox1.Visible = true;
                comboBox1.Enabled = false;
                labelTextBox1.Text = "Цена:";
                labelTextBox1.Visible = true;
                textBox1.Visible = true;
            }
            else if (selectedTable == "Guest")
            {
                labelComboBox1.Text = "Организация:";
                labelComboBox1.Visible = true;
                comboBox1.Visible = true;
                labelTextBox1.Text = "ФИО:";
                labelTextBox1.Visible = true;
                textBox1.Visible = true;
            }
            else if (selectedTable == "Reservation")
            {
                labelComboBox1.Text = "Организация:";
                labelComboBox1.Visible = true;
                comboBox1.Visible = true;
                labelfrom.Visible = true;
                labelto.Visible = true;
                dateTimePickerFrom.Visible = true;
                dateTimePickerTo.Visible = true;
            }
            else if (selectedTable == "Organization")
            {
                labelTextBox1.Text = "Название:";
                labelTextBox1.Visible = true;
                textBox1.Visible = true;
                labelTextBox2.Text = "Примечание:";
                labelTextBox2.Visible = true;
                textBox2.Visible = true;
            }
            else if (selectedTable == "users")
            {
                labelTextBox1.Text = "Username:";
                labelTextBox1.Visible = true;
                textBox1.Visible = true;
                labelTextBox2.Text = "Пароль:";
                labelTextBox2.Visible = true;
                textBox2.Visible = true;
            }
        }
        private void clearAllBoxes()
        {
            labelTextBox1.Visible = false;
            labelTextBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Visible = false;
            textBox2.Visible = false;
            labelComboBox1.Visible = false;
            labelComboBox2.Visible = false;
            comboBox1.Items.Clear();
            comboBox1.Enabled = true;
            comboBox2.Items.Clear();
            comboBox1.Visible = false; comboBox2.Visible = false;
            labelfrom.Visible = false;
            labelto.Visible = false;
            dateTimePickerFrom.Visible = false;
            dateTimePickerTo.Visible = false;
            dateTimePickerTo.Value = DateTime.Now;
            dateTimePickerFrom.Value = DateTime.Now;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (selectedUpdateTable == "Room")
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                {
                    e.Handled = true;
                }
            }
        }
    } 
    
}
