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
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsValidDay(int month, string day, string year)
        {
            if (Regex.IsMatch(day.Trim(), @"[0-9]") && Regex.IsMatch(year.Trim(), @"[0-9]"))
            {
                int dobDay = Int32.Parse(day);
                int dobYear = Int32.Parse(year);

                //verify that a semi reasonable year is picked.
                if ((DateTime.Now.Year - dobYear) > 18 && (DateTime.Now.Year - dobYear) < 120)
                {
                    if (dobDay > 0 && dobDay <= DateTime.DaysInMonth(dobYear, dobDay)) return true;
                    else return false;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
    }
}
