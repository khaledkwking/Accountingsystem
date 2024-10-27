namespace ERPSYS
{
    partial class QidOutAddOld
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
            System.Windows.Forms.Label qidDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QidOutAdd));
            System.Windows.Forms.Label brachIdLabel;
            System.Windows.Forms.Label empIdLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label qidcodeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.qidsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.qididTextBox = new System.Windows.Forms.TextBox();
            this.qidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qidDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.CmdActiveSave = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BankRdBtn = new System.Windows.Forms.RadioButton();
            this.BoxRdBtn = new System.Windows.Forms.RadioButton();
            this.txtrecitetype = new System.Windows.Forms.TextBox();
            this.txtBoxAcc = new System.Windows.Forms.TextBox();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBankAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.CmbBanks = new System.Windows.Forms.ComboBox();
            this.accountingBindingSourceBank = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.qidsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter();
            this.qidsDetailsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.costCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qidcodeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnPrint = new System.Windows.Forms.Button();
            this.costCentersTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter();
            this.bindingNavigatorInv = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setupCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupCodesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtQidDate = new System.Windows.Forms.TextBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.toValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNTCODE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterDateQid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qididDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QidType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            qidDateLabel = new System.Windows.Forms.Label();
            brachIdLabel = new System.Windows.Forms.Label();
            empIdLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            qidcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInv)).BeginInit();
            this.bindingNavigatorInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qidDateLabel
            // 
            resources.ApplyResources(qidDateLabel, "qidDateLabel");
            qidDateLabel.ForeColor = System.Drawing.Color.Blue;
            qidDateLabel.Name = "qidDateLabel";
            // 
            // brachIdLabel
            // 
            resources.ApplyResources(brachIdLabel, "brachIdLabel");
            brachIdLabel.ForeColor = System.Drawing.Color.Blue;
            brachIdLabel.Name = "brachIdLabel";
            // 
            // empIdLabel
            // 
            resources.ApplyResources(empIdLabel, "empIdLabel");
            empIdLabel.ForeColor = System.Drawing.Color.Blue;
            empIdLabel.Name = "empIdLabel";
            // 
            // notesLabel
            // 
            resources.ApplyResources(notesLabel, "notesLabel");
            notesLabel.ForeColor = System.Drawing.Color.Blue;
            notesLabel.Name = "notesLabel";
            // 
            // qidcodeLabel
            // 
            resources.ApplyResources(qidcodeLabel, "qidcodeLabel");
            qidcodeLabel.ForeColor = System.Drawing.Color.Blue;
            qidcodeLabel.Name = "qidcodeLabel";
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
            // qidsDetailsBindingSource
            // 
            this.qidsDetailsBindingSource.DataMember = "qidsDetails";
            this.qidsDetailsBindingSource.DataSource = this.nEWERPDataSet;
            this.qidsDetailsBindingSource.PositionChanged += new System.EventHandler(this.qidsDetailsBindingSource_PositionChanged);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click_1);
            // 
            // CmdClose
            // 
            this.CmdClose.CausesValidation = false;
            resources.ApplyResources(this.CmdClose, "CmdClose");
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // qididTextBox
            // 
            this.qididTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "qidid", true));
            resources.ApplyResources(this.qididTextBox, "qididTextBox");
            this.qididTextBox.Name = "qididTextBox";
            // 
            // qidsBindingSource
            // 
            this.qidsBindingSource.DataMember = "qids";
            this.qidsBindingSource.DataSource = this.nEWERPDataSet;
            this.qidsBindingSource.PositionChanged += new System.EventHandler(this.qidsBindingSource_PositionChanged);
            // 
            // qidDateDateTimePicker
            // 
            resources.ApplyResources(this.qidDateDateTimePicker, "qidDateDateTimePicker");
            this.qidDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.qidDateDateTimePicker.Name = "qidDateDateTimePicker";
            this.qidDateDateTimePicker.ValueChanged += new System.EventHandler(this.qidDateDateTimePicker_ValueChanged);
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "EmpId", true));
            resources.ApplyResources(this.empIdTextBox, "empIdTextBox");
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.qidcodeTextBox_KeyUp);
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "Notes", true));
            resources.ApplyResources(this.notesTextBox, "notesTextBox");
            this.notesTextBox.Name = "notesTextBox";
            // 
            // CmbBranch
            // 
            this.CmbBranch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qidsBindingSource, "BrachId", true));
            this.CmbBranch.DataSource = this.bRANCHESBindingSource;
            this.CmbBranch.DisplayMember = "BRANCHNAME";
            resources.ApplyResources(this.CmbBranch, "CmbBranch");
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.ValueMember = "BRANCHCODE";
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txtTotalToValue
            // 
            resources.ApplyResources(this.txtTotalToValue, "txtTotalToValue");
            this.txtTotalToValue.Name = "txtTotalToValue";
            // 
            // CmdActiveSave
            // 
            resources.ApplyResources(this.CmdActiveSave, "CmdActiveSave");
            this.CmdActiveSave.ForeColor = System.Drawing.Color.Black;
            this.CmdActiveSave.Name = "CmdActiveSave";
            this.CmdActiveSave.UseVisualStyleBackColor = true;
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BankRdBtn);
            this.groupBox1.Controls.Add(this.BoxRdBtn);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BankRdBtn
            // 
            resources.ApplyResources(this.BankRdBtn, "BankRdBtn");
            this.BankRdBtn.ForeColor = System.Drawing.Color.Black;
            this.BankRdBtn.Name = "BankRdBtn";
            this.BankRdBtn.TabStop = true;
            this.BankRdBtn.UseVisualStyleBackColor = true;
            this.BankRdBtn.CheckedChanged += new System.EventHandler(this.BankRdBtn_CheckedChanged);
            // 
            // BoxRdBtn
            // 
            resources.ApplyResources(this.BoxRdBtn, "BoxRdBtn");
            this.BoxRdBtn.Checked = true;
            this.BoxRdBtn.ForeColor = System.Drawing.Color.Black;
            this.BoxRdBtn.Name = "BoxRdBtn";
            this.BoxRdBtn.TabStop = true;
            this.BoxRdBtn.UseVisualStyleBackColor = true;
            this.BoxRdBtn.CheckedChanged += new System.EventHandler(this.BoxRdBtn_CheckedChanged);
            // 
            // txtrecitetype
            // 
            this.txtrecitetype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "recitetype", true));
            resources.ApplyResources(this.txtrecitetype, "txtrecitetype");
            this.txtrecitetype.Name = "txtrecitetype";
            // 
            // txtBoxAcc
            // 
            this.txtBoxAcc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "boxaccid", true));
            resources.ApplyResources(this.txtBoxAcc, "txtBoxAcc");
            this.txtBoxAcc.Name = "txtBoxAcc";
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txtBankAcc
            // 
            this.txtBankAcc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "bankaccid", true));
            resources.ApplyResources(this.txtBankAcc, "txtBankAcc");
            this.txtBankAcc.Name = "txtBankAcc";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "ChequeNo", true));
            resources.ApplyResources(this.txtChequeNo, "txtChequeNo");
            this.txtChequeNo.Name = "txtChequeNo";
            // 
            // CmbBanks
            // 
            this.CmbBanks.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qidsBindingSource, "BankAccId", true));
            this.CmbBanks.DataSource = this.accountingBindingSourceBank;
            this.CmbBanks.DisplayMember = "accountname";
            resources.ApplyResources(this.CmbBanks, "CmbBanks");
            this.CmbBanks.FormattingEnabled = true;
            this.CmbBanks.Name = "CmbBanks";
            this.CmbBanks.ValueMember = "accountid";
            // 
            // accountingBindingSourceBank
            // 
            this.accountingBindingSourceBank.DataMember = "accounting";
            this.accountingBindingSourceBank.DataSource = this.nEWERPDataSet;
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // qidsTableAdapter
            // 
            this.qidsTableAdapter.ClearBeforeFill = true;
            // 
            // qidsDetailsTableAdapter
            // 
            this.qidsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // StockDGView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.StockDGView, "StockDGView");
            this.StockDGView.AutoGenerateColumns = false;
            this.StockDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StockDGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toValueDataGridViewTextBoxColumn,
            this.ACCOUNTCODE,
            this.AccountName,
            this.fromValueDataGridViewTextBoxColumn,
            this.Description,
            this.EnterDateQid,
            this.Detcode,
            this.iDDataGridViewTextBoxColumn,
            this.qididDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.detcodeDataGridViewTextBoxColumn,
            this.QidType,
            this.ActionType,
            this.CostId});
            this.StockDGView.ContextMenuStrip = this.contextMenuStrip1;
            this.StockDGView.DataSource = this.qidsDetailsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGView.DefaultCellStyle = dataGridViewCellStyle4;
            this.StockDGView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StockDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StockDGView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StockDGView_RowValidating);
            this.StockDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGView_CellValidated);
            this.StockDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StockDGView_RowsAdded);
            this.StockDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StockDGView_CellValidating);
            this.StockDGView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGView_CellEndEdit);
            this.StockDGView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.StockDGView_DefaultValuesNeeded);
            this.StockDGView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGView_CellValueChanged_1);
            this.StockDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StockDGView_DataError);
            this.StockDGView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.StockDGView_EditingControlShowing);
            // 
            // costCentersBindingSource
            // 
            this.costCentersBindingSource.DataMember = "CostCenters";
            this.costCentersBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // DelMenuItem
            // 
            this.DelMenuItem.Name = "DelMenuItem";
            resources.ApplyResources(this.DelMenuItem, "DelMenuItem");
            this.DelMenuItem.Click += new System.EventHandler(this.DelMenuItem_Click);
            // 
            // qidcodeTextBox
            // 
            this.qidcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "qidcode", true));
            resources.ApplyResources(this.qidcodeTextBox, "qidcodeTextBox");
            this.qidcodeTextBox.Name = "qidcodeTextBox";
            this.qidcodeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.qidcodeTextBox_KeyUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // costCentersTableAdapter
            // 
            this.costCentersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorInv
            // 
            this.bindingNavigatorInv.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorInv.BindingSource = this.qidsBindingSource;
            this.bindingNavigatorInv.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorInv.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorInv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            resources.ApplyResources(this.bindingNavigatorInv, "bindingNavigatorInv");
            this.bindingNavigatorInv.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorInv.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorInv.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorInv.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorInv.Name = "bindingNavigatorInv";
            this.bindingNavigatorInv.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // setupCodesBindingSource
            // 
            this.setupCodesBindingSource.DataMember = "SetupCodes";
            this.setupCodesBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupCodesTableAdapter
            // 
            this.setupCodesTableAdapter.ClearBeforeFill = true;
            // 
            // txtUserId
            // 
            this.txtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "EmpId", true));
            resources.ApplyResources(this.txtUserId, "txtUserId");
            this.txtUserId.Name = "txtUserId";
            // 
            // txtQidDate
            // 
            this.txtQidDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "qidDate", true));
            resources.ApplyResources(this.txtQidDate, "txtQidDate");
            this.txtQidDate.Name = "txtQidDate";
            // 
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.ForeColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // toValueDataGridViewTextBoxColumn
            // 
            this.toValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toValueDataGridViewTextBoxColumn.DataPropertyName = "ToValue";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.toValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.toValueDataGridViewTextBoxColumn, "toValueDataGridViewTextBoxColumn");
            this.toValueDataGridViewTextBoxColumn.Name = "toValueDataGridViewTextBoxColumn";
            // 
            // ACCOUNTCODE
            // 
            this.ACCOUNTCODE.DataPropertyName = "ACCOUNTID";
            this.ACCOUNTCODE.DataSource = this.accountingBindingSource;
            this.ACCOUNTCODE.DisplayMember = "AccountCode";
            this.ACCOUNTCODE.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.ACCOUNTCODE, "ACCOUNTCODE");
            this.ACCOUNTCODE.Name = "ACCOUNTCODE";
            this.ACCOUNTCODE.ValueMember = "accountid";
            // 
            // AccountName
            // 
            this.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AccountName.DataPropertyName = "ACCOUNTID";
            this.AccountName.DataSource = this.accountingBindingSource;
            this.AccountName.DisplayMember = "accountname";
            this.AccountName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.AccountName, "AccountName");
            this.AccountName.Name = "AccountName";
            this.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccountName.ValueMember = "accountid";
            // 
            // fromValueDataGridViewTextBoxColumn
            // 
            this.fromValueDataGridViewTextBoxColumn.DataPropertyName = "FromValue";
            resources.ApplyResources(this.fromValueDataGridViewTextBoxColumn, "fromValueDataGridViewTextBoxColumn");
            this.fromValueDataGridViewTextBoxColumn.Name = "fromValueDataGridViewTextBoxColumn";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description.DataPropertyName = "Description";
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            // 
            // EnterDateQid
            // 
            this.EnterDateQid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnterDateQid.DataPropertyName = "EnterDate";
            resources.ApplyResources(this.EnterDateQid, "EnterDateQid");
            this.EnterDateQid.Name = "EnterDateQid";
            // 
            // Detcode
            // 
            this.Detcode.DataPropertyName = "Detcode";
            resources.ApplyResources(this.Detcode, "Detcode");
            this.Detcode.Name = "Detcode";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qididDataGridViewTextBoxColumn
            // 
            this.qididDataGridViewTextBoxColumn.DataPropertyName = "qidid";
            resources.ApplyResources(this.qididDataGridViewTextBoxColumn, "qididDataGridViewTextBoxColumn");
            this.qididDataGridViewTextBoxColumn.Name = "qididDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // detcodeDataGridViewTextBoxColumn
            // 
            this.detcodeDataGridViewTextBoxColumn.DataPropertyName = "Detcode";
            resources.ApplyResources(this.detcodeDataGridViewTextBoxColumn, "detcodeDataGridViewTextBoxColumn");
            this.detcodeDataGridViewTextBoxColumn.Name = "detcodeDataGridViewTextBoxColumn";
            // 
            // QidType
            // 
            this.QidType.DataPropertyName = "QidType";
            resources.ApplyResources(this.QidType, "QidType");
            this.QidType.Name = "QidType";
            // 
            // ActionType
            // 
            this.ActionType.DataPropertyName = "ActionType";
            resources.ApplyResources(this.ActionType, "ActionType");
            this.ActionType.Name = "ActionType";
            // 
            // CostId
            // 
            this.CostId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostId.DataPropertyName = "CostId";
            this.CostId.DataSource = this.costCentersBindingSource;
            this.CostId.DisplayMember = "costName";
            this.CostId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.CostId, "CostId");
            this.CostId.Name = "CostId";
            this.CostId.ValueMember = "costid";
            // 
            // QidOutAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.CmdDel);
            this.Controls.Add(this.txtQidDate);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.bindingNavigatorInv);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(qidcodeLabel);
            this.Controls.Add(this.qidcodeTextBox);
            this.Controls.Add(this.StockDGView);
            this.Controls.Add(this.txtBoxAcc);
            this.Controls.Add(this.txtBankAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.CmbBanks);
            this.Controls.Add(this.txtrecitetype);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CmdActiveSave);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(empIdLabel);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(brachIdLabel);
            this.Controls.Add(qidDateLabel);
            this.Controls.Add(this.qidDateDateTimePicker);
            this.Controls.Add(this.qididTextBox);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QidOutAdd";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.QidOutAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSourceBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInv)).EndInit();
            this.bindingNavigatorInv.ResumeLayout(false);
            this.bindingNavigatorInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCostPrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox qididTextBox;
        private System.Windows.Forms.DateTimePicker qidDateDateTimePicker;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.BindingSource qidsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter qidsTableAdapter;
        private System.Windows.Forms.BindingSource qidsDetailsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter qidsDetailsTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.TextBox txtTotalToValue;
        internal System.Windows.Forms.Button CmdActiveSave;
        internal System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BankRdBtn;
        private System.Windows.Forms.RadioButton BoxRdBtn;
        private System.Windows.Forms.TextBox txtrecitetype;
        private System.Windows.Forms.TextBox txtBoxAcc;
        private System.Windows.Forms.TextBox txtBankAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.ComboBox CmbBanks;
        private System.Windows.Forms.BindingSource accountingBindingSourceBank;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        internal System.Windows.Forms.DataGridView StockDGView;
        private System.Windows.Forms.TextBox qidcodeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.BindingSource costCentersBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter costCentersTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorInv;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource setupCodesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter setupCodesTableAdapter;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtQidDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DelMenuItem;
        internal System.Windows.Forms.Button CmdDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn toValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ACCOUNTCODE;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterDateQid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qididDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QidType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewComboBoxColumn CostId;

    }
}