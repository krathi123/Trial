namespace Trial
{
    partial class Waiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.placeOrderUsrCtrl1 = new Trial.PlaceOrderUsrCtrl();
            this.homePage1 = new Trial.HomePage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 781);
            this.panel1.TabIndex = 0;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOutBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(50, 390);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(130, 50);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.placeOrderBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.Location = new System.Drawing.Point(50, 300);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(130, 50);
            this.placeOrderBtn.TabIndex = 5;
            this.placeOrderBtn.Text = "Place Order ";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(50, 212);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(130, 50);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // placeOrderUsrCtrl1
            // 
            this.placeOrderUsrCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placeOrderUsrCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placeOrderUsrCtrl1.BackgroundImage")));
            this.placeOrderUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placeOrderUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeOrderUsrCtrl1.Location = new System.Drawing.Point(212, 0);
            this.placeOrderUsrCtrl1.Name = "placeOrderUsrCtrl1";
            this.placeOrderUsrCtrl1.Size = new System.Drawing.Size(1066, 781);
            this.placeOrderUsrCtrl1.TabIndex = 1;
            this.placeOrderUsrCtrl1.Load += new System.EventHandler(this.placeOrderUsrCtrl1_Load);
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homePage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage1.BackgroundImage")));
            this.homePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage1.Location = new System.Drawing.Point(212, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(1066, 781);
            this.homePage1.TabIndex = 2;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 781);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.placeOrderUsrCtrl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter Page";
            this.Load += new System.EventHandler(this.Waiter_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button homeBtn;
        private PlaceOrderUsrCtrl placeOrderUsrCtrl1;
        private editOrderlistUsrctrl editOrderlist1;
        private HomePage homePage1;
    }
}