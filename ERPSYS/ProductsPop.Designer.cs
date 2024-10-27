namespace ERPSYS
{
    partial class ProductsPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsPop));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMainNode = new System.Windows.Forms.TextBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.txtRootFlag = new System.Windows.Forms.TextBox();
            this.txtProcessFlag = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLimitQty = new System.Windows.Forms.TextBox();
            this.txtProductEngName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbStores = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.cDEUNITTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMainProducts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbProductType = new System.Windows.Forms.ComboBox();
            this.cDEPRODUCTTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.SaveCmd = new System.Windows.Forms.Button();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.cDE_UNIT_TYPESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter();
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.cDE_PRODUCTTYPESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_PRODUCTTYPESTableAdapter();
            this.product_Units_PricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Units_PricesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STOCKTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPRODUCTTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMainNode);
            this.groupBox1.Controls.Add(this.txtRootFlag);
            this.groupBox1.Controls.Add(this.txtProcessFlag);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtLimitQty);
            this.groupBox1.Controls.Add(this.txtProductEngName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CmbStores);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtProductPrice);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbUnits);
            this.groupBox1.Controls.Add(this.cmbMainProducts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label22);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbProductType);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.Label7);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtMainNode
            // 
            this.txtMainNode.AcceptsReturn = true;
            this.txtMainNode.BackColor = System.Drawing.SystemColors.Window;
            this.txtMainNode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainNode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "MainNode", true));
            resources.ApplyResources(this.txtMainNode, "txtMainNode");
            this.txtMainNode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMainNode.Name = "txtMainNode";
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRootFlag
            // 
            this.txtRootFlag.AcceptsReturn = true;
            this.txtRootFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtRootFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRootFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "Root", true));
            resources.ApplyResources(this.txtRootFlag, "txtRootFlag");
            this.txtRootFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRootFlag.Name = "txtRootFlag";
            // 
            // txtProcessFlag
            // 
            this.txtProcessFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtProcessFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "ProcessFlag", true));
            resources.ApplyResources(this.txtProcessFlag, "txtProcessFlag");
            this.txtProcessFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProcessFlag.Name = "txtProcessFlag";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // txtLimitQty
            // 
            this.txtLimitQty.AcceptsReturn = true;
            this.txtLimitQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtLimitQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtLimitQty, "txtLimitQty");
            this.txtLimitQty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLimitQty.Name = "txtLimitQty";
            // 
            // txtProductEngName
            // 
            this.txtProductEngName.AcceptsReturn = true;
            this.txtProductEngName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductEngName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductEngName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "EnglishName", true));
            resources.ApplyResources(this.txtProductEngName, "txtProductEngName");
            this.txtProductEngName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductEngName.Name = "txtProductEngName";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Name = "label12";
            // 
            // CmbStores
            // 
            this.CmbStores.DataSource = this.sTORESBindingSource;
            this.CmbStores.DisplayMember = "STORNAME";
            this.CmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CmbStores, "CmbStores");
            this.CmbStores.FormattingEnabled = true;
            this.CmbStores.Name = "CmbStores";
            this.CmbStores.ValueMember = "STOREID";
            // 
            // sTORESBindingSource
            // 
            this.sTORESBindingSource.DataMember = "STORES";
            this.sTORESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AcceptsReturn = true;
            this.txtProductPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtProductPrice, "txtProductPrice");
            this.txtProductPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductPrice.Name = "txtProductPrice";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AcceptsReturn = true;
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtBarcode, "txtBarcode");
            this.txtBarcode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBarcode.Name = "txtBarcode";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // cmbUnits
            // 
            this.cmbUnits.DataSource = this.cDEUNITTYPESBindingSource;
            this.cmbUnits.DisplayMember = "UNITDESC";
            this.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbUnits, "cmbUnits");
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.ValueMember = "UINTID";
            // 
            // cDEUNITTYPESBindingSource
            // 
            this.cDEUNITTYPESBindingSource.DataMember = "CDE_UNIT_TYPES";
            this.cDEUNITTYPESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // cmbMainProducts
            // 
            this.cmbMainProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTSBindingSource, "ParentProductId", true));
            this.cmbMainProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbMainProducts, "cmbMainProducts");
            this.cmbMainProducts.FormattingEnabled = true;
            this.cmbMainProducts.Name = "cmbMainProducts";
            this.cmbMainProducts.SelectionChangeCommitted += new System.EventHandler(this.cmbMainProducts_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // CmbProductType
            // 
            this.CmbProductType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTSBindingSource, "ProductTypeID", true));
            this.CmbProductType.DataSource = this.cDEPRODUCTTYPESBindingSource;
            this.CmbProductType.DisplayMember = "TYPEDESC";
            this.CmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CmbProductType, "CmbProductType");
            this.CmbProductType.FormattingEnabled = true;
            this.CmbProductType.Name = "CmbProductType";
            this.CmbProductType.ValueMember = "TYPEID";
            // 
            // cDEPRODUCTTYPESBindingSource
            // 
            this.cDEPRODUCTTYPESBindingSource.DataMember = "CDE_PRODUCTTYPES";
            this.cDEPRODUCTTYPESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txtProductName
            // 
            this.txtProductName.AcceptsReturn = true;
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "productname", true));
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductName.Name = "txtProductName";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.ForeColor = System.Drawing.Color.Blue;
            this.Label8.Name = "Label8";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtProductCode
            // 
            this.txtProductCode.AcceptsReturn = true;
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "PRODUCTCODE", true));
            resources.ApplyResources(this.txtProductCode, "txtProductCode");
            this.txtProductCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductCode.Name = "txtProductCode";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // SaveCmd
            // 
            resources.ApplyResources(this.SaveCmd, "SaveCmd");
            this.SaveCmd.ForeColor = System.Drawing.Color.Black;
            this.SaveCmd.Name = "SaveCmd";
            this.SaveCmd.UseVisualStyleBackColor = true;
            this.SaveCmd.Click += new System.EventHandler(this.SaveCmd_Click);
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_UNIT_TYPESTableAdapter
            // 
            this.cDE_UNIT_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // sTORESTableAdapter
            // 
            this.sTORESTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_PRODUCTTYPESTableAdapter
            // 
            this.cDE_PRODUCTTYPESTableAdapter.ClearBeforeFill = true;
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
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // ProductsPop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.CmdCancel);
            this.Name = "ProductsPop";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPRODUCTTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox CmbProductType;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductCode;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button SaveCmd;
        internal System.Windows.Forms.ComboBox cmbUnits;
        internal System.Windows.Forms.ComboBox cmbMainProducts;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.ComboBox CmbStores;
        public System.Windows.Forms.Label label10;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource cDEUNITTYPESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter cDE_UNIT_TYPESTableAdapter;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        private System.Windows.Forms.BindingSource cDEPRODUCTTYPESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_PRODUCTTYPESTableAdapter cDE_PRODUCTTYPESTableAdapter;
        public System.Windows.Forms.TextBox txtProductEngName;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtLimitQty;
        private System.Windows.Forms.BindingSource product_Units_PricesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter product_Units_PricesTableAdapter;
        public System.Windows.Forms.TextBox txtProcessFlag;
        public System.Windows.Forms.TextBox txtRootFlag;
        public System.Windows.Forms.TextBox txtMainNode;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        internal System.Windows.Forms.Label label4;

    }
}