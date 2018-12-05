namespace Trial
{
    partial class editOrderlistUsrctrl
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
            this.editOrderLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editOrderLbl
            // 
            this.editOrderLbl.AutoSize = true;
            this.editOrderLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderLbl.Location = new System.Drawing.Point(410, 247);
            this.editOrderLbl.Name = "editOrderLbl";
            this.editOrderLbl.Size = new System.Drawing.Size(42, 22);
            this.editOrderLbl.TabIndex = 0;
            this.editOrderLbl.Text = "Edit";
            // 
            // editOrderlistUsrctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.editOrderLbl);
            this.Name = "editOrderlistUsrctrl";
            this.Size = new System.Drawing.Size(903, 588);
            this.Load += new System.EventHandler(this.editOrderlistUsrctrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editOrderLbl;
    }
}
