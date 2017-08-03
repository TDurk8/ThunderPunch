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

        public bool IsValidDay(int month, string day, string year)
        {
            int dobDay;
            int dobYear;
            if (int.TryParse(day, out dobDay) && int.TryParse(year,out dobYear))
            {
                //verify that a semi reasonable year is picked.
                if ((DateTime.Now.Year - dobYear) > 18 && (DateTime.Now.Year - dobYear) < 120)
                {
                    if (dobDay > 0 && dobDay <= DateTime.DaysInMonth(dobYear, month+1)) return true;
                    else return false;
                }
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

    }
}
