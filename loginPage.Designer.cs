namespace Trial
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.mobileNoTxt = new System.Windows.Forms.TextBox();
            this.mobilenoLbl = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
            this.errorProvidermobileNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderdesg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermobileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderdesg)).BeginInit();
            this.SuspendLayout();
            // 
            // mobileNoTxt
            // 
            this.mobileNoTxt.Location = new System.Drawing.Point(292, 129);
            this.mobileNoTxt.Name = "mobileNoTxt";
            this.mobileNoTxt.Size = new System.Drawing.Size(182, 20);
            this.mobileNoTxt.TabIndex = 40;
            this.mobileNoTxt.Validating += new System.ComponentModel.CancelEventHandler(this.mobileNoTxt_Validating);
            // 
            // mobilenoLbl
            // 
            this.mobilenoLbl.AutoSize = true;
            this.mobilenoLbl.BackColor = System.Drawing.Color.Transparent;
            this.mobilenoLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mobilenoLbl.Location = new System.Drawing.Point(100, 129);
            this.mobilenoLbl.Name = "mobilenoLbl";
            this.mobilenoLbl.Size = new System.Drawing.Size(92, 22);
            this.mobilenoLbl.TabIndex = 39;
            this.mobilenoLbl.Text = "Mobile No.";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(292, 181);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(182, 20);
            this.pwdTxt.TabIndex = 43;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pwdLbl.Location = new System.Drawing.Point(100, 181);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(82, 22);
            this.pwdLbl.TabIndex = 42;
            this.pwdLbl.Text = "Password";
            this.pwdLbl.Click += new System.EventHandler(this.pwdLbl_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.submitbtn.Location = new System.Drawing.Point(231, 282);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(126, 34);
            this.submitbtn.TabIndex = 44;
            this.submitbtn.Text = "login";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLbl.Location = new System.Drawing.Point(238, 25);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(119, 38);
            this.loginLbl.TabIndex = 45;
            this.loginLbl.Text = "LOG IN";
            // 
            // errorProvidermobileNo
            // 
            this.errorProvidermobileNo.ContainerControl = this;
            // 
            // errorProviderPwd
            // 
            this.errorProviderPwd.ContainerControl = this;
            // 
            // errorProviderdesg
            // 
            this.errorProviderdesg.ContainerControl = this;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 407);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.mobileNoTxt);
            this.Controls.Add(this.mobilenoLbl);
            this.MaximizeBox = false;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginPage";
            this.Load += new System.EventHandler(this.loginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermobileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderdesg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mobileNoTxt;
        private System.Windows.Forms.Label mobilenoLbl;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.ErrorProvider errorProvidermobileNo;
        private System.Windows.Forms.ErrorProvider errorProviderPwd;
        private System.Windows.Forms.ErrorProvider errorProviderdesg;
    }
}