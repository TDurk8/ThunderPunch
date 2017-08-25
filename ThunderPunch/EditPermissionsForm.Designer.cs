namespace ThunderPunch
{
    partial class EditPermissionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPermissionTypes = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPermissionTitle = new System.Windows.Forms.TextBox();
            this.grpPermissions = new System.Windows.Forms.GroupBox();
            this.chkEditPunches = new System.Windows.Forms.CheckBox();
            this.chkViewReports = new System.Windows.Forms.CheckBox();
            this.chkEditSocialMedia = new System.Windows.Forms.CheckBox();
            this.chkEditUserInfo = new System.Windows.Forms.CheckBox();
            this.chkEditPermission = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPermissionError = new System.Windows.Forms.Label();
            this.grpPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPermissionTypes
            // 
            this.cmbPermissionTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermissionTypes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPermissionTypes.FormattingEnabled = true;
            this.cmbPermissionTypes.Location = new System.Drawing.Point(28, 20);
            this.cmbPermissionTypes.Name = "cmbPermissionTypes";
            this.cmbPermissionTypes.Size = new System.Drawing.Size(181, 28);
            this.cmbPermissionTypes.TabIndex = 0;
            this.cmbPermissionTypes.SelectionChangeCommitted += new System.EventHandler(this.cmbPermissionTypes_SelectionChangeCommitted);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(212, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(263, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPermissionTitle
            // 
            this.txtPermissionTitle.Enabled = false;
            this.txtPermissionTitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermissionTitle.Location = new System.Drawing.Point(28, 62);
            this.txtPermissionTitle.Name = "txtPermissionTitle";
            this.txtPermissionTitle.Size = new System.Drawing.Size(181, 26);
            this.txtPermissionTitle.TabIndex = 5;
            this.txtPermissionTitle.Enter += new System.EventHandler(this.txtPermissionTitle_Enter);
            this.txtPermissionTitle.Leave += new System.EventHandler(this.txtPermissionTitle_Leave);
            // 
            // grpPermissions
            // 
            this.grpPermissions.Controls.Add(this.chkEditPunches);
            this.grpPermissions.Controls.Add(this.chkViewReports);
            this.grpPermissions.Controls.Add(this.chkEditSocialMedia);
            this.grpPermissions.Controls.Add(this.chkEditUserInfo);
            this.grpPermissions.Controls.Add(this.chkEditPermission);
            this.grpPermissions.Enabled = false;
            this.grpPermissions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPermissions.ForeColor = System.Drawing.Color.PaleGreen;
            this.grpPermissions.Location = new System.Drawing.Point(28, 102);
            this.grpPermissions.Name = "grpPermissions";
            this.grpPermissions.Size = new System.Drawing.Size(281, 116);
            this.grpPermissions.TabIndex = 14;
            this.grpPermissions.TabStop = false;
            this.grpPermissions.Text = "Set Permissions";
            // 
            // chkEditPunches
            // 
            this.chkEditPunches.AutoSize = true;
            this.chkEditPunches.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditPunches.ForeColor = System.Drawing.SystemColors.Control;
            this.chkEditPunches.Location = new System.Drawing.Point(5, 82);
            this.chkEditPunches.Name = "chkEditPunches";
            this.chkEditPunches.Size = new System.Drawing.Size(107, 24);
            this.chkEditPunches.TabIndex = 10;
            this.chkEditPunches.Text = "Edit Punches";
            this.chkEditPunches.UseVisualStyleBackColor = true;
            // 
            // chkViewReports
            // 
            this.chkViewReports.AutoSize = true;
            this.chkViewReports.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkViewReports.ForeColor = System.Drawing.SystemColors.Control;
            this.chkViewReports.Location = new System.Drawing.Point(5, 52);
            this.chkViewReports.Name = "chkViewReports";
            this.chkViewReports.Size = new System.Drawing.Size(108, 24);
            this.chkViewReports.TabIndex = 8;
            this.chkViewReports.Text = "View Reports";
            this.chkViewReports.UseVisualStyleBackColor = true;
            // 
            // chkEditSocialMedia
            // 
            this.chkEditSocialMedia.AutoSize = true;
            this.chkEditSocialMedia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditSocialMedia.ForeColor = System.Drawing.SystemColors.Control;
            this.chkEditSocialMedia.Location = new System.Drawing.Point(143, 52);
            this.chkEditSocialMedia.Name = "chkEditSocialMedia";
            this.chkEditSocialMedia.Size = new System.Drawing.Size(133, 24);
            this.chkEditSocialMedia.TabIndex = 14;
            this.chkEditSocialMedia.Text = "Edit Social Media";
            this.chkEditSocialMedia.UseVisualStyleBackColor = true;
            // 
            // chkEditUserInfo
            // 
            this.chkEditUserInfo.AutoSize = true;
            this.chkEditUserInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditUserInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.chkEditUserInfo.Location = new System.Drawing.Point(143, 22);
            this.chkEditUserInfo.Name = "chkEditUserInfo";
            this.chkEditUserInfo.Size = new System.Drawing.Size(108, 24);
            this.chkEditUserInfo.TabIndex = 12;
            this.chkEditUserInfo.Text = "Edit User Info";
            this.chkEditUserInfo.UseVisualStyleBackColor = true;
            // 
            // chkEditPermission
            // 
            this.chkEditPermission.AutoSize = true;
            this.chkEditPermission.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditPermission.ForeColor = System.Drawing.SystemColors.Control;
            this.chkEditPermission.Location = new System.Drawing.Point(5, 22);
            this.chkEditPermission.Name = "chkEditPermission";
            this.chkEditPermission.Size = new System.Drawing.Size(129, 24);
            this.chkEditPermission.TabIndex = 6;
            this.chkEditPermission.Text = "Edit Permissions";
            this.chkEditPermission.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(87, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(168, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPermissionError
            // 
            this.lblPermissionError.AutoSize = true;
            this.lblPermissionError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPermissionError.Location = new System.Drawing.Point(215, 65);
            this.lblPermissionError.Name = "lblPermissionError";
            this.lblPermissionError.Size = new System.Drawing.Size(86, 20);
            this.lblPermissionError.TabIndex = 8;
            this.lblPermissionError.Text = "Invalid Name";
            // 
            // EditPermissionsForm
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(340, 277);
            this.Controls.Add(this.lblPermissionError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpPermissions);
            this.Controls.Add(this.txtPermissionTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbPermissionTypes);
            this.Name = "EditPermissionsForm";
            this.Text = "Edit App Permissions";
            this.grpPermissions.ResumeLayout(false);
            this.grpPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPermissionTypes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPermissionTitle;
        private System.Windows.Forms.GroupBox grpPermissions;
        private System.Windows.Forms.CheckBox chkEditPunches;
        private System.Windows.Forms.CheckBox chkViewReports;
        private System.Windows.Forms.CheckBox chkEditSocialMedia;
        private System.Windows.Forms.CheckBox chkEditUserInfo;
        private System.Windows.Forms.CheckBox chkEditPermission;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPermissionError;
    }
}