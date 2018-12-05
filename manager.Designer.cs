namespace Trial
{
    partial class manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager));
            this.sidePnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.editItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.editCategoryBtn = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homePage1 = new Trial.HomePage();
            this.editItem1 = new Trial.EditItem();
            this.editcategoryUsrCtrl1 = new Trial.EditcategoryUsrCtrl();
            this.addItemUsrCtrl11 = new Trial.AddItemUsrCtrl1();
            this.addCategotyUserCtrl1 = new Trial.AddCategotyUserCtrl();
            this.sidePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.Black;
            this.sidePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePnl.Controls.Add(this.button1);
            this.sidePnl.Controls.Add(this.editItemBtn);
            this.sidePnl.Controls.Add(this.addItemBtn);
            this.sidePnl.Controls.Add(this.editCategoryBtn);
            this.sidePnl.Controls.Add(this.addCategoryBtn);
            this.sidePnl.Controls.Add(this.homeBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(200, 772);
            this.sidePnl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editItemBtn
            // 
            this.editItemBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editItemBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemBtn.Location = new System.Drawing.Point(32, 522);
            this.editItemBtn.Name = "editItemBtn";
            this.editItemBtn.Size = new System.Drawing.Size(130, 50);
            this.editItemBtn.TabIndex = 4;
            this.editItemBtn.Text = "Edit Item";
            this.editItemBtn.UseVisualStyleBackColor = true;
            this.editItemBtn.Click += new System.EventHandler(this.editItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addItemBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(32, 416);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(130, 50);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // editCategoryBtn
            // 
            this.editCategoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editCategoryBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoryBtn.Location = new System.Drawing.Point(32, 310);
            this.editCategoryBtn.Name = "editCategoryBtn";
            this.editCategoryBtn.Size = new System.Drawing.Size(130, 50);
            this.editCategoryBtn.TabIndex = 2;
            this.editCategoryBtn.Text = "Edit Category";
            this.editCategoryBtn.UseVisualStyleBackColor = true;
            this.editCategoryBtn.Click += new System.EventHandler(this.editCategoryBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.Location = new System.Drawing.Point(32, 204);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(130, 50);
            this.addCategoryBtn.TabIndex = 1;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(32, 98);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(130, 50);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.homePage1);
            this.panel1.Controls.Add(this.editItem1);
            this.panel1.Controls.Add(this.editcategoryUsrCtrl1);
            this.panel1.Controls.Add(this.addItemUsrCtrl11);
            this.panel1.Controls.Add(this.addCategotyUserCtrl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 772);
            this.panel1.TabIndex = 1;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage1.Location = new System.Drawing.Point(0, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(989, 772);
            this.homePage1.TabIndex = 4;
            // 
            // editItem1
            // 
            this.editItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editItem1.BackgroundImage")));
            this.editItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editItem1.Location = new System.Drawing.Point(0, 0);
            this.editItem1.Name = "editItem1";
            this.editItem1.Size = new System.Drawing.Size(989, 772);
            this.editItem1.TabIndex = 3;
            this.editItem1.Load += new System.EventHandler(this.editItem1_Load);
            // 
            // editcategoryUsrCtrl1
            // 
            this.editcategoryUsrCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editcategoryUsrCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editcategoryUsrCtrl1.BackgroundImage")));
            this.editcategoryUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editcategoryUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editcategoryUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.editcategoryUsrCtrl1.Name = "editcategoryUsrCtrl1";
            this.editcategoryUsrCtrl1.Size = new System.Drawing.Size(989, 772);
            this.editcategoryUsrCtrl1.TabIndex = 2;
            // 
            // addItemUsrCtrl11
            // 
            this.addItemUsrCtrl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addItemUsrCtrl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addItemUsrCtrl11.BackgroundImage")));
            this.addItemUsrCtrl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addItemUsrCtrl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemUsrCtrl11.Location = new System.Drawing.Point(0, 0);
            this.addItemUsrCtrl11.Name = "addItemUsrCtrl11";
            this.addItemUsrCtrl11.Size = new System.Drawing.Size(989, 772);
            this.addItemUsrCtrl11.TabIndex = 1;
            // 
            // addCategotyUserCtrl1
            // 
            this.addCategotyUserCtrl1.AutoSize = true;
            this.addCategotyUserCtrl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addCategotyUserCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCategotyUserCtrl1.BackgroundImage")));
            this.addCategotyUserCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCategotyUserCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCategotyUserCtrl1.Location = new System.Drawing.Point(0, 0);
            this.addCategotyUserCtrl1.Name = "addCategotyUserCtrl1";
            this.addCategotyUserCtrl1.Size = new System.Drawing.Size(989, 772);
            this.addCategotyUserCtrl1.TabIndex = 0;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.MaximizeBox = false;
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manager";
            this.Load += new System.EventHandler(this.manager_Load);
            this.sidePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button editCategoryBtn;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel panel1;
        private AddCategotyUserCtrl addCategotyUserCtrl1;
        private AddItemUsrCtrl1 addItemUsrCtrl11;
        private EditItem editItem1;
        private EditcategoryUsrCtrl editcategoryUsrCtrl1;
        private HomePage homePage1;
    }
}