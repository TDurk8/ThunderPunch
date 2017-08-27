namespace ThunderPunch
{
    partial class ModifyUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUserForm));
            this.tbctrlUser = new System.Windows.Forms.TabControl();
            this.tabUserPersonalInfo = new System.Windows.Forms.TabPage();
            this.grpUserPermissions = new System.Windows.Forms.GroupBox();
            this.btnEditPermissions = new System.Windows.Forms.Button();
            this.pbPermissionInfo = new System.Windows.Forms.PictureBox();
            this.cmbAppPermission = new System.Windows.Forms.ComboBox();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.grpCompanyRole = new System.Windows.Forms.GroupBox();
            this.lblWageType = new System.Windows.Forms.Label();
            this.cmbWages = new System.Windows.Forms.ComboBox();
            this.lblWageError = new System.Windows.Forms.Label();
            this.txtWages = new System.Windows.Forms.TextBox();
            this.cmbEmployment = new System.Windows.Forms.ComboBox();
            this.lblEmployment = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblDateHiredError = new System.Windows.Forms.Label();
            this.txtYearHired = new System.Windows.Forms.TextBox();
            this.txtDayHired = new System.Windows.Forms.TextBox();
            this.cmbDateHired = new System.Windows.Forms.ComboBox();
            this.lblDateHired = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.grpSocialMedia = new System.Windows.Forms.GroupBox();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblZipError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblDOBError = new System.Windows.Forms.Label();
            this.txtYearDOB = new System.Windows.Forms.TextBox();
            this.txtDayDOB = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.cmboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.cmboDOBMonth = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabUserAdd = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbctrlUser.SuspendLayout();
            this.tabUserPersonalInfo.SuspendLayout();
            this.grpUserPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPermissionInfo)).BeginInit();
            this.grpCompanyRole.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlUser
            // 
            this.tbctrlUser.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbctrlUser.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbctrlUser.Controls.Add(this.tabUserPersonalInfo);
            this.tbctrlUser.Controls.Add(this.tabUserAdd);
            this.tbctrlUser.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbctrlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctrlUser.HotTrack = true;
            this.tbctrlUser.ItemSize = new System.Drawing.Size(50, 106);
            this.tbctrlUser.Location = new System.Drawing.Point(12, 51);
            this.tbctrlUser.Margin = new System.Windows.Forms.Padding(0);
            this.tbctrlUser.Multiline = true;
            this.tbctrlUser.Name = "tbctrlUser";
            this.tbctrlUser.Padding = new System.Drawing.Point(0, 0);
            this.tbctrlUser.SelectedIndex = 0;
            this.tbctrlUser.Size = new System.Drawing.Size(876, 609);
            this.tbctrlUser.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrlUser.TabIndex = 999;
            // 
            // tabUserPersonalInfo
            // 
            this.tabUserPersonalInfo.BackColor = System.Drawing.Color.Gray;
            this.tabUserPersonalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabUserPersonalInfo.Controls.Add(this.grpUserPermissions);
            this.tabUserPersonalInfo.Controls.Add(this.grpCompanyRole);
            this.tabUserPersonalInfo.Controls.Add(this.grpSocialMedia);
            this.tabUserPersonalInfo.Controls.Add(this.grpPersonalInfo);
            this.tabUserPersonalInfo.Controls.Add(this.btnClear);
            this.tabUserPersonalInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUserPersonalInfo.ImageIndex = 0;
            this.tabUserPersonalInfo.Location = new System.Drawing.Point(107, 4);
            this.tabUserPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabUserPersonalInfo.Name = "tabUserPersonalInfo";
            this.tabUserPersonalInfo.Size = new System.Drawing.Size(765, 601);
            this.tabUserPersonalInfo.TabIndex = 0;
            this.tabUserPersonalInfo.Text = "Add/Edit Employee";
            // 
            // grpUserPermissions
            // 
            this.grpUserPermissions.Controls.Add(this.btnEditPermissions);
            this.grpUserPermissions.Controls.Add(this.pbPermissionInfo);
            this.grpUserPermissions.Controls.Add(this.cmbAppPermission);
            this.grpUserPermissions.Controls.Add(this.lblPermissions);
            this.grpUserPermissions.Controls.Add(this.chkActive);
            this.grpUserPermissions.ForeColor = System.Drawing.Color.PaleGreen;
            this.grpUserPermissions.Location = new System.Drawing.Point(457, 280);
            this.grpUserPermissions.Name = "grpUserPermissions";
            this.grpUserPermissions.Size = new System.Drawing.Size(295, 279);
            this.grpUserPermissions.TabIndex = 14;
            this.grpUserPermissions.TabStop = false;
            this.grpUserPermissions.Text = "App Settings";
            // 
            // btnEditPermissions
            // 
            this.btnEditPermissions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPermissions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditPermissions.Location = new System.Drawing.Point(179, 104);
            this.btnEditPermissions.Name = "btnEditPermissions";
            this.btnEditPermissions.Size = new System.Drawing.Size(75, 30);
            this.btnEditPermissions.TabIndex = 4;
            this.btnEditPermissions.Text = "Edit";
            this.btnEditPermissions.UseVisualStyleBackColor = true;
            this.btnEditPermissions.Click += new System.EventHandler(this.btnEditPermissions_Click);
            // 
            // pbPermissionInfo
            // 
            this.pbPermissionInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPermissionInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbPermissionInfo.Image")));
            this.pbPermissionInfo.Location = new System.Drawing.Point(153, 83);
            this.pbPermissionInfo.Name = "pbPermissionInfo";
            this.pbPermissionInfo.Size = new System.Drawing.Size(20, 20);
            this.pbPermissionInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPermissionInfo.TabIndex = 3;
            this.pbPermissionInfo.TabStop = false;
            // 
            // cmbAppPermission
            // 
            this.cmbAppPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppPermission.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppPermission.FormattingEnabled = true;
            this.cmbAppPermission.Location = new System.Drawing.Point(27, 106);
            this.cmbAppPermission.Name = "cmbAppPermission";
            this.cmbAppPermission.Size = new System.Drawing.Size(146, 28);
            this.cmbAppPermission.TabIndex = 2;
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPermissions.Location = new System.Drawing.Point(23, 80);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(128, 23);
            this.lblPermissions.TabIndex = 1;
            this.lblPermissions.Text = "Permission Level";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.ForeColor = System.Drawing.SystemColors.Control;
            this.chkActive.Location = new System.Drawing.Point(27, 31);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 27);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // grpCompanyRole
            // 
            this.grpCompanyRole.Controls.Add(this.lblWageType);
            this.grpCompanyRole.Controls.Add(this.cmbWages);
            this.grpCompanyRole.Controls.Add(this.lblWageError);
            this.grpCompanyRole.Controls.Add(this.txtWages);
            this.grpCompanyRole.Controls.Add(this.cmbEmployment);
            this.grpCompanyRole.Controls.Add(this.lblEmployment);
            this.grpCompanyRole.Controls.Add(this.cmbPosition);
            this.grpCompanyRole.Controls.Add(this.lblPosition);
            this.grpCompanyRole.Controls.Add(this.cmbDept);
            this.grpCompanyRole.Controls.Add(this.lblDept);
            this.grpCompanyRole.Controls.Add(this.lblDateHiredError);
            this.grpCompanyRole.Controls.Add(this.txtYearHired);
            this.grpCompanyRole.Controls.Add(this.txtDayHired);
            this.grpCompanyRole.Controls.Add(this.cmbDateHired);
            this.grpCompanyRole.Controls.Add(this.lblDateHired);
            this.grpCompanyRole.Controls.Add(this.lblLoginError);
            this.grpCompanyRole.Controls.Add(this.btnRandom);
            this.grpCompanyRole.Controls.Add(this.btnCheck);
            this.grpCompanyRole.Controls.Add(this.lblLoginID);
            this.grpCompanyRole.Controls.Add(this.txtLogin);
            this.grpCompanyRole.ForeColor = System.Drawing.Color.PaleGreen;
            this.grpCompanyRole.Location = new System.Drawing.Point(7, 280);
            this.grpCompanyRole.Name = "grpCompanyRole";
            this.grpCompanyRole.Size = new System.Drawing.Size(443, 280);
            this.grpCompanyRole.TabIndex = 2;
            this.grpCompanyRole.TabStop = false;
            this.grpCompanyRole.Text = "Company Role";
            this.grpCompanyRole.Enter += new System.EventHandler(this.grpCompanyRole_Enter);
            // 
            // lblWageType
            // 
            this.lblWageType.AutoSize = true;
            this.lblWageType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWageType.ForeColor = System.Drawing.Color.White;
            this.lblWageType.Location = new System.Drawing.Point(351, 186);
            this.lblWageType.Name = "lblWageType";
            this.lblWageType.Size = new System.Drawing.Size(43, 20);
            this.lblWageType.TabIndex = 42;
            this.lblWageType.Text = "/ hour";
            // 
            // cmbWages
            // 
            this.cmbWages.DropDownHeight = 200;
            this.cmbWages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWages.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWages.FormattingEnabled = true;
            this.cmbWages.IntegralHeight = false;
            this.cmbWages.Items.AddRange(new object[] {
            "Hourly",
            "Salary"});
            this.cmbWages.Location = new System.Drawing.Point(177, 182);
            this.cmbWages.MaxDropDownItems = 15;
            this.cmbWages.Name = "cmbWages";
            this.cmbWages.Size = new System.Drawing.Size(80, 28);
            this.cmbWages.TabIndex = 9;
            this.cmbWages.TextChanged += new System.EventHandler(this.cmbWages_TextChanged);
            // 
            // lblWageError
            // 
            this.lblWageError.AutoSize = true;
            this.lblWageError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWageError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWageError.Location = new System.Drawing.Point(88, 213);
            this.lblWageError.Name = "lblWageError";
            this.lblWageError.Size = new System.Drawing.Size(77, 20);
            this.lblWageError.TabIndex = 38;
            this.lblWageError.Text = "Wage Error";
            // 
            // txtWages
            // 
            this.txtWages.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWages.Location = new System.Drawing.Point(263, 183);
            this.txtWages.MaxLength = 6;
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(82, 26);
            this.txtWages.TabIndex = 10;
            this.txtWages.Enter += new System.EventHandler(this.txtWages_Enter);
            this.txtWages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWages_KeyPress);
            this.txtWages.Leave += new System.EventHandler(this.txtWages_Leave);
            // 
            // cmbEmployment
            // 
            this.cmbEmployment.DropDownHeight = 200;
            this.cmbEmployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployment.FormattingEnabled = true;
            this.cmbEmployment.IntegralHeight = false;
            this.cmbEmployment.Location = new System.Drawing.Point(92, 182);
            this.cmbEmployment.MaxDropDownItems = 15;
            this.cmbEmployment.Name = "cmbEmployment";
            this.cmbEmployment.Size = new System.Drawing.Size(79, 28);
            this.cmbEmployment.TabIndex = 8;
            // 
            // lblEmployment
            // 
            this.lblEmployment.AutoSize = true;
            this.lblEmployment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployment.ForeColor = System.Drawing.Color.White;
            this.lblEmployment.Location = new System.Drawing.Point(4, 186);
            this.lblEmployment.Name = "lblEmployment";
            this.lblEmployment.Size = new System.Drawing.Size(84, 20);
            this.lblEmployment.TabIndex = 33;
            this.lblEmployment.Text = "Employment";
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownHeight = 200;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Enabled = false;
            this.cmbPosition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.IntegralHeight = false;
            this.cmbPosition.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbPosition.Location = new System.Drawing.Point(93, 143);
            this.cmbPosition.MaxDropDownItems = 15;
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(252, 28);
            this.cmbPosition.TabIndex = 7;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(31, 146);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(57, 20);
            this.lblPosition.TabIndex = 31;
            this.lblPosition.Text = "Position";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownHeight = 200;
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.IntegralHeight = false;
            this.cmbDept.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbDept.Location = new System.Drawing.Point(93, 104);
            this.cmbDept.MaxDropDownItems = 15;
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(252, 28);
            this.cmbDept.TabIndex = 6;
            this.cmbDept.SelectionChangeCommitted += new System.EventHandler(this.cmbDept_SelectionChangeCommitted);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.White;
            this.lblDept.Location = new System.Drawing.Point(11, 106);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(77, 20);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "Department";
            // 
            // lblDateHiredError
            // 
            this.lblDateHiredError.AutoSize = true;
            this.lblDateHiredError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHiredError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDateHiredError.Location = new System.Drawing.Point(349, 69);
            this.lblDateHiredError.Name = "lblDateHiredError";
            this.lblDateHiredError.Size = new System.Drawing.Size(86, 20);
            this.lblDateHiredError.TabIndex = 28;
            this.lblDateHiredError.Text = "Invalid Name";
            // 
            // txtYearHired
            // 
            this.txtYearHired.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearHired.ForeColor = System.Drawing.Color.DarkGray;
            this.txtYearHired.Location = new System.Drawing.Point(284, 66);
            this.txtYearHired.MaxLength = 4;
            this.txtYearHired.Name = "txtYearHired";
            this.txtYearHired.Size = new System.Drawing.Size(61, 26);
            this.txtYearHired.TabIndex = 5;
            this.txtYearHired.Text = "  Year";
            this.txtYearHired.Enter += new System.EventHandler(this.txtYearHired_Enter);
            this.txtYearHired.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearHired_KeyPress);
            this.txtYearHired.Leave += new System.EventHandler(this.txtYearHired_Leave);
            // 
            // txtDayHired
            // 
            this.txtDayHired.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayHired.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDayHired.Location = new System.Drawing.Point(212, 66);
            this.txtDayHired.MaxLength = 2;
            this.txtDayHired.Name = "txtDayHired";
            this.txtDayHired.Size = new System.Drawing.Size(45, 26);
            this.txtDayHired.TabIndex = 4;
            this.txtDayHired.Text = "  Day";
            this.txtDayHired.Enter += new System.EventHandler(this.txtDayHired_Enter);
            this.txtDayHired.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDayHired_KeyPress);
            this.txtDayHired.Leave += new System.EventHandler(this.txtDayHired_Leave);
            // 
            // cmbDateHired
            // 
            this.cmbDateHired.DropDownHeight = 200;
            this.cmbDateHired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateHired.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateHired.FormattingEnabled = true;
            this.cmbDateHired.IntegralHeight = false;
            this.cmbDateHired.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbDateHired.Location = new System.Drawing.Point(93, 65);
            this.cmbDateHired.MaxDropDownItems = 15;
            this.cmbDateHired.Name = "cmbDateHired";
            this.cmbDateHired.Size = new System.Drawing.Size(92, 28);
            this.cmbDateHired.TabIndex = 3;
            // 
            // lblDateHired
            // 
            this.lblDateHired.AutoSize = true;
            this.lblDateHired.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHired.ForeColor = System.Drawing.Color.White;
            this.lblDateHired.Location = new System.Drawing.Point(24, 69);
            this.lblDateHired.Name = "lblDateHired";
            this.lblDateHired.Size = new System.Drawing.Size(64, 20);
            this.lblDateHired.TabIndex = 12;
            this.lblDateHired.Text = "Hire Date";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLoginError.Location = new System.Drawing.Point(263, 31);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(70, 20);
            this.lblLoginError.TabIndex = 6;
            this.lblLoginError.Text = "Login Error";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandom.Location = new System.Drawing.Point(200, 26);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(57, 31);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(139, 26);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(57, 31);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginID.ForeColor = System.Drawing.Color.White;
            this.lblLoginID.Location = new System.Drawing.Point(30, 31);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(58, 20);
            this.lblLoginID.TabIndex = 2;
            this.lblLoginID.Text = "Login ID";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Location = new System.Drawing.Point(93, 28);
            this.txtLogin.MaxLength = 4;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(40, 26);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "8888";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // grpSocialMedia
            // 
            this.grpSocialMedia.ForeColor = System.Drawing.Color.PaleGreen;
            this.grpSocialMedia.Location = new System.Drawing.Point(456, 3);
            this.grpSocialMedia.Name = "grpSocialMedia";
            this.grpSocialMedia.Size = new System.Drawing.Size(296, 271);
            this.grpSocialMedia.TabIndex = 1;
            this.grpSocialMedia.TabStop = false;
            this.grpSocialMedia.Text = "Social Media";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.lblPhoneError);
            this.grpPersonalInfo.Controls.Add(this.lblZipError);
            this.grpPersonalInfo.Controls.Add(this.lblNameError);
            this.grpPersonalInfo.Controls.Add(this.lblEmailError);
            this.grpPersonalInfo.Controls.Add(this.lblDOBError);
            this.grpPersonalInfo.Controls.Add(this.txtYearDOB);
            this.grpPersonalInfo.Controls.Add(this.txtDayDOB);
            this.grpPersonalInfo.Controls.Add(this.lblPhone);
            this.grpPersonalInfo.Controls.Add(this.txtZipcode);
            this.grpPersonalInfo.Controls.Add(this.cmboState);
            this.grpPersonalInfo.Controls.Add(this.txtCity);
            this.grpPersonalInfo.Controls.Add(this.lblCity);
            this.grpPersonalInfo.Controls.Add(this.txtAddress2);
            this.grpPersonalInfo.Controls.Add(this.lblAddress2);
            this.grpPersonalInfo.Controls.Add(this.txtAddress1);
            this.grpPersonalInfo.Controls.Add(this.lblAddress1);
            this.grpPersonalInfo.Controls.Add(this.cmboDOBMonth);
            this.grpPersonalInfo.Controls.Add(this.lblBirthday);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Controls.Add(this.txtLName);
            this.grpPersonalInfo.Controls.Add(this.txtFName);
            this.grpPersonalInfo.Controls.Add(this.txtPhone);
            this.grpPersonalInfo.Controls.Add(this.lblState);
            this.grpPersonalInfo.Controls.Add(this.lblZip);
            this.grpPersonalInfo.ForeColor = System.Drawing.Color.PaleGreen;
            this.grpPersonalInfo.Location = new System.Drawing.Point(7, 3);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(443, 271);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Info";
            this.grpPersonalInfo.Enter += new System.EventHandler(this.grpPersonalInfo_Enter);
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhoneError.Location = new System.Drawing.Point(224, 129);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(90, 20);
            this.lblPhoneError.TabIndex = 29;
            this.lblPhoneError.Text = "Invalid Phone";
            // 
            // lblZipError
            // 
            this.lblZipError.AutoSize = true;
            this.lblZipError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblZipError.Location = new System.Drawing.Point(351, 225);
            this.lblZipError.Name = "lblZipError";
            this.lblZipError.Size = new System.Drawing.Size(69, 20);
            this.lblZipError.TabIndex = 28;
            this.lblZipError.Text = "Invalid Zip";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNameError.Location = new System.Drawing.Point(351, 31);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(86, 20);
            this.lblNameError.TabIndex = 27;
            this.lblNameError.Text = "Invalid Name";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailError.Location = new System.Drawing.Point(351, 63);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(84, 20);
            this.lblEmailError.TabIndex = 26;
            this.lblEmailError.Text = "Invalid Email";
            // 
            // lblDOBError
            // 
            this.lblDOBError.AutoSize = true;
            this.lblDOBError.BackColor = System.Drawing.Color.Transparent;
            this.lblDOBError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDOBError.Location = new System.Drawing.Point(351, 96);
            this.lblDOBError.Name = "lblDOBError";
            this.lblDOBError.Size = new System.Drawing.Size(69, 20);
            this.lblDOBError.TabIndex = 1;
            this.lblDOBError.Text = "DOB error";
            // 
            // txtYearDOB
            // 
            this.txtYearDOB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearDOB.ForeColor = System.Drawing.Color.DarkGray;
            this.txtYearDOB.Location = new System.Drawing.Point(284, 92);
            this.txtYearDOB.MaxLength = 4;
            this.txtYearDOB.Name = "txtYearDOB";
            this.txtYearDOB.Size = new System.Drawing.Size(61, 26);
            this.txtYearDOB.TabIndex = 6;
            this.txtYearDOB.Text = "  Year";
            this.txtYearDOB.Enter += new System.EventHandler(this.txtYearDOB_Enter);
            this.txtYearDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearDOB_KeyPress);
            this.txtYearDOB.Leave += new System.EventHandler(this.txtYearDOB_Leave);
            // 
            // txtDayDOB
            // 
            this.txtDayDOB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayDOB.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDayDOB.Location = new System.Drawing.Point(212, 92);
            this.txtDayDOB.MaxLength = 2;
            this.txtDayDOB.Name = "txtDayDOB";
            this.txtDayDOB.Size = new System.Drawing.Size(45, 26);
            this.txtDayDOB.TabIndex = 5;
            this.txtDayDOB.Text = "  Day";
            this.txtDayDOB.Enter += new System.EventHandler(this.txtDayDOB_Enter);
            this.txtDayDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDayDOB_KeyPress);
            this.txtDayDOB.Leave += new System.EventHandler(this.txtDayDOB_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(40, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 20);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipcode.Location = new System.Drawing.Point(301, 222);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(44, 26);
            this.txtZipcode.TabIndex = 12;
            this.txtZipcode.Text = "88888";
            this.txtZipcode.Enter += new System.EventHandler(this.txtZipcode_Enter);
            this.txtZipcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipcode_KeyPress);
            this.txtZipcode.Leave += new System.EventHandler(this.txtZipcode_Leave);
            // 
            // cmboState
            // 
            this.cmboState.DropDownHeight = 200;
            this.cmboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboState.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboState.FormattingEnabled = true;
            this.cmboState.IntegralHeight = false;
            this.cmboState.Location = new System.Drawing.Point(234, 222);
            this.cmboState.Name = "cmboState";
            this.cmboState.Size = new System.Drawing.Size(45, 28);
            this.cmboState.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(93, 222);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(107, 26);
            this.txtCity.TabIndex = 10;
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(57, 223);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 20);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(93, 190);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(252, 26);
            this.txtAddress2.TabIndex = 9;
            this.txtAddress2.Enter += new System.EventHandler(this.txtAddress2_Enter);
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.White;
            this.lblAddress2.Location = new System.Drawing.Point(17, 191);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(71, 20);
            this.lblAddress2.TabIndex = 17;
            this.lblAddress2.Text = "Address 2";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(93, 158);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(252, 26);
            this.txtAddress1.TabIndex = 8;
            this.txtAddress1.Enter += new System.EventHandler(this.txtAddress1_Enter);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.White;
            this.lblAddress1.Location = new System.Drawing.Point(17, 159);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(71, 20);
            this.lblAddress1.TabIndex = 15;
            this.lblAddress1.Text = "Address 1";
            // 
            // cmboDOBMonth
            // 
            this.cmboDOBMonth.DropDownHeight = 200;
            this.cmboDOBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboDOBMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDOBMonth.FormattingEnabled = true;
            this.cmboDOBMonth.IntegralHeight = false;
            this.cmboDOBMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmboDOBMonth.Location = new System.Drawing.Point(93, 91);
            this.cmboDOBMonth.MaxDropDownItems = 15;
            this.cmboDOBMonth.Name = "cmboDOBMonth";
            this.cmboDOBMonth.Size = new System.Drawing.Size(92, 28);
            this.cmboDOBMonth.TabIndex = 4;
            this.cmboDOBMonth.SelectionChangeCommitted += new System.EventHandler(this.cmboDOBMonth_SelectionChangeCommitted);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(7, 95);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(81, 20);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(93, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(46, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(44, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLName.Location = new System.Drawing.Point(206, 28);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(139, 26);
            this.txtLName.TabIndex = 2;
            this.txtLName.Text = "  Last";
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFName.Location = new System.Drawing.Point(93, 28);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(107, 26);
            this.txtFName.TabIndex = 0;
            this.txtFName.Text = "  First";
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(93, 126);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 26);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(197, 225);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 20);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.ForeColor = System.Drawing.Color.White;
            this.lblZip.Location = new System.Drawing.Point(276, 225);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(27, 20);
            this.lblZip.TabIndex = 24;
            this.lblZip.Text = "Zip";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabUserAdd
            // 
            this.tabUserAdd.BackColor = System.Drawing.Color.Gray;
            this.tabUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabUserAdd.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUserAdd.ImageIndex = 1;
            this.tabUserAdd.Location = new System.Drawing.Point(107, 4);
            this.tabUserAdd.Margin = new System.Windows.Forms.Padding(0);
            this.tabUserAdd.Name = "tabUserAdd";
            this.tabUserAdd.Size = new System.Drawing.Size(765, 601);
            this.tabUserAdd.TabIndex = 1;
            this.tabUserAdd.Text = "New Employee";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EditUser.png");
            this.imageList1.Images.SetKeyName(1, "add-user-512.png");
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(897, 709);
            this.Controls.Add(this.tbctrlUser);
            this.Name = "ModifyUserForm";
            this.Text = "ModifyUserForm";
            this.tbctrlUser.ResumeLayout(false);
            this.tabUserPersonalInfo.ResumeLayout(false);
            this.grpUserPermissions.ResumeLayout(false);
            this.grpUserPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPermissionInfo)).EndInit();
            this.grpCompanyRole.ResumeLayout(false);
            this.grpCompanyRole.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlUser;
        private System.Windows.Forms.TabPage tabUserPersonalInfo;
        private System.Windows.Forms.TabPage tabUserAdd;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.ComboBox cmboState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmboDOBMonth;
        private System.Windows.Forms.TextBox txtDayDOB;
        private System.Windows.Forms.TextBox txtYearDOB;
        private System.Windows.Forms.Label lblDOBError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblZipError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.GroupBox grpCompanyRole;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox grpSocialMedia;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Label lblDateHiredError;
        private System.Windows.Forms.TextBox txtYearHired;
        private System.Windows.Forms.TextBox txtDayHired;
        private System.Windows.Forms.ComboBox cmbDateHired;
        private System.Windows.Forms.Label lblDateHired;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbEmployment;
        private System.Windows.Forms.Label lblEmployment;
        private System.Windows.Forms.TextBox txtWages;
        private System.Windows.Forms.Label lblWageError;
        private System.Windows.Forms.Label lblWageType;
        private System.Windows.Forms.ComboBox cmbWages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpUserPermissions;
        private System.Windows.Forms.PictureBox pbPermissionInfo;
        private System.Windows.Forms.ComboBox cmbAppPermission;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnEditPermissions;
    }
}