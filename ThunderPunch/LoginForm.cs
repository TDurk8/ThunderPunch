using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderPunch
{
    public partial class frmLogin : Form
    {
        private string Login;

        public string Login1 { get => Login; set => Login = value; }

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

        private void btn0_Click(object sender, EventArgs e)
        {
            DigitInput("0");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login);
            lblMaskLogin.Text = "";
            Login = "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DigitInput("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Login = "";
            lblMaskLogin.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitInput(string digit)
        {
            Login += digit;
            lblMaskLogin.Text += '*';
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
