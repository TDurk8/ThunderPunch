using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;


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

        public User ValidLogin(string Login)
        {
            User user = null;

            SqlCommand command = new SqlCommand("SELECT * from Employee", cs);
            if (DB_Status())
            {
                cs.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["LoginID"].ToString() == Login)
                    {
                        user = new User(dr["FName"].ToString(), dr["LName"].ToString(), dr["LoginID"].ToString(), dr["Title"].ToString(), dr["EmployeePhoto"].ToString());
                        break;
                    }
                }
                cs.Close();
            }
            return user;
        }

        public bool DB_Status()
        {
            
            try
            {
                
                cs.Open();
                cs.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }   
    }
}
