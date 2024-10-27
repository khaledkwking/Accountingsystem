namespace ERPSYS
{
    partial class AccountBalanceCenterbank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBalanceCenterbank));
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.accountingBindingSourceTemp = new System.Windows.Forms.BindingSource(this.components);
            this.cDE_CurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDE_CurrencyTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter();
            this.PrintBtn2 = new System.Windows.Forms.Button();
            this.PrintBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDE_CurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
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
            this.CmdClose.CausesValidation = false;
            resources.ApplyResources(this.CmdClose, "CmdClose");
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
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
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
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
            // cDE_CurrencyBindingSource
            // 
            this.cDE_CurrencyBindingSource.DataMember = "CDE_Currency";
            this.cDE_CurrencyBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // cDE_CurrencyTableAdapter
            // 
            this.cDE_CurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // PrintBtn2
            // 
            resources.ApplyResources(this.PrintBtn2, "PrintBtn2");
            this.PrintBtn2.ForeColor = System.Drawing.Color.Black;
            this.PrintBtn2.Name = "PrintBtn2";
            this.PrintBtn2.UseVisualStyleBackColor = true;
            this.PrintBtn2.Click += new System.EventHandler(this.PrintBtn2_Click);
            // 
            // PrintBtn1
            // 
            resources.ApplyResources(this.PrintBtn1, "PrintBtn1");
            this.PrintBtn1.ForeColor = System.Drawing.Color.Black;
            this.PrintBtn1.Name = "PrintBtn1";
            this.PrintBtn1.UseVisualStyleBackColor = true;
            this.PrintBtn1.Click += new System.EventHandler(this.PrintBtn1_Click);
            // 
            // AccountBalanceCenterbank
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.PrintBtn1);
            this.Controls.Add(this.PrintBtn2);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountBalanceCenterbank";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.Activated += new System.EventHandler(this.AccountSum_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDE_CurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSourceTemp;
        private System.Windows.Forms.BindingSource cDE_CurrencyBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter cDE_CurrencyTableAdapter;
        internal System.Windows.Forms.Button PrintBtn2;
        internal System.Windows.Forms.Button PrintBtn1;
       
        

    }
}