namespace ERPSYS
{
    partial class BranchesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchesAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hintNameTextBox = new System.Windows.Forms.TextBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.telPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.txBranchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BranchesDGView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRANCHNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salInvSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchInvSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNetaccid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSSales = new System.Windows.Forms.TextBox();
            this.txtsPurchase = new System.Windows.Forms.TextBox();
            this.CmbKeyNet = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            resources.ApplyResources(this.groupBox4, "groupBox4");
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // hintNameTextBox
            // 
            this.hintNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "HintName", true));
            resources.ApplyResources(this.hintNameTextBox, "hintNameTextBox");
            this.hintNameTextBox.Name = "hintNameTextBox";
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telPhoneTextBox
            // 
            this.telPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "TelPhone", true));
            resources.ApplyResources(this.telPhoneTextBox, "telPhoneTextBox");
            this.telPhoneTextBox.Name = "telPhoneTextBox";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "Address", true));
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "CompanyName", true));
            resources.ApplyResources(this.companyNameTextBox, "companyNameTextBox");
            this.companyNameTextBox.Name = "companyNameTextBox";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "BRANCHCODE", true));
            resources.ApplyResources(this.txtBranchCode, "txtBranchCode");
            this.txtBranchCode.Name = "txtBranchCode";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // txBranchName
            // 
            this.txBranchName.AcceptsReturn = true;
            this.txBranchName.BackColor = System.Drawing.SystemColors.Window;
            this.txBranchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBranchName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "BRANCHNAME", true));
            resources.ApplyResources(this.txBranchName, "txBranchName");
            this.txBranchName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txBranchName.Name = "txBranchName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.BranchesDGView);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // BranchesDGView
            // 
            this.BranchesDGView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchesDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.BranchesDGView, "BranchesDGView");
            this.BranchesDGView.AutoGenerateColumns = false;
            this.BranchesDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchesDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BranchesDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchesDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.BRANCHNAME,
            this.bRANCHCODEDataGridViewTextBoxColumn,
            this.bRANCHNAMEDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telPhoneDataGridViewTextBoxColumn,
            this.hintNameDataGridViewTextBoxColumn,
            this.salInvSerialDataGridViewTextBoxColumn,
            this.purchInvSerialDataGridViewTextBoxColumn,
            this.KeyNetaccid});
            this.BranchesDGView.DataSource = this.bRANCHESBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BranchesDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BranchesDGView.EnableHeadersVisualStyles = false;
            this.BranchesDGView.MultiSelect = false;
            this.BranchesDGView.Name = "BranchesDGView";
            this.BranchesDGView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchesDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.BranchesDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BranchesDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BranchesDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValidated);
            this.BranchesDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.BranchesDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StoresDGView_DataError);
            this.BranchesDGView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_RowLeave);
            this.BranchesDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StoresDGView_RowsAdded);
            this.BranchesDGView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StoresDGView_RowValidating);
            this.BranchesDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "BRANCHCODE";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BRANCHNAME
            // 
            this.BRANCHNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BRANCHNAME.DataPropertyName = "BRANCHNAME";
            resources.ApplyResources(this.BRANCHNAME, "BRANCHNAME");
            this.BRANCHNAME.Name = "BRANCHNAME";
            this.BRANCHNAME.ReadOnly = true;
            // 
            // bRANCHCODEDataGridViewTextBoxColumn
            // 
            this.bRANCHCODEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHCODE";
            resources.ApplyResources(this.bRANCHCODEDataGridViewTextBoxColumn, "bRANCHCODEDataGridViewTextBoxColumn");
            this.bRANCHCODEDataGridViewTextBoxColumn.Name = "bRANCHCODEDataGridViewTextBoxColumn";
            this.bRANCHCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHNAMEDataGridViewTextBoxColumn
            // 
            this.bRANCHNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHNAME";
            resources.ApplyResources(this.bRANCHNAMEDataGridViewTextBoxColumn, "bRANCHNAMEDataGridViewTextBoxColumn");
            this.bRANCHNAMEDataGridViewTextBoxColumn.Name = "bRANCHNAMEDataGridViewTextBoxColumn";
            this.bRANCHNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            resources.ApplyResources(this.companyNameDataGridViewTextBoxColumn, "companyNameDataGridViewTextBoxColumn");
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.addressDataGridViewTextBoxColumn, "addressDataGridViewTextBoxColumn");
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telPhoneDataGridViewTextBoxColumn
            // 
            this.telPhoneDataGridViewTextBoxColumn.DataPropertyName = "TelPhone";
            resources.ApplyResources(this.telPhoneDataGridViewTextBoxColumn, "telPhoneDataGridViewTextBoxColumn");
            this.telPhoneDataGridViewTextBoxColumn.Name = "telPhoneDataGridViewTextBoxColumn";
            this.telPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hintNameDataGridViewTextBoxColumn
            // 
            this.hintNameDataGridViewTextBoxColumn.DataPropertyName = "HintName";
            resources.ApplyResources(this.hintNameDataGridViewTextBoxColumn, "hintNameDataGridViewTextBoxColumn");
            this.hintNameDataGridViewTextBoxColumn.Name = "hintNameDataGridViewTextBoxColumn";
            this.hintNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salInvSerialDataGridViewTextBoxColumn
            // 
            this.salInvSerialDataGridViewTextBoxColumn.DataPropertyName = "SalInvSerial";
            resources.ApplyResources(this.salInvSerialDataGridViewTextBoxColumn, "salInvSerialDataGridViewTextBoxColumn");
            this.salInvSerialDataGridViewTextBoxColumn.Name = "salInvSerialDataGridViewTextBoxColumn";
            this.salInvSerialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchInvSerialDataGridViewTextBoxColumn
            // 
            this.purchInvSerialDataGridViewTextBoxColumn.DataPropertyName = "PurchInvSerial";
            resources.ApplyResources(this.purchInvSerialDataGridViewTextBoxColumn, "purchInvSerialDataGridViewTextBoxColumn");
            this.purchInvSerialDataGridViewTextBoxColumn.Name = "purchInvSerialDataGridViewTextBoxColumn";
            this.purchInvSerialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KeyNetaccid
            // 
            this.KeyNetaccid.DataPropertyName = "KeyNetaccid";
            resources.ApplyResources(this.KeyNetaccid, "KeyNetaccid");
            this.KeyNetaccid.Name = "KeyNetaccid";
            this.KeyNetaccid.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "DiscountValue", true));
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // txtSSales
            // 
            this.txtSSales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "SalInvSerial", true));
            resources.ApplyResources(this.txtSSales, "txtSSales");
            this.txtSSales.Name = "txtSSales";
            // 
            // txtsPurchase
            // 
            this.txtsPurchase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bRANCHESBindingSource, "PurchInvSerial", true));
            resources.ApplyResources(this.txtsPurchase, "txtsPurchase");
            this.txtsPurchase.Name = "txtsPurchase";
            // 
            // CmbKeyNet
            // 
            this.CmbKeyNet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbKeyNet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbKeyNet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bRANCHESBindingSource, "KeyNetaccid", true));
            this.CmbKeyNet.DataSource = this.accountingBindingSource;
            this.CmbKeyNet.DisplayMember = "accountname";
            resources.ApplyResources(this.CmbKeyNet, "CmbKeyNet");
            this.CmbKeyNet.FormattingEnabled = true;
            this.CmbKeyNet.Name = "CmbKeyNet";
            this.CmbKeyNet.ValueMember = "accountid";
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
            // BranchesAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.CmbKeyNet);
            this.Controls.Add(this.txtsPurchase);
            this.Controls.Add(this.txtSSales);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hintNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telPhoneTextBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBranchName);
            this.Controls.Add(this.Label22);
            this.Name = "BranchesAdd";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.TextBox txBranchName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.DataGridView BranchesDGView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.TextBox companyNameTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hintNameTextBox;
        private System.Windows.Forms.TextBox telPhoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsPurchase;
        private System.Windows.Forms.TextBox txtSSales;
        private System.Windows.Forms.ComboBox CmbKeyNet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANCHNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salInvSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchInvSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNetaccid;

    }
}