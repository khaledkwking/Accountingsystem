namespace ERPSYS
{
    partial class ProductCostRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCostRpt));
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmbProducts = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.product_AssemplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_AssemplyTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Product_AssemplyTableAdapter();
            this.product_Units_PricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Units_PricesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_AssemplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CmbProducts
            // 
            this.CmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProducts.DataSource = this.pRODUCTSBindingSource;
            this.CmbProducts.DisplayMember = "productname";
            resources.ApplyResources(this.CmbProducts, "CmbProducts");
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
            // product_AssemplyBindingSource
            // 
            this.product_AssemplyBindingSource.DataMember = "Product_Assemply";
            this.product_AssemplyBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // product_AssemplyTableAdapter
            // 
            this.product_AssemplyTableAdapter.ClearBeforeFill = true;
            // 
            // product_Units_PricesBindingSource
            // 
            this.product_Units_PricesBindingSource.DataMember = "Product_Units_Prices";
            this.product_Units_PricesBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // product_Units_PricesTableAdapter
            // 
            this.product_Units_PricesTableAdapter.ClearBeforeFill = true;
            // 
            // ProductCostRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbProducts);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductCostRpt";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_AssemplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.ComboBox CmbProducts;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource product_AssemplyBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Product_AssemplyTableAdapter product_AssemplyTableAdapter;
        private System.Windows.Forms.BindingSource product_Units_PricesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter product_Units_PricesTableAdapter;
       
        

    }
}