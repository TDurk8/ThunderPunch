using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderPunch
{
    class Validation
    {
        public bool FourDigits(string punch)
        {
            if (punch.Length != 4) return false;
            return true;
        }
    }
}
