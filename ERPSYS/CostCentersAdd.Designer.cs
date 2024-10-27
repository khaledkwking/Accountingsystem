namespace ERPSYS
{
    partial class CostCentersAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCentersAdd));
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastSerial = new System.Windows.Forms.TextBox();
            this.costCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.txtMainParentId = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtdisplay_Flag = new System.Windows.Forms.TextBox();
            this.txtProcessFlag = new System.Windows.Forms.TextBox();
            this.MainAccChkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAccountparentId = new System.Windows.Forms.TextBox();
            this.txtStartdate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRootFlag = new System.Windows.Forms.TextBox();
            this.txtAccountparentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtAccountparentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.AccountTreeView = new System.Windows.Forms.TreeView();
            this.ContextMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMainAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSubAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeReFreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeOpenAllMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeimageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.costCentersTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter();
            this.tabControlProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.ContextMenuAccount.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProduct
            // 
            resources.ApplyResources(this.tabControlProduct, "tabControlProduct");
            this.tabControlProduct.Controls.Add(this.tabPage1);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtLastSerial);
            this.groupBox1.Controls.Add(this.txtMainParentId);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.txtdisplay_Flag);
            this.groupBox1.Controls.Add(this.txtProcessFlag);
            this.groupBox1.Controls.Add(this.MainAccChkBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.txtAccountId);
            this.groupBox1.Controls.Add(this.txtAccountparentId);
            this.groupBox1.Controls.Add(this.txtStartdate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRootFlag);
            this.groupBox1.Controls.Add(this.txtAccountparentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Label22);
            this.groupBox1.Controls.Add(this.txtAccountparentCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAccountSName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAccountCode);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtLastSerial
            // 
            resources.ApplyResources(this.txtLastSerial, "txtLastSerial");
            this.txtLastSerial.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastSerial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "LastSerialNo", true));
            this.txtLastSerial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastSerial.Name = "txtLastSerial";
            // 
            // costCentersBindingSource
            // 
            this.costCentersBindingSource.DataMember = "CostCenters";
            this.costCentersBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMainParentId
            // 
            this.txtMainParentId.AcceptsReturn = true;
            resources.ApplyResources(this.txtMainParentId, "txtMainParentId");
            this.txtMainParentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMainParentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainParentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "MainParentAccId", true));
            this.txtMainParentId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMainParentId.Name = "txtMainParentId";
            // 
            // txtLevel
            // 
            this.txtLevel.AcceptsReturn = true;
            resources.ApplyResources(this.txtLevel, "txtLevel");
            this.txtLevel.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "AccLevel", true));
            this.txtLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLevel.Name = "txtLevel";
            // 
            // txtdisplay_Flag
            // 
            this.txtdisplay_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.txtdisplay_Flag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdisplay_Flag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "display_Flag", true));
            resources.ApplyResources(this.txtdisplay_Flag, "txtdisplay_Flag");
            this.txtdisplay_Flag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdisplay_Flag.Name = "txtdisplay_Flag";
            // 
            // txtProcessFlag
            // 
            this.txtProcessFlag.AcceptsReturn = true;
            this.txtProcessFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtProcessFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "ProcessFlag", true));
            resources.ApplyResources(this.txtProcessFlag, "txtProcessFlag");
            this.txtProcessFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProcessFlag.Name = "txtProcessFlag";
            // 
            // MainAccChkBox
            // 
            resources.ApplyResources(this.MainAccChkBox, "MainAccChkBox");
            this.MainAccChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.costCentersBindingSource, "MainNode", true));
            this.MainAccChkBox.ForeColor = System.Drawing.Color.Blue;
            this.MainAccChkBox.Name = "MainAccChkBox";
            this.MainAccChkBox.UseVisualStyleBackColor = true;
            this.MainAccChkBox.CheckedChanged += new System.EventHandler(this.MainAccChkBox_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "notes", true));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Name = "txtNotes";
            // 
            // txtAccountId
            // 
            this.txtAccountId.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountId, "txtAccountId");
            this.txtAccountId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "costid", true));
            this.txtAccountId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountId.Name = "txtAccountId";
            // 
            // txtAccountparentId
            // 
            this.txtAccountparentId.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountparentId, "txtAccountparentId");
            this.txtAccountparentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountparentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountparentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "costparentId", true));
            this.txtAccountparentId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountparentId.Name = "txtAccountparentId";
            // 
            // txtStartdate
            // 
            this.txtStartdate.AcceptsReturn = true;
            resources.ApplyResources(this.txtStartdate, "txtStartdate");
            this.txtStartdate.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "startdate", true));
            this.txtStartdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartdate.Name = "txtStartdate";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // txtRootFlag
            // 
            this.txtRootFlag.AcceptsReturn = true;
            resources.ApplyResources(this.txtRootFlag, "txtRootFlag");
            this.txtRootFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtRootFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRootFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "root", true));
            this.txtRootFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRootFlag.Name = "txtRootFlag";
            // 
            // txtAccountparentName
            // 
            this.txtAccountparentName.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountparentName, "txtAccountparentName");
            this.txtAccountparentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountparentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountparentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountparentName.Name = "txtAccountparentName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // txtAccountparentCode
            // 
            resources.ApplyResources(this.txtAccountparentCode, "txtAccountparentCode");
            this.txtAccountparentCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountparentCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountparentCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountparentCode.Name = "txtAccountparentCode";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // txtAccountSName
            // 
            this.txtAccountSName.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountSName, "txtAccountSName");
            this.txtAccountSName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountSName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountSName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "costSName", true));
            this.txtAccountSName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountSName.Name = "txtAccountSName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // txtAccountName
            // 
            this.txtAccountName.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountName, "txtAccountName");
            this.txtAccountName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "costName", true));
            this.txtAccountName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountName.Name = "txtAccountName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountCode, "txtAccountCode");
            this.txtAccountCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costCentersBindingSource, "costCode", true));
            this.txtAccountCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountCode.Name = "txtAccountCode";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // AccountTreeView
            // 
            this.AccountTreeView.ContextMenuStrip = this.ContextMenuAccount;
            resources.ApplyResources(this.AccountTreeView, "AccountTreeView");
            this.AccountTreeView.ImageList = this.TreeimageList;
            this.AccountTreeView.Name = "AccountTreeView";
            this.AccountTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterCollapse);
            this.AccountTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterExpand);
            this.AccountTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProductstreeView_AfterSelect);
            this.AccountTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AccountTreeView_NodeMouseClick);
            this.AccountTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountTreeView_MouseClick);
            // 
            // ContextMenuAccount
            // 
            this.ContextMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMainAccMenuItem,
            this.AddSubAccMenuItem,
            this.MenuItemDel,
            this.MenuItemSave,
            this.TreeReFreshMenuItem,
            this.TreeOpenAllMItem});
            this.ContextMenuAccount.Name = "ContextMenuAccount";
            resources.ApplyResources(this.ContextMenuAccount, "ContextMenuAccount");
            // 
            // AddMainAccMenuItem
            // 
            resources.ApplyResources(this.AddMainAccMenuItem, "AddMainAccMenuItem");
            this.AddMainAccMenuItem.Name = "AddMainAccMenuItem";
            this.AddMainAccMenuItem.Click += new System.EventHandler(this.AddMainAccMenuItem_Click);
            // 
            // AddSubAccMenuItem
            // 
            resources.ApplyResources(this.AddSubAccMenuItem, "AddSubAccMenuItem");
            this.AddSubAccMenuItem.Name = "AddSubAccMenuItem";
            this.AddSubAccMenuItem.Click += new System.EventHandler(this.AddSubAccMenuItem_Click);
            // 
            // MenuItemDel
            // 
            resources.ApplyResources(this.MenuItemDel, "MenuItemDel");
            this.MenuItemDel.Name = "MenuItemDel";
            // 
            // MenuItemSave
            // 
            resources.ApplyResources(this.MenuItemSave, "MenuItemSave");
            this.MenuItemSave.Name = "MenuItemSave";
            // 
            // TreeReFreshMenuItem
            // 
            resources.ApplyResources(this.TreeReFreshMenuItem, "TreeReFreshMenuItem");
            this.TreeReFreshMenuItem.Name = "TreeReFreshMenuItem";
            this.TreeReFreshMenuItem.Click += new System.EventHandler(this.TreeReFreshMenuItem_Click);
            // 
            // TreeOpenAllMItem
            // 
            resources.ApplyResources(this.TreeOpenAllMItem, "TreeOpenAllMItem");
            this.TreeOpenAllMItem.Name = "TreeOpenAllMItem";
            this.TreeOpenAllMItem.Click += new System.EventHandler(this.TreeOpenAllMItem_Click);
            // 
            // TreeimageList
            // 
            this.TreeimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeimageList.ImageStream")));
            this.TreeimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeimageList.Images.SetKeyName(0, "");
            this.TreeimageList.Images.SetKeyName(1, "");
            this.TreeimageList.Images.SetKeyName(2, "");
            this.TreeimageList.Images.SetKeyName(3, "");
            this.TreeimageList.Images.SetKeyName(4, "nodelock on.ico");
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.AccountTreeView);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.txtSearch);
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // costCentersTableAdapter
            // 
            this.costCentersTableAdapter.ClearBeforeFill = true;
            // 
            // CostCentersAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControlProduct);
            this.Controls.Add(this.groupBox11);
            this.Name = "CostCentersAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.tabControlProduct.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.ContextMenuAccount.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtAccountCode;
        public System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtAccountSName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAccountName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAccountparentCode;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.TextBox txtStartdate;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label5;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        public System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TreeView AccountTreeView;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ImageList TreeimageList;
        public System.Windows.Forms.TextBox txtAccountparentName;
        public System.Windows.Forms.TextBox txtRootFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mainUnitDataGridViewCheckBoxColumn1;
        public System.Windows.Forms.TextBox txtAccountparentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCostPrictDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtAccountId;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdDel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.CheckBox MainAccChkBox;
        public System.Windows.Forms.TextBox txtProcessFlag;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuAccount;
        private System.Windows.Forms.ToolStripMenuItem AddMainAccMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem TreeReFreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSubAccMenuItem;
        public System.Windows.Forms.TextBox txtdisplay_Flag;
        public System.Windows.Forms.TextBox txtMainParentId;
        public System.Windows.Forms.TextBox txtLevel;
        public System.Windows.Forms.TextBox txtLastSerial;
        private System.Windows.Forms.ToolStripMenuItem TreeOpenAllMItem;
        private System.Windows.Forms.BindingSource costCentersBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter costCentersTableAdapter;

    }
}