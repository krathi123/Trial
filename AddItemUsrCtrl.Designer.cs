namespace Trial
{
    partial class AddItemUsrCtrl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemUsrCtrl1));
            this.itemDescTxt = new System.Windows.Forms.TextBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.itemTypelbl = new System.Windows.Forms.Label();
            this.radioButtonPnl = new System.Windows.Forms.Panel();
            this.nonVegRadioBtn = new System.Windows.Forms.RadioButton();
            this.vegRadioBtn = new System.Windows.Forms.RadioButton();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.addItemSubmitbtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.unitPriceTxt = new System.Windows.Forms.TextBox();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.unitPricelbl = new System.Windows.Forms.Label();
            this.errorProviderItemName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidercategoryName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderItemDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderstock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderunitprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryTxt = new System.Windows.Forms.ComboBox();
            this.radioButtonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItemDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderunitprice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDescTxt
            // 
            this.itemDescTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescTxt.Location = new System.Drawing.Point(244, 321);
            this.itemDescTxt.Multiline = true;
            this.itemDescTxt.Name = "itemDescTxt";
            this.itemDescTxt.Size = new System.Drawing.Size(150, 86);
            this.itemDescTxt.TabIndex = 13;
            this.itemDescTxt.TextChanged += new System.EventHandler(this.itemDescTxt_TextChanged);
            this.itemDescTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemDescriptionTxt_Validating);
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.itemNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTxt.Location = new System.Drawing.Point(240, 147);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(150, 20);
            this.itemNameTxt.TabIndex = 11;
            this.itemNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemNameTxt_Validating);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.descriptionLbl.Location = new System.Drawing.Point(56, 321);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(97, 22);
            this.descriptionLbl.TabIndex = 10;
            this.descriptionLbl.Text = "Description";
            this.descriptionLbl.Click += new System.EventHandler(this.descriptionLbl_Click);
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.categoryNameLbl.Location = new System.Drawing.Point(56, 198);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(126, 22);
            this.categoryNameLbl.TabIndex = 9;
            this.categoryNameLbl.Text = "Category Name";
            this.categoryNameLbl.Click += new System.EventHandler(this.categoryNameLbl_Click);
            // 
            // itemTypelbl
            // 
            this.itemTypelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTypelbl.AutoSize = true;
            this.itemTypelbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypelbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.itemTypelbl.Location = new System.Drawing.Point(56, 244);
            this.itemTypelbl.Name = "itemTypelbl";
            this.itemTypelbl.Size = new System.Drawing.Size(88, 22);
            this.itemTypelbl.TabIndex = 14;
            this.itemTypelbl.Text = "Item Type";
            this.itemTypelbl.Click += new System.EventHandler(this.itemTypelbl_Click);
            // 
            // radioButtonPnl
            // 
            this.radioButtonPnl.Controls.Add(this.nonVegRadioBtn);
            this.radioButtonPnl.Controls.Add(this.vegRadioBtn);
            this.radioButtonPnl.Location = new System.Drawing.Point(245, 244);
            this.radioButtonPnl.Name = "radioButtonPnl";
            this.radioButtonPnl.Size = new System.Drawing.Size(151, 50);
            this.radioButtonPnl.TabIndex = 15;
            // 
            // nonVegRadioBtn
            // 
            this.nonVegRadioBtn.AutoSize = true;
            this.nonVegRadioBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonVegRadioBtn.Location = new System.Drawing.Point(63, 14);
            this.nonVegRadioBtn.Name = "nonVegRadioBtn";
            this.nonVegRadioBtn.Size = new System.Drawing.Size(85, 24);
            this.nonVegRadioBtn.TabIndex = 1;
            this.nonVegRadioBtn.TabStop = true;
            this.nonVegRadioBtn.Text = "Non-Veg";
            this.nonVegRadioBtn.UseVisualStyleBackColor = true;
            // 
            // vegRadioBtn
            // 
            this.vegRadioBtn.AutoSize = true;
            this.vegRadioBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegRadioBtn.Location = new System.Drawing.Point(3, 14);
            this.vegRadioBtn.Name = "vegRadioBtn";
            this.vegRadioBtn.Size = new System.Drawing.Size(52, 24);
            this.vegRadioBtn.TabIndex = 0;
            this.vegRadioBtn.TabStop = true;
            this.vegRadioBtn.Text = "Veg";
            this.vegRadioBtn.UseVisualStyleBackColor = true;
            // 
            // addItemLbl
            // 
            this.addItemLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.Location = new System.Drawing.Point(159, 47);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(141, 38);
            this.addItemLbl.TabIndex = 16;
            this.addItemLbl.Text = "Add Item";
            this.addItemLbl.Click += new System.EventHandler(this.addItemLbl_Click);
            // 
            // addItemSubmitbtn
            // 
            this.addItemSubmitbtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemSubmitbtn.Location = new System.Drawing.Point(77, 549);
            this.addItemSubmitbtn.Name = "addItemSubmitbtn";
            this.addItemSubmitbtn.Size = new System.Drawing.Size(150, 30);
            this.addItemSubmitbtn.TabIndex = 17;
            this.addItemSubmitbtn.Text = "Submit";
            this.addItemSubmitbtn.UseVisualStyleBackColor = true;
            this.addItemSubmitbtn.Click += new System.EventHandler(this.addItemSubmitbtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(280, 549);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(159, 30);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.itemNameLbl.Location = new System.Drawing.Point(56, 144);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(95, 22);
            this.itemNameLbl.TabIndex = 19;
            this.itemNameLbl.Text = "Item Name";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.stock.Location = new System.Drawing.Point(56, 418);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(52, 22);
            this.stock.TabIndex = 23;
            this.stock.Text = "Stock";
            // 
            // unitPriceTxt
            // 
            this.unitPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceTxt.Location = new System.Drawing.Point(244, 472);
            this.unitPriceTxt.Name = "unitPriceTxt";
            this.unitPriceTxt.Size = new System.Drawing.Size(150, 20);
            this.unitPriceTxt.TabIndex = 22;
            this.unitPriceTxt.Validated += new System.EventHandler(this.unitPriceTxt_Validated);
            // 
            // stockTxt
            // 
            this.stockTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockTxt.Location = new System.Drawing.Point(245, 421);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(145, 20);
            this.stockTxt.TabIndex = 21;
            this.stockTxt.TextChanged += new System.EventHandler(this.stockTxt_TextChanged);
            this.stockTxt.Validating += new System.ComponentModel.CancelEventHandler(this.stockTxt_Validating);
            // 
            // unitPricelbl
            // 
            this.unitPricelbl.AutoSize = true;
            this.unitPricelbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPricelbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.unitPricelbl.Location = new System.Drawing.Point(56, 472);
            this.unitPricelbl.Name = "unitPricelbl";
            this.unitPricelbl.Size = new System.Drawing.Size(88, 22);
            this.unitPricelbl.TabIndex = 20;
            this.unitPricelbl.Text = "Unit Price";
            // 
            // errorProviderItemName
            // 
            this.errorProviderItemName.ContainerControl = this;
            // 
            // errorProvidercategoryName
            // 
            this.errorProvidercategoryName.ContainerControl = this;
            // 
            // errorProviderItemDesc
            // 
            this.errorProviderItemDesc.ContainerControl = this;
            // 
            // errorProviderstock
            // 
            this.errorProviderstock.ContainerControl = this;
            // 
            // errorProviderunitprice
            // 
            this.errorProviderunitprice.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.categoryTxt);
            this.panel1.Controls.Add(this.categoryNameLbl);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.addItemSubmitbtn);
            this.panel1.Controls.Add(this.descriptionLbl);
            this.panel1.Controls.Add(this.unitPriceTxt);
            this.panel1.Controls.Add(this.itemNameTxt);
            this.panel1.Controls.Add(this.stockTxt);
            this.panel1.Controls.Add(this.unitPricelbl);
            this.panel1.Controls.Add(this.itemDescTxt);
            this.panel1.Controls.Add(this.itemNameLbl);
            this.panel1.Controls.Add(this.itemTypelbl);
            this.panel1.Controls.Add(this.radioButtonPnl);
            this.panel1.Controls.Add(this.addItemLbl);
            this.panel1.Location = new System.Drawing.Point(232, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 621);
            this.panel1.TabIndex = 24;
            // 
            // categoryTxt
            // 
            this.categoryTxt.FormattingEnabled = true;
            this.categoryTxt.Location = new System.Drawing.Point(240, 198);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(156, 21);
            this.categoryTxt.TabIndex = 24;
            // 
            // AddItemUsrCtrl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "AddItemUsrCtrl1";
            this.Size = new System.Drawing.Size(1137, 698);
            this.Load += new System.EventHandler(this.AddItemUsrCtrl_Load);
            this.radioButtonPnl.ResumeLayout(false);
            this.radioButtonPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItemDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderunitprice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox itemDescTxt;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.Label itemTypelbl;
        private System.Windows.Forms.Panel radioButtonPnl;
        private System.Windows.Forms.RadioButton nonVegRadioBtn;
        private System.Windows.Forms.RadioButton vegRadioBtn;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.Button addItemSubmitbtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox unitPriceTxt;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label unitPricelbl;
        private System.Windows.Forms.ErrorProvider errorProviderItemName;
        private System.Windows.Forms.ErrorProvider errorProvidercategoryName;
        private System.Windows.Forms.ErrorProvider errorProviderItemDesc;
        private System.Windows.Forms.ErrorProvider errorProviderstock;
        private System.Windows.Forms.ErrorProvider errorProviderunitprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox categoryTxt;
    }
}
