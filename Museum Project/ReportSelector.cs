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
            MuseumApp.sql = $"EXECUTE {uxReportSelectComboBox.SelectedItem.ToString()}";
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
