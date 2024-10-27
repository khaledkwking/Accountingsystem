namespace ERPSYS
{
    partial class ReorderInvList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReorderInvList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.enterDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceReodersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.invoiceReodersTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InvoiceReodersTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.curReorderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceReodersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // enterDateDateTimePicker
            // 
            resources.ApplyResources(this.enterDateDateTimePicker, "enterDateDateTimePicker");
            this.enterDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enterDateDateTimePicker.Name = "enterDateDateTimePicker";
            this.enterDateDateTimePicker.ValueChanged += new System.EventHandler(this.enterDateDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            this.StoresDGView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.StoresDGView, "StoresDGView");
            this.StoresDGView.AutoGenerateColumns = false;
            this.StoresDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curReorderId,
            this.ReorderDate,
            this.custIdDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.invoiceReodersBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StoresDGView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StoresDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StoresDGView_CellMouseDoubleClick);
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // invoiceReodersBindingSource
            // 
            this.invoiceReodersBindingSource.DataMember = "InvoiceReoders";
            this.invoiceReodersBindingSource.DataSource = this.nEWERPDataSet;
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
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtToDate
            // 
            resources.ApplyResources(this.txtToDate, "txtToDate");
            this.txtToDate.Name = "txtToDate";
            // 
            // txtFromDate
            // 
            resources.ApplyResources(this.txtFromDate, "txtFromDate");
            this.txtFromDate.Name = "txtFromDate";
            // 
            // invoiceReodersTableAdapter
            // 
            this.invoiceReodersTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // curReorderId
            // 
            this.curReorderId.DataPropertyName = "ReorderId";
            resources.ApplyResources(this.curReorderId, "curReorderId");
            this.curReorderId.Name = "curReorderId";
            this.curReorderId.ReadOnly = true;
            // 
            // ReorderDate
            // 
            this.ReorderDate.DataPropertyName = "ReorderDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ReorderDate.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.ReorderDate, "ReorderDate");
            this.ReorderDate.Name = "ReorderDate";
            this.ReorderDate.ReadOnly = true;
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "CustId";
            this.custIdDataGridViewTextBoxColumn.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.custIdDataGridViewTextBoxColumn.DisplayMember = "SUP_CUST_FNAME";
            this.custIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.custIdDataGridViewTextBoxColumn, "custIdDataGridViewTextBoxColumn");
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            this.custIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.custIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.custIdDataGridViewTextBoxColumn.ValueMember = "SUP_CUST_ID";
            // 
            // ReorderInvList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.enterDateDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCode);
            this.Name = "ReorderInvList";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceReodersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.DataGridView StoresDGView;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.DateTimePicker enterDateDateTimePicker;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.BindingSource invoiceReodersBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InvoiceReodersTableAdapter invoiceReodersTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn curReorderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn custIdDataGridViewTextBoxColumn;

    }
}