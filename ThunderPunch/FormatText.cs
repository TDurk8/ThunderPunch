using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ThunderPunch
{
    class FormatText
    {
        public string ProperName(string name)
        {
            //Capitalize Proper Names
            return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Count() - 1).ToLower();
        }

        public string Phone(string phone)
        {
            //Format that Phone!
            return ("(" + phone.Substring(0, 3) + ")" + phone.Substring(3, 3) + "-" + phone.Substring(6, 4));
        }

        public void TextBoxEnter(TextBox tb, string type)
        {
            //Removes the grayed out text guides and changes font to be a readable style
            //Otherwise highlight existing text to easily change errors
            if (tb.Text == type)
            {
                tb.Text = "";
                tb.ForeColor = System.Drawing.Color.Black;
                tb.Font = new Font(tb.Font, FontStyle.Regular);
            }
            else
            {
                tb.SelectAll();
            }
        }

        public void TextBoxLeave(TextBox tb, string type, Label error)
        {
            tb.Text.Trim();
            error.Text = "";
            if (tb.Text == "")
            {
                tb.Text = type;
                tb.ForeColor = System.Drawing.Color.DarkGray;
                tb.Font = new Font(tb.Font, FontStyle.Italic);
            }
        }
        
        public string RemoveFormat(string number)
        {
            string returnNumber = "";
            foreach (char num in number)
            {
                if (char.IsNumber(num)) returnNumber += num;
            }
            return returnNumber;
        }

        public string RemoveCurrencyFormat(string number)
        {
            string returnNumber = "";
            foreach(char num in number)
            {
                if (num=='.' || char.IsNumber(num))
                {
                    returnNumber += num;
                }
            }
            return returnNumber;
        }

        public string CurrencyFormat(string money, RadioButton hourly, RadioButton salary)
        {
            string formattedMoney = "";
            decimal momoney = 0.00m;
            if (decimal.TryParse(money, out momoney) && salary.Checked)
            {
                formattedMoney = String.Format("{0:C0}", momoney);
            }
            else if (decimal.TryParse(money, out momoney))
            {
                formattedMoney = momoney.ToString("C");
            }
            return formattedMoney;
        }
    }
}
