namespace ERPSYS
{
    partial class StroesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StroesAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txtStoreCode = new System.Windows.Forms.TextBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBranchName = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txStoreName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.STOREID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STORECODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STORNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // txtStoreCode
            // 
            this.txtStoreCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTORESBindingSource, "STORECODE", true));
            resources.ApplyResources(this.txtStoreCode, "txtStoreCode");
            this.txtStoreCode.Name = "txtStoreCode";
            // 
            // sTORESBindingSource
            // 
            this.sTORESBindingSource.DataMember = "STORES";
            this.sTORESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTORESBindingSource, "Notes", true));
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Name = "txtNotes";
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
            this.CmbBranchName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTORESBindingSource, "BRANCHCODE", true));
            this.CmbBranchName.DataSource = this.bRANCHESBindingSource;
            this.CmbBranchName.DisplayMember = "BRANCHNAME";
            this.CmbBranchName.FormattingEnabled = true;
            this.CmbBranchName.Name = "CmbBranchName";
            this.CmbBranchName.ValueMember = "BRANCHCODE";
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txStoreName
            // 
            this.txStoreName.AcceptsReturn = true;
            this.txStoreName.BackColor = System.Drawing.SystemColors.Window;
            this.txStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txStoreName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTORESBindingSource, "STORNAME", true));
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
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoresDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.StoresDGView, "StoresDGView");
            this.StoresDGView.AutoGenerateColumns = false;
            this.StoresDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STOREID,
            this.STORECODE,
            this.STORNAME,
            this.notesDataGridViewTextBoxColumn,
            this.sTORECODEDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.sTORESBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StoresDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValidated);
            this.StoresDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.StoresDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StoresDGView_DataError);
            this.StoresDGView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_RowLeave);
            this.StoresDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StoresDGView_RowsAdded);
            this.StoresDGView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StoresDGView_RowValidating);
            this.StoresDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // STOREID
            // 
            this.STOREID.DataPropertyName = "STOREID";
            resources.ApplyResources(this.STOREID, "STOREID");
            this.STOREID.Name = "STOREID";
            this.STOREID.ReadOnly = true;
            // 
            // STORECODE
            // 
            this.STORECODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STORECODE.DataPropertyName = "STORECODE";
            resources.ApplyResources(this.STORECODE, "STORECODE");
            this.STORECODE.Name = "STORECODE";
            this.STORECODE.ReadOnly = true;
            // 
            // STORNAME
            // 
            this.STORNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STORNAME.DataPropertyName = "STORNAME";
            resources.ApplyResources(this.STORNAME, "STORNAME");
            this.STORNAME.Name = "STORNAME";
            this.STORNAME.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTORECODEDataGridViewTextBoxColumn
            // 
            this.sTORECODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sTORECODEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHCODE";
            this.sTORECODEDataGridViewTextBoxColumn.DataSource = this.bRANCHESBindingSource;
            this.sTORECODEDataGridViewTextBoxColumn.DisplayMember = "BRANCHNAME";
            this.sTORECODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTORECODEDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.sTORECODEDataGridViewTextBoxColumn, "sTORECODEDataGridViewTextBoxColumn");
            this.sTORECODEDataGridViewTextBoxColumn.Name = "sTORECODEDataGridViewTextBoxColumn";
            this.sTORECODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTORECODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTORECODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTORECODEDataGridViewTextBoxColumn.ValueMember = "BRANCHCODE";
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sTORESTableAdapter
            // 
            this.sTORESTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StroesAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.CmbBranchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txStoreName);
            this.Controls.Add(this.Label8);
            this.Name = "StroesAdd";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox CmbBranchName;
        public System.Windows.Forms.TextBox txStoreName;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label7;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        internal System.Windows.Forms.DataGridView StoresDGView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOREID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STORECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STORNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTORECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtStoreCode;

    }
}