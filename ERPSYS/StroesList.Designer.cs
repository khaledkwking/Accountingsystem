namespace ERPSYS
{
    partial class stroesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stroesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txStoreName = new System.Windows.Forms.TextBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoreCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.sTORECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtStoreCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTORESBindingSource, "STORECODE", true));
            resources.ApplyResources(this.txtStoreCode, "txtStoreCode");
            this.txtStoreCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStoreCode.Name = "txtStoreCode";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.ForeColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sTORESTableAdapter
            // 
            this.sTORESTableAdapter.ClearBeforeFill = true;
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            this.StoresDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
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
            this.StoreId,
            this.StoreCode,
            this.StoreName,
            this.notesDataGridViewTextBoxColumn,
            this.sTORECODEDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.sTORESBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.StoresDGView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StoresDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // sTORECODEDataGridViewTextBoxColumn
            // 
            this.sTORECODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sTORECODEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHCODE";
            this.sTORECODEDataGridViewTextBoxColumn.DataSource = this.bRANCHESBindingSource;
            this.sTORECODEDataGridViewTextBoxColumn.DisplayMember = "BRANCHNAME";
            this.sTORECODEDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.sTORECODEDataGridViewTextBoxColumn, "sTORECODEDataGridViewTextBoxColumn");
            this.sTORECODEDataGridViewTextBoxColumn.Name = "sTORECODEDataGridViewTextBoxColumn";
            this.sTORECODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTORECODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTORECODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTORECODEDataGridViewTextBoxColumn.ValueMember = "BRANCHCODE";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StoreName.DataPropertyName = "STORNAME";
            resources.ApplyResources(this.StoreName, "StoreName");
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // StoreCode
            // 
            this.StoreCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StoreCode.DataPropertyName = "STORECODE";
            resources.ApplyResources(this.StoreCode, "StoreCode");
            this.StoreCode.Name = "StoreCode";
            this.StoreCode.ReadOnly = true;
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "STOREID";
            resources.ApplyResources(this.StoreId, "StoreId");
            this.StoreId.Name = "StoreId";
            this.StoreId.ReadOnly = true;
            // 
            // stroesList
            // 
            this.AcceptButton = this.CmdAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(this.txStoreName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.groupBox4);
            this.Name = "stroesList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txStoreName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtStoreCode;
        public System.Windows.Forms.Label Label7;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.DataGridView StoresDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTORECODEDataGridViewTextBoxColumn;

    }
}