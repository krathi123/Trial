namespace Trial
{
    partial class ViewUser
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
            this.viewusrLbl = new System.Windows.Forms.Label();
            this.viewdesgBtn = new System.Windows.Forms.Button();
            this.viewdesgTxt = new System.Windows.Forms.TextBox();
            this.viewdesglbl = new System.Windows.Forms.Label();
            this.viewsearchBtn = new System.Windows.Forms.Button();
            this.viewuseridTxt = new System.Windows.Forms.TextBox();
            this.viewusridLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewusrLbl
            // 
            this.viewusrLbl.AutoSize = true;
            this.viewusrLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewusrLbl.Location = new System.Drawing.Point(401, 45);
            this.viewusrLbl.Name = "viewusrLbl";
            this.viewusrLbl.Size = new System.Drawing.Size(113, 28);
            this.viewusrLbl.TabIndex = 0;
            this.viewusrLbl.Text = "View User";
            // 
            // viewdesgBtn
            // 
            this.viewdesgBtn.Location = new System.Drawing.Point(596, 144);
            this.viewdesgBtn.Name = "viewdesgBtn";
            this.viewdesgBtn.Size = new System.Drawing.Size(75, 23);
            this.viewdesgBtn.TabIndex = 12;
            this.viewdesgBtn.Text = "Search";
            this.viewdesgBtn.UseVisualStyleBackColor = true;
            // 
            // viewdesgTxt
            // 
            this.viewdesgTxt.Location = new System.Drawing.Point(356, 148);
            this.viewdesgTxt.Name = "viewdesgTxt";
            this.viewdesgTxt.Size = new System.Drawing.Size(177, 20);
            this.viewdesgTxt.TabIndex = 11;
            // 
            // viewdesglbl
            // 
            this.viewdesglbl.AutoSize = true;
            this.viewdesglbl.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdesglbl.Location = new System.Drawing.Point(181, 148);
            this.viewdesglbl.Name = "viewdesglbl";
            this.viewdesglbl.Size = new System.Drawing.Size(139, 18);
            this.viewdesglbl.TabIndex = 10;
            this.viewdesglbl.Text = "Search by designation";
            // 
            // viewsearchBtn
            // 
            this.viewsearchBtn.Location = new System.Drawing.Point(596, 111);
            this.viewsearchBtn.Name = "viewsearchBtn";
            this.viewsearchBtn.Size = new System.Drawing.Size(75, 23);
            this.viewsearchBtn.TabIndex = 9;
            this.viewsearchBtn.Text = "Search";
            this.viewsearchBtn.UseVisualStyleBackColor = true;
            // 
            // viewuseridTxt
            // 
            this.viewuseridTxt.Location = new System.Drawing.Point(356, 115);
            this.viewuseridTxt.Name = "viewuseridTxt";
            this.viewuseridTxt.Size = new System.Drawing.Size(177, 20);
            this.viewuseridTxt.TabIndex = 8;
            // 
            // viewusridLbl
            // 
            this.viewusridLbl.AutoSize = true;
            this.viewusridLbl.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewusridLbl.Location = new System.Drawing.Point(181, 115);
            this.viewusridLbl.Name = "viewusridLbl";
            this.viewusridLbl.Size = new System.Drawing.Size(116, 18);
            this.viewusridLbl.TabIndex = 7;
            this.viewusridLbl.Text = "Search by user ID";
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.viewdesgBtn);
            this.Controls.Add(this.viewdesgTxt);
            this.Controls.Add(this.viewdesglbl);
            this.Controls.Add(this.viewsearchBtn);
            this.Controls.Add(this.viewuseridTxt);
            this.Controls.Add(this.viewusridLbl);
            this.Controls.Add(this.viewusrLbl);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(950, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewusrLbl;
        private System.Windows.Forms.Button viewdesgBtn;
        private System.Windows.Forms.TextBox viewdesgTxt;
        private System.Windows.Forms.Label viewdesglbl;
        private System.Windows.Forms.Button viewsearchBtn;
        private System.Windows.Forms.TextBox viewuseridTxt;
        private System.Windows.Forms.Label viewusridLbl;
    }
}
