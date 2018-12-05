namespace Trial
{
    partial class AddRoleUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoleUsrCtrl));
            this.addroleLbl = new System.Windows.Forms.Label();
            this.roleNameLbl = new System.Windows.Forms.Label();
            this.roledescLbl = new System.Windows.Forms.Label();
            this.roleDescTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submitBtn = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.RoleNamecomboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addroleLbl
            // 
            this.addroleLbl.AutoSize = true;
            this.addroleLbl.BackColor = System.Drawing.Color.Transparent;
            this.addroleLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addroleLbl.Location = new System.Drawing.Point(211, 39);
            this.addroleLbl.Name = "addroleLbl";
            this.addroleLbl.Size = new System.Drawing.Size(130, 38);
            this.addroleLbl.TabIndex = 0;
            this.addroleLbl.Text = "Add role";
            // 
            // roleNameLbl
            // 
            this.roleNameLbl.AutoSize = true;
            this.roleNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.roleNameLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roleNameLbl.Location = new System.Drawing.Point(45, 132);
            this.roleNameLbl.Name = "roleNameLbl";
            this.roleNameLbl.Size = new System.Drawing.Size(94, 22);
            this.roleNameLbl.TabIndex = 1;
            this.roleNameLbl.Text = "Role Name";
            // 
            // roledescLbl
            // 
            this.roledescLbl.AutoSize = true;
            this.roledescLbl.BackColor = System.Drawing.Color.Transparent;
            this.roledescLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roledescLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roledescLbl.Location = new System.Drawing.Point(24, 209);
            this.roledescLbl.Name = "roledescLbl";
            this.roledescLbl.Size = new System.Drawing.Size(137, 22);
            this.roledescLbl.TabIndex = 2;
            this.roledescLbl.Text = "Role Description";
            // 
            // roleDescTxt
            // 
            this.roleDescTxt.Location = new System.Drawing.Point(218, 200);
            this.roleDescTxt.Multiline = true;
            this.roleDescTxt.Name = "roleDescTxt";
            this.roleDescTxt.Size = new System.Drawing.Size(155, 48);
            this.roleDescTxt.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(146, 298);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 33);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Rest
            // 
            this.Rest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Rest.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.Location = new System.Drawing.Point(318, 298);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(75, 33);
            this.Rest.TabIndex = 7;
            this.Rest.Text = "Reset";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // RoleNamecomboBox
            // 
            this.RoleNamecomboBox.FormattingEnabled = true;
            this.RoleNamecomboBox.Location = new System.Drawing.Point(218, 132);
            this.RoleNamecomboBox.Name = "RoleNamecomboBox";
            this.RoleNamecomboBox.Size = new System.Drawing.Size(155, 21);
            this.RoleNamecomboBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.addroleLbl);
            this.panel1.Controls.Add(this.roleNameLbl);
            this.panel1.Controls.Add(this.RoleNamecomboBox);
            this.panel1.Controls.Add(this.roledescLbl);
            this.panel1.Controls.Add(this.Rest);
            this.panel1.Controls.Add(this.roleDescTxt);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Location = new System.Drawing.Point(159, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 373);
            this.panel1.TabIndex = 9;
            // 
            // AddRoleUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "AddRoleUsrCtrl";
            this.Size = new System.Drawing.Size(929, 667);
            this.Load += new System.EventHandler(this.AddRoleUsrCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addroleLbl;
        private System.Windows.Forms.Label roleNameLbl;
        private System.Windows.Forms.Label roledescLbl;
        private System.Windows.Forms.TextBox roleDescTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.ComboBox RoleNamecomboBox;
        private System.Windows.Forms.Panel panel1;
    }
}
