﻿using System;
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
                        user = new User(dr["FName"].ToString(), dr["LName"].ToString(), dr["LoginID"].ToString(), dr["PositionID"].ToString(), dr["EmployeePhoto"].ToString());
                        break;
                    }
                }
                cs.Close();
            }
            return user;
        }

        //set Departments into the dropdown menu from the Database
        public List<string> SetDepartments()
        {
            var retList = new List<string>();
            SqlCommand command = new SqlCommand("SELECT Department FROM DEPARTMENT", cs);
            try
            {
                cs.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    retList.Add(dr["Department"].ToString());
                }
                cs.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retList;
        }

        //set Employment Types into dropdown menu from the Database
        public List<string> SetEmploymentTypes()
        {
            var retList = new List<string>();
            SqlCommand command = new SqlCommand("SELECT EmploymentType FROM EmploymentType",cs);
            try
            {
                cs.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    retList.Add(dr["EmploymentType"].ToString());
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retList;
        }

        //return DepartmentID of currently selected Department
        public int GetDeptID(string dept)
        {
            Int32 returnDeptID = -1;
            SqlCommand command = new SqlCommand("Select DepartmentID FROM Department Where Department = @dept", cs);
            command.Parameters.Add("@dept", SqlDbType.VarChar);
            command.Parameters["@dept"].Value = dept;
            try
            {
                cs.Open();
                returnDeptID = (Int32)command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cs.Close();
            return returnDeptID;
        }

        //Add all positions open in the department selected by passing the DeptID
        public List<string> SetPositions(int DeptID)
        {
            var retList = new List<string>();
            SqlCommand command = new SqlCommand("SELECT Position FROM Position WHERE DepartmentID = @DeptID", cs);
            command.Parameters.Add("@DeptID", SqlDbType.Int);
            command.Parameters["@DeptID"].Value = DeptID;
            try
            {
                cs.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    retList.Add(dr["Position"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retList;
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
