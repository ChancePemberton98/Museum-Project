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
    public partial class VisitHandler : Form
    {
        public VisitHandler()
        {
            InitializeComponent();
            uxMemberVisitHistoryBtn.Click += onMemberVisitHistoryClick;
            uxNewVisitBtn.Click += onNewVisitBtnClick;
        }

        private void onMemberVisitHistoryClick(object sender, EventArgs e)
        {
            MuseumApp.sql = $"EXEC MemberVisits @MEMBERID = {uxMemberID.Text}";
            Close();
        }

        private void onNewVisitBtnClick(object sender, EventArgs e)
        {
            var ZipList = new List<string>();
            ZipList.Add(uxGuestZip1.Text.ToString());
            ZipList.Add(uxGuestZip2.Text.ToString());
            ZipList.Add(uxGuestZip3.Text.ToString());
            ZipList.Add(uxGuestZip4.Text.ToString());
            ZipList.Add(uxGuestZip5.Text.ToString());

            int guestCount = 0;
            foreach(string zip in ZipList) { if (zip.Length == 5) guestCount++; }

            if (uxMemberID.Text != "")
            {
                MuseumApp.sql = $" INSERT INTO Project.Visit(Date, Fee) " +
                                 $" VALUES (GETDATE(), {guestCount * 5}) "+
                                 $" INSERT INTO Project.MemberVisit(VisitId, MemberId) " +
                                 $" VALUES (SYSDATETIMEOFFSET(IDENT_CURRENT('Project.Visit')), {uxMemberID.Text}) ";
            }

            if (guestCount > 0)
            {


                MuseumApp.sql += $" INSERT INTO Project.Guest(Visit, ZipCode) ";

                foreach (string zip in ZipList)
                {
                    if (zip.Length == 5)
                    {
                        MuseumApp.sql += $" ( SELECT IDENT_CURRENT('Visit'),{zip}) ";
                    }
                }
            }

            Close();
        }
    }
}
