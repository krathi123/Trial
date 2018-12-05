namespace Trial
{
    partial class adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpage));
            this.menupanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.editRolebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.adduserBtn = new System.Windows.Forms.Button();
            this.trainingDataSet = new Trial.TrainingDataSet();
            this.orderuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_userTableAdapter = new Trial.TrainingDataSetTableAdapters.order_userTableAdapter();
            this.orderuserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.addRoleUsrCtrl2 = new Trial.AddRoleUsrCtrl();
            this.addRoleUsrCtrl1 = new Trial.AddRoleUsrCtrl();
            this.viewUserCtrl1 = new Trial.ViewUser();
            this.editUserCtrl1 = new Trial.editUser();
            this.adduserctrl1 = new Trial.adduserctrl();
            this.editRoleCtrl1 = new Trial.EditRoleCtrl();
            this.homePage1 = new Trial.HomePage();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.Black;
            this.menupanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menupanel.Controls.Add(this.button5);
            this.menupanel.Controls.Add(this.editRolebtn);
            this.menupanel.Controls.Add(this.button4);
            this.menupanel.Controls.Add(this.button2);
            this.menupanel.Controls.Add(this.homeBtn);
            this.menupanel.Controls.Add(this.adduserBtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(181, 772);
            this.menupanel.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add Role";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // editRolebtn
            // 
            this.editRolebtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRolebtn.Location = new System.Drawing.Point(12, 383);
            this.editRolebtn.Name = "editRolebtn";
            this.editRolebtn.Size = new System.Drawing.Size(150, 40);
            this.editRolebtn.TabIndex = 6;
            this.editRolebtn.Text = "Edit Role";
            this.editRolebtn.UseVisualStyleBackColor = true;
            this.editRolebtn.Click += new System.EventHandler(this.editRolebtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateuserBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(12, 95);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(150, 40);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // adduserBtn
            // 
            this.adduserBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserBtn.Location = new System.Drawing.Point(12, 167);
            this.adduserBtn.Name = "adduserBtn";
            this.adduserBtn.Size = new System.Drawing.Size(150, 40);
            this.adduserBtn.TabIndex = 0;
            this.adduserBtn.Text = "Add User";
            this.adduserBtn.UseVisualStyleBackColor = true;
            this.adduserBtn.Click += new System.EventHandler(this.adduserBtn_Click);
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
            // orderuserBindingSource1
            // 
            this.orderuserBindingSource1.DataMember = "order_user";
            this.orderuserBindingSource1.DataSource = this.trainingDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addRoleUsrCtrl2
            // 
            this.addRoleUsrCtrl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addRoleUsrCtrl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRoleUsrCtrl2.BackgroundImage")));
            this.addRoleUsrCtrl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRoleUsrCtrl2.Location = new System.Drawing.Point(482, 0);
            this.addRoleUsrCtrl2.Name = "addRoleUsrCtrl2";
            this.addRoleUsrCtrl2.Size = new System.Drawing.Size(89, 48);
            this.addRoleUsrCtrl2.TabIndex = 6;
            // 
            // addRoleUsrCtrl1
            // 
            this.addRoleUsrCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addRoleUsrCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRoleUsrCtrl1.BackgroundImage")));
            this.addRoleUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRoleUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRoleUsrCtrl1.Location = new System.Drawing.Point(181, 0);
            this.addRoleUsrCtrl1.Name = "addRoleUsrCtrl1";
            this.addRoleUsrCtrl1.Size = new System.Drawing.Size(1008, 772);
            this.addRoleUsrCtrl1.TabIndex = 5;
            this.addRoleUsrCtrl1.Load += new System.EventHandler(this.addRoleUsrCtrl1_Load);
            // 
            // viewUserCtrl1
            // 
            this.viewUserCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewUserCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUserCtrl1.Location = new System.Drawing.Point(181, 0);
            this.viewUserCtrl1.Name = "viewUserCtrl1";
            this.viewUserCtrl1.Size = new System.Drawing.Size(1008, 772);
            this.viewUserCtrl1.TabIndex = 4;
            // 
            // editUserCtrl1
            // 
            this.editUserCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editUserCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editUserCtrl1.BackgroundImage")));
            this.editUserCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUserCtrl1.Location = new System.Drawing.Point(181, 0);
            this.editUserCtrl1.Name = "editUserCtrl1";
            this.editUserCtrl1.Size = new System.Drawing.Size(1008, 772);
            this.editUserCtrl1.TabIndex = 3;
            // 
            // adduserctrl1
            // 
            this.adduserctrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adduserctrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adduserctrl1.BackgroundImage")));
            this.adduserctrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adduserctrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adduserctrl1.Location = new System.Drawing.Point(181, 0);
            this.adduserctrl1.Name = "adduserctrl1";
            this.adduserctrl1.Size = new System.Drawing.Size(1008, 772);
            this.adduserctrl1.TabIndex = 2;
            // 
            // editRoleCtrl1
            // 
            this.editRoleCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editRoleCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editRoleCtrl1.BackgroundImage")));
            this.editRoleCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editRoleCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editRoleCtrl1.Location = new System.Drawing.Point(181, 0);
            this.editRoleCtrl1.Name = "editRoleCtrl1";
            this.editRoleCtrl1.Size = new System.Drawing.Size(1008, 772);
            this.editRoleCtrl1.TabIndex = 7;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage1.Location = new System.Drawing.Point(181, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(1008, 772);
            this.homePage1.TabIndex = 8;
            // 
            // adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1189, 772);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.editRoleCtrl1);
            this.Controls.Add(this.addRoleUsrCtrl2);
            this.Controls.Add(this.addRoleUsrCtrl1);
            this.Controls.Add(this.viewUserCtrl1);
            this.Controls.Add(this.editUserCtrl1);
            this.Controls.Add(this.adduserctrl1);
            this.Controls.Add(this.menupanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin page";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menupanel;
        private TrainingDataSet trainingDataSet;
        private System.Windows.Forms.BindingSource orderuserBindingSource;
        private TrainingDataSetTableAdapters.order_userTableAdapter order_userTableAdapter;
        private System.Windows.Forms.BindingSource orderuserBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button adduserBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private adduserctrl adduserctrl1;
        private editUser editUserCtrl1;
        private ViewUser viewUserCtrl1;
        private System.Windows.Forms.Button editRolebtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private AddRoleUsrCtrl addRoleUsrCtrl1;
        private AddRoleUsrCtrl addRoleUsrCtrl2;
        private EditRoleCtrl editRoleCtrl1;
        private HomePage homePage1;
    }
}