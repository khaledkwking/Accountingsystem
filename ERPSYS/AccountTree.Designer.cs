namespace ERPSYS
{
    partial class AccountTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountTree));
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.AccountTreeView = new System.Windows.Forms.TreeView();
            this.TreeimageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label28
            // 
            this.label28.AccessibleDescription = null;
            this.label28.AccessibleName = null;
            resources.ApplyResources(this.label28, "label28");
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider1.SetError(this.label28, resources.GetString("label28.Error"));
            this.label28.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.label28, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label28.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label28, ((int)(resources.GetObject("label28.IconPadding"))));
            this.label28.Name = "label28";
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
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // AccountTreeView
            // 
            this.AccountTreeView.AccessibleDescription = null;
            this.AccountTreeView.AccessibleName = null;
            resources.ApplyResources(this.AccountTreeView, "AccountTreeView");
            this.AccountTreeView.BackgroundImage = null;
            this.errorProvider1.SetError(this.AccountTreeView, resources.GetString("AccountTreeView.Error"));
            this.AccountTreeView.Font = null;
            this.errorProvider1.SetIconAlignment(this.AccountTreeView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("AccountTreeView.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.AccountTreeView, ((int)(resources.GetObject("AccountTreeView.IconPadding"))));
            this.AccountTreeView.ImageList = this.TreeimageList;
            this.AccountTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AccountTreeView_NodeMouseDoubleClick);
            this.AccountTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterCollapse);
            this.AccountTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountTreeView_MouseClick);
            this.AccountTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterSelect);
            this.AccountTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AccountTreeView_NodeMouseClick);
            this.AccountTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterExpand);
            // 
            // TreeimageList
            // 
            resources.ApplyResources(this.TreeimageList, "TreeimageList");
            this.TreeimageList.Images.SetKeyName(0, "");
            this.TreeimageList.Images.SetKeyName(1, "");
            this.TreeimageList.Images.SetKeyName(2, "");
            this.TreeimageList.Images.SetKeyName(3, "");
            this.TreeimageList.Images.SetKeyName(4, "nodelock on.ico");
            // 
            // groupBox11
            // 
            this.groupBox11.AccessibleDescription = null;
            this.groupBox11.AccessibleName = null;
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.BackgroundImage = null;
            this.groupBox11.Controls.Add(this.AccountTreeView);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.txtSearch);
            this.errorProvider1.SetError(this.groupBox11, resources.GetString("groupBox11.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox11, ((int)(resources.GetObject("groupBox11.IconPadding"))));
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // AccountTree
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.CmdCancel);
            this.Font = null;
            this.Icon = null;
           
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        public System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TreeView AccountTreeView;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ImageList TreeimageList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mainUnitDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCostPrictDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}