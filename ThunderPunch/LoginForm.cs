using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThunderPunch
{
    public partial class frmLogin : Form
    {
        private string Login;
        private Validation validator = new Validation();
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
            //if (!validator.FourDigits(Login)) lblStatus.Text = " Login must be four digits";
            //MessageBox.Show(Login);
            //lblMaskLogin.Text = "";
            //Login = "";

            //SqlConnection cs = new SqlConnection("Data Source=thunderpunch.cpdrk8ewqf7q.us-east-2.rds.amazonaws.com; Initial Catalog=thunderpunch; User Id=tdurk8; Password=hondacrx03;");
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.InsertCommand = new SqlCommand("INSERT INTO DropTable VALUES(@FName,@LName)", cs);
            //da.InsertCommand.Parameters.Add("@FName", SqlDbType.NVarChar).Value = "Fred";
            //da.InsertCommand.Parameters.Add("@LName", SqlDbType.NVarChar).Value = "Johnson";

            //cs.Open();
            //da.InsertCommand.ExecuteNonQuery();
            //cs.Close();

            SQL_Interact test = new SQL_Interact();
            lblStatus.Text=test.ValidLogin(Login);
            Login = "";
            lblMaskLogin.Text = "";
            
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
            lblStatus.Text = "";
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            MessageBox.Show(e.KeyChar.ToString());
            MessageBox.Show(Keys.D1.ToString());
        }
    }
}
