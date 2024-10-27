namespace ERPSYS
{
    partial class AccountAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountAdd));
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CurrencycmbBox = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cDECurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txtLastSerial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMainParentId = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtdisplay_Flag = new System.Windows.Forms.TextBox();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccValue = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtToValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountSName = new System.Windows.Forms.TextBox();
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccountparentCode = new System.Windows.Forms.TextBox();
            this.txtProcessFlag = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.MainAccChkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbClosedTo = new System.Windows.Forms.ComboBox();
            this.txtAccountparentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRootFlag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbAccountType = new System.Windows.Forms.ComboBox();
            this.txtStartdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountparentId = new System.Windows.Forms.TextBox();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.CustTabPage = new System.Windows.Forms.TabPage();
            this.EmptabPage = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.AccountTreeView = new System.Windows.Forms.TreeView();
            this.ContextMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMainAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSubAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeReFreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeOpenAllMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintTreeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeimageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.cDE_CurrencyTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter();
            this.tabControlProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDECurrencyBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.ContextMenuAccount.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProduct
            // 
            resources.ApplyResources(this.tabControlProduct, "tabControlProduct");
            this.tabControlProduct.Controls.Add(this.tabPage1);
            this.tabControlProduct.Controls.Add(this.CustTabPage);
            this.tabControlProduct.Controls.Add(this.EmptabPage);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlProduct.SelectedIndexChanged += new System.EventHandler(this.tabControlProduct_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.CurrencycmbBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.txtLastSerial);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtMainParentId);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.txtLevel);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.txtdisplay_Flag);
            this.tabPage1.Controls.Add(this.txtAccountCode);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAccValue);
            this.tabPage1.Controls.Add(this.txtAccountName);
            this.tabPage1.Controls.Add(this.txtToValue);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtAccountSName);
            this.tabPage1.Controls.Add(this.txtFromValue);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAccountparentCode);
            this.tabPage1.Controls.Add(this.txtProcessFlag);
            this.tabPage1.Controls.Add(this.Label22);
            this.tabPage1.Controls.Add(this.MainAccChkBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CmbClosedTo);
            this.tabPage1.Controls.Add(this.txtAccountparentName);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtRootFlag);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.CmbAccountType);
            this.tabPage1.Controls.Add(this.txtStartdate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAccountparentId);
            this.tabPage1.Controls.Add(this.txtAccountId);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // CurrencycmbBox
            // 
            resources.ApplyResources(this.CurrencycmbBox, "CurrencycmbBox");
            this.CurrencycmbBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountingBindingSource, "CurId", true));
            this.CurrencycmbBox.DataSource = this.cDECurrencyBindingSource;
            this.CurrencycmbBox.DisplayMember = "CurDesc";
            this.CurrencycmbBox.FormattingEnabled = true;
            this.CurrencycmbBox.Name = "CurrencycmbBox";
            this.CurrencycmbBox.ValueMember = "CurId";
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
            // cDECurrencyBindingSource
            // 
            this.cDECurrencyBindingSource.DataMember = "CDE_Currency";
            this.cDECurrencyBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
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
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.ForeColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // txtLastSerial
            // 
            this.txtLastSerial.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastSerial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "LastSerialNo", true));
            resources.ApplyResources(this.txtLastSerial, "txtLastSerial");
            this.txtLastSerial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastSerial.Name = "txtLastSerial";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtMainParentId
            // 
            this.txtMainParentId.AcceptsReturn = true;
            this.txtMainParentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMainParentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainParentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "MainParentAccId", true));
            resources.ApplyResources(this.txtMainParentId, "txtMainParentId");
            this.txtMainParentId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMainParentId.Name = "txtMainParentId";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "notes", true));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Name = "txtNotes";
            // 
            // txtLevel
            // 
            this.txtLevel.AcceptsReturn = true;
            this.txtLevel.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "AccLevel", true));
            resources.ApplyResources(this.txtLevel, "txtLevel");
            this.txtLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLevel.Name = "txtLevel";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // txtdisplay_Flag
            // 
            this.txtdisplay_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.txtdisplay_Flag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdisplay_Flag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "display_Flag", true));
            resources.ApplyResources(this.txtdisplay_Flag, "txtdisplay_Flag");
            this.txtdisplay_Flag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdisplay_Flag.Name = "txtdisplay_Flag";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountCode, "txtAccountCode");
            this.txtAccountCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "AccountCode", true));
            this.txtAccountCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountCode.Name = "txtAccountCode";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtAccValue
            // 
            this.txtAccValue.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccValue, "txtAccValue");
            this.txtAccValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccValue.Name = "txtAccValue";
            // 
            // txtAccountName
            // 
            this.txtAccountName.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountName, "txtAccountName");
            this.txtAccountName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "accountname", true));
            this.txtAccountName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountName.Name = "txtAccountName";
            // 
            // txtToValue
            // 
            this.txtToValue.AcceptsReturn = true;
            resources.ApplyResources(this.txtToValue, "txtToValue");
            this.txtToValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtToValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Totaltovalue", true));
            this.txtToValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtToValue.Name = "txtToValue";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // txtAccountSName
            // 
            this.txtAccountSName.AcceptsReturn = true;
            resources.ApplyResources(this.txtAccountSName, "txtAccountSName");
            this.txtAccountSName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountSName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountSName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "AccountSName", true));
            this.txtAccountSName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountSName.Name = "txtAccountSName";
            // 
            // txtFromValue
            // 
            this.txtFromValue.AcceptsReturn = true;
            resources.ApplyResources(this.txtFromValue, "txtFromValue");
            this.txtFromValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtFromValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Totalfromvalue", true));
            this.txtFromValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFromValue.Name = "txtFromValue";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // txtAccountparentCode
            // 
            resources.ApplyResources(this.txtAccountparentCode, "txtAccountparentCode");
            this.txtAccountparentCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountparentCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountparentCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountparentCode.Name = "txtAccountparentCode";
            // 
            // txtProcessFlag
            // 
            this.txtProcessFlag.AcceptsReturn = true;
            this.txtProcessFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtProcessFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "ProcessFlag", true));
            resources.ApplyResources(this.txtProcessFlag, "txtProcessFlag");
            this.txtProcessFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProcessFlag.Name = "txtProcessFlag";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // MainAccChkBox
            // 
            resources.ApplyResources(this.MainAccChkBox, "MainAccChkBox");
            this.MainAccChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.accountingBindingSource, "MainNode", true));
            this.MainAccChkBox.ForeColor = System.Drawing.Color.Blue;
            this.MainAccChkBox.Name = "MainAccChkBox";
            this.MainAccChkBox.UseVisualStyleBackColor = true;
            this.MainAccChkBox.CheckedChanged += new System.EventHandler(this.MainAccChkBox_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // CmbClosedTo
            // 
            resources.ApplyResources(this.CmbClosedTo, "CmbClosedTo");
            this.CmbClosedTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountingBindingSource, "ClosedTo", true));
            this.CmbClosedTo.DisplayMember = "accountname";
            this.CmbClosedTo.FormattingEnabled = true;
            this.CmbClosedTo.Name = "CmbClosedTo";
            this.CmbClosedTo.ValueMember = "accountId";
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
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // txtRootFlag
            // 
            this.txtRootFlag.AcceptsReturn = true;
            this.txtRootFlag.BackColor = System.Drawing.SystemColors.Window;
            this.txtRootFlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRootFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "root", true));
            resources.ApplyResources(this.txtRootFlag, "txtRootFlag");
            this.txtRootFlag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRootFlag.Name = "txtRootFlag";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // CmbAccountType
            // 
            resources.ApplyResources(this.CmbAccountType, "CmbAccountType");
            this.CmbAccountType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountingBindingSource, "accountType", true));
            this.CmbAccountType.DisplayMember = "DESC";
            this.CmbAccountType.FormattingEnabled = true;
            this.CmbAccountType.Name = "CmbAccountType";
            this.CmbAccountType.ValueMember = "ID";
            this.CmbAccountType.SelectedIndexChanged += new System.EventHandler(this.CmbAccountType_SelectedIndexChanged);
            // 
            // txtStartdate
            // 
            this.txtStartdate.AcceptsReturn = true;
            resources.ApplyResources(this.txtStartdate, "txtStartdate");
            this.txtStartdate.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "startdate", true));
            this.txtStartdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartdate.Name = "txtStartdate";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // txtAccountparentId
            // 
            this.txtAccountparentId.AcceptsReturn = true;
            this.txtAccountparentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountparentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountparentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "AccountparentId", true));
            resources.ApplyResources(this.txtAccountparentId, "txtAccountparentId");
            this.txtAccountparentId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountparentId.Name = "txtAccountparentId";
            // 
            // txtAccountId
            // 
            this.txtAccountId.AcceptsReturn = true;
            this.txtAccountId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "accountid", true));
            resources.ApplyResources(this.txtAccountId, "txtAccountId");
            this.txtAccountId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountId.Name = "txtAccountId";
            // 
            // CustTabPage
            // 
            this.CustTabPage.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.CustTabPage, "CustTabPage");
            this.CustTabPage.Name = "CustTabPage";
            // 
            // EmptabPage
            // 
            this.EmptabPage.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.EmptabPage, "EmptabPage");
            this.EmptabPage.Name = "EmptabPage";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.Blue;
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
            this.AccountTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountTreeView.ContextMenuStrip = this.ContextMenuAccount;
            this.AccountTreeView.HideSelection = false;
            resources.ApplyResources(this.AccountTreeView, "AccountTreeView");
            this.AccountTreeView.ImageList = this.TreeimageList;
            this.AccountTreeView.Name = "AccountTreeView";
            this.AccountTreeView.ShowNodeToolTips = true;
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
            this.TreeReFreshMenuItem,
            this.TreeOpenAllMItem,
            this.MenuItemSave,
            this.PrintTreeMenuItem,
            this.AccountMoveMenuItem});
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
            this.MenuItemDel.Click += new System.EventHandler(this.CmdDel_Click);
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
            // MenuItemSave
            // 
            resources.ApplyResources(this.MenuItemSave, "MenuItemSave");
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // PrintTreeMenuItem
            // 
            resources.ApplyResources(this.PrintTreeMenuItem, "PrintTreeMenuItem");
            this.PrintTreeMenuItem.Name = "PrintTreeMenuItem";
            this.PrintTreeMenuItem.Click += new System.EventHandler(this.PrintTreeMenuItem_Click);
            // 
            // AccountMoveMenuItem
            // 
            resources.ApplyResources(this.AccountMoveMenuItem, "AccountMoveMenuItem");
            this.AccountMoveMenuItem.Name = "AccountMoveMenuItem";
            this.AccountMoveMenuItem.Click += new System.EventHandler(this.AccountMoveMenuItem_Click);
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
            this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_CurrencyTableAdapter
            // 
            this.cDE_CurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // AccountAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tabControlProduct);
            this.Controls.Add(this.groupBox11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccountAdd";
            this.Activated += new System.EventHandler(this.AccountAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.tabControlProduct.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDECurrencyBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ContextMenuAccount.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CustTabPage;
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
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbAccountType;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.ComboBox CmbClosedTo;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox MainAccChkBox;
        public System.Windows.Forms.TextBox txtProcessFlag;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtAccValue;
        public System.Windows.Forms.TextBox txtToValue;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtFromValue;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage EmptabPage;
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
        private System.Windows.Forms.ToolStripMenuItem PrintTreeMenuItem;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem AccountMoveMenuItem;
        private System.Windows.Forms.ComboBox CurrencycmbBox;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource cDECurrencyBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter cDE_CurrencyTableAdapter;

    }
}