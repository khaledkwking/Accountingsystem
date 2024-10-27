namespace ERPSYS
{
    partial class ProductProfitRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductProfitRpt));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.cmbCustSup = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.CmbStores = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.accountingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invProductsMoveVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invProductsMoveVIEWTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InvProductsMoveVIEWTableAdapter();
            this.CmbProducts = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invProductsMoveVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
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
            // cmbCustSup
            // 
            resources.ApplyResources(this.cmbCustSup, "cmbCustSup");
            this.cmbCustSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustSup.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.cmbCustSup.DisplayMember = "SUP_CUST_FNAME";
            this.cmbCustSup.FormattingEnabled = true;
            this.cmbCustSup.Name = "cmbCustSup";
            this.cmbCustSup.ValueMember = "SUP_CUST_ID";
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
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
            // CmbStores
            // 
            resources.ApplyResources(this.CmbStores, "CmbStores");
            this.CmbStores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbStores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbStores.DataSource = this.sTORESBindingSource;
            this.CmbStores.DisplayMember = "STORNAME";
            this.CmbStores.FormattingEnabled = true;
            this.CmbStores.Name = "CmbStores";
            this.CmbStores.ValueMember = "STOREID";
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // accountingViewBindingSource
            // 
            this.accountingViewBindingSource.DataMember = "AccountingView";
            this.accountingViewBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountingViewTableAdapter
            // 
            this.accountingViewTableAdapter.ClearBeforeFill = true;
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // invProductsMoveVIEWBindingSource
            // 
            this.invProductsMoveVIEWBindingSource.DataMember = "InvProductsMoveVIEW";
            this.invProductsMoveVIEWBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // invProductsMoveVIEWTableAdapter
            // 
            this.invProductsMoveVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // CmbProducts
            // 
            resources.ApplyResources(this.CmbProducts, "CmbProducts");
            this.CmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProducts.DataSource = this.pRODUCTSBindingSource;
            this.CmbProducts.DisplayMember = "productname";
            this.CmbProducts.FormattingEnabled = true;
            this.CmbProducts.Name = "CmbProducts";
            this.CmbProducts.ValueMember = "PRODUCTID";
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
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
            // ProductProfitRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbProducts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbStores);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCustSup);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductProfitRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invProductsMoveVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        private NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.ComboBox cmbCustSup;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.ComboBox CmbStores;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private System.Windows.Forms.BindingSource accountingViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter accountingViewTableAdapter;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.BindingSource invProductsMoveVIEWBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InvProductsMoveVIEWTableAdapter invProductsMoveVIEWTableAdapter;
        private System.Windows.Forms.ComboBox CmbProducts;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
       
        

    }
}