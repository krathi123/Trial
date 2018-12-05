namespace Trial
{
    partial class editUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUser));
            this.updateuserlbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.byuseridTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchdesgBtn = new System.Windows.Forms.Button();
            this.searchdesgTxt = new System.Windows.Forms.TextBox();
            this.searchdesglbl = new System.Windows.Forms.Label();
            this.dataGridVieweditUsr = new System.Windows.Forms.DataGridView();
            this.orderuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDataSet = new Trial.TrainingDataSet();
            this.order_userTableAdapter = new Trial.TrainingDataSetTableAdapters.order_userTableAdapter();
            this.findAllbtn = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweditUsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // updateuserlbl
            // 
            this.updateuserlbl.AutoSize = true;
            this.updateuserlbl.BackColor = System.Drawing.Color.Transparent;
            this.updateuserlbl.Font = new System.Drawing.Font("Bodoni MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateuserlbl.Location = new System.Drawing.Point(348, 79);
            this.updateuserlbl.Name = "updateuserlbl";
            this.updateuserlbl.Size = new System.Drawing.Size(259, 41);
            this.updateuserlbl.TabIndex = 0;
            this.updateuserlbl.Text = "Edit User Details";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchLbl.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchLbl.Location = new System.Drawing.Point(99, 174);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(190, 25);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search by user Name";
            // 
            // byuseridTxt
            // 
            this.byuseridTxt.Location = new System.Drawing.Point(320, 174);
            this.byuseridTxt.Name = "byuseridTxt";
            this.byuseridTxt.Size = new System.Drawing.Size(177, 20);
            this.byuseridTxt.TabIndex = 2;
            this.byuseridTxt.TextChanged += new System.EventHandler(this.byuseridTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(560, 170);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchdesgBtn
            // 
            this.searchdesgBtn.Location = new System.Drawing.Point(560, 203);
            this.searchdesgBtn.Name = "searchdesgBtn";
            this.searchdesgBtn.Size = new System.Drawing.Size(75, 23);
            this.searchdesgBtn.TabIndex = 6;
            this.searchdesgBtn.Text = "Search";
            this.searchdesgBtn.UseVisualStyleBackColor = true;
            this.searchdesgBtn.Click += new System.EventHandler(this.searchdesgBtn_Click);
            // 
            // searchdesgTxt
            // 
            this.searchdesgTxt.Location = new System.Drawing.Point(320, 207);
            this.searchdesgTxt.Name = "searchdesgTxt";
            this.searchdesgTxt.Size = new System.Drawing.Size(177, 20);
            this.searchdesgTxt.TabIndex = 5;
            this.searchdesgTxt.TextChanged += new System.EventHandler(this.searchdesgTxt_TextChanged);
            // 
            // searchdesglbl
            // 
            this.searchdesglbl.AutoSize = true;
            this.searchdesglbl.BackColor = System.Drawing.Color.Transparent;
            this.searchdesglbl.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdesglbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchdesglbl.Location = new System.Drawing.Point(99, 207);
            this.searchdesglbl.Name = "searchdesglbl";
            this.searchdesglbl.Size = new System.Drawing.Size(197, 25);
            this.searchdesglbl.TabIndex = 4;
            this.searchdesglbl.Text = "Search by designation";
            // 
            // dataGridVieweditUsr
            // 
            this.dataGridVieweditUsr.AllowUserToResizeColumns = false;
            this.dataGridVieweditUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieweditUsr.Location = new System.Drawing.Point(51, 362);
            this.dataGridVieweditUsr.Name = "dataGridVieweditUsr";
            this.dataGridVieweditUsr.Size = new System.Drawing.Size(951, 117);
            this.dataGridVieweditUsr.TabIndex = 7;
            this.dataGridVieweditUsr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieweditUsr_CellContentClick);
            this.dataGridVieweditUsr.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieweditUsr_CellValueChanged);
            // 
            // orderuserBindingSource
            // 
            this.orderuserBindingSource.DataMember = "order_user";
            this.orderuserBindingSource.DataSource = this.trainingDataSet;
            // 
            // trainingDataSet
            // 
            this.trainingDataSet.DataSetName = "TrainingDataSet";
            this.trainingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_userTableAdapter
            // 
            this.order_userTableAdapter.ClearBeforeFill = true;
            // 
            // findAllbtn
            // 
            this.findAllbtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllbtn.Location = new System.Drawing.Point(340, 280);
            this.findAllbtn.Name = "findAllbtn";
            this.findAllbtn.Size = new System.Drawing.Size(119, 37);
            this.findAllbtn.TabIndex = 8;
            this.findAllbtn.Text = "Find All";
            this.findAllbtn.UseVisualStyleBackColor = true;
            this.findAllbtn.Click += new System.EventHandler(this.findAllbtn_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(-15, -15);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 9;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(516, 280);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 37);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.findAllbtn);
            this.Controls.Add(this.dataGridVieweditUsr);
            this.Controls.Add(this.searchdesgBtn);
            this.Controls.Add(this.searchdesgTxt);
            this.Controls.Add(this.searchdesglbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.byuseridTxt);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.updateuserlbl);
            this.Name = "editUser";
            this.Size = new System.Drawing.Size(1271, 652);
            this.Load += new System.EventHandler(this.editUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweditUsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateuserlbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox byuseridTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button searchdesgBtn;
        private System.Windows.Forms.TextBox searchdesgTxt;
        private System.Windows.Forms.Label searchdesglbl;
        private System.Windows.Forms.DataGridView dataGridVieweditUsr;
        private System.Windows.Forms.BindingSource orderuserBindingSource;
        private TrainingDataSet trainingDataSet;
        private TrainingDataSetTableAdapters.order_userTableAdapter order_userTableAdapter;
        private System.Windows.Forms.Button findAllbtn;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button deleteBtn;
    }
}
