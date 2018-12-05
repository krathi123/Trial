namespace Trial
{
    partial class EditcategoryUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditcategoryUsrCtrl));
            this.editcategoryLbl = new System.Windows.Forms.Label();
            this.searchCategorynameBtn = new System.Windows.Forms.Button();
            this.categorynameTxt = new System.Windows.Forms.TextBox();
            this.searchcategorynamelbl = new System.Windows.Forms.Label();
            this.ordercategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDataSet = new Trial.TrainingDataSet();
            this.order_categoryTableAdapter = new Trial.TrainingDataSetTableAdapters.order_categoryTableAdapter();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.findAllBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordercategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // editcategoryLbl
            // 
            this.editcategoryLbl.AutoSize = true;
            this.editcategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.editcategoryLbl.Font = new System.Drawing.Font("Bodoni MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcategoryLbl.Location = new System.Drawing.Point(335, 56);
            this.editcategoryLbl.Name = "editcategoryLbl";
            this.editcategoryLbl.Size = new System.Drawing.Size(213, 41);
            this.editcategoryLbl.TabIndex = 0;
            this.editcategoryLbl.Text = "Edit Category";
            // 
            // searchCategorynameBtn
            // 
            this.searchCategorynameBtn.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategorynameBtn.Location = new System.Drawing.Point(578, 163);
            this.searchCategorynameBtn.Name = "searchCategorynameBtn";
            this.searchCategorynameBtn.Size = new System.Drawing.Size(75, 36);
            this.searchCategorynameBtn.TabIndex = 13;
            this.searchCategorynameBtn.Text = "Search";
            this.searchCategorynameBtn.UseVisualStyleBackColor = true;
            this.searchCategorynameBtn.Click += new System.EventHandler(this.searchCategorynameBtn_Click);
            // 
            // categorynameTxt
            // 
            this.categorynameTxt.Location = new System.Drawing.Point(354, 173);
            this.categorynameTxt.Name = "categorynameTxt";
            this.categorynameTxt.Size = new System.Drawing.Size(177, 20);
            this.categorynameTxt.TabIndex = 12;
            // 
            // searchcategorynamelbl
            // 
            this.searchcategorynamelbl.AutoSize = true;
            this.searchcategorynamelbl.BackColor = System.Drawing.Color.White;
            this.searchcategorynamelbl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcategorynamelbl.Location = new System.Drawing.Point(125, 170);
            this.searchcategorynamelbl.Name = "searchcategorynamelbl";
            this.searchcategorynamelbl.Size = new System.Drawing.Size(205, 22);
            this.searchcategorynamelbl.TabIndex = 11;
            this.searchcategorynamelbl.Text = "Search by Category Name";
            // 
            // ordercategoryBindingSource
            // 
            this.ordercategoryBindingSource.DataMember = "order_category";
            this.ordercategoryBindingSource.DataSource = this.trainingDataSet;
            // 
            // trainingDataSet
            // 
            this.trainingDataSet.DataSetName = "TrainingDataSet";
            this.trainingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_categoryTableAdapter
            // 
            this.order_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AllowUserToAddRows = false;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(305, 296);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.Size = new System.Drawing.Size(226, 121);
            this.dataGridViewTest.TabIndex = 16;
            this.dataGridViewTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellContentClick);
            this.dataGridViewTest.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellValueChanged);
            this.dataGridViewTest.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTest_DataBindingComplete);
            // 
            // findAllBtn
            // 
            this.findAllBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllBtn.Location = new System.Drawing.Point(369, 238);
            this.findAllBtn.Name = "findAllBtn";
            this.findAllBtn.Size = new System.Drawing.Size(121, 34);
            this.findAllBtn.TabIndex = 17;
            this.findAllBtn.Text = "Find All";
            this.findAllBtn.UseVisualStyleBackColor = true;
            this.findAllBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(354, 448);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 34);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditcategoryUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.findAllBtn);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.searchCategorynameBtn);
            this.Controls.Add(this.categorynameTxt);
            this.Controls.Add(this.searchcategorynamelbl);
            this.Controls.Add(this.editcategoryLbl);
            this.Name = "EditcategoryUsrCtrl";
            this.Size = new System.Drawing.Size(870, 591);
            this.Load += new System.EventHandler(this.EditcategoryUsrCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordercategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editcategoryLbl;
        private System.Windows.Forms.Button searchCategorynameBtn;
        private System.Windows.Forms.TextBox categorynameTxt;
        private System.Windows.Forms.Label searchcategorynamelbl;
        private System.Windows.Forms.BindingSource ordercategoryBindingSource;
        private TrainingDataSet trainingDataSet;
        private TrainingDataSetTableAdapters.order_categoryTableAdapter order_categoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Button findAllBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
