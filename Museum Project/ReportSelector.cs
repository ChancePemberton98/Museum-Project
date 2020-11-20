using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Museum_Project;

namespace Museum_Project
{
    public partial class ReportSelector : Form
    {
        private List<string> reports = new List<string>();

        public ReportSelector()
        {
            InitializeComponent();
            reports.Add("VisitorsWithin100Miles");
            reports.Add("MonthlyMemberShipReport");
            reports.Add("SixMonthActivityRegistrationReport");
            reports.Add("WeeklyGuestReport");
            reports.Add("GuestsReport");
            reports.Add("MonthlyVisitorReport");
            reports.Add("SixMonthMembershipReport");
            reports.Add("MonthlyTransactionReport");
            reports.Add("MembersWithin100Miles");
            reports.Add("Show_All_Members");
            uxCancelBtn.Click += onCancelButtonClick;
            uxRunReportBtn.Click += onRunClick;
            uxReportSelectComboBox.DataSource = reports;
        }

        /// <summary>
        /// Sets the static MuseumApp.sql string to an approprite string for the 
        /// selected report to be run. The selector is then closed.
        /// IN PROGRESS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onRunClick(object sender, EventArgs e)
        {
            MuseumApp.sql = $"EXEC {uxReportSelectComboBox.SelectedItem.ToString()}";
            Close();
        }

        /// <summary>
        /// Sets the Museum.sql string to be empty so no report is run and closes the selector.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCancelButtonClick(object sender, EventArgs e)
        {
            MuseumApp.sql = "";
            Close();
        }
    }
}
