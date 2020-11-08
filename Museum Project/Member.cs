using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum_Project
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DoB { get; set; }
        public int Zip { get; set; }

        public Member(int ID, string name, string email, int day, int month, int year, int zip)
        {
            MemberID = ID;
            Name = name;
            Email = email;
            DoB.Day.Equals(day); DoB.Month.Equals(month); DoB.Year.Equals(year);
            Zip = zip;
        }
    }
}
