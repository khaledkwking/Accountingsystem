namespace ERPSYS
{
    partial class CustomersSupplierSalesRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersSupplierSalesRpt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.accountingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.accountingViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
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
            this.customerSalesSelectViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerSalesSelectViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CustomerSalesSelectViewTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.sUPCUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_CUST_FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashVauleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chashReordervalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agalreorderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashColValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesSelectViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
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
            // accountingViewBindingSource
            // 
            this.accountingViewBindingSource.DataMember = "AccountingView";
            this.accountingViewBindingSource.DataSource = this.nEWERPDataSet;
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
            this.CmbCustomer.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.CmbCustomer.DisplayMember = "SUP_CUST_FNAME";
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.ValueMember = "SUP_CUST_ID";
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
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
            // accountingViewTableAdapter
            // 
            this.accountingViewTableAdapter.ClearBeforeFill = true;
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
            // customerSalesSelectViewBindingSource
            // 
            this.customerSalesSelectViewBindingSource.DataMember = "CustomerSalesSelectView";
            this.customerSalesSelectViewBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // customerSalesSelectViewTableAdapter
            // 
            this.customerSalesSelectViewTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
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
            // StockDGView
            // 
            this.StockDGView.AllowUserToAddRows = false;
            this.StockDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.StockDGView, "StockDGView");
            this.StockDGView.AutoGenerateColumns = false;
            this.StockDGView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StockDGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPCUSTIDDataGridViewTextBoxColumn,
            this.SUP_CUST_FNAME,
            this.cashVauleDataGridViewTextBoxColumn,
            this.chashReordervalueDataGridViewTextBoxColumn,
            this.agalValueDataGridViewTextBoxColumn,
            this.agalreorderValueDataGridViewTextBoxColumn,
            this.cashColValueDataGridViewTextBoxColumn});
            this.StockDGView.DataSource = this.customerSalesSelectViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.ReadOnly = true;
            this.StockDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StockDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // sUPCUSTIDDataGridViewTextBoxColumn
            // 
            this.sUPCUSTIDDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_ID";
            resources.ApplyResources(this.sUPCUSTIDDataGridViewTextBoxColumn, "sUPCUSTIDDataGridViewTextBoxColumn");
            this.sUPCUSTIDDataGridViewTextBoxColumn.Name = "sUPCUSTIDDataGridViewTextBoxColumn";
            this.sUPCUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SUP_CUST_FNAME
            // 
            this.SUP_CUST_FNAME.DataPropertyName = "SUP_CUST_FNAME";
            resources.ApplyResources(this.SUP_CUST_FNAME, "SUP_CUST_FNAME");
            this.SUP_CUST_FNAME.Name = "SUP_CUST_FNAME";
            this.SUP_CUST_FNAME.ReadOnly = true;
            // 
            // cashVauleDataGridViewTextBoxColumn
            // 
            this.cashVauleDataGridViewTextBoxColumn.DataPropertyName = "CashVaule";
            resources.ApplyResources(this.cashVauleDataGridViewTextBoxColumn, "cashVauleDataGridViewTextBoxColumn");
            this.cashVauleDataGridViewTextBoxColumn.Name = "cashVauleDataGridViewTextBoxColumn";
            this.cashVauleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chashReordervalueDataGridViewTextBoxColumn
            // 
            this.chashReordervalueDataGridViewTextBoxColumn.DataPropertyName = "ChashReordervalue";
            resources.ApplyResources(this.chashReordervalueDataGridViewTextBoxColumn, "chashReordervalueDataGridViewTextBoxColumn");
            this.chashReordervalueDataGridViewTextBoxColumn.Name = "chashReordervalueDataGridViewTextBoxColumn";
            this.chashReordervalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agalValueDataGridViewTextBoxColumn
            // 
            this.agalValueDataGridViewTextBoxColumn.DataPropertyName = "AgalValue";
            resources.ApplyResources(this.agalValueDataGridViewTextBoxColumn, "agalValueDataGridViewTextBoxColumn");
            this.agalValueDataGridViewTextBoxColumn.Name = "agalValueDataGridViewTextBoxColumn";
            this.agalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agalreorderValueDataGridViewTextBoxColumn
            // 
            this.agalreorderValueDataGridViewTextBoxColumn.DataPropertyName = "AgalreorderValue";
            resources.ApplyResources(this.agalreorderValueDataGridViewTextBoxColumn, "agalreorderValueDataGridViewTextBoxColumn");
            this.agalreorderValueDataGridViewTextBoxColumn.Name = "agalreorderValueDataGridViewTextBoxColumn";
            this.agalreorderValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashColValueDataGridViewTextBoxColumn
            // 
            this.cashColValueDataGridViewTextBoxColumn.DataPropertyName = "CashColValue";
            resources.ApplyResources(this.cashColValueDataGridViewTextBoxColumn, "cashColValueDataGridViewTextBoxColumn");
            this.cashColValueDataGridViewTextBoxColumn.Name = "cashColValueDataGridViewTextBoxColumn";
            this.cashColValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BtnSearch
            // 
            resources.ApplyResources(this.BtnSearch, "BtnSearch");
            this.BtnSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CustomersSupplierSalesRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.StockDGView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStores);
            this.Controls.Add(this.txttotalBalance);
            this.Controls.Add(this.txtTotalFromValue);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label4);
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
            this.Name = "CustomersSupplierSalesRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesSelectViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
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
        private System.Windows.Forms.BindingSource accountingViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter accountingViewTableAdapter;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
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
        private System.Windows.Forms.BindingSource customerSalesSelectViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CustomerSalesSelectViewTableAdapter customerSalesSelectViewTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        internal System.Windows.Forms.DataGridView StockDGView;
        internal System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_CUST_FNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashVauleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chashReordervalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agalreorderValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashColValueDataGridViewTextBoxColumn;
       
        

    }
}