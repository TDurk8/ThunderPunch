using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThunderPunch
{
    public class SQL_Interact
    {
        SqlConnection cs;
        SqlDataAdapter da;
        SqlDataReader dr = null;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public SQL_Interact()
        {
            cs = new SqlConnection("Data Source=thunderpunch.cpdrk8ewqf7q.us-east-2.rds.amazonaws.com; Initial Catalog=thunderpunch; User Id=tdurk8; Password=hondacrx03;");
            da = new SqlDataAdapter();
        }

        public string ValidLogin(string Login)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE LoginID = @LoginID", cs);
            //command.Parameters.Add("@LoginID", SqlDbType.NVarChar, 6481);
            //da.SelectCommand = command;
            //MessageBox.Show(da.SelectCommand.CommandText);
            string status = "Invalid User";
            User user = new User();
            user = null;

            SqlCommand command = new SqlCommand("SELECT * from Employee", cs);

            cs.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["LoginID"].ToString() == Login)
                {
                    MessageBox.Show(dr["FName"].ToString());
                    status = "";
                    break;
                }
            }
            return status;
            cs.Close();
        }
    }
}
