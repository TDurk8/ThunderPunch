using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlickrNet;
using System.Drawing.Drawing2D;


namespace ThunderPunch
{
    public partial class ModifyUserForm : Form
    {
        //setup objects for validation and format
        private Validation validator = new Validation();
        private FormatText textFormater = new FormatText();
        
        #region Setup Form
        public ModifyUserForm()
        {
            InitializeComponent();
            tbctrlUser.DrawItem += new DrawItemEventHandler(tbctrlUser_DrawItem);
            
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
                    _textBrush = new SolidBrush(Color.PaleGreen);
                    g.FillRectangle(Brushes.Gray, e.Bounds);

                }
            else
                {
                    _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
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

        private void DrawBorder(Control con, Color color, int width)
        {
            ControlPaint.DrawBorder(con.CreateGraphics(),
                con.ClientRectangle,
                color,
                width,
                ButtonBorderStyle.Solid,
                color,
                width,
                ButtonBorderStyle.Solid,
                color,
                width,
                ButtonBorderStyle.Solid,
                color,
                width,
                ButtonBorderStyle.Solid);
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

        private void SetDepartment()
        {
            //Clear existing data and rerun the query to select Departments
            cmbDept.Items.Clear();
            SQL_Interact sql = new SQL_Interact();
            foreach (String dept in sql.SetDepartments())
            {
                cmbDept.Items.Add(dept);
            }
        }

        private void SetEmployment()
        {
            //clear existing data and set the employment types
            cmbEmployment.Items.Clear();
            SQL_Interact sql = new SQL_Interact();
            foreach (String type in sql.SetEmploymentTypes())
            {
                cmbEmployment.Items.Add(type);
            }
        }

        private void SetPermissionApp()
        {
            //clear existing data and set the Permission Types
            cmbAppPermission.Items.Clear();
            SQL_Interact sql = new SQL_Interact();
            foreach(String type in sql.SetAppPermissions())
            {
                cmbAppPermission.Items.Add(type);
            }
            cmbAppPermission.Sorted = true;
            cmbAppPermission.SelectedIndex = -1;
        }

        private void cmbDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SQL_Interact sql = new SQL_Interact();
            List<string> positions = new List<string>();
            cmbPosition.Enabled = true;
            cmbPosition.Items.Clear();
            positions = sql.SetPositions(sql.GetDeptID(cmbDept.SelectedItem.ToString()));

            foreach(string position in positions)
            {
                cmbPosition.Items.Add(position);
            }
        }

        private void SetUserForm()
        {
            //properly setup form for new user
            SetStateList();
            SetEmployment();
            SetDepartment();
            SetPermissionApp();
            cmbDept.Sorted=true;

            txtFName.Text="First";
            txtLName.Text = "Last";
            txtEmail.Clear();
            cmboDOBMonth.SelectedIndex = -1;
            txtDayDOB.Text = "Day";
            txtYearDOB.Text = "Year";
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
            txtDayHired.Font = new Font(txtYearDOB.Font, FontStyle.Italic);
            txtYearHired.Font = new Font(txtYearDOB.Font, FontStyle.Italic);
            txtYearHired.ForeColor = System.Drawing.Color.DarkGray;
            txtDayHired.ForeColor = System.Drawing.Color.DarkGray;
            lblLoginError.Text = "";
            txtLogin.Clear();
            lblDateHiredError.Text = "";
            txtYearHired.Text="Year";
            txtDayHired.Text="Day";
            cmbDateHired.SelectedIndex = -1;
            cmbPosition.Items.Clear();
            cmbDept.SelectedIndex = -1;
            cmbPosition.Enabled = false;
            txtWages.Clear();
            lblWageError.Text = "";
            txtWages.Text = "";
            cmbWages.SelectedIndex = 0;
            lblWageType.Text = "/ hour";

            
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
        #endregion
        
        #region Group Personal Info
        private void txtFName_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtFName, "First", lblNameError);
            if (!validator.IsAlpha(txtFName.Text))
            {
                lblNameError.Text = "Invalid Name";
                txtFName.Focus();
            }
            else txtFName.Text = textFormater.ProperName(txtFName.Text);
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtFName, "First");
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtLName, "Last");
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtLName, "Last", lblNameError);
            if (!validator.IsAlpha(txtLName.Text))
            {
                lblNameError.Text = "Invalid Name";
                txtLName.Focus();
            }
            else
            {
                txtLName.Text = textFormater.ProperName(txtLName.Text);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtEmail, "", lblEmailError);
            if (!validator.IsEmail(txtEmail.Text.Trim()) && txtEmail.Text.Trim() != "")
            {
                lblEmailError.Text = "Invalid Email";
                txtEmail.Focus();
            }
        }

        private void txtDayDOB_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtDayDOB, "Day", lblDOBError);
        }

        private void txtDayDOB_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtDayDOB, "Day");
        }

        private void txtYearDOB_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtYearDOB, "Year", lblDOBError);
            validator.IsValidDOB(cmboDOBMonth.SelectedIndex + 1, txtDayDOB.Text, txtYearDOB.Text, lblDOBError);
        }

        private void txtYearDOB_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtYearDOB, "Year");
        }

        private void cmboDOBMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDOBError.Text = "";
            validator.IsValidDOB(cmboDOBMonth.SelectedIndex + 1, txtDayDOB.Text, txtYearDOB.Text, lblDOBError);
        }

        private void txtZipcode_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtZipcode, "", lblZipError);
            if (!validator.IsZip(txtZipcode.Text) && txtZipcode.Text != "")
            {
                lblZipError.Text = "Invalid Zip";
                txtZipcode.Focus();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.DigitOnly(e);
        }

        private void txtZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.DigitOnly(e);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtPhone, "", lblPhoneError);
            if (txtPhone.Text.Count() == 10)
            {
                txtPhone.Text = textFormater.Phone(txtPhone.Text);
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
            e.Handled = validator.DigitOnly(e);
        }

        private void txtYearDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.DigitOnly(e);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            ////if phone number is in text box already, remove formatting
            txtPhone.Text = textFormater.RemoveFormat(txtPhone.Text);
            textFormater.TextBoxEnter(txtPhone, "");
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
        #endregion

        #region Group Company Role
        private void grpCompanyRole_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnCheck;
        }
        private void txtDayHired_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtDayHired, "Day", lblDateHiredError);
            HireDateLeave();
        }

        private void txtYearHired_Leave(object sender, EventArgs e)
        {
            textFormater.TextBoxLeave(txtYearHired, "Year", lblDateHiredError);
            HireDateLeave();
        }

        private void txtDayHired_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtDayHired, "Day");
        }

        private void txtYearHired_Enter(object sender, EventArgs e)
        {
            textFormater.TextBoxEnter(txtYearHired, "Year");
        }

        private void HireDateLeave()
        {
            if (txtDayHired.Text != "Day" && txtYearHired.Text != "Year" && cmbDateHired.SelectedIndex >= 0)
            {
                if (validator.IsValidHireDate(cmbDateHired.SelectedIndex, txtDayHired.Text, txtYearHired.Text))
                {
                    lblDateHiredError.Text = "Future Date";
                }
            }
        }
        private void txtDayHired_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.DigitOnly(e);
        }

        private void txtYearHired_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.DigitOnly(e);
        }

        private void txtWages_Leave(object sender, EventArgs e)
        {
            if (!validator.WageSalaryCheck(txtWages.Text, cmbWages, lblWageError))
            {
                txtWages.SelectAll();
            }
            txtWages.Text = textFormater.CurrencyFormat(txtWages.Text, cmbWages);
        }

        private void txtWages_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validator.CurrencyDigitsOnly(e);
        }

        private void txtWages_Enter(object sender, EventArgs e)
        {
            txtWages.Text = textFormater.RemoveCurrencyFormat(txtWages.Text);
        }

        private void cmbWages_TextChanged(object sender, EventArgs e)
        {
            txtWages.Clear();
            if (cmbWages.Text == "Hourly") lblWageType.Text = "/ hour";
            else lblWageType.Text = "/ year";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // verify first that login is 4 digits
            // check to see if Attempted Login Id Exists in DB already

            lblLoginError.ForeColor = System.Drawing.Color.DarkRed;
            if (validator.FourDigits(txtLogin.Text))
            {
                SQL_Interact sql = new SQL_Interact();
                if (sql.ValidLogin(txtLogin.Text) != null)
                {
                    lblLoginError.Text = "Login Taken";
                    txtLogin.Focus();
                }
                else
                {
                    lblLoginError.ForeColor = System.Drawing.Color.PaleGreen;
                    lblLoginError.Text = "Login Available!";
                }
            }
            else
            {
                lblLoginError.Text = "Must be 4 Digits";
                txtLogin.Focus();
            }
            txtLogin.SelectAll();
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
            e.Handled = validator.DigitOnly(e);
        }

        private string RandomLogin()
        {
            //number between 0000 and 9999
            // find the four digit number, flesh it out with '0' if single, double, or triple digits
            int min = 0;
            int max = 9999;
            Random rdm = new Random();
            return (rdm.Next(min, max)).ToString().PadLeft(4, '0');
        }

        private void grpPersonalInfo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnClear;
        }
        #endregion

        #region Main Form Controls
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear form for new user
            SetUserForm();
        }
        #endregion

        private void pbPermissionInfo_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pbPermissionInfo, "Sets permissions within the application\n and handles accessible information for user.");
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }
    }        
}
