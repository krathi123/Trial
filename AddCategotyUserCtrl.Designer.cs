namespace Trial
{
    partial class AddCategotyUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategotyUserCtrl));
            this.addCategotryLbl = new System.Windows.Forms.Label();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.categorynameTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categorynDescTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.errorProviderDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidercName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidercdesc = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercdesc)).BeginInit();
            this.SuspendLayout();
            // 
            // addCategotryLbl
            // 
            this.addCategotryLbl.AutoSize = true;
            this.addCategotryLbl.BackColor = System.Drawing.Color.Transparent;
            this.addCategotryLbl.Font = new System.Drawing.Font("Bodoni MT", 26F, System.Drawing.FontStyle.Bold);
            this.addCategotryLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCategotryLbl.Location = new System.Drawing.Point(406, 36);
            this.addCategotryLbl.Name = "addCategotryLbl";
            this.addCategotryLbl.Size = new System.Drawing.Size(222, 41);
            this.addCategotryLbl.TabIndex = 0;
            this.addCategotryLbl.Text = "Add Categotry";
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryNameLbl.Font = new System.Drawing.Font("Bodoni MT", 16F, System.Drawing.FontStyle.Bold);
            this.categoryNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryNameLbl.Location = new System.Drawing.Point(258, 178);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(149, 26);
            this.categoryNameLbl.TabIndex = 2;
            this.categoryNameLbl.Text = "Category Name";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Bodoni MT", 16F, System.Drawing.FontStyle.Bold);
            this.descriptionLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descriptionLbl.Location = new System.Drawing.Point(258, 254);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(114, 26);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description";
            // 
            // categorynameTxt
            // 
            this.categorynameTxt.Location = new System.Drawing.Point(488, 178);
            this.categorynameTxt.Name = "categorynameTxt";
            this.categorynameTxt.Size = new System.Drawing.Size(150, 20);
            this.categorynameTxt.TabIndex = 5;
            this.categorynameTxt.TextChanged += new System.EventHandler(this.categorynameTxt_TextChanged);
            this.categorynameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.categorynameTxt_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // categorynDescTxt
            // 
            this.categorynDescTxt.Location = new System.Drawing.Point(488, 254);
            this.categorynDescTxt.Multiline = true;
            this.categorynDescTxt.Name = "categorynDescTxt";
            this.categorynDescTxt.Size = new System.Drawing.Size(150, 86);
            this.categorynDescTxt.TabIndex = 7;
            this.categorynDescTxt.Validating += new System.ComponentModel.CancelEventHandler(this.categorynDescTxt_Validating);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(362, 407);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(120, 38);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(563, 407);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(109, 38);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // errorProviderDesc
            // 
            this.errorProviderDesc.ContainerControl = this;
            // 
            // errorProvidercName
            // 
            this.errorProvidercName.ContainerControl = this;
            // 
            // errorProvidercdesc
            // 
            this.errorProvidercdesc.ContainerControl = this;
            // 
            // AddCategotyUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.categorynDescTxt);
            this.Controls.Add(this.categorynameTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.categoryNameLbl);
            this.Controls.Add(this.addCategotryLbl);
            this.Name = "AddCategotyUserCtrl";
            this.Size = new System.Drawing.Size(1027, 645);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercdesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addCategotryLbl;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox categorynameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox categorynDescTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ErrorProvider errorProviderDesc;
        private System.Windows.Forms.ErrorProvider errorProvidercName;
        private System.Windows.Forms.ErrorProvider errorProvidercdesc;
    }
}
