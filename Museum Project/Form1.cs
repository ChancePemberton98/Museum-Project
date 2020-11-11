using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum_Project
{
    public partial class MuseumApp : Form
    {
        public MuseumApp()
        {
            InitializeComponent();
        }
        ErrorProvider errorProvider = new ErrorProvider();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uxNameLabel_Click(object sender, EventArgs e)
        {

        }
        private void uxAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                new Member(Convert.ToInt32(uxMemberID), uxFirstName.Text + " " + uxLastName.Text, uxEmailAddress.Text, uxDoBPick.Value.Day, uxDoBPick.Value.Month, uxDoBPick.Value.Year, Convert.ToInt32(uxZipCode.Text));
                /*
                 * 
                 * Implement a way to add to database here maybe?
                 * 
                 */
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







        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
