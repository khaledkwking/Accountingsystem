namespace ERPSYS
{
    partial class AccountCustomerDanWithMonthRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCustomerDanWithMonthRpt));
            this.label5 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CmbItemSorted = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFromValue = new System.Windows.Forms.TextBox();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.accountA3marAlDauanMonthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountA3marAlDauanMonthsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountA3marAlDauanMonthsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountA3marAlDauanMonthsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBranch
            // 
            this.cmbBranch.AccessibleDescription = null;
            this.cmbBranch.AccessibleName = null;
            resources.ApplyResources(this.cmbBranch, "cmbBranch");
            this.cmbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBranch.BackgroundImage = null;
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
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleDescription = null;
            this.BtnPrint.AccessibleName = null;
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.BackgroundImage = null;
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.AccessibleDescription = null;
            this.CmdClose.AccessibleName = null;
            resources.ApplyResources(this.CmdClose, "CmdClose");
            this.CmdClose.BackgroundImage = null;
            this.CmdClose.CausesValidation = false;
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // cmbAccount
            // 
            this.cmbAccount.AccessibleDescription = null;
            this.cmbAccount.AccessibleName = null;
            resources.ApplyResources(this.cmbAccount, "cmbAccount");
            this.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccount.BackgroundImage = null;
            this.cmbAccount.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.cmbAccount.DisplayMember = "SUP_CUST_FNAME";
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.ValueMember = "accountid";
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // CmbItemSorted
            // 
            this.CmbItemSorted.AccessibleDescription = null;
            this.CmbItemSorted.AccessibleName = null;
            resources.ApplyResources(this.CmbItemSorted, "CmbItemSorted");
            this.CmbItemSorted.BackgroundImage = null;
            this.CmbItemSorted.DisplayMember = "DESC";
            this.CmbItemSorted.FormattingEnabled = true;
            this.CmbItemSorted.Name = "CmbItemSorted";
            this.CmbItemSorted.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // txttotalBalance
            // 
            this.txttotalBalance.AccessibleDescription = null;
            this.txttotalBalance.AccessibleName = null;
            resources.ApplyResources(this.txttotalBalance, "txttotalBalance");
            this.txttotalBalance.BackgroundImage = null;
            this.txttotalBalance.ForeColor = System.Drawing.Color.Black;
            this.txttotalBalance.Name = "txttotalBalance";
            // 
            // txtTotalFromValue
            // 
            this.txtTotalFromValue.AccessibleDescription = null;
            this.txtTotalFromValue.AccessibleName = null;
            resources.ApplyResources(this.txtTotalFromValue, "txtTotalFromValue");
            this.txtTotalFromValue.BackgroundImage = null;
            this.txtTotalFromValue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFromValue.Name = "txtTotalFromValue";
            // 
            // txtTotalToValue
            // 
            this.txtTotalToValue.AccessibleDescription = null;
            this.txtTotalToValue.AccessibleName = null;
            resources.ApplyResources(this.txtTotalToValue, "txtTotalToValue");
            this.txtTotalToValue.BackgroundImage = null;
            this.txtTotalToValue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalToValue.Name = "txtTotalToValue";
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
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // accountA3marAlDauanMonthsBindingSource
            // 
            this.accountA3marAlDauanMonthsBindingSource.DataMember = "AccountA3marAlDauanMonths";
            this.accountA3marAlDauanMonthsBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountA3marAlDauanMonthsTableAdapter
            // 
            this.accountA3marAlDauanMonthsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.CmbItemSorted);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbAccount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.CmdClose);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.AccessibleDescription = null;
            this.crystalReportViewer1.AccessibleName = null;
            this.crystalReportViewer1.ActiveViewIndex = -1;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.BackgroundImage = null;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Font = null;
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // AccountCustomerDanWithMonthRpt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = null;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttotalBalance);
            this.Controls.Add(this.txtTotalFromValue);
            this.Controls.Add(this.txtTotalToValue);
            this.Font = null;
            this.Icon = null;
            this.Name = "AccountCustomerDanWithMonthRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountA3marAlDauanMonthsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.Label label5;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.ComboBox cmbAccount;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.ComboBox CmbItemSorted;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalBalance;
        private System.Windows.Forms.TextBox txtTotalFromValue;
        private System.Windows.Forms.TextBox txtTotalToValue;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource accountA3marAlDauanMonthsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountA3marAlDauanMonthsTableAdapter accountA3marAlDauanMonthsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       
        

    }
}