namespace ERPSYS
{
    partial class ProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ProductstreeView = new System.Windows.Forms.TreeView();
            this.TreeimageList = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.CmdAdd);
            this.groupBox2.Controls.Add(this.CmdCancel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.ProductstreeView);
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = null;
            this.txtSearch.AccessibleName = null;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackgroundImage = null;
            this.errorProvider1.SetError(this.txtSearch, resources.GetString("txtSearch.Error"));
            this.txtSearch.Font = null;
            this.errorProvider1.SetIconAlignment(this.txtSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSearch.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtSearch, ((int)(resources.GetObject("txtSearch.IconPadding"))));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // ProductstreeView
            // 
            this.ProductstreeView.AccessibleDescription = null;
            this.ProductstreeView.AccessibleName = null;
            resources.ApplyResources(this.ProductstreeView, "ProductstreeView");
            this.ProductstreeView.BackgroundImage = null;
            this.ProductstreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.ProductstreeView, resources.GetString("ProductstreeView.Error"));
            this.ProductstreeView.Font = null;
            this.errorProvider1.SetIconAlignment(this.ProductstreeView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ProductstreeView.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ProductstreeView, ((int)(resources.GetObject("ProductstreeView.IconPadding"))));
            this.ProductstreeView.ImageList = this.TreeimageList;
            this.ProductstreeView.Name = "ProductstreeView";
            this.ProductstreeView.ShowNodeToolTips = true;
            this.ProductstreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterCollapse);
            this.ProductstreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterSelect);
            this.ProductstreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterExpand);
            // 
            // TreeimageList
            // 
            this.TreeimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeimageList.ImageStream")));
            this.TreeimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeimageList.Images.SetKeyName(0, "treeroot.ico");
            this.TreeimageList.Images.SetKeyName(1, "treenode.ico");
            this.TreeimageList.Images.SetKeyName(2, "arrow first.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
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
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // CmdAdd
            // 
            this.CmdAdd.AccessibleDescription = null;
            this.CmdAdd.AccessibleName = null;
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.BackgroundImage = null;
            this.CmdAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorProvider1.SetError(this.CmdAdd, resources.GetString("CmdAdd.Error"));
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.CmdAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CmdAdd.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CmdAdd, ((int)(resources.GetObject("CmdAdd.IconPadding"))));
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.AccessibleDescription = null;
            this.CmdCancel.AccessibleName = null;
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.BackgroundImage = null;
            this.errorProvider1.SetError(this.CmdCancel, resources.GetString("CmdCancel.Error"));
            this.errorProvider1.SetIconAlignment(this.CmdCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CmdCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CmdCancel, ((int)(resources.GetObject("CmdCancel.IconPadding"))));
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // ProductsList
            // 
            this.AcceptButton = this.CmdAdd;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.CancelButton = this.CmdCancel;
            this.Controls.Add(this.groupBox2);
            this.Font = null;
            this.Icon = null;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsList_FormClosing);
            this.Load += new System.EventHandler(this.ProductsList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALIDITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceRuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasOfferDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerFromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerProductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentProductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITPRICECOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITPRICESALESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHRESHOLDINSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dISCONTINUEDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEORDERLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKNODataGridViewTextBoxColumn;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TreeView ProductstreeView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList TreeimageList;
        internal System.Windows.Forms.Button CmdAdd;
    }
}