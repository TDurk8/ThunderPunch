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
        Validation validator = new Validation();
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
                    g.FillRectangle(Brushes.SteelBlue, e.Bounds);
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
            foreach(State state in Enum.GetValues(typeof(State)))
            {
                cmboState.Items.Add(state);
            }
            cmboState.Sorted = true;
        }

        private void SetUserForm()
        {
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
        }
        public enum State
        {
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
            SetUserForm();
        }


        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                txtFName.Text = "  First";
                txtFName.ForeColor = System.Drawing.Color.DarkGray;
                txtFName.Font = new Font(txtFName.Font, FontStyle.Italic);
            }
            else if (!validator.IsAlpha(txtFName.Text)) MessageBox.Show("failure");
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            if(txtFName.Text == "  First")
            {
                txtFName.Text = "";
                txtFName.ForeColor = System.Drawing.Color.Black;
                txtFName.Font = new Font(txtFName.Font, FontStyle.Regular);
            }
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            if (txtLName.Text == "  Last")
            {
                txtLName.Text = "";
                txtLName.ForeColor = System.Drawing.Color.Black;
                txtLName.Font = new Font(txtLName.Font, FontStyle.Regular);
            }
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                txtLName.Text = "  Last";
                txtLName.ForeColor = System.Drawing.Color.DarkGray;
                txtLName.Font = new Font(txtFName.Font, FontStyle.Italic);
            }
            else if (!validator.IsAlpha(txtLName.Text)) MessageBox.Show("failure");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
           if (validator.IsEmail(txtEmail.Text)) MessageBox.Show("Valid");
            else MessageBox.Show("Invalid");
        }

        private void txtDayDOB_Leave(object sender, EventArgs e)
        {
            if (txtDayDOB.Text == "")
            {
                txtDayDOB.Text = "  Day";
                txtDayDOB.ForeColor = System.Drawing.Color.DarkGray;
                txtDayDOB.Font = new Font(txtDayDOB.Font, FontStyle.Italic);
            }
            else if (txtDayDOB.Text!="  Day" && txtYearDOB.Text!="  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text)) lblDOBError.Text = "Invalid DOB";
                else lblDOBError.Text = "";
            }
        }

        private void txtDayDOB_Enter(object sender, EventArgs e)
        {
            if (txtDayDOB.Text == "  Day")
            {
                txtDayDOB.Text = "";
                txtDayDOB.ForeColor = System.Drawing.Color.Black;
                txtDayDOB.Font = new Font(txtDayDOB.Font, FontStyle.Regular);
            }
        }

        private void txtYearDOB_Leave(object sender, EventArgs e)
        {
            if (txtYearDOB.Text == "")
            {
                txtYearDOB.Text = "  Year";
                txtYearDOB.ForeColor = System.Drawing.Color.DarkGray;
                txtYearDOB.Font = new Font(txtYearDOB.Font, FontStyle.Italic);
            }
            else if (txtDayDOB.Text != "  Day" && txtYearDOB.Text != "  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text)) lblDOBError.Text = "Invalid DOB";
                else lblDOBError.Text = "";
            }
        }

        private void txtYearDOB_Enter(object sender, EventArgs e)
        {
            if (txtYearDOB.Text == "  Year")
            {
                txtYearDOB.Text = "";
                txtYearDOB.ForeColor = System.Drawing.Color.Black;
                txtYearDOB.Font = new Font(txtYearDOB.Font, FontStyle.Regular);
            }
        }

        private void cmboDOBMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtDayDOB.Text != "  Day" && txtYearDOB.Text != "  Year" && cmboDOBMonth.SelectedIndex >= 0)
            {
                if (!validator.IsValidDay(cmboDOBMonth.SelectedIndex, txtDayDOB.Text, txtYearDOB.Text)) lblDOBError.Text="Invalid DOB";
                else lblDOBError.Text = "";
            }
        }
    }
}
