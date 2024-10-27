namespace ERPSYS
{
    partial class AccountCustomerWithDanRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCustomerWithDanRpt));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CmbItemSorted = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFromValue = new System.Windows.Forms.TextBox();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.accountA3marAlDauanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountA3marAlDauanTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountA3marAlDauanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountA3marAlDauanBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
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
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
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
            // dtFromDate
            // 
            this.dtFromDate.AccessibleDescription = null;
            this.dtFromDate.AccessibleName = null;
            resources.ApplyResources(this.dtFromDate, "dtFromDate");
            this.dtFromDate.BackgroundImage = null;
            this.dtFromDate.CalendarFont = null;
            this.dtFromDate.CustomFormat = null;
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // dtToDate
            // 
            this.dtToDate.AccessibleDescription = null;
            this.dtToDate.AccessibleName = null;
            resources.ApplyResources(this.dtToDate, "dtToDate");
            this.dtToDate.BackgroundImage = null;
            this.dtToDate.CalendarFont = null;
            this.dtToDate.CustomFormat = null;
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.AccessibleDescription = null;
            this.txtFromDate.AccessibleName = null;
            resources.ApplyResources(this.txtFromDate, "txtFromDate");
            this.txtFromDate.BackgroundImage = null;
            this.txtFromDate.Name = "txtFromDate";
            // 
            // txtToDate
            // 
            this.txtToDate.AccessibleDescription = null;
            this.txtToDate.AccessibleName = null;
            resources.ApplyResources(this.txtToDate, "txtToDate");
            this.txtToDate.BackgroundImage = null;
            this.txtToDate.Name = "txtToDate";
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = null;
            this.checkBox1.AccessibleName = null;
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackgroundImage = null;
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleDescription = null;
            this.checkBox2.AccessibleName = null;
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.BackgroundImage = null;
            this.checkBox2.ForeColor = System.Drawing.Color.Blue;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AccessibleDescription = null;
            this.checkBox3.AccessibleName = null;
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.BackgroundImage = null;
            this.checkBox3.ForeColor = System.Drawing.Color.Blue;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
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
            // accountA3marAlDauanBindingSource
            // 
            this.accountA3marAlDauanBindingSource.DataMember = "AccountA3marAlDauan";
            this.accountA3marAlDauanBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountA3marAlDauanTableAdapter
            // 
            this.accountA3marAlDauanTableAdapter.ClearBeforeFill = true;
            // 
            // AccountCustomerWithDanRpt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = null;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.txttotalBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalFromValue);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.CmbItemSorted);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = null;
            this.Icon = null;
            this.Name = "AccountCustomerWithDanRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountA3marAlDauanBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbAccount;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox CmbItemSorted;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalBalance;
        private System.Windows.Forms.TextBox txtTotalFromValue;
        private System.Windows.Forms.TextBox txtTotalToValue;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource accountA3marAlDauanBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountA3marAlDauanTableAdapter accountA3marAlDauanTableAdapter;
       
        

    }
}