namespace ERPSYS
{
    partial class FunctionsAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionsAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.Label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBranchName = new System.Windows.Forms.ComboBox();
            this.txStoreName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCTIONSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.FUNCTIONSTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCTIONSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.ForeColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // CmbBranchName
            // 
            resources.ApplyResources(this.CmbBranchName, "CmbBranchName");
            this.CmbBranchName.DisplayMember = "BRANCHCODE";
            this.CmbBranchName.FormattingEnabled = true;
            this.CmbBranchName.Name = "CmbBranchName";
            this.CmbBranchName.ValueMember = "BRANCHCODE";
            // 
            // txStoreName
            // 
            this.txStoreName.AcceptsReturn = true;
            this.txStoreName.BackColor = System.Drawing.SystemColors.Window;
            this.txStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txStoreName, "txStoreName");
            this.txStoreName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txStoreName.Name = "txStoreName";
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.Color.Blue;
            this.Label8.Name = "Label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            resources.ApplyResources(this.StoresDGView, "StoresDGView");
            this.StoresDGView.AutoGenerateColumns = false;
            this.StoresDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tEXTDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.fUNCTIONSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StoresDGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StoresDGView_RowValidating);
            this.StoresDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValidated);
            this.StoresDGView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_RowLeave);
            this.StoresDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.StoresDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StoresDGView_RowsAdded);
            this.StoresDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StoresDGView_DataError);
            this.StoresDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEXTDataGridViewTextBoxColumn
            // 
            this.tEXTDataGridViewTextBoxColumn.DataPropertyName = "TEXT";
            resources.ApplyResources(this.tEXTDataGridViewTextBoxColumn, "tEXTDataGridViewTextBoxColumn");
            this.tEXTDataGridViewTextBoxColumn.Name = "tEXTDataGridViewTextBoxColumn";
            this.tEXTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            resources.ApplyResources(this.nAMEDataGridViewTextBoxColumn, "nAMEDataGridViewTextBoxColumn");
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fUNCTIONSBindingSource
            // 
            this.fUNCTIONSBindingSource.DataMember = "FUNCTIONS";
            this.fUNCTIONSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // fUNCTIONSTableAdapter
            // 
            this.fUNCTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Name = "textBox1";
            // 
            // FunctionsAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBranchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txStoreName);
            this.Controls.Add(this.Label8);
            this.Name = "FunctionsAdd";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCTIONSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox CmbBranchName;
        public System.Windows.Forms.TextBox txStoreName;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label label1;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.DataGridView StoresDGView;
        private System.Windows.Forms.BindingSource fUNCTIONSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.FUNCTIONSTableAdapter fUNCTIONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBox1;

    }
}