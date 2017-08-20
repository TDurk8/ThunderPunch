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
        public EditPermissionsForm()
        {
            InitializeComponent();
            SetupPermissionTypes();
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
                cmbPermissionTypes.Enabled = false;
                grpPermissions.Enabled = true;
                txtPermissionTitle.Enabled = true;
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Visible = false;
            cmbPermissionTypes.Enabled = true;
            grpPermissions.Enabled = false;
            txtPermissionTitle.Enabled = false;
            txtPermissionTitle.Clear();
        }
    }
}
