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
        SqlConnection cs;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        private User()
        {
            cs = new SqlConnection("Data Source=thunderpunch.cpdrk8ewqf7q.us-east-2.rds.amazonaws.com; Initial Catalog=thunderpunch; User Id=tdurk8; Password=hondacrx03;");
            da = new SqlDataAdapter();
        }

        private bool ValidLogin(string Login)
        {
            cs.

            
        }
    }
}
