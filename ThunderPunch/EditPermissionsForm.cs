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
    public partial class EditPermissionsForm : Form
    {
        FormatText texter = new FormatText();
        Validation validator = new Validation();
        string originalPermission;
        public EditPermissionsForm()
        {
            InitializeComponent();
            SetupPermissionTypes();
            texter.TextBoxLeave(txtPermissionTitle, "Permission Level Name", lblPermissionError);
        }

        private void SetupPermissionTypes()
        {
            SQL_Interact sql = new SQL_Interact();
            foreach(String type in sql.SetAppPermissions())
            {
                cmbPermissionTypes.Items.Add(type);  
            }
            cmbPermissionTypes.Sorted = true;
            cmbPermissionTypes.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbPermissionTypes.SelectedIndex > -1)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Visible = true;
                btnCancel.Enabled = true;
                btnSave.Visible = true;
                cmbPermissionTypes.Enabled = false;
                grpPermissions.Enabled = true;
                txtPermissionTitle.Enabled = true;
                txtPermissionTitle.Text = cmbPermissionTypes.Text;
                txtPermissionTitle.SelectAll();
                txtPermissionTitle.Focus();
                originalPermission = txtPermissionTitle.Text;
                SQL_Interact sql = new SQL_Interact();
                Permissions perm = sql.GetPermissions(cmbPermissionTypes.Text);
                chkEditPermission.Checked = perm.EditPermissions;
                chkEditPunches.Checked = perm.EditPunches;
                chkEditSocialMedia.Checked = perm.EditSocialMedia;
                chkEditUserInfo.Checked = perm.EditUserInfo;
                chkViewReports.Checked = perm.ViewReports;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
            cmbPermissionTypes.Enabled = true;
            grpPermissions.Enabled = false;
            txtPermissionTitle.Enabled = false;
            txtPermissionTitle.Clear();
            cmbPermissionTypes.SelectedIndex = -1;
            texter.TextBoxLeave(txtPermissionTitle, "Permission Level Name", lblPermissionError);
            cmbPermissionTypes.Items.Clear();
            SetupPermissionTypes();

            foreach (Control ctrl in grpPermissions.Controls)
            {
                ((CheckBox)ctrl).Checked = false;
            }
        }

        private void cmbPermissionTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPermissionTypes.SelectedIndex > -1) btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            btnSave.Visible = true;
            cmbPermissionTypes.Enabled = false;
            grpPermissions.Enabled = true;
            txtPermissionTitle.Enabled = true;
            texter.TextBoxEnter(txtPermissionTitle, "Permission Level Name");
            txtPermissionTitle.Focus();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogbox = MessageBox.Show("Would you like to save current configurations?", "Save Permissions", MessageBoxButtons.YesNo);
            if (dialogbox== DialogResult.Yes)
            {
                SQL_Interact sql = new SQL_Interact();
                Permissions perm = new Permissions(originalPermission ,txtPermissionTitle.Text);

                //if check set to true. By default, when Permission object is created all values are set
                //to false by the constructor.
                if (chkEditPermission.Checked) perm.EditPermissions = true;
                if (chkEditPunches.Checked) perm.EditPunches = true;
                if (chkEditSocialMedia.Checked) perm.EditSocialMedia = true;
                if (chkEditUserInfo.Checked) perm.EditUserInfo = true;
                if (chkViewReports.Checked) perm.ViewReports = true;
                sql.UpdateAppPermissions(perm);
                btnCancel.PerformClick();
            }
        }

        private void txtPermissionTitle_Leave(object sender, EventArgs e)
        {

            texter.TextBoxLeave(txtPermissionTitle, "", lblPermissionError);
            if (!validator.IsAlpha(txtPermissionTitle.Text))
            {
                lblPermissionError.Text = "Invalid Name";
                txtPermissionTitle.Focus();
            }
            else
            {
                
            }
        }

        //take the currently selected text in the combobox and add to temp string
        //format the permission text box to be legible black font
        //reinsert the text.
        private void txtPermissionTitle_Enter(object sender, EventArgs e)
        {
            string temp = cmbPermissionTypes.Text;
            texter.TextBoxEnter(txtPermissionTitle, temp);
            txtPermissionTitle.Text = temp;
        }
    }
}
