using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ThunderPunch
{
    class Validation
    {
        public bool FourDigits(string punch)
        {
            
            if (punch.Length != 4) return false;
            return true;
        }

        public bool IsAlpha(string word)
        {
            if (Regex.IsMatch(word.Trim(), @"^[a-zA-Z]+$"))return true;
            return false;
        }

        public bool IsEmail(string email)
        {
            try
            {
                if (email != "")
                {
                    MailAddress mail = new MailAddress(email);
                    return true;
                }
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public DateTime IsValidDay(int month, string day, string year)
        {
            int dobDay;
            int dobYear;
            DateTime dob = new DateTime();
            if (int.TryParse(day, out dobDay) && int.TryParse(year,out dobYear) && dobYear>0 && dobYear<9999)
            {
                if (dobDay > 0 && dobDay <= DateTime.DaysInMonth(dobYear, month))
                {
                    dob = new DateTime(dobYear, month, dobDay);
                    MessageBox.Show("valid");
                }
            }
            return dob;
        }

        public bool Is18(int month, string day, string year)
        {
            //Make sure employee is 18
            return false;
        }

        //public bool IsOldAsDirt(int month, string day, string year)
        //{
        //    //make sure employee isn't the oldest person alive
        //    int ageCutoff = 100;
        //    return false;
        //}
        public bool IsValidHireDate(int month, string day, string year)
        {
            int dobDay;
            int dobYear;
            month++;
            if (int.TryParse(day, out dobDay) && int.TryParse(year, out dobYear))
            {
                //verify date is in the past or today's date
                DateTime hiredate = new DateTime(dobYear, month, dobDay);
                if (hiredate > DateTime.Today) return true;
                else return false;
            }
            else return false;
        }

        public bool IsZip(string zipcode)
        {
            int zip;
            if (zipcode.Length == 5 && int.TryParse(zipcode,out zip)&& zip >0) return true;
            else return false;
        }

        public bool IsValidDOB(int month, string day, string year, Label error)
        {
            //make sure we don't have the world's oldest person
            //also validates proper year put in. :)
            int AgeCutoff = 100;
            DateTime dob = new DateTime();
            if (day != "Day" && year != "Year" && month >= 0)
            {
                dob = IsValidDay(month, day, year);
                if (DateTime.Now.Year - dob.Year < AgeCutoff) MessageBox.Show("young enough");

                else error.Text = "Age > 100";
            }
            
            return true;
        }
    }
}
