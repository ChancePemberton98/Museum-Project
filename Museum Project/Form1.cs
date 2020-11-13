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
using System.Runtime.CompilerServices;

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
            uxAddActivityBtn.Click += onActivityAddClick;
            uxLookUpActivityBtn.Click += onLookupActivityClick;
            uxRegisterBtn.Click += onRegisterClick;
            uxShowAttendees.Click += onShowAttendeesClick;
            this.FormClosed += onFormClosed;
        }
        ErrorProvider errorProvider = new ErrorProvider();

        private void onFormClosed(object sender, EventArgs e)
        {
            if(cnn != null) cnn.Close();
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    var newM = new Member(0, uxFirstName.Text + " " + uxLastName.Text, uxEmailAddress.Text, uxDoBPick.Value.Day, uxDoBPick.Value.Month, uxDoBPick.Value.Year, Convert.ToInt32(uxZipCode.Text));
                    sql = $"INSERT INTO Project.Member(MembershipId,[Name],Email,DateOfBirth,IsPrimary,ZipCode)" +
                          $"VALUES(1,N'{newM.Name}',N'{newM.Email}',N'{newM.DoB}', 1,N'{newM.Zip.ToString()}')";
                    command = new SqlCommand(sql, cnn);

                    dataAdapter.InsertCommand = command;
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    uxResults.Text = ex.Message;
                }
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
            sql = $" SELECT M.MemberId, M.Name, M.Email  " +
                  $" FROM Project.Member M WHERE M.Name = N'{uxFirstName.Text} {uxLastName.Text}'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + $"MEMBER ID:{dataReader.GetValue(0)}\r\n" +
                                  $"NAME:{dataReader.GetValue(1)}\r\n" +
                                  $"EMAIL:{dataReader.GetValue(2)}\r\n\r\n";
            }
            dataReader.Close();
            uxResults.Text = output;
        }

        private void onConnectClick(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = $@"Data Source=mssql.cs.ksu.edu;Initial Catalog={usernameTxt.Text};User ID={usernameTxt.Text};Password={passwordTxt.Text}";
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                uxResults.Text = "Connection Open!";
                uxAdd.Enabled = true;
                uxLookup.Enabled = true;
                uxAddActivityBtn.Enabled = true;
                uxLookUpActivityBtn.Enabled = true;
                uxRegisterBtn.Enabled = true;
                uxShowAttendees.Enabled = true;
            }
            catch (Exception)
            {
                uxResults.Text = "Login failed...";
            }
        }

        private void onActivityAddClick(object sender, EventArgs e)
        {
            sql = $"INSERT INTO Project.Activity([ActivityName],ActivityDate,Fee)" +
                  $"VALUES(N'{uxActivityName.Text}',N'{uxActivityDate.Value.Year}-{uxActivityDate.Value.Month}-{uxActivityDate.Value.Day}',{uxActivityFee.Value})";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = command;
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }

        private void onLookupActivityClick(object sender, EventArgs e)
        {
            sql = $" SELECT A.ActivityName, CAST(A.ActivityDate AS DATE) AS ActivityDate, A.Fee, COUNT(DISTINCT AA.MemberId) AS Registered " +
                  $" FROM Project.Activity A " +
                  $" LEFT JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                  $" WHERE A.ActivityName = N'{uxActivityName.Text}' " +
                  $" GROUP BY A.ActivityName, ActivityDate, A.Fee";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + $"NAME:{dataReader.GetValue(0)}\r\n" +
                                  $"DATE:{dataReader.GetValue(1)}\r\n" +
                                  $"FEE:{dataReader.GetValue(2)}\r\n" +
                                  $"REGISTRATION COUNT:{dataReader.GetValue(3)}\r\n\r\n";
            }
            dataReader.Close();
            if (output == "") output = "Activity not found...";
            uxResults.Text = output;
            output = "";
        }

        private void onRegisterClick(object sender, EventArgs e)
        {
            try
            {
                sql = $"DECLARE @ActivityId INT = ( SELECT A.ActivityId FROM Project.Activity A WHERE A.ActivityName = N'{uxActivityName.Text}' );"+
                      $"INSERT INTO Project.ActivityAttendee(ActivityId, MemberId)" +
                      $"VALUES(@ActivityId, { Convert.ToInt32(uxMemberID.Text)})";
                command = new SqlCommand(sql, cnn);

                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                uxResults.Text = ex.Message;
            }
            command.Dispose();
        }

        private void onShowAttendeesClick(object sender, EventArgs e)
        {
            sql = $" SELECT M.MemberId, M.[Name], M.Email " +
                  $" FROM Project.Activity A " +
                  $" INNER JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                  $" INNER JOIN Project.Member M ON M.MemberId = AA.MemberId " +
                  $" WHERE A.ActivityName = N'{uxActivityName.Text}' ";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + $"MEMBER ID:{dataReader.GetValue(0)}\r\n" +
                                  $"NAME:{dataReader.GetValue(1)}\r\n" +
                                  $"EMAIL:{dataReader.GetValue(2)}\r\n\r\n";
            }
            dataReader.Close();
            uxResults.Text = output;
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

        private void MuseumApp_Load(object sender, EventArgs e)
        {

        }

        private void uxNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
