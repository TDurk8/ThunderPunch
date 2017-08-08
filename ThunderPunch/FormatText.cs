using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderPunch
{
    class FormatText
    {
        public string ProperName(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Count() - 1).ToLower();
        }

        public string Phone(string phone)
        {
            return ("(" + phone.Substring(0, 3) + ")" + phone.Substring(3, 3) + "-" + phone.Substring(6, 4));
        }
    }
}
