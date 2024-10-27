namespace ERPSYS
{
    partial class CustomersMoveRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersMoveRpt));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CmbItemSorted = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFromValue = new System.Windows.Forms.TextBox();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.invoiceViewSelectMoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceViewSelectMoveTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InvoiceViewSelectMoveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewSelectMoveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBranch
            // 
            resources.ApplyResources(this.cmbBranch, "cmbBranch");
            this.cmbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBranch.DataSource = this.bRANCHESBindingSource;
            this.cmbBranch.DisplayMember = "BRANCHNAME";
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.ValueMember = "BRANCHCODE";
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmdClose
            // 
            resources.ApplyResources(this.CmdClose, "CmdClose");
            this.CmdClose.CausesValidation = false;
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmbCustomer
            // 
            resources.ApplyResources(this.CmbCustomer, "CmbCustomer");
            this.CmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCustomer.DataSource = this.accountingBindingSource;
            this.CmbCustomer.DisplayMember = "accountname";
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.ValueMember = "accountid";
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // dtFromDate
            // 
            resources.ApplyResources(this.dtFromDate, "dtFromDate");
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // dtToDate
            // 
            resources.ApplyResources(this.dtToDate, "dtToDate");
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // txtFromDate
            // 
            resources.ApplyResources(this.txtFromDate, "txtFromDate");
            this.txtFromDate.Name = "txtFromDate";
            // 
            // txtToDate
            // 
            resources.ApplyResources(this.txtToDate, "txtToDate");
            this.txtToDate.Name = "txtToDate";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CmbItemSorted
            // 
            this.CmbItemSorted.DisplayMember = "DESC";
            resources.ApplyResources(this.CmbItemSorted, "CmbItemSorted");
            this.CmbItemSorted.FormattingEnabled = true;
            this.CmbItemSorted.Name = "CmbItemSorted";
            this.CmbItemSorted.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.CmbItemSorted);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbProducts
            // 
            resources.ApplyResources(this.cmbProducts, "cmbProducts");
            this.cmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducts.DataSource = this.pRODUCTSBindingSource;
            this.cmbProducts.DisplayMember = "productname";
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.ValueMember = "PRODUCTID";
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // txttotalBalance
            // 
            resources.ApplyResources(this.txttotalBalance, "txttotalBalance");
            this.txttotalBalance.ForeColor = System.Drawing.Color.Black;
            this.txttotalBalance.Name = "txttotalBalance";
            // 
            // txtTotalFromValue
            // 
            resources.ApplyResources(this.txtTotalFromValue, "txtTotalFromValue");
            this.txtTotalFromValue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFromValue.Name = "txtTotalFromValue";
            // 
            // txtTotalToValue
            // 
            resources.ApplyResources(this.txtTotalToValue, "txtTotalToValue");
            this.txtTotalToValue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalToValue.Name = "txtTotalToValue";
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStores
            // 
            resources.ApplyResources(this.cmbStores, "cmbStores");
            this.cmbStores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStores.DataSource = this.sTORESBindingSource;
            this.cmbStores.DisplayMember = "STORNAME";
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.ValueMember = "STOREID";
            // 
            // sTORESBindingSource
            // 
            this.sTORESBindingSource.DataMember = "STORES";
            this.sTORESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // sTORESTableAdapter
            // 
            this.sTORESTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceViewSelectMoveBindingSource
            // 
            this.invoiceViewSelectMoveBindingSource.DataMember = "InvoiceViewSelectMove";
            this.invoiceViewSelectMoveBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // invoiceViewSelectMoveTableAdapter
            // 
            this.invoiceViewSelectMoveTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersMoveRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStores);
            this.Controls.Add(this.txttotalBalance);
            this.Controls.Add(this.txtTotalFromValue);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "CustomersMoveRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewSelectMoveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.ComboBox CmbCustomer;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox CmbItemSorted;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProducts;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotalBalance;
        private System.Windows.Forms.TextBox txtTotalFromValue;
        private System.Windows.Forms.TextBox txtTotalToValue;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource invoiceViewSelectMoveBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InvoiceViewSelectMoveTableAdapter invoiceViewSelectMoveTableAdapter;
       
        

    }
}