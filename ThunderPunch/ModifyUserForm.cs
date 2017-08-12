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
    public partial class ModifyUserForm : Form
    {
        //setup objects for validation and format
        private Validation validator = new Validation();
        private FormatText textFormater = new FormatText();
        
        public ModifyUserForm()
        {
            InitializeComponent();
            tbctrlUser.DrawItem += new DrawItemEventHandler(tbctrlUser_DrawItem);
            SetStateList();
            SetUserForm();
        }

        private void tbctrlUser_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tbctrlUser.TabPages[e.Index];
            Rectangle _tabBounds = tbctrlUser.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
                {

                    // Draw a different background color, and don't paint a focus rectangle.
                    _textBrush = new SolidBrush(Color.White);
                    g.FillRectangle(Brushes.Gray, e.Bounds);
                }
            else
                {
                    _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.DarkSlateGray, e.Bounds);
                    //e.DrawBackground();
                }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)16.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
            
        }


        private void SetStateList()
        {
            cmboState.Items.Clear();
            foreach(State state in Enum.GetValues(typeof(State)))
            {
                cmboState.Items.Add(state);
            }
            cmboState.Sorted = true;
        }

        private void SetUserForm()
        {
            //properly setup form for new user
            SetStateList();
            txtFName.Text="  First";
            txtLName.Text = "  Last";
            txtEmail.Clear();
            cmboDOBMonth.SelectedIndex = -1;
            txtDayDOB.Text = "  Day";
            txtYearDOB.Text = "  Year";
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cmboState.SelectedIndex = -1;
            lblDOBError.Text = "";
            lblNameError.Text = "";
            lblEmailError.Text = "";
            lblPhoneError.Text = "";
            lblZipError.Text = "";
            txtZipcode.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            cmboState.SelectedIndex = -1;
            txtFName.ForeColor = Color.DarkGray;
            txtFName.Font = new Font(txtFName.Font, FontStyle.Italic);
            txtLName.ForeColor = System.Drawing.Color.DarkGray;
            txtLName.Font = new Font(txtFName.Font, FontStyle.Italic);
            txtDayDOB.ForeColor = System.Drawing.Color.DarkGray;
            txtDayDOB.Font = new Font(txtDayDOB.Font, FontStyle.Italic);
            txtYearDOB.ForeColor = System.Drawing.Color.DarkGray;
            txtYearDOB.Font = new Font(txtYearDOB.Font, FontStyle.Italic);
            lblLoginError.Text = "";
            txtLogin.Clear();
            lblDateHiredError.Text = "";
            txtYearHired.Text="  Year";
            txtDayHired.Text="  Day";
            cmbDateHired.SelectedIndex = -1;
        }
        public enum State
        {
            //State Combobox
            [Description("Alabama")]
            AL,

            [Description("Alaska")]
            AK,

            [Description("Arkansas")]
            AR,

            [Description("Arizona")]
            AZ,

            [Description("California")]
            CA,

            [Description("Colorado")]
            CO,

            [Description("Connecticut")]
            CT,

            [Description("D.C.")]
            DC,

            [Description("Delaware")]
            DE,

            [Description("Florida")]
            FL,

            [Description("Georgia")]
            GA,

            [Description("Hawaii")]
            HI,

            [Description("Iowa")]
            IA,

            [Description("Idaho")]
            ID,

            [Description("Illinois")]
            IL,

            [Description("Indiana")]
            IN,

            [Description("Kansas")]
            KS,

            [Description("Kentucky")]
            KY,

            [Description("Louisiana")]
            LA,

            [Description("Massachusetts")]
            MA,

            [Description("Maryland")]
            MD,

            [Description("Maine")]
            ME,

            [Description("Michigan")]
            MI,

            [Description("Minnesota")]
            MN,

            [Description("Missouri")]
            MO,

            [Description("Mississippi")]
            MS,

            [Description("Montana")]
            MT,

            [Description("North Carolina")]
            NC,

            [Description("North Dakota")]
            ND,

            [Description("Nebraska")]
            NE,

            [Description("New Hampshire")]
            NH,

            [Description("New Jersey")]
            NJ,

            [Description("New Mexico")]
            NM,

            [Description("Nevada")]
            NV,

            [Description("New York")]
            NY,

            [Description("Oklahoma")]
            OK,

            [Description("Ohio")]
            OH,

            [Description("Oregon")]
            OR,

            [Description("Pennsylvania")]
            PA,

            [Description("Rhode Island")]
            RI,

            [Description("South Carolina")]
            SC,

            [Description("South Dakota")]
            SD,

            [Description("Tennessee")]
            TN,

            [Description("Texas")]
            TX,

            [Description("Utah")]
            UT,

            [Description("Virginia")]
            VA,

            [Description("Vermont")]
            VT,

            [Description("Washington")]
            WA,

            [Description("Wisconsin")]
            WI,

            [Description("West Virginia")]
            WV,

            [Description("Wyoming")]
            WY
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear form for new user
            SetUserForm();
        }


        private void txtFName_Leave(object sender, EventArgs e)
        {
            txtFName.Text= txtFName.Text.Trim();
            if (txtFName.Text == "")
            {
                txtFName.Text = "  First";
                txtFName.ForeColor = Color.DarkGray;
                txtFName.Font = new Font(txtFName.Font, FontStyle.Italic);
            }
            else if (!validator.IsAlpha(txtFName.Text))
            {
                lblNameError.Text = "Invalid Name";
                txtFName.Focus();
            }
            else
            {
                lblNameError.Text = "";
                txtFName.Text = textFormater.ProperName(txtFName.Text);
            }
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            //if(txtFName.Text == "  First")
            //{
            //    txtFName.Text = "";
            //    txtFName.ForeColor = System.Drawing.Color.Black;
            //    txtFName.Font = new Font(txtFName.Font, FontStyle.Regular);
            //}
            textFormater.TextBoxEnter(txtFName, "  First");
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            //if (txtLName.Text == "  Last")
            //{
            //    txtLName.Text = "";
            //    txtLName.ForeColor = System.Drawing.Color.Black;
            //    txtLName.Font = new Font(txtLName.Font, FontStyle.Regular);
            //}
            textFormater.TextBoxEnter(txtLName, "  Last");
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            txtLName.Text = txtLName.Text.Trim();
            if (txtLName.Text == "")
            {
                txtLName.Text = "  Last";
                txtLName.ForeColor = System.Drawing.Color.DarkGray;
                txtLName.Font = new Font(txtFName.Font, FontStyle.Italic);
            }
            else if (!validator.IsAlpha(txtLName.Text))
            {
                lblNameError.Text = "Invalid Name";
                txtLName.Focus();
            }
            else
            {
                lblNameError.Text = "";
                txtLName.Text = textFormater.ProperName(txtLName.Text);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmail.Text.Trim();
            if (!validator.IsEmail(txtEmail.Text.Trim()) && txtEmail.Text.Trim()!= "")
            {
                lblEmailError.Text = "Invalid Email";
                txtEmail.Focus();
            }
            else
            {
                lblEmailError.Text = "";
            }
        }

        private void txtDayDOB_Leave(object sender, EventArgs e)
        {
            txtDayDOB.Text = txtDayDOB.Text.Trim();
            if (txtDayDOB.Text == "")
            {
                txtDayDOB.Text = "  Day";
                txtDayDOB.ForeColor = System.Drawing.Color.DarkGray;
                txtDayDOB.Font = new Font(txtDayDOB.Font, FontStyle.Italic);
            }
            else if (txtDayDOB.Text!="  Day" && txtYearDOB.Text!="  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text))
                {
                    lblDOBError.Text = "Invalid DOB";
                }
                else lblDOBError.Text = "";
            }
        }

        private void txtDayDOB_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtDayDOB, "  Day");
        }

        private void txtYearDOB_Leave(object sender, EventArgs e)
        {
            txtYearDOB.Text = txtYearDOB.Text.Trim();
            if (txtYearDOB.Text == "")
            {
                txtYearDOB.Text = "  Year";
                txtYearDOB.ForeColor = System.Drawing.Color.DarkGray;
                txtYearDOB.Font = new Font(txtYearDOB.Font, FontStyle.Italic);
            }
            else if (txtDayDOB.Text != "  Day" && txtYearDOB.Text != "  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text))
                {
                    lblDOBError.Text = "Invalid DOB";
                }
                else lblDOBError.Text = "";
            }
        }

        private void txtYearDOB_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtYearDOB, "  Year");
        }

        private void cmboDOBMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDOBError.Text = "";
            if (txtDayDOB.Text != "  Day" && txtYearDOB.Text != "  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text)) lblDOBError.Text="Invalid DOB";
                else lblDOBError.Text = "";
            }
        }

        private void txtZipcode_Leave(object sender, EventArgs e)
        {
            if (!validator.IsZip(txtZipcode.Text)&& txtZipcode.Text!="")
            {
                lblZipError.Text = "Invalid Zip";
                txtZipcode.Focus();
            }
            else
            {
                lblZipError.Text = "";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void txtZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }


        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text.Count() == 10)
            {
                txtPhone.Text = textFormater.Phone(txtPhone.Text);
                lblPhoneError.Text = "";
            }
            else if (txtPhone.Text != "")
            {
                lblPhoneError.Text = "Invalid Phone Number";
                txtPhone.Focus();
            }
        }
        //verify that there is a nonnumber pressed 
        //then check to see if a special character like a '!' was pressed
        //by checking if it is not an integer and not the backspace.
        private void txtDayDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar !=(char)Keys.Back) e.Handled = true;
        }

        private void txtYearDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            //if phone number is in text box already, remove formatting
            string phone = txtPhone.Text;
            textFormater.TextBoxEnter(txtPhone,"");
            if (phone.Count() == 13 && phone.Substring(0, 1) == "(" && phone.Substring(4, 1) == ")" && phone.Substring(8, 1) == "-")
            {
                txtPhone.Clear();
                foreach (char c in phone)
                {
                    if (char.IsDigit(c)) txtPhone.Text += c.ToString();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // verify first that login is 4 digits
            // check to see if Attempted Login Id Exists in DB already
            if (validator.FourDigits(txtLogin.Text))
            {
                SQL_Interact sql = new SQL_Interact();
                if (sql.ValidLogin(txtLogin.Text) != null) lblLoginError.Text = "Login Taken";
                else
                {
                    lblLoginError.Text = "Login Available!";

                }
            }
            else
            {
                lblLoginError.Text = "Must be 4 Digits";
            }
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            //clear exist error if there, then get a four digit number
            lblLoginError.Text = "";
            SQL_Interact sql = new SQL_Interact();
            string login = RandomLogin();
            if (sql.ValidLogin(login) != null) btnRandom.PerformClick();
            else txtLogin.Text = login;
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtLogin, "");
            this.AcceptButton = btnCheck;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private string RandomLogin()
        {
            //number between 0000 and 9999
            // find the four digit number, flesh it out with '0' if single, double, or triple digits
            int min=0;
            int max=9999;
            Random rdm = new Random();
            return (rdm.Next(min, max)).ToString().PadLeft(4,'0');            
        }

        private void grpPersonalInfo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnClear;
        }

        private void grpCompanyRole_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnCheck;
        }

        private void txtDayHired_Leave(object sender, EventArgs e)
        {
            HireDateLeave(txtDayHired,"  Day");
        }

        private void txtYearHired_Leave(object sender, EventArgs e)
        {
            HireDateLeave(txtYearHired, "  Year");
        }

        private void txtDayHired_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtDayHired, "  Day");
        }

        private void txtYearHired_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtYearHired, "  Year");
        }


        private void HireDateLeave(TextBox tb, string type)
        {
            lblDateHiredError.Text = "";
            tb.Text = tb.Text.Trim();
            if (tb.Text == "")
            {
                tb.Text = type;
                tb.ForeColor = System.Drawing.Color.DarkGray;
                tb.Font = new Font(tb.Font, FontStyle.Italic);
            }
            else if (txtDayHired.Text != "  Day" && txtYearHired.Text != "  Year" && cmbDateHired.SelectedIndex >= 0)
            {
                if (validator.IsValidHireDate(cmbDateHired.SelectedIndex, txtDayHired.Text, txtYearHired.Text))
                {
                    lblDateHiredError.Text = "Future Date";
                }
                else lblDOBError.Text = "";
            }
        }

        private void TextBoxEnter(TextBox tb, string type)
        {
            if (tb.Text == type)
            {
                tb.Text = "";
                tb.ForeColor = System.Drawing.Color.Black;
                tb.Font = new Font(tb.Font, FontStyle.Regular);
            }
            else
            {
                tb.SelectAll();
            }
        }
        private void TextBoxLeave(TextBox tb, string type)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtEmail, "");
        }

        private void txtAddress1_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtAddress1, "");
        }

        private void txtAddress2_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtAddress2, "");
        }

        private void txtCity_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtCity, "");
        }

        private void txtZipcode_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtZipcode, "");
        }
    }        
}
