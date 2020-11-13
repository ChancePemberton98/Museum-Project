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
                try
                {
                    if (uxNewMembership.Checked == false)
                    {
                        var newM = new Member(0, uxFirstName.Text + " " + uxLastName.Text, uxEmailAddress.Text, uxDoBPick.Value.Day, uxDoBPick.Value.Month, uxDoBPick.Value.Year, Convert.ToInt32(uxZipCode.Text));
                        sql = $" INSERT INTO Project.Member(MembershipId,[Name],Email,DateOfBirth,IsPrimary,ZipCode) " +
                              $" VALUES({uxMembershipId.Text}, N'{uxFirstName.Text} {uxLastName.Text}',N'{uxEmailAddress.Text}',N'{newM.DoB}',0 ,N'{uxZipCode.Text}')";
                        command = new SqlCommand(sql, cnn);

                        dataAdapter.InsertCommand = command;
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        output = "Member added!\r\n";
                    }
                    else
                    {
                        var newM = new Member(0, uxFirstName.Text + " " + uxLastName.Text, uxEmailAddress.Text, uxDoBPick.Value.Day, uxDoBPick.Value.Month, uxDoBPick.Value.Year, Convert.ToInt32(uxZipCode.Text));
                        sql = $" INSERT INTO Project.Membership(Expiration) " +
                              $" VALUES(N'{DateTime.Today.Year + 1}-{DateTime.Today.Month}-{DateTime.Today.Day}')" +
                              $" DECLARE @MembershipId INT = SCOPE_IDENTITY();" +
                              $" INSERT INTO Project.Member(MembershipId,[Name],Email,DateOfBirth,IsPrimary,ZipCode)" +
                              $" VALUES( @MembershipId, N'{uxFirstName.Text} {uxLastName.Text}', N'{uxEmailAddress.Text}', N'{newM.DoB}',1 ,N'{uxZipCode.Text}')";
                        command = new SqlCommand(sql, cnn);

                        dataAdapter.InsertCommand = command;
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        output = "Member added!\r\n";
                    }
                }
                catch (Exception ex)
                {
                    output = ex.Message;
                }
                command.Dispose();
                uxResults.Text = output;
                showMemberInfo();
                output = "";
            
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
            try
            {
                if(uxMemberID.Text != "")
                {
                    sql = $" SELECT M.MemberId, M.MembershipId, M.Name, M.Email  " +
                      $" FROM Project.Member M WHERE M.MemberId = {uxMemberID.Text}";
                }
                else if(uxEmailAddress.Text != "")
                {
                    sql = $" SELECT M.MemberId, M.MembershipId, M.Name, M.Email  " +
                      $" FROM Project.Member M WHERE M.Email = N'{uxEmailAddress.Text}'";
                }
                else if(uxFirstName.Text != "")
                {
                    sql = $" SELECT M.MemberId, M.MembershipId, M.Name, M.Email  " +
                      $" FROM Project.Member M WHERE M.Name = N'{uxFirstName.Text} {uxLastName.Text}'";
                }
                else
                {
                    sql = $" SELECT M.MemberId, M.MembershipId, M.Name, M.Email  " +
                      $" FROM Project.Member M WHERE M.MembershipId = {uxMembershipId.Text}";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + $"MEMBER ID:{dataReader.GetValue(0)}\r\n" +
                                      $"MEMBERSHIP ID:{dataReader.GetValue(1)}\r\n" +
                                      $"NAME:{dataReader.GetValue(2)}\r\n" +
                                      $"EMAIL:{dataReader.GetValue(3)}\r\n\r\n";
                }
                dataReader.Close();
                
            }
            catch(Exception ex)
            {
                output = ex.Message;
            }
            if (output == "") output = "Member not found...";
            uxResults.Text = output;
            output = "";

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
            try
            {
                sql = $"INSERT INTO Project.Activity([ActivityName],ActivityDate,Fee)" +
                      $"VALUES(N'{uxActivityName.Text}', N'{uxActivityDate.Value.Year}-{uxActivityDate.Value.Month}-{uxActivityDate.Value.Day}', {uxActivityFee.Value})";
                command = new SqlCommand(sql, cnn);
                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();
                output = "Activity Added!";
            }
            catch(Exception ex)
            {
                output = ex.Message;
            }
            
            command.Dispose();
            uxResults.Text = output;
            output = "";
        }

        private void onLookupActivityClick(object sender, EventArgs e)
        {
            try
            {
                if(uxActivityId.Text != "")
                {
                    sql = $" SELECT A.ActivityName, CAST(A.ActivityDate AS DATE) AS ActivityDate, A.Fee, COUNT(AA.MemberId) AS Registered " +
                      $" FROM Project.Activity A " +
                      $" LEFT JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                      $" WHERE A.ActivityId = {uxActivityId.Text} " +
                      $" GROUP BY A.ActivityName, ActivityDate, A.Fee ";
                }
                else
                {
                    sql = $" SELECT A.ActivityName, CAST(A.ActivityDate AS DATE) AS ActivityDate, A.Fee, COUNT(DISTINCT AA.MemberId) AS Registered " +
                      $" FROM Project.Activity A " +
                      $" LEFT JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                      $" WHERE A.ActivityName = N'{uxActivityName.Text}' " +
                      $" GROUP BY A.ActivityName, ActivityDate, A.Fee ";
                }
                
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
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }

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
                      $"VALUES({uxActivityId.Text}, {Convert.ToInt32(uxMemberID.Text)})";
                command = new SqlCommand(sql, cnn);

                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();
                uxResults.Text = "Registration complete!";
            }
            catch (Exception ex)
            {
                uxResults.Text = ex.Message;
            }
            command.Dispose();
        }

        private void onShowAttendeesClick(object sender, EventArgs e)
        {
            try
            {
                if (uxActivityId.Text != "")
                {
                    sql = $" SELECT M.MemberId, M.[Name], M.Email " +
                     $" FROM Project.Activity A " +
                     $" INNER JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                     $" INNER JOIN Project.Member M ON M.MemberId = AA.MemberId " +
                     $" WHERE A.ActivityId = {uxActivityId.Text} ";
                }
                else
                {
                    sql = $" SELECT M.MemberId, M.[Name], M.Email " +
                      $" FROM Project.Activity A " +
                      $" INNER JOIN Project.ActivityAttendee AA ON AA.ActivityId = A.ActivityId " +
                      $" INNER JOIN Project.Member M ON M.MemberId = AA.MemberId " +
                      $" WHERE A.ActivityName = N'{uxActivityName.Text}' ";
                }

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + $"MEMBER ID:{dataReader.GetValue(0)}\r\n" +
                                      $"NAME:{dataReader.GetValue(1)}\r\n" +
                                      $"EMAIL:{dataReader.GetValue(2)}\r\n\r\n";
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            uxResults.Text = output;
            output = "";
        }

        private string getMembershipId(string email)
        {
            string gotId = "";
            try
            {
                sql = $" SELECT M.MembershipId" +
                      $" FROM Project.Member M WHERE M.Email = N'{email}'";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }

            return gotId;
        }

        private string getMemberId(string email)
        {
            string gotId = "";
            try
            {
                sql = $" SELECT M.MemberId" +
                      $" FROM Project.Member M WHERE M.Email = N'{email}'";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }

            return gotId;
        }

        private void showMemberInfo()
        {
            try
            {
                sql = $" SELECT M.MemberId, M.MembershipId, M.Name, M.Email  " +
                      $" FROM Project.Member M WHERE M.Email = N'{uxEmailAddress.Text}'";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + $"MEMBER ID:{dataReader.GetValue(0)}\r\n" +
                                      $"MEMBERSHIP ID:{dataReader.GetValue(1)}\r\n" +
                                      $"NAME:{dataReader.GetValue(2)}\r\n" +
                                      $"EMAIL:{dataReader.GetValue(3)}\r\n\r\n";
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            uxResults.Text = output;
            output = "";
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
