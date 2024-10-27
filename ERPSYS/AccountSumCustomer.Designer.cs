namespace ERPSYS
{
    partial class AccountSumCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSumCustomer));
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
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.accountingViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFromValue = new System.Windows.Forms.TextBox();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.CmbCostCenter = new System.Windows.Forms.ComboBox();
            this.costCentersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.costCentersTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCust1 = new System.Windows.Forms.ComboBox();
            this.accountingBindingSourceCust1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCust2 = new System.Windows.Forms.ComboBox();
            this.accountingBindingSourceCust2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbCostCenter1 = new System.Windows.Forms.ComboBox();
            this.costCentersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceCust1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceCust2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource2)).BeginInit();
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
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
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
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label4, "label4");
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
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // CmbCostCenter
            // 
            resources.ApplyResources(this.CmbCostCenter, "CmbCostCenter");
            this.CmbCostCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCostCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCostCenter.DataSource = this.costCentersBindingSource1;
            this.CmbCostCenter.DisplayMember = "costCode";
            this.CmbCostCenter.FormattingEnabled = true;
            this.CmbCostCenter.Name = "CmbCostCenter";
            this.CmbCostCenter.ValueMember = "costid";
            // 
            // costCentersBindingSource1
            // 
            this.costCentersBindingSource1.DataMember = "CostCenters";
            this.costCentersBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // costCentersBindingSource
            // 
            this.costCentersBindingSource.DataMember = "CostCenters";
            this.costCentersBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // costCentersTableAdapter
            // 
            this.costCentersTableAdapter.ClearBeforeFill = true;
            // 
            // cmbProducts
            // 
            this.cmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducts.DataSource = this.pRODUCTSBindingSource;
            this.cmbProducts.DisplayMember = "productname";
            resources.ApplyResources(this.cmbProducts, "cmbProducts");
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.ValueMember = "PRODUCTID";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // cmbCust1
            // 
            resources.ApplyResources(this.cmbCust1, "cmbCust1");
            this.cmbCust1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCust1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCust1.DataSource = this.accountingBindingSourceCust1;
            this.cmbCust1.DisplayMember = "accountname";
            this.cmbCust1.FormattingEnabled = true;
            this.cmbCust1.Name = "cmbCust1";
            this.cmbCust1.ValueMember = "accountid";
            // 
            // accountingBindingSourceCust1
            // 
            this.accountingBindingSourceCust1.DataMember = "accounting";
            this.accountingBindingSourceCust1.DataSource = this.nEWERPDataSet;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // cmbCust2
            // 
            resources.ApplyResources(this.cmbCust2, "cmbCust2");
            this.cmbCust2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCust2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCust2.DataSource = this.accountingBindingSourceCust2;
            this.cmbCust2.DisplayMember = "accountname";
            this.cmbCust2.FormattingEnabled = true;
            this.cmbCust2.Name = "cmbCust2";
            this.cmbCust2.ValueMember = "accountid";
            // 
            // accountingBindingSourceCust2
            // 
            this.accountingBindingSourceCust2.DataMember = "accounting";
            this.accountingBindingSourceCust2.DataSource = this.nEWERPDataSet;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // CmbCostCenter1
            // 
            resources.ApplyResources(this.CmbCostCenter1, "CmbCostCenter1");
            this.CmbCostCenter1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCostCenter1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCostCenter1.DataSource = this.costCentersBindingSource2;
            this.CmbCostCenter1.DisplayMember = "costCode";
            this.CmbCostCenter1.FormattingEnabled = true;
            this.CmbCostCenter1.Name = "CmbCostCenter1";
            this.CmbCostCenter1.ValueMember = "costid";
            // 
            // costCentersBindingSource2
            // 
            this.costCentersBindingSource2.DataMember = "CostCenters";
            this.costCentersBindingSource2.DataSource = this.nEWERPDataSet;
            // 
            // AccountSumCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.CmbCostCenter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCust2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCust1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbCostCenter);
            this.Controls.Add(this.txttotalBalance);
            this.Controls.Add(this.txtTotalFromValue);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "AccountSumCustomer";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceCust1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceCust2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource2)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.BindingSource accountingViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter accountingViewTableAdapter;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotalBalance;
        private System.Windows.Forms.TextBox txtTotalFromValue;
        private System.Windows.Forms.TextBox txtTotalToValue;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.ComboBox CmbCostCenter;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource costCentersBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter costCentersTableAdapter;
        private System.Windows.Forms.ComboBox cmbProducts;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCust1;
        private System.Windows.Forms.BindingSource accountingBindingSourceCust1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCust2;
        private System.Windows.Forms.BindingSource accountingBindingSourceCust2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbCostCenter1;
        private System.Windows.Forms.BindingSource costCentersBindingSource1;
        private System.Windows.Forms.BindingSource costCentersBindingSource2;
       
        

    }
}