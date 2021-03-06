﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace ThunderPunch
{
    public partial class frmLogin : Form
    {
        private string Login;
        private Validation validator = new Validation();
        

        public frmLogin()
        {
            
            InitializeComponent();
           //timerTime.Start();
           //tmrTimeout.Start();
            ResetGUI();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DigitInput("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            DigitInput("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            DigitInput("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            DigitInput("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            DigitInput("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            DigitInput("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            DigitInput("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            DigitInput("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            DigitInput("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            DigitInput("0");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            resetLastUser();
            //Create User to store return found in database
            User loginUser;
            
            //Create object for class SQL_Interact to connect to database and read data
            //also sends the current login from the user.
            SQL_Interact test = new SQL_Interact();
            loginUser=test.ValidLogin(Login);
            
            //reset interface
            ResetLoginForm();

            if (loginUser != null)
            {
                pbProfilePic.ImageLocation = loginUser.profilePic + ".jpg";
                lblFName.Text= loginUser.fName;
                lblLName.Text= loginUser.lName;
                lblTitle.Text=loginUser.title;
                
            }
            else
            {
                lblStatus.Text = "Invalid User";
            }
            DisplayConnectionStatus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetLastUser();
            ResetLoginForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitInput(string digit)
        {
            Login += digit;
            lblMaskLogin.Text += '*';
            lblStatus.Text = "";
            resetLastUser();
            //Reset Timeout Timer
            tmrTimeout.Stop();
            tmrTimeout.Start();
            DisplayConnectionStatus();
        }

        public void DisplayConnectionStatus()
        {
            SQL_Interact status = new SQL_Interact();
            if (status.DB_Status())
            {
                pbNetworkStatus.Image = Properties.Resources.greencircle;
                lblNetworkStatus.Text = "Connected";
            }
            else
            {
                pbNetworkStatus.Image = Properties.Resources.redcircle;
                lblNetworkStatus.Text = "Unable to connect to database";
            }
            pbNetworkStatus.Refresh();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Cleanup GUI and check database connection
            resetLastUser();
            DisplayConnectionStatus();

            //only allow keystrokes that are digits.
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) DigitInput((e.KeyValue - 48).ToString());
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) DigitInput((e.KeyValue-96).ToString());
            
            //delete last entered digit if user hits backspace
            if (e.KeyValue == 8)
            {
                if (Login.Count() > 0)
                {
                    lblMaskLogin.Text = lblMaskLogin.Text.Substring(0, lblMaskLogin.Text.Count() - 1);
                    Login = Login.Substring(0, Login.Count() - 1);
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ModifyUserForm userform = new ModifyUserForm();
            userform.Show();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dateAndTime = DateTime.Now;
            this.lblCurrentTime.Text = dateAndTime.ToString();
        }

        public void ResetGUI()
        {
            ResetLoginForm();
            resetLastUser();
            btnOK.Focus();
        }

        public void ResetLoginForm()
        {
            lblStatus.Text = "";
            lblMaskLogin.Text = "";
            Login = "";
        }

        public void resetLastUser()
        {
            lblFName.Text = "";
            lblLName.Text = "";
            lblTitle.Text = "";
            pbProfilePic.Image = null;
        }

        private void tmrTimeout_Tick(object sender, EventArgs e)
        {
            ResetGUI();
        }
    }
}
