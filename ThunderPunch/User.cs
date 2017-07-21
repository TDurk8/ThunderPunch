using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ThunderPunch
{
    public class User
    {
        public string fName;
        public string lName;
        public string loginID;
        public string profilePic;
        public string title;

        public User()
        {

        }

        public User(string first, string last,string login,string position,string url)
        {
            fName = first;
            lName = last;
            loginID = login;
            profilePic = url;
            title = position;
        }
    }
}
