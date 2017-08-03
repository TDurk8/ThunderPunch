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
            this.tbctrlUser = new System.Windows.Forms.TabControl();
            this.tabUserPersonalInfo = new System.Windows.Forms.TabPage();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblZipError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblDOBError = new System.Windows.Forms.Label();
            this.txtYearDOB = new System.Windows.Forms.TextBox();
            this.txtDayDOB = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.cmboState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
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
            this.tbNew = new System.Windows.Forms.TabPage();
            this.tbctrlUser.SuspendLayout();
            this.tabUserPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlUser
            // 
            this.tbctrlUser.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbctrlUser.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbctrlUser.Controls.Add(this.tabUserPersonalInfo);
            this.tbctrlUser.Controls.Add(this.tbNew);
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
            this.tbctrlUser.Size = new System.Drawing.Size(854, 443);
            this.tbctrlUser.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrlUser.TabIndex = 0;
            // 
            // tabUserPersonalInfo
            // 
            this.tabUserPersonalInfo.BackColor = System.Drawing.Color.Gray;
            this.tabUserPersonalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabUserPersonalInfo.Controls.Add(this.lblPhoneError);
            this.tabUserPersonalInfo.Controls.Add(this.lblZipError);
            this.tabUserPersonalInfo.Controls.Add(this.lblNameError);
            this.tabUserPersonalInfo.Controls.Add(this.lblEmailError);
            this.tabUserPersonalInfo.Controls.Add(this.lblDOBError);
            this.tabUserPersonalInfo.Controls.Add(this.txtYearDOB);
            this.tabUserPersonalInfo.Controls.Add(this.txtDayDOB);
            this.tabUserPersonalInfo.Controls.Add(this.btnClear);
            this.tabUserPersonalInfo.Controls.Add(this.lblPhone);
            this.tabUserPersonalInfo.Controls.Add(this.lblZip);
            this.tabUserPersonalInfo.Controls.Add(this.txtZipcode);
            this.tabUserPersonalInfo.Controls.Add(this.cmboState);
            this.tabUserPersonalInfo.Controls.Add(this.lblState);
            this.tabUserPersonalInfo.Controls.Add(this.txtCity);
            this.tabUserPersonalInfo.Controls.Add(this.lblCity);
            this.tabUserPersonalInfo.Controls.Add(this.txtAddress2);
            this.tabUserPersonalInfo.Controls.Add(this.lblAddress2);
            this.tabUserPersonalInfo.Controls.Add(this.txtAddress1);
            this.tabUserPersonalInfo.Controls.Add(this.lblAddress1);
            this.tabUserPersonalInfo.Controls.Add(this.cmboDOBMonth);
            this.tabUserPersonalInfo.Controls.Add(this.lblBirthday);
            this.tabUserPersonalInfo.Controls.Add(this.txtEmail);
            this.tabUserPersonalInfo.Controls.Add(this.lblEmail);
            this.tabUserPersonalInfo.Controls.Add(this.lblName);
            this.tabUserPersonalInfo.Controls.Add(this.txtLName);
            this.tabUserPersonalInfo.Controls.Add(this.txtFName);
            this.tabUserPersonalInfo.Controls.Add(this.txtPhone);
            this.tabUserPersonalInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUserPersonalInfo.Location = new System.Drawing.Point(107, 4);
            this.tabUserPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabUserPersonalInfo.Name = "tabUserPersonalInfo";
            this.tabUserPersonalInfo.Size = new System.Drawing.Size(743, 435);
            this.tabUserPersonalInfo.TabIndex = 0;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhoneError.Location = new System.Drawing.Point(232, 198);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(103, 23);
            this.lblPhoneError.TabIndex = 29;
            this.lblPhoneError.Text = "Invalid Phone";
            // 
            // lblZipError
            // 
            this.lblZipError.AutoSize = true;
            this.lblZipError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblZipError.Location = new System.Drawing.Point(409, 330);
            this.lblZipError.Name = "lblZipError";
            this.lblZipError.Size = new System.Drawing.Size(79, 23);
            this.lblZipError.TabIndex = 28;
            this.lblZipError.Text = "Invalid Zip";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNameError.Location = new System.Drawing.Point(409, 64);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(99, 23);
            this.lblNameError.TabIndex = 27;
            this.lblNameError.Text = "Invalid Name";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailError.Location = new System.Drawing.Point(409, 108);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(95, 23);
            this.lblEmailError.TabIndex = 26;
            this.lblEmailError.Text = "Invalid Email";
            // 
            // lblDOBError
            // 
            this.lblDOBError.AutoSize = true;
            this.lblDOBError.BackColor = System.Drawing.Color.Transparent;
            this.lblDOBError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDOBError.Location = new System.Drawing.Point(409, 153);
            this.lblDOBError.Name = "lblDOBError";
            this.lblDOBError.Size = new System.Drawing.Size(80, 23);
            this.lblDOBError.TabIndex = 1;
            this.lblDOBError.Text = "DOB error";
            // 
            // txtYearDOB
            // 
            this.txtYearDOB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearDOB.ForeColor = System.Drawing.Color.DarkGray;
            this.txtYearDOB.Location = new System.Drawing.Point(324, 150);
            this.txtYearDOB.Name = "txtYearDOB";
            this.txtYearDOB.Size = new System.Drawing.Size(79, 29);
            this.txtYearDOB.TabIndex = 6;
            this.txtYearDOB.Text = "  Year";
            this.txtYearDOB.Enter += new System.EventHandler(this.txtYearDOB_Enter);
            this.txtYearDOB.Leave += new System.EventHandler(this.txtYearDOB_Leave);
            // 
            // txtDayDOB
            // 
            this.txtDayDOB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayDOB.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDayDOB.Location = new System.Drawing.Point(224, 150);
            this.txtDayDOB.Name = "txtDayDOB";
            this.txtDayDOB.Size = new System.Drawing.Size(66, 29);
            this.txtDayDOB.TabIndex = 5;
            this.txtDayDOB.Text = "  Day";
            this.txtDayDOB.Enter += new System.EventHandler(this.txtDayDOB_Enter);
            this.txtDayDOB.Leave += new System.EventHandler(this.txtDayDOB_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(40, 196);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 23);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.ForeColor = System.Drawing.Color.White;
            this.lblZip.Location = new System.Drawing.Point(321, 330);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 23);
            this.lblZip.TabIndex = 24;
            this.lblZip.Text = "Zip";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipcode.Location = new System.Drawing.Point(352, 327);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(51, 29);
            this.txtZipcode.TabIndex = 12;
            this.txtZipcode.Text = "88888";
            this.txtZipcode.Leave += new System.EventHandler(this.txtZipcode_Leave);
            // 
            // cmboState
            // 
            this.cmboState.DropDownHeight = 200;
            this.cmboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboState.FormattingEnabled = true;
            this.cmboState.IntegralHeight = false;
            this.cmboState.Location = new System.Drawing.Point(271, 326);
            this.cmboState.Name = "cmboState";
            this.cmboState.Size = new System.Drawing.Size(47, 31);
            this.cmboState.TabIndex = 11;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(225, 330);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 23);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(98, 327);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 29);
            this.txtCity.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(62, 328);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 23);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(98, 283);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(305, 29);
            this.txtAddress2.TabIndex = 9;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.White;
            this.lblAddress2.Location = new System.Drawing.Point(15, 284);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(81, 23);
            this.lblAddress2.TabIndex = 17;
            this.lblAddress2.Text = "Address 2";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(98, 239);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(305, 29);
            this.txtAddress1.TabIndex = 8;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.White;
            this.lblAddress1.Location = new System.Drawing.Point(15, 240);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(81, 23);
            this.lblAddress1.TabIndex = 15;
            this.lblAddress1.Text = "Address 1";
            // 
            // cmboDOBMonth
            // 
            this.cmboDOBMonth.DropDownHeight = 200;
            this.cmboDOBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboDOBMonth.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmboDOBMonth.Location = new System.Drawing.Point(98, 149);
            this.cmboDOBMonth.MaxDropDownItems = 15;
            this.cmboDOBMonth.Name = "cmboDOBMonth";
            this.cmboDOBMonth.Size = new System.Drawing.Size(101, 31);
            this.cmboDOBMonth.TabIndex = 4;
            this.cmboDOBMonth.SelectionChangeCommitted += new System.EventHandler(this.cmboDOBMonth_SelectionChangeCommitted);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(4, 152);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(92, 23);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(98, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 29);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(48, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(44, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLName.Location = new System.Drawing.Point(245, 61);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(158, 29);
            this.txtLName.TabIndex = 2;
            this.txtLName.Text = "  Last";
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFName.Location = new System.Drawing.Point(98, 61);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(132, 29);
            this.txtFName.TabIndex = 1;
            this.txtFName.Text = "  First";
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(98, 195);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 29);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // tbNew
            // 
            this.tbNew.BackColor = System.Drawing.Color.Gray;
            this.tbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNew.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNew.Location = new System.Drawing.Point(107, 4);
            this.tbNew.Margin = new System.Windows.Forms.Padding(0);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(743, 435);
            this.tbNew.TabIndex = 1;
            this.tbNew.Text = "New Employee";
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
            this.tabUserPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlUser;
        private System.Windows.Forms.TabPage tabUserPersonalInfo;
        private System.Windows.Forms.TabPage tbNew;
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
    }
}