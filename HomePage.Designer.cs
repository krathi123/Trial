namespace Trial
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.homeCtrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeCtrl
            // 
            this.homeCtrl.AutoSize = true;
            this.homeCtrl.BackColor = System.Drawing.Color.Transparent;
            this.homeCtrl.Font = new System.Drawing.Font("Bodoni MT Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeCtrl.Location = new System.Drawing.Point(298, 109);
            this.homeCtrl.Name = "homeCtrl";
            this.homeCtrl.Size = new System.Drawing.Size(259, 41);
            this.homeCtrl.TabIndex = 0;
            this.homeCtrl.Text = "HOME PAGE";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.homeCtrl);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(868, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeCtrl;
    }
}
