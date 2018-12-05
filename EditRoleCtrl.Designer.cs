namespace Trial
{
    partial class EditRoleCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoleCtrl));
            this.updateBtn = new System.Windows.Forms.Button();
            this.roleDescTxt = new System.Windows.Forms.TextBox();
            this.roleDescLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.roleNameTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.editRoleLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Location = new System.Drawing.Point(400, 309);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 29);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // roleDescTxt
            // 
            this.roleDescTxt.Location = new System.Drawing.Point(400, 240);
            this.roleDescTxt.Name = "roleDescTxt";
            this.roleDescTxt.Size = new System.Drawing.Size(202, 20);
            this.roleDescTxt.TabIndex = 12;
            // 
            // roleDescLbl
            // 
            this.roleDescLbl.AutoSize = true;
            this.roleDescLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDescLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roleDescLbl.Location = new System.Drawing.Point(219, 238);
            this.roleDescLbl.Name = "roleDescLbl";
            this.roleDescLbl.Size = new System.Drawing.Size(137, 22);
            this.roleDescLbl.TabIndex = 11;
            this.roleDescLbl.Text = "Role Description";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(628, 183);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // roleNameTxt
            // 
            this.roleNameTxt.Location = new System.Drawing.Point(400, 186);
            this.roleNameTxt.Name = "roleNameTxt";
            this.roleNameTxt.Size = new System.Drawing.Size(202, 20);
            this.roleNameTxt.TabIndex = 9;
            this.roleNameTxt.TextChanged += new System.EventHandler(this.roleNameTxt_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchLbl.Location = new System.Drawing.Point(219, 186);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(142, 22);
            this.searchLbl.TabIndex = 8;
            this.searchLbl.Text = "Enter Role Name";
            // 
            // editRoleLbl
            // 
            this.editRoleLbl.AutoSize = true;
            this.editRoleLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoleLbl.Location = new System.Drawing.Point(404, 94);
            this.editRoleLbl.Name = "editRoleLbl";
            this.editRoleLbl.Size = new System.Drawing.Size(142, 38);
            this.editRoleLbl.TabIndex = 7;
            this.editRoleLbl.Text = "Edit Role";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Location = new System.Drawing.Point(539, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditRoleCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleDescTxt);
            this.Controls.Add(this.roleDescLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.roleNameTxt);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.editRoleLbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "EditRoleCtrl";
            this.Size = new System.Drawing.Size(953, 619);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox roleDescTxt;
        private System.Windows.Forms.Label roleDescLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox roleNameTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label editRoleLbl;
        private System.Windows.Forms.Button deleteBtn;
    }
}
