using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class UserForm : Form
    {
        DBworker database = new();
        string pasport;
        public UserForm( )
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select * from [Order]";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            userOrdersGridView.DataSource = table;
        }
        public UserForm(string pasport)
        {
            InitializeComponent();
            this.pasport = pasport;
            pasportlabel.Text += pasport;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select * from [Order] where [pasport] = '{this.pasport}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            userOrdersGridView.DataSource = table;
            }

        private void btnFindOpenRooms_Click(object sender, EventArgs e) //кнопка найти комнаты открытые
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            var from=dateTimePickerFrom.Value.ToString("yyyy/MM/dd");
            var to=dateTimePickerTo.Value.ToString("yyyy/MM/dd");
            //fromlabel.Text= from.ToString();
            //Tolabel.Text= to.ToString();
            string querystring = $@"select * from f_OpenRooms('{from}','{to}')";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            openRoomsGridView.DataSource = table;
        }
    }
}
