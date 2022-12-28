using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
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
            //заполняю таблицу с организауиями и комбо бокс на Добавить резервацию
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
            //Заполняю номерами комнат на Добавить резервацию
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
            //Заполняю кровати на Добавить проживание
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
            clearAllBoxes(); //очищаю все боксы в Изменить
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
            if (checkUser(pasportUser, loginUser, passUser))
            {
                string querystring = $@"insert into users([user], password, pasport, admin) values ('{loginUser}','{passUser}','{pasportUser}',0)";
                database.openConnection();
                SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                //table = new DataTable();
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Успешно введен пользователь", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var pasport = pasportOrderTxtBox.Text;
            var numbed = bedComboBox.SelectedItem;
            var dateArrival = arrivalDatePicker.Value.ToString("yyyy/MM/dd");
            var dateDeparture = departureDatePicker.Value.ToString("yyyy/MM/dd");
            if (checkDatesOrder(arrivalDatePicker, departureDatePicker))
            {
                string querystring = $@"insert into [Order](Pasport, NumBed, ArrivalDate, DepartureDate) values ('{pasport}',N'{numbed}','{dateArrival}','{dateDeparture}')";
                database.openConnection();
                SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Успешно введена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            deletedComboBox.SelectedItem = null;
            deletedComboBox.Items.Clear();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                deletedComboBox.Items.Add(table.Rows[i][0]);
            }
            labelDeletedKey.Text = table.Columns[0].ColumnName;
            
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tableDeleteComboBox.SelectedItem != null && deletedComboBox.SelectedItem != null)
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
            else
            {
                MessageBox.Show("Значения не заполнены. Введите значения", "Ошибка значений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            var selectedOrg = orgNumComboBox.SelectedItem.ToString();
            var arrivalTime = arrivalTimePicker.Value.ToString("yyyy/MM/dd");
            var departureTime = departureTimePicker.Value.ToString("yyyy/MM/dd");
            var numRoom = numRoomComboBox.SelectedItem.ToString();
            var now = DateTime.Now.ToString("yyyy/MM/dd");
            if (checkDatesReservation(arrivalTimePicker,departureTimePicker))
            {
                database.openConnection();
                string querystring = $@"insert into [Reservation](OrgKey, NumRoom, ArrivalTime, DepartureTime, ReserveTime) values ('{selectedOrg}',N'{numRoom}','{arrivalTime}','{departureTime}','{now}')";
                SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Успешно введена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                querystring = $@"select NumBed from [Bed]";
                command = new SqlCommand(querystring, database.GetConnection());
                table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox2.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox2.Items.Add(table.Rows[i].Field<Byte>("NumBed"));
                }
                querystring = $@"select pasport from [Guest]";
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand(querystring, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox1.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox1.Items.Add(table.Rows[i].Field<string>("Pasport"));
                }
            }
            else if (selectedTable == "Room")
            {
                labelComboBox1.Text = "Кроватей:";
                labelComboBox1.Visible = true;
                comboBox1.Visible = true;
                comboBox1.Enabled = false;
                labelTextBox1.Text = "Цена:";
                labelTextBox1.Visible = true;
                textBox1.Visible = true;
            }
            else if (selectedTable == "Guest")
            {
                querystring = $@"select OrgKey from [Organization]";
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand(querystring, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox1.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox1.Items.Add(table.Rows[i].Field<int>("OrgKey"));
                }
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
                labelComboBox2.Text = "Комната:";
                labelComboBox1.Visible = true; labelComboBox2.Visible = true;
                comboBox1.Visible = true; comboBox2.Visible = true;
                labelfrom.Visible = true;
                labelto.Visible = true;
                dateTimePickerFrom.Visible = true;
                dateTimePickerTo.Visible = true;
                querystring = $@"select OrgKey from Organization";
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand(querystring, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox1.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox1.Items.Add(table.Rows[i].Field<int>("OrgKey"));
                }
                querystring = $@"select NumRoom from Room";
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand(querystring, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox2.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox2.Items.Add(table.Rows[i].Field<Int16>("NumRoom"));
                }
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
                labelComboBox1.Text = "Паспорт:"; labelComboBox1.Visible = true;
                comboBox1.Visible = true;
                querystring = $@"select pasport from [Guest]";
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand(querystring, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                comboBox1.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    comboBox1.Items.Add(table.Rows[i].Field<string>("Pasport"));
                }
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
            keyTextBox.Clear();
            labelTextBox1.Visible = false;
            labelTextBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Visible = false;
            textBox2.Visible = false;
            labelComboBox1.Visible = false;
            labelComboBox2.Visible = false;
            comboBox1.Enabled = true;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox1.Items.Clear();
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

        private void updateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            String[] inits = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = updateGridView.Rows[selectedRow];
                keyTextBox.Text = row.Cells[0].Value.ToString();

                if (selectedUpdateTable == "Order")
                {
                    comboBox1.SelectedItem = row.Cells[1].Value.ToString();
                    comboBox2.SelectedItem = row.Cells[2].Value;
                    dateTimePickerFrom.Value = (DateTime)row.Cells[3].Value;
                    dateTimePickerTo.Value = (DateTime)row.Cells[4].Value;
                }
                else if (selectedUpdateTable == "Room")
                {
                    comboBox1.Enabled = true;
                    comboBox1.Items.AddRange(inits);
                    comboBox1.SelectedItem = row.Cells[1].Value.ToString();
                    comboBox1.Enabled = false;
                    textBox1.Text = row.Cells[2].Value.ToString();
                }
                else if (selectedUpdateTable == "Guest")
                {
                    //comboBox1.SelectedItem = null;
                    comboBox1.SelectedItem = row.Cells[2].Value;
                    textBox1.Text = row.Cells[1].Value.ToString();
                }
                else if (selectedUpdateTable == "Reservation")
                {
                    comboBox1.SelectedItem = row.Cells[1].Value;
                    dateTimePickerFrom.Value = (DateTime)row.Cells[3].Value;
                    dateTimePickerTo.Value = (DateTime)row.Cells[4].Value;
                    comboBox2.SelectedItem = row.Cells[5].Value;
                }
                else if (selectedUpdateTable == "Organization")
                {
                    textBox1.Text = row.Cells[2].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                }
                else if (selectedUpdateTable == "users")
                {
                    comboBox1.SelectedItem = row.Cells[4].Value.ToString();
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUpdateTable == null)
            {
                MessageBox.Show("Обязательно выберите таблицу для обработки", "Нет таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (keyTextBox.Text == "")
            {
                MessageBox.Show("Обязательно выберите элемент для обработки", "Нет элемента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var thisKey = keyTextBox.Text;
            switch (selectedUpdateTable)
            {
                case "Order":
                    {
                        if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null &&
                                 checkDatesOrder(dateTimePickerFrom, dateTimePickerTo))
                        {
                            var pasport = comboBox1.SelectedItem;
                            var bed = comboBox2.SelectedItem;
                            var arrivalDate = dateTimePickerFrom.Value.ToString("yyyy/MM/dd");
                            var departureDate = dateTimePickerTo.Value.ToString("yyyy/MM/dd");
                            database.openConnection();
                            string querystring = $@"update [Order] set pasport='{pasport}', NumBed=N'{bed}', ArrivalDate='{arrivalDate}', DepartureDate='{departureDate}' where OrderKey={thisKey}";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Что-то пошло не так", "ОЙ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case "Room":
                    {
                        if (textBox1.Text!="")
                        {
                            database.openConnection();
                            string querystring = $@"update [Room] set price='{textBox1.Text}' where NumRoom={thisKey}";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Заполните цену", "ОЙ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case "Guest":
                    {
                        var org = "";
                        if (comboBox1.SelectedItem != null) { org = comboBox1.SelectedItem.ToString(); }
                        var fio = textBox1.Text;
                        if (fio == "")
                        {
                            MessageBox.Show("Заполните ФИО", "ОЙ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            database.openConnection();
                            string querystring = $@"update [Guest] set OrgKey='{org}',FIO='{fio}' where Pasport='{thisKey}'";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        break;
                    }
                case "Reservation":
                    {
                        if (comboBox1.SelectedItem !=null && comboBox2.SelectedItem!=null &&
                            checkDatesReservation(dateTimePickerFrom, dateTimePickerTo))
                        {
                            var org = comboBox1.SelectedItem;
                            var room = comboBox2.SelectedItem;
                            var arrivalDate = dateTimePickerFrom.Value.ToString("yyyy/MM/dd");
                            var departureDate = dateTimePickerTo.Value.ToString("yyyy/MM/dd");
                            database.openConnection();
                            string querystring = $@"update [Reservation] set OrgKey='{org}', NumRoom=N'{room}', ArrivalTime='{arrivalDate}', DepartureTime='{departureDate}' where ReserveKey={thisKey}";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Что-то пошло не так", "ОЙ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case "Organization":
                    {
                        if (textBox1.Text!="") {
                            var name=textBox1.Text;
                            var feature = textBox2.Text;
                            database.openConnection();
                            string querystring = $@"update [Organization] set OrgName='{name}', features='{feature}' where OrgKey={thisKey}";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Название у организации должно быть", "ОЙ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case "users":
                    {
                        var login = textBox1.Text;
                        var password = textBox2.Text;
                        if (comboBox1.SelectedItem != null && login != "" && password != "" &&
                            checkUser(comboBox1.SelectedItem.ToString(), login, password))
                        {
                            var pasport = comboBox1.SelectedItem.ToString();
                            database.openConnection();
                            string querystring = $@"update [users] set [user]='{login}', password='{password}', pasport='{pasport}' where userKey={thisKey}";
                            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                            command.ExecuteNonQuery();
                            database.closeConnection();
                            MessageBox.Show("Успешно изменена запись", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

            }
            updateTableComboBox_SelectedValueChanged(sender, e);
        }
        private bool checkDatesReservation(DateTimePicker From, DateTimePicker To)
        {
            if (From.Value <= DateTime.Now)
            {
                MessageBox.Show("Дата приезда не может быть запланирована в прошлом. Измените дату приезда", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (From.Value >= To.Value)
            {
                MessageBox.Show("Дата приезда не может быть позже отъезда. Измените даты", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checkDatesOrder(DateTimePicker From, DateTimePicker To)
        {
            if (From.Value >= DateTime.Now)
            {
                MessageBox.Show("Нельзя фиксировать проживание на будущее. Измените дату приезда", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
            if (From.Value >= To.Value)
            {
                MessageBox.Show("Дата приезда не может быть позже отъезда. Измените даты", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }
        private bool checkUser(string pasportUser, string loginUser, string passUser)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select pasport from [Guest] where [pasport] = '{pasportUser}'";
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет такого гостя в базе", "Паспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                return false;
            }
            return true;
        }
    }
    
    
}
