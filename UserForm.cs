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
        }
        public UserForm(string pasport)
        {
            InitializeComponent();
            this.pasport = pasport;
            pasportlabel.Text += pasport;
        }
        }
}
