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
        public ReportSelector()
        {
            uxCancelBox.Click += onCancelButtonClick;
            InitializeComponent();
        }

        private void onCancelButtonClick(object sender, EventArgs e)
        {
            Museum_Project.MuseumApp.sql = "";
            this.Close();
        }
    }
}
