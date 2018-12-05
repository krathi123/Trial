namespace Trial
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.searchItmCategorynameBtn = new System.Windows.Forms.Button();
            this.ItmcategorynameTxt = new System.Windows.Forms.TextBox();
            this.Itmsearchcategorynamelbl = new System.Windows.Forms.Label();
            this.searchItemyIdBtn = new System.Windows.Forms.Button();
            this.byItemNameTxt = new System.Windows.Forms.TextBox();
            this.byItemNameLbl = new System.Windows.Forms.Label();
            this.edititemLbl = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.findAllBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchItmCategorynameBtn
            // 
            this.searchItmCategorynameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItmCategorynameBtn.Location = new System.Drawing.Point(452, 151);
            this.searchItmCategorynameBtn.Name = "searchItmCategorynameBtn";
            this.searchItmCategorynameBtn.Size = new System.Drawing.Size(75, 34);
            this.searchItmCategorynameBtn.TabIndex = 19;
            this.searchItmCategorynameBtn.Text = "Search";
            this.searchItmCategorynameBtn.UseVisualStyleBackColor = true;
            this.searchItmCategorynameBtn.Click += new System.EventHandler(this.searchItmCategorynameBtn_Click);
            // 
            // ItmcategorynameTxt
            // 
            this.ItmcategorynameTxt.Location = new System.Drawing.Point(253, 152);
            this.ItmcategorynameTxt.Name = "ItmcategorynameTxt";
            this.ItmcategorynameTxt.Size = new System.Drawing.Size(177, 20);
            this.ItmcategorynameTxt.TabIndex = 18;
            this.ItmcategorynameTxt.TextChanged += new System.EventHandler(this.ItmcategorynameTxt_TextChanged);
            // 
            // Itmsearchcategorynamelbl
            // 
            this.Itmsearchcategorynamelbl.AutoSize = true;
            this.Itmsearchcategorynamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Itmsearchcategorynamelbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itmsearchcategorynamelbl.Location = new System.Drawing.Point(17, 152);
            this.Itmsearchcategorynamelbl.Name = "Itmsearchcategorynamelbl";
            this.Itmsearchcategorynamelbl.Size = new System.Drawing.Size(205, 22);
            this.Itmsearchcategorynamelbl.TabIndex = 17;
            this.Itmsearchcategorynamelbl.Text = "Search by Category Name";
            this.Itmsearchcategorynamelbl.Click += new System.EventHandler(this.Itmsearchcategorynamelbl_Click);
            // 
            // searchItemyIdBtn
            // 
            this.searchItemyIdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemyIdBtn.Location = new System.Drawing.Point(452, 111);
            this.searchItemyIdBtn.Name = "searchItemyIdBtn";
            this.searchItemyIdBtn.Size = new System.Drawing.Size(75, 34);
            this.searchItemyIdBtn.TabIndex = 16;
            this.searchItemyIdBtn.Text = "Search";
            this.searchItemyIdBtn.UseVisualStyleBackColor = true;
            this.searchItemyIdBtn.Click += new System.EventHandler(this.searchItemyIdBtn_Click);
            // 
            // byItemNameTxt
            // 
            this.byItemNameTxt.Location = new System.Drawing.Point(253, 119);
            this.byItemNameTxt.Name = "byItemNameTxt";
            this.byItemNameTxt.Size = new System.Drawing.Size(177, 20);
            this.byItemNameTxt.TabIndex = 15;
            this.byItemNameTxt.TextChanged += new System.EventHandler(this.byItemidTxt_TextChanged);
            // 
            // byItemNameLbl
            // 
            this.byItemNameLbl.AutoSize = true;
            this.byItemNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.byItemNameLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byItemNameLbl.Location = new System.Drawing.Point(17, 117);
            this.byItemNameLbl.Name = "byItemNameLbl";
            this.byItemNameLbl.Size = new System.Drawing.Size(174, 22);
            this.byItemNameLbl.TabIndex = 14;
            this.byItemNameLbl.Text = "Search by Item Name";
            this.byItemNameLbl.Click += new System.EventHandler(this.byItemIDLbl_Click);
            // 
            // edititemLbl
            // 
            this.edititemLbl.AutoSize = true;
            this.edititemLbl.BackColor = System.Drawing.Color.Transparent;
            this.edititemLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edititemLbl.Location = new System.Drawing.Point(258, 30);
            this.edititemLbl.Name = "edititemLbl";
            this.edititemLbl.Size = new System.Drawing.Size(143, 38);
            this.edititemLbl.TabIndex = 20;
            this.edititemLbl.Text = "Edit Item";
            this.edititemLbl.Click += new System.EventHandler(this.edititemLbl_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(99, 272);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(411, 180);
            this.dataGridViewItems.TabIndex = 21;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellValueChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(265, 474);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 39);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // findAllBtn
            // 
            this.findAllBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllBtn.Location = new System.Drawing.Point(229, 205);
            this.findAllBtn.Name = "findAllBtn";
            this.findAllBtn.Size = new System.Drawing.Size(126, 31);
            this.findAllBtn.TabIndex = 23;
            this.findAllBtn.Text = "Find All";
            this.findAllBtn.UseVisualStyleBackColor = true;
            this.findAllBtn.Click += new System.EventHandler(this.findAllBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.edititemLbl);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.findAllBtn);
            this.panel1.Controls.Add(this.searchItmCategorynameBtn);
            this.panel1.Controls.Add(this.byItemNameLbl);
            this.panel1.Controls.Add(this.searchItemyIdBtn);
            this.panel1.Controls.Add(this.byItemNameTxt);
            this.panel1.Controls.Add(this.dataGridViewItems);
            this.panel1.Controls.Add(this.Itmsearchcategorynamelbl);
            this.panel1.Controls.Add(this.ItmcategorynameTxt);
            this.panel1.Location = new System.Drawing.Point(137, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 538);
            this.panel1.TabIndex = 24;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(1022, 639);
            this.Load += new System.EventHandler(this.EditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchItmCategorynameBtn;
        private System.Windows.Forms.TextBox ItmcategorynameTxt;
        private System.Windows.Forms.Label Itmsearchcategorynamelbl;
        private System.Windows.Forms.Button searchItemyIdBtn;
        private System.Windows.Forms.TextBox byItemNameTxt;
        private System.Windows.Forms.Label byItemNameLbl;
        private System.Windows.Forms.Label edititemLbl;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button findAllBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
