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
        //confirm 4 digit login
        public bool FourDigits(string punch)
        {
            
            if (punch.Length != 4) return false;
            return true;
        }

        //only alpha letters
        public bool IsAlpha(string word)
        {
            if (Regex.IsMatch(word.Trim(), @"^[a-zA-Z]+$"))return true;
            return false;
        }

        //using windows verification, check email
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

        //check for valid date
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
                }
            }
            return dob;
        }

        //no future dates for Hire date
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

        //check five digit zip
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
                if (DateTime.Now.Year - dob.Year < AgeCutoff)
                    //if 19 or older don't verify month otherwise if 18 verify exact day
                    if (DateTime.Now.Year - dob.Year > 18 || (DateTime.Now.Year - dob.Year == 18) && DateTime.Now.Month - month >= 0 && DateTime.Now.Day - dob.Day >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        error.Text = "Must Be 18";
                    }
                else error.Text = "Age > "+ AgeCutoff;
            }
            return false;
        }

        public bool DigitOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) return true;
            else return false;
        }

        public bool CurrencyDigitsOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46) return true;
            else return false;
            //if (e.KeyChar == 46) MessageBox.Show(".");
            //return false;
        }

        public bool WageSalaryCheck(string wage, RadioButton salary,RadioButton hourly, Label error)
        {
            const int SALARYMINIMUM = 20000;
            const int SALARYMAXIMUM = 999999;
            const decimal HOURLYMINIMUM = 7.25m;
            const decimal HOURLYMAXIMUM = 200.00M;

            
            error.Text = "";
            if (decimal.TryParse(wage, out decimal convertedWage))
            {
                if ((convertedWage < SALARYMINIMUM || convertedWage > SALARYMAXIMUM) && salary.Checked)
                {
                    error.Text = "Salary Must be between $" + SALARYMINIMUM + " and $" + SALARYMAXIMUM;
                    return false;
                }
                else if ((convertedWage < HOURLYMINIMUM || convertedWage > HOURLYMAXIMUM) && hourly.Checked)
                {
                    error.Text = "Hourly Must be between $" + HOURLYMINIMUM + " and $" + HOURLYMAXIMUM;
                    return false;
                }
            }
            else if(salary.Checked || hourly.Checked)
            {
                error.Text = "Invalid wage Amount";
                return false;
            }
            return true;
        }
    }
}
