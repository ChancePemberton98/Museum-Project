using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Museum_Project
{
    public partial class MuseumApp : Form
    {
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        String sql, output = "";

        public MuseumApp()
        {
            InitializeComponent();
            connectBtn.Click += onConnectClick;
            uxLookup.Click += onLookupClick;
        }
        ErrorProvider errorProvider = new ErrorProvider();

        
        private void uxAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var newM = new Member(0, uxFirstName.Text + " " + uxLastName.Text, uxEmailAddress.Text, uxDoBPick.Value.Day, uxDoBPick.Value.Month, uxDoBPick.Value.Year, Convert.ToInt32(uxZipCode.Text));
                sql = $"INSERT INTO Project.Member(MembershipId,[Name],Email,DateOfBirth,IsPrimary,ZipCode)" +
                      $"VALUES(1,N'{newM.Name}',N'{newM.Email}',N'{newM.DoB}', 1,N'{newM.Zip.ToString()}')";
                command = new SqlCommand(sql, cnn);

                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
        }

        private void uxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(uxFirstName.Text))
            {
                e.Cancel = true;
                uxFirstName.Focus();
                errorProvider.SetError(uxFirstName, "Please enter first name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(uxFirstName, null);
            }
        }

        private void uxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(uxLastName.Text))
            {
                e.Cancel = true;
                uxLastName.Focus();
                errorProvider.SetError(uxLastName, "Please enter first name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(uxLastName, null);
            }
        }
        
        private void onLookupClick(object sender, EventArgs e)
        {
            sql = $"SELECT * FROM Project.Member M WHERE M.Name = N'{uxFirstName.Text} {uxLastName.Text}'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + $"{dataReader.GetValue(0)} - {dataReader.GetValue(1)} - {dataReader.GetValue(2)} \n";
            }
            dataReader.Close();
            uxResults.Text = output;
        }

        private void onConnectClick(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = $@"Data Source=mssql.cs.ksu.edu;Initial Catalog={usernameTxt.Text};User ID={usernameTxt.Text};Password={passwordTxt.Text}";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            uxResults.Text = "Connection Open!";
        }

        private void uxEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uxNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
