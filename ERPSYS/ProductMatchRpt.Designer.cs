namespace ERPSYS
{
    partial class ProductMatchRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMatchRpt));
            this.label5 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmbStores = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.CmbProducts = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.cDEUNITTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDE_UNIT_TYPESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.movmentQtyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.stockViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.StockViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockViewBindingSource)).BeginInit();
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
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
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
            // cDEUNITTYPESBindingSource
            // 
            this.cDEUNITTYPESBindingSource.DataMember = "CDE_UNIT_TYPES";
            this.cDEUNITTYPESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // cDE_UNIT_TYPESTableAdapter
            // 
            this.cDE_UNIT_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // movmentQtyTextBox
            // 
            resources.ApplyResources(this.movmentQtyTextBox, "movmentQtyTextBox");
            this.movmentQtyTextBox.Name = "movmentQtyTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // txtProductCode
            // 
            resources.ApplyResources(this.txtProductCode, "txtProductCode");
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.Name = "txtProductCode";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // txtBarCode
            // 
            resources.ApplyResources(this.txtBarCode, "txtBarCode");
            this.txtBarCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarCode.ForeColor = System.Drawing.Color.Black;
            this.txtBarCode.Name = "txtBarCode";
            // 
            // stockViewBindingSource
            // 
            this.stockViewBindingSource.DataMember = "StockView";
            this.stockViewBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // stockViewTableAdapter
            // 
            this.stockViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtToQty
            // 
            resources.ApplyResources(this.txtToQty, "txtToQty");
            this.txtToQty.Name = "txtToQty";
            // 
            // ProductMatchRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.txtToQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movmentQtyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbProducts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbStores);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductMatchRpt";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.Label label5;
        private NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.ComboBox CmbStores;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private System.Windows.Forms.ComboBox CmbProducts;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource cDEUNITTYPESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter cDE_UNIT_TYPESTableAdapter;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movmentQtyTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtProductCode;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.BindingSource stockViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.StockViewTableAdapter stockViewTableAdapter;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToQty;
       
        

    }
}