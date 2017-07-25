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
            this.tbEditUser = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.tbNew = new System.Windows.Forms.TabPage();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblDOBYear = new System.Windows.Forms.Label();
            this.lbxYear = new System.Windows.Forms.ListBox();
            this.cmboYear = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmboDOBMonth = new System.Windows.Forms.ComboBox();
            this.tbctrlUser.SuspendLayout();
            this.tbEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlUser
            // 
            this.tbctrlUser.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbctrlUser.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbctrlUser.Controls.Add(this.tbEditUser);
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
            this.tbctrlUser.Size = new System.Drawing.Size(653, 439);
            this.tbctrlUser.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrlUser.TabIndex = 0;
            // 
            // tbEditUser
            // 
            this.tbEditUser.BackColor = System.Drawing.Color.Gray;
            this.tbEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEditUser.Controls.Add(this.cmboDOBMonth);
            this.tbEditUser.Controls.Add(this.lblMonth);
            this.tbEditUser.Controls.Add(this.cmboYear);
            this.tbEditUser.Controls.Add(this.lbxYear);
            this.tbEditUser.Controls.Add(this.lblDOBYear);
            this.tbEditUser.Controls.Add(this.lblBirthday);
            this.tbEditUser.Controls.Add(this.txtEmail);
            this.tbEditUser.Controls.Add(this.lblEmail);
            this.tbEditUser.Controls.Add(this.lblLName);
            this.tbEditUser.Controls.Add(this.txtLName);
            this.tbEditUser.Controls.Add(this.txtMName);
            this.tbEditUser.Controls.Add(this.lblMName);
            this.tbEditUser.Controls.Add(this.txtFName);
            this.tbEditUser.Controls.Add(this.lblFName);
            this.tbEditUser.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditUser.Location = new System.Drawing.Point(107, 4);
            this.tbEditUser.Margin = new System.Windows.Forms.Padding(0);
            this.tbEditUser.Name = "tbEditUser";
            this.tbEditUser.Size = new System.Drawing.Size(542, 431);
            this.tbEditUser.TabIndex = 0;
            this.tbEditUser.Text = "Modify ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(77, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 29);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(14, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.White;
            this.lblLName.Location = new System.Drawing.Point(14, 96);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(39, 23);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Last";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(77, 93);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(192, 29);
            this.txtLName.TabIndex = 4;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(77, 58);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(192, 29);
            this.txtMName.TabIndex = 3;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.ForeColor = System.Drawing.Color.White;
            this.lblMName.Location = new System.Drawing.Point(14, 61);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(56, 23);
            this.lblMName.TabIndex = 2;
            this.lblMName.Text = "Middle";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(77, 23);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(192, 29);
            this.txtFName.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.White;
            this.lblFName.Location = new System.Drawing.Point(14, 26);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(39, 23);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First";
            // 
            // tbNew
            // 
            this.tbNew.BackColor = System.Drawing.Color.Gray;
            this.tbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNew.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNew.Location = new System.Drawing.Point(107, 4);
            this.tbNew.Margin = new System.Windows.Forms.Padding(0);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(542, 431);
            this.tbNew.TabIndex = 1;
            this.tbNew.Text = "New Employee";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(14, 170);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(92, 23);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Date of Birth";
            // 
            // lblDOBYear
            // 
            this.lblDOBYear.AutoSize = true;
            this.lblDOBYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBYear.ForeColor = System.Drawing.Color.White;
            this.lblDOBYear.Location = new System.Drawing.Point(126, 170);
            this.lblDOBYear.Name = "lblDOBYear";
            this.lblDOBYear.Size = new System.Drawing.Size(42, 23);
            this.lblDOBYear.TabIndex = 9;
            this.lblDOBYear.Text = "Year";
            // 
            // lbxYear
            // 
            this.lbxYear.FormattingEnabled = true;
            this.lbxYear.ItemHeight = 23;
            this.lbxYear.Location = new System.Drawing.Point(174, 290);
            this.lbxYear.Name = "lbxYear";
            this.lbxYear.ScrollAlwaysVisible = true;
            this.lbxYear.Size = new System.Drawing.Size(70, 27);
            this.lbxYear.TabIndex = 10;
            // 
            // cmboYear
            // 
            this.cmboYear.DropDownHeight = 200;
            this.cmboYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboYear.FormattingEnabled = true;
            this.cmboYear.IntegralHeight = false;
            this.cmboYear.Location = new System.Drawing.Point(174, 170);
            this.cmboYear.MaxDropDownItems = 15;
            this.cmboYear.Name = "cmboYear";
            this.cmboYear.Size = new System.Drawing.Size(55, 28);
            this.cmboYear.TabIndex = 1;
            this.cmboYear.SelectedIndexChanged += new System.EventHandler(this.cmboYear_SelectedIndexChanged);
            this.cmboYear.SelectedValueChanged += new System.EventHandler(this.cmboYear_SelectedValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(246, 175);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(53, 23);
            this.lblMonth.TabIndex = 11;
            this.lblMonth.Text = "Month";
            // 
            // cmboDOBMonth
            // 
            this.cmboDOBMonth.DropDownHeight = 200;
            this.cmboDOBMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDOBMonth.FormattingEnabled = true;
            this.cmboDOBMonth.IntegralHeight = false;
            this.cmboDOBMonth.Location = new System.Drawing.Point(294, 175);
            this.cmboDOBMonth.MaxDropDownItems = 15;
            this.cmboDOBMonth.Name = "cmboDOBMonth";
            this.cmboDOBMonth.Size = new System.Drawing.Size(40, 28);
            this.cmboDOBMonth.TabIndex = 12;
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(677, 622);
            this.Controls.Add(this.tbctrlUser);
            this.Name = "ModifyUserForm";
            this.Text = "ModifyUserForm";
            this.tbctrlUser.ResumeLayout(false);
            this.tbEditUser.ResumeLayout(false);
            this.tbEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlUser;
        private System.Windows.Forms.TabPage tbEditUser;
        private System.Windows.Forms.TabPage tbNew;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListBox lbxYear;
        private System.Windows.Forms.Label lblDOBYear;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.ComboBox cmboYear;
        private System.Windows.Forms.ComboBox cmboDOBMonth;
        private System.Windows.Forms.Label lblMonth;
    }
}