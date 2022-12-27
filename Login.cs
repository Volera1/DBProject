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
    public partial class Login : Form
    {
        DBworker database = new();
        Administrator administrator;
        UserForm userform;
        public Login()
        {
            InitializeComponent();
            usernameTxtBox.MaxLength = 50;
            passwordTxtBox.MaxLength = 50;
            administrator = new Administrator();
            administrator.Hide();
            userform = new UserForm();
            userform.Hide();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            var loginUser = usernameTxtBox.Text;
            var passUser = passwordTxtBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select UserKey, [user], password, pasport, admin from users where [user] = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (table.Rows[0].Field<bool>("admin"))
                {
                    //this.Hide();
                    userform = new UserForm();
                    userform.Show();
                    administrator = new Administrator();
                    administrator.Show();
                    //this.Show();
                }
                else
                {
                    this.Hide();
                    administrator.Close();
                    userform.Close();
                    userform = new UserForm(table.Rows[0].Field<string>("pasport"));
                    userform.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            administrator.Close();
            userform.Close();
        }
    }
    
}
