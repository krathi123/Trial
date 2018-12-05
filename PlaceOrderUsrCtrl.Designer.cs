namespace Trial
{
    partial class PlaceOrderUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderUsrCtrl));
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridViewItemsList = new System.Windows.Forms.DataGridView();
            this.placeOrderLbl = new System.Windows.Forms.Label();
            this.categorynameCmb = new System.Windows.Forms.ComboBox();
            this.categorynameLbl = new System.Windows.Forms.Label();
            this.orderLbl = new System.Windows.Forms.Button();
            this.canecelOrderBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(711, 163);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 52;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridViewItemsList
            // 
            this.dataGridViewItemsList.AllowUserToAddRows = false;
            this.dataGridViewItemsList.AllowUserToDeleteRows = false;
            this.dataGridViewItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsList.Location = new System.Drawing.Point(93, 235);
            this.dataGridViewItemsList.Name = "dataGridViewItemsList";
            this.dataGridViewItemsList.ReadOnly = true;
            this.dataGridViewItemsList.Size = new System.Drawing.Size(804, 163);
            this.dataGridViewItemsList.TabIndex = 51;
            this.dataGridViewItemsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemsList_CellContentClick);
            this.dataGridViewItemsList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewItemsList_EditingControlShowing);
            // 
            // placeOrderLbl
            // 
            this.placeOrderLbl.AutoSize = true;
            this.placeOrderLbl.BackColor = System.Drawing.Color.White;
            this.placeOrderLbl.Font = new System.Drawing.Font("Bodoni MT", 26F, System.Drawing.FontStyle.Bold);
            this.placeOrderLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.placeOrderLbl.Location = new System.Drawing.Point(466, 41);
            this.placeOrderLbl.Name = "placeOrderLbl";
            this.placeOrderLbl.Size = new System.Drawing.Size(253, 41);
            this.placeOrderLbl.TabIndex = 50;
            this.placeOrderLbl.Text = "PLACE ORDER";
            this.placeOrderLbl.Click += new System.EventHandler(this.placeOrderLbl_Click);
            // 
            // categorynameCmb
            // 
            this.categorynameCmb.FormattingEnabled = true;
            this.categorynameCmb.Location = new System.Drawing.Point(473, 163);
            this.categorynameCmb.Name = "categorynameCmb";
            this.categorynameCmb.Size = new System.Drawing.Size(182, 21);
            this.categorynameCmb.TabIndex = 49;
            this.categorynameCmb.SelectedIndexChanged += new System.EventHandler(this.categorynameCmb_SelectedIndexChanged);
            // 
            // categorynameLbl
            // 
            this.categorynameLbl.AutoSize = true;
            this.categorynameLbl.BackColor = System.Drawing.Color.White;
            this.categorynameLbl.Font = new System.Drawing.Font("Bodoni MT", 16F, System.Drawing.FontStyle.Bold);
            this.categorynameLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.categorynameLbl.Location = new System.Drawing.Point(274, 166);
            this.categorynameLbl.Name = "categorynameLbl";
            this.categorynameLbl.Size = new System.Drawing.Size(149, 26);
            this.categorynameLbl.TabIndex = 48;
            this.categorynameLbl.Text = "Category Name";
            // 
            // orderLbl
            // 
            this.orderLbl.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.Location = new System.Drawing.Point(93, 447);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(162, 30);
            this.orderLbl.TabIndex = 53;
            this.orderLbl.Text = "Order";
            this.orderLbl.UseVisualStyleBackColor = true;
            this.orderLbl.Click += new System.EventHandler(this.orderLbl_Click);
            // 
            // canecelOrderBtn
            // 
            this.canecelOrderBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canecelOrderBtn.Location = new System.Drawing.Point(429, 447);
            this.canecelOrderBtn.Name = "canecelOrderBtn";
            this.canecelOrderBtn.Size = new System.Drawing.Size(150, 30);
            this.canecelOrderBtn.TabIndex = 54;
            this.canecelOrderBtn.Text = "Cancel Order";
            this.canecelOrderBtn.UseVisualStyleBackColor = true;
            this.canecelOrderBtn.Visible = false;
            this.canecelOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(735, 447);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(162, 30);
            this.refreshBtn.TabIndex = 55;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // PlaceOrderUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.canecelOrderBtn);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridViewItemsList);
            this.Controls.Add(this.placeOrderLbl);
            this.Controls.Add(this.categorynameCmb);
            this.Controls.Add(this.categorynameLbl);
            this.Name = "PlaceOrderUsrCtrl";
            this.Size = new System.Drawing.Size(1224, 645);
            this.Load += new System.EventHandler(this.PlaceOrderUsrCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridViewItemsList;
        private System.Windows.Forms.Label placeOrderLbl;
        private System.Windows.Forms.ComboBox categorynameCmb;
        private System.Windows.Forms.Label categorynameLbl;
        private System.Windows.Forms.Button orderLbl;
        private System.Windows.Forms.Button canecelOrderBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}
