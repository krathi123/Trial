namespace Trial
{
    partial class adduserctrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduserctrl));
            this.genderPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.malerbtn = new System.Windows.Forms.RadioButton();
            this.femalerBtn = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.confirmPwdTxt = new System.Windows.Forms.TextBox();
            this.cpwdLbl = new System.Windows.Forms.Label();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.designationCmb = new System.Windows.Forms.ComboBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.emailIDTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.mobileNoTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.designationLbl = new System.Windows.Forms.Label();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.dobdate = new System.Windows.Forms.Label();
            this.emailidrbtn = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.mobilenoLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.adduserLbl = new System.Windows.Forms.Label();
            this.trainingDataSet = new Trial.TrainingDataSet();
            this.orderuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_userTableAdapter = new Trial.TrainingDataSetTableAdapters.order_userTableAdapter();
            this.trainingDataSet1 = new Trial.TrainingDataSet();
            this.trainingDataSet2 = new Trial.TrainingDataSet();
            this.order_userTableAdapter1 = new Trial.TrainingDataSetTableAdapters.order_userTableAdapter();
            this.resetBtn = new System.Windows.Forms.Button();
            this.ErrProviderUsrName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMobileNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmailId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDesg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDesignation = new System.Windows.Forms.ErrorProvider(this.components);
            this.genderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProviderUsrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMobileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // genderPnl
            // 
            this.genderPnl.BackColor = System.Drawing.Color.Transparent;
            this.genderPnl.Controls.Add(this.malerbtn);
            this.genderPnl.Controls.Add(this.femalerBtn);
            this.genderPnl.Location = new System.Drawing.Point(500, 273);
            this.genderPnl.Name = "genderPnl";
            this.genderPnl.Size = new System.Drawing.Size(182, 30);
            this.genderPnl.TabIndex = 47;
            this.genderPnl.Validating += new System.ComponentModel.CancelEventHandler(this.genderPnl_Validating);
            // 
            // malerbtn
            // 
            this.malerbtn.AutoSize = true;
            this.malerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.malerbtn.Location = new System.Drawing.Point(3, 3);
            this.malerbtn.Name = "malerbtn";
            this.malerbtn.Size = new System.Drawing.Size(58, 17);
            this.malerbtn.TabIndex = 19;
            this.malerbtn.TabStop = true;
            this.malerbtn.Text = "MALE";
            this.malerbtn.UseVisualStyleBackColor = true;
            // 
            // femalerBtn
            // 
            this.femalerBtn.AutoSize = true;
            this.femalerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.femalerBtn.Location = new System.Drawing.Point(67, 3);
            this.femalerBtn.Name = "femalerBtn";
            this.femalerBtn.Size = new System.Drawing.Size(73, 17);
            this.femalerBtn.TabIndex = 20;
            this.femalerBtn.TabStop = true;
            this.femalerBtn.Text = "FEMALE";
            this.femalerBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitBtn.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(470, 544);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(114, 38);
            this.submitBtn.TabIndex = 46;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // confirmPwdTxt
            // 
            this.confirmPwdTxt.Location = new System.Drawing.Point(500, 452);
            this.confirmPwdTxt.Name = "confirmPwdTxt";
            this.confirmPwdTxt.PasswordChar = '*';
            this.confirmPwdTxt.Size = new System.Drawing.Size(182, 20);
            this.confirmPwdTxt.TabIndex = 45;
            this.confirmPwdTxt.TextChanged += new System.EventHandler(this.confirmPwdTxt_TextChanged);
            // 
            // cpwdLbl
            // 
            this.cpwdLbl.AutoSize = true;
            this.cpwdLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpwdLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.cpwdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cpwdLbl.Location = new System.Drawing.Point(308, 452);
            this.cpwdLbl.Name = "cpwdLbl";
            this.cpwdLbl.Size = new System.Drawing.Size(147, 22);
            this.cpwdLbl.TabIndex = 44;
            this.cpwdLbl.Text = "Confirm password";
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Location = new System.Drawing.Point(500, 357);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(182, 20);
            this.dobDatePicker.TabIndex = 43;
            this.dobDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // designationCmb
            // 
            this.designationCmb.FormattingEnabled = true;
            this.designationCmb.Location = new System.Drawing.Point(503, 491);
            this.designationCmb.Name = "designationCmb";
            this.designationCmb.Size = new System.Drawing.Size(182, 21);
            this.designationCmb.TabIndex = 42;
            this.designationCmb.SelectedIndexChanged += new System.EventHandler(this.designationCmb_SelectedIndexChanged);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(500, 410);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(182, 20);
            this.pwdTxt.TabIndex = 41;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // emailIDTxt
            // 
            this.emailIDTxt.Location = new System.Drawing.Point(500, 320);
            this.emailIDTxt.Name = "emailIDTxt";
            this.emailIDTxt.Size = new System.Drawing.Size(182, 20);
            this.emailIDTxt.TabIndex = 40;
            this.emailIDTxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.emailIDTxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailIDTxt_Validating);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(500, 192);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(182, 57);
            this.addressTxt.TabIndex = 39;
            this.addressTxt.Validating += new System.ComponentModel.CancelEventHandler(this.addressTxt_Validating);
            // 
            // mobileNoTxt
            // 
            this.mobileNoTxt.Location = new System.Drawing.Point(500, 152);
            this.mobileNoTxt.Name = "mobileNoTxt";
            this.mobileNoTxt.Size = new System.Drawing.Size(182, 20);
            this.mobileNoTxt.TabIndex = 38;
            this.mobileNoTxt.Validating += new System.ComponentModel.CancelEventHandler(this.mobileNoTxt_Validating);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(500, 106);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(182, 20);
            this.userNameTxt.TabIndex = 37;
            this.userNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.userNameTxt_Validating);
            // 
            // designationLbl
            // 
            this.designationLbl.AutoSize = true;
            this.designationLbl.BackColor = System.Drawing.Color.Transparent;
            this.designationLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.designationLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.designationLbl.Location = new System.Drawing.Point(308, 494);
            this.designationLbl.Name = "designationLbl";
            this.designationLbl.Size = new System.Drawing.Size(101, 22);
            this.designationLbl.TabIndex = 35;
            this.designationLbl.Text = "Designation";
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.pwdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pwdLbl.Location = new System.Drawing.Point(308, 410);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(82, 22);
            this.pwdLbl.TabIndex = 34;
            this.pwdLbl.Text = "Password";
            // 
            // dobdate
            // 
            this.dobdate.AutoSize = true;
            this.dobdate.BackColor = System.Drawing.Color.Transparent;
            this.dobdate.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.dobdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dobdate.Location = new System.Drawing.Point(308, 357);
            this.dobdate.Name = "dobdate";
            this.dobdate.Size = new System.Drawing.Size(47, 22);
            this.dobdate.TabIndex = 33;
            this.dobdate.Text = "DOB";
            // 
            // emailidrbtn
            // 
            this.emailidrbtn.AutoSize = true;
            this.emailidrbtn.BackColor = System.Drawing.Color.Transparent;
            this.emailidrbtn.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.emailidrbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailidrbtn.Location = new System.Drawing.Point(308, 322);
            this.emailidrbtn.Name = "emailidrbtn";
            this.emailidrbtn.Size = new System.Drawing.Size(81, 22);
            this.emailidrbtn.TabIndex = 32;
            this.emailidrbtn.Text = "Email ID";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.genderLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.genderLbl.Location = new System.Drawing.Point(308, 273);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(64, 22);
            this.genderLbl.TabIndex = 31;
            this.genderLbl.Text = "Gender";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.BackColor = System.Drawing.Color.Transparent;
            this.addressLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.addressLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addressLbl.Location = new System.Drawing.Point(308, 194);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(70, 22);
            this.addressLbl.TabIndex = 30;
            this.addressLbl.Text = "Address";
            // 
            // mobilenoLbl
            // 
            this.mobilenoLbl.AutoSize = true;
            this.mobilenoLbl.BackColor = System.Drawing.Color.Transparent;
            this.mobilenoLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.mobilenoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mobilenoLbl.Location = new System.Drawing.Point(308, 152);
            this.mobilenoLbl.Name = "mobilenoLbl";
            this.mobilenoLbl.Size = new System.Drawing.Size(92, 22);
            this.mobilenoLbl.TabIndex = 29;
            this.mobilenoLbl.Text = "Mobile No.";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLbl.Location = new System.Drawing.Point(308, 108);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 22);
            this.nameLbl.TabIndex = 28;
            this.nameLbl.Text = "Name";
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // adduserLbl
            // 
            this.adduserLbl.AutoSize = true;
            this.adduserLbl.BackColor = System.Drawing.Color.Transparent;
            this.adduserLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adduserLbl.Location = new System.Drawing.Point(463, 10);
            this.adduserLbl.Name = "adduserLbl";
            this.adduserLbl.Size = new System.Drawing.Size(172, 38);
            this.adduserLbl.TabIndex = 27;
            this.adduserLbl.Text = "ADD USER";
            // 
            // trainingDataSet
            // 
            this.trainingDataSet.DataSetName = "TrainingDataSet";
            this.trainingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderuserBindingSource
            // 
            this.orderuserBindingSource.DataMember = "order_user";
            this.orderuserBindingSource.DataSource = this.trainingDataSet;
            // 
            // order_userTableAdapter
            // 
            this.order_userTableAdapter.ClearBeforeFill = true;
            // 
            // trainingDataSet1
            // 
            this.trainingDataSet1.DataSetName = "TrainingDataSet";
            this.trainingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingDataSet2
            // 
            this.trainingDataSet2.DataSetName = "TrainingDataSet";
            this.trainingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_userTableAdapter1
            // 
            this.order_userTableAdapter1.ClearBeforeFill = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(610, 544);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(111, 38);
            this.resetBtn.TabIndex = 48;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ErrProviderUsrName
            // 
            this.ErrProviderUsrName.ContainerControl = this;
            // 
            // errorProviderMobileNo
            // 
            this.errorProviderMobileNo.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderEmailId
            // 
            this.errorProviderEmailId.ContainerControl = this;
            // 
            // errorProviderPwd
            // 
            this.errorProviderPwd.ContainerControl = this;
            // 
            // errorProviderConfirmPwd
            // 
            this.errorProviderConfirmPwd.ContainerControl = this;
            // 
            // errorProviderDesg
            // 
            this.errorProviderDesg.ContainerControl = this;
            // 
            // errorProviderDOB
            // 
            this.errorProviderDOB.ContainerControl = this;
            // 
            // errorProviderDesignation
            // 
            this.errorProviderDesignation.ContainerControl = this;
            // 
            // adduserctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.genderPnl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.confirmPwdTxt);
            this.Controls.Add(this.cpwdLbl);
            this.Controls.Add(this.dobDatePicker);
            this.Controls.Add(this.designationCmb);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.emailIDTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.mobileNoTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.designationLbl);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.dobdate);
            this.Controls.Add(this.emailidrbtn);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.mobilenoLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.adduserLbl);
            this.Location = new System.Drawing.Point(70, 61);
            this.Name = "adduserctrl";
            this.Size = new System.Drawing.Size(1092, 673);
            this.Load += new System.EventHandler(this.AddUserControl_Load);
            this.genderPnl.ResumeLayout(false);
            this.genderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProviderUsrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMobileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel genderPnl;
        private System.Windows.Forms.RadioButton malerbtn;
        private System.Windows.Forms.RadioButton femalerBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox confirmPwdTxt;
        private System.Windows.Forms.Label cpwdLbl;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.ComboBox designationCmb;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.TextBox emailIDTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox mobileNoTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label designationLbl;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label dobdate;
        private System.Windows.Forms.Label emailidrbtn;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label mobilenoLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label adduserLbl;
        private System.Windows.Forms.BindingSource orderuserBindingSource;
        private TrainingDataSet trainingDataSet;
        private TrainingDataSetTableAdapters.order_userTableAdapter order_userTableAdapter;
        private TrainingDataSet trainingDataSet1;
        private TrainingDataSet trainingDataSet2;
        private TrainingDataSetTableAdapters.order_userTableAdapter order_userTableAdapter1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ErrorProvider ErrProviderUsrName;
        private System.Windows.Forms.ErrorProvider errorProviderMobileNo;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderEmailId;
        private System.Windows.Forms.ErrorProvider errorProviderPwd;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPwd;
        private System.Windows.Forms.ErrorProvider errorProviderDesg;
        private System.Windows.Forms.ErrorProvider errorProviderDOB;
        private System.Windows.Forms.ErrorProvider errorProviderDesignation;
    }
}
