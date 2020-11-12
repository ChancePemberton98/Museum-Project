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

namespace Museum_Project
{
    public partial class QueryForm : Form
    {
        SqlConnection cnn;
        public QueryForm()
        {
            InitializeComponent();
            connectBtn.Click += onConnectClick;
        }

        private void onConnectClick(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = $@"Data Source=mssql.cs.ksu.edu;Initial Catalog={usernameTxt.Text};User ID={usernameTxt.Text};Password={passwordTxt.Text}";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
        }
        

    }
}
