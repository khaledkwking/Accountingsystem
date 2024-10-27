namespace ERPSYS
{
    partial class InvoicesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmboxCenter = new System.Windows.Forms.ComboBox();
            this.costCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.enterDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.CmbInvTypes = new System.Windows.Forms.ComboBox();
            this.CmbBranches = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDEUNITTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.invoiceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.cDE_UNIT_TYPESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.product_Units_PricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Units_PricesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter();
            this.invoiceViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InvoiceViewTableAdapter();
            this.costCentersTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtPayToDate = new System.Windows.Forms.TextBox();
            this.txtPayFromDate = new System.Windows.Forms.TextBox();
            this.ddlPayToDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlPayFromDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ChkReoderFlag = new System.Windows.Forms.CheckBox();
            this.labelCustSup = new System.Windows.Forms.Label();
            this.CmbCustSupAccid = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter();
            this.InvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTotalNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.recoderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSupAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invRemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalAddCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReoderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReoderNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayFinish = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmboxCenter
            // 
            this.CmboxCenter.DataSource = this.costCentersBindingSource;
            this.CmboxCenter.DisplayMember = "costName";
            resources.ApplyResources(this.CmboxCenter, "CmboxCenter");
            this.CmboxCenter.FormattingEnabled = true;
            this.CmboxCenter.Name = "CmboxCenter";
            this.CmboxCenter.ValueMember = "costid";
            this.CmboxCenter.SelectionChangeCommitted += new System.EventHandler(this.CmboxCenter_SelectionChangeCommitted);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // enterDateDateTimePicker
            // 
            resources.ApplyResources(this.enterDateDateTimePicker, "enterDateDateTimePicker");
            this.enterDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enterDateDateTimePicker.Name = "enterDateDateTimePicker";
            this.enterDateDateTimePicker.ValueChanged += new System.EventHandler(this.enterDateDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // CmbInvTypes
            // 
            this.CmbInvTypes.DisplayMember = "Desc";
            resources.ApplyResources(this.CmbInvTypes, "CmbInvTypes");
            this.CmbInvTypes.FormattingEnabled = true;
            this.CmbInvTypes.Name = "CmbInvTypes";
            this.CmbInvTypes.ValueMember = "ID";
            this.CmbInvTypes.SelectionChangeCommitted += new System.EventHandler(this.CmbInvTypes_SelectionChangeCommitted);
            // 
            // CmbBranches
            // 
            this.CmbBranches.DataSource = this.bRANCHESBindingSource;
            this.CmbBranches.DisplayMember = "BRANCHNAME";
            resources.ApplyResources(this.CmbBranches, "CmbBranches");
            this.CmbBranches.FormattingEnabled = true;
            this.CmbBranches.Name = "CmbBranches";
            this.CmbBranches.ValueMember = "BRANCHCODE";
            this.CmbBranches.SelectionChangeCommitted += new System.EventHandler(this.CmbBranches_SelectionChangeCommitted);
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // cDEUNITTYPESBindingSource
            // 
            this.cDEUNITTYPESBindingSource.DataMember = "CDE_UNIT_TYPES";
            this.cDEUNITTYPESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // sTORESBindingSource
            // 
            this.sTORESBindingSource.DataMember = "STORES";
            this.sTORESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.StoresDGView);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            this.StoresDGView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.StoresDGView, "StoresDGView");
            this.StoresDGView.AutoGenerateColumns = false;
            this.StoresDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvId,
            this.invCodeDataGridViewTextBoxColumn,
            this.ColColor,
            this.InvDate,
            this.InvTypeDesc,
            this.sUPCUSTFNAMEDataGridViewTextBoxColumn,
            this.PaymentTypeDesc,
            this.invTotalDataGridViewTextBoxColumn,
            this.invTotalNetDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.costIdDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.recoderCodeDataGridViewTextBoxColumn,
            this.invAccidDataGridViewTextBoxColumn,
            this.custSupAccidDataGridViewTextBoxColumn,
            this.paymentAccidDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn,
            this.paymentValueDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.invPaymentDataGridViewTextBoxColumn,
            this.invRemainDataGridViewTextBoxColumn,
            this.ReferID,
            this.paymentCostDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.chequeFlagDataGridViewCheckBoxColumn,
            this.totalAddCostDataGridViewTextBoxColumn,
            this.totalReoderDataGridViewTextBoxColumn,
            this.totalReoderNetDataGridViewTextBoxColumn,
            this.sUPCUSTIDDataGridViewTextBoxColumn,
            this.collectValueDataGridViewTextBoxColumn,
            this.InvType,
            this.aCCOUNTNameDataGridViewTextBoxColumn,
            this.PaymentType,
            this.PayFinish});
            this.StoresDGView.DataSource = this.invoiceViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StoresDGView.DefaultCellStyle = dataGridViewCellStyle4;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StoresDGView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StoresDGView_CellFormatting);
            this.StoresDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StoresDGView_CellMouseDoubleClick);
            // 
            // invoiceViewBindingSource
            // 
            this.invoiceViewBindingSource.DataMember = "InvoiceView";
            this.invoiceViewBindingSource.DataSource = this.nEWERPDataSet;
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
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sTORESTableAdapter
            // 
            this.sTORESTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_UNIT_TYPESTableAdapter
            // 
            this.cDE_UNIT_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
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
            // invoiceViewTableAdapter
            // 
            this.invoiceViewTableAdapter.ClearBeforeFill = true;
            // 
            // costCentersTableAdapter
            // 
            this.costCentersTableAdapter.ClearBeforeFill = true;
            // 
            // txtToDate
            // 
            resources.ApplyResources(this.txtToDate, "txtToDate");
            this.txtToDate.Name = "txtToDate";
            // 
            // txtFromDate
            // 
            resources.ApplyResources(this.txtFromDate, "txtFromDate");
            this.txtFromDate.Name = "txtFromDate";
            // 
            // txtPayToDate
            // 
            resources.ApplyResources(this.txtPayToDate, "txtPayToDate");
            this.txtPayToDate.Name = "txtPayToDate";
            // 
            // txtPayFromDate
            // 
            resources.ApplyResources(this.txtPayFromDate, "txtPayFromDate");
            this.txtPayFromDate.Name = "txtPayFromDate";
            // 
            // ddlPayToDate
            // 
            resources.ApplyResources(this.ddlPayToDate, "ddlPayToDate");
            this.ddlPayToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddlPayToDate.Name = "ddlPayToDate";
            this.ddlPayToDate.ValueChanged += new System.EventHandler(this.ddlPayToDate_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // ddlPayFromDate
            // 
            resources.ApplyResources(this.ddlPayFromDate, "ddlPayFromDate");
            this.ddlPayFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddlPayFromDate.Name = "ddlPayFromDate";
            this.ddlPayFromDate.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ChkReoderFlag
            // 
            resources.ApplyResources(this.ChkReoderFlag, "ChkReoderFlag");
            this.ChkReoderFlag.Name = "ChkReoderFlag";
            this.ChkReoderFlag.UseVisualStyleBackColor = true;
            // 
            // labelCustSup
            // 
            resources.ApplyResources(this.labelCustSup, "labelCustSup");
            this.labelCustSup.BackColor = System.Drawing.Color.Transparent;
            this.labelCustSup.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCustSup.ForeColor = System.Drawing.Color.Blue;
            this.labelCustSup.Name = "labelCustSup";
            // 
            // CmbCustSupAccid
            // 
            this.CmbCustSupAccid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustSupAccid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            resources.ApplyResources(this.CmbCustSupAccid, "CmbCustSupAccid");
            this.CmbCustSupAccid.Name = "CmbCustSupAccid";
            this.CmbCustSupAccid.ValueMember = "accountid";
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUser.DataSource = this.uSERBindingSource;
            this.comboBoxUser.DisplayMember = "Name";
            resources.ApplyResources(this.comboBoxUser, "comboBoxUser");
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.ValueMember = "ID";
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // InvId
            // 
            this.InvId.DataPropertyName = "InvId";
            resources.ApplyResources(this.InvId, "InvId");
            this.InvId.Name = "InvId";
            this.InvId.ReadOnly = true;
            // 
            // invCodeDataGridViewTextBoxColumn
            // 
            this.invCodeDataGridViewTextBoxColumn.DataPropertyName = "InvCode";
            resources.ApplyResources(this.invCodeDataGridViewTextBoxColumn, "invCodeDataGridViewTextBoxColumn");
            this.invCodeDataGridViewTextBoxColumn.Name = "invCodeDataGridViewTextBoxColumn";
            this.invCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColColor
            // 
            resources.ApplyResources(this.ColColor, "ColColor");
            this.ColColor.Name = "ColColor";
            this.ColColor.ReadOnly = true;
            // 
            // InvDate
            // 
            this.InvDate.DataPropertyName = "InvDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.InvDate.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.InvDate, "InvDate");
            this.InvDate.Name = "InvDate";
            this.InvDate.ReadOnly = true;
            // 
            // InvTypeDesc
            // 
            resources.ApplyResources(this.InvTypeDesc, "InvTypeDesc");
            this.InvTypeDesc.Name = "InvTypeDesc";
            this.InvTypeDesc.ReadOnly = true;
            // 
            // sUPCUSTFNAMEDataGridViewTextBoxColumn
            // 
            this.sUPCUSTFNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_FNAME";
            resources.ApplyResources(this.sUPCUSTFNAMEDataGridViewTextBoxColumn, "sUPCUSTFNAMEDataGridViewTextBoxColumn");
            this.sUPCUSTFNAMEDataGridViewTextBoxColumn.Name = "sUPCUSTFNAMEDataGridViewTextBoxColumn";
            this.sUPCUSTFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentTypeDesc
            // 
            resources.ApplyResources(this.PaymentTypeDesc, "PaymentTypeDesc");
            this.PaymentTypeDesc.Name = "PaymentTypeDesc";
            this.PaymentTypeDesc.ReadOnly = true;
            // 
            // invTotalDataGridViewTextBoxColumn
            // 
            this.invTotalDataGridViewTextBoxColumn.DataPropertyName = "invTotal";
            resources.ApplyResources(this.invTotalDataGridViewTextBoxColumn, "invTotalDataGridViewTextBoxColumn");
            this.invTotalDataGridViewTextBoxColumn.Name = "invTotalDataGridViewTextBoxColumn";
            this.invTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invTotalNetDataGridViewTextBoxColumn
            // 
            this.invTotalNetDataGridViewTextBoxColumn.DataPropertyName = "InvTotalNet";
            resources.ApplyResources(this.invTotalNetDataGridViewTextBoxColumn, "invTotalNetDataGridViewTextBoxColumn");
            this.invTotalNetDataGridViewTextBoxColumn.Name = "invTotalNetDataGridViewTextBoxColumn";
            this.invTotalNetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.paymentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.paymentDateDataGridViewTextBoxColumn, "paymentDateDataGridViewTextBoxColumn");
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            resources.ApplyResources(this.discountDataGridViewTextBoxColumn, "discountDataGridViewTextBoxColumn");
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costIdDataGridViewTextBoxColumn
            // 
            this.costIdDataGridViewTextBoxColumn.DataPropertyName = "CostId";
            this.costIdDataGridViewTextBoxColumn.DataSource = this.costCentersBindingSource;
            this.costIdDataGridViewTextBoxColumn.DisplayMember = "costName";
            this.costIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.costIdDataGridViewTextBoxColumn, "costIdDataGridViewTextBoxColumn");
            this.costIdDataGridViewTextBoxColumn.Name = "costIdDataGridViewTextBoxColumn";
            this.costIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.costIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.costIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.costIdDataGridViewTextBoxColumn.ValueMember = "costid";
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId";
            this.branchIdDataGridViewTextBoxColumn.DataSource = this.bRANCHESBindingSource;
            this.branchIdDataGridViewTextBoxColumn.DisplayMember = "BRANCHNAME";
            this.branchIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.branchIdDataGridViewTextBoxColumn, "branchIdDataGridViewTextBoxColumn");
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.branchIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.branchIdDataGridViewTextBoxColumn.ValueMember = "BRANCHCODE";
            // 
            // recoderCodeDataGridViewTextBoxColumn
            // 
            this.recoderCodeDataGridViewTextBoxColumn.DataPropertyName = "RecoderCode";
            resources.ApplyResources(this.recoderCodeDataGridViewTextBoxColumn, "recoderCodeDataGridViewTextBoxColumn");
            this.recoderCodeDataGridViewTextBoxColumn.Name = "recoderCodeDataGridViewTextBoxColumn";
            this.recoderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invAccidDataGridViewTextBoxColumn
            // 
            this.invAccidDataGridViewTextBoxColumn.DataPropertyName = "InvAccid";
            resources.ApplyResources(this.invAccidDataGridViewTextBoxColumn, "invAccidDataGridViewTextBoxColumn");
            this.invAccidDataGridViewTextBoxColumn.Name = "invAccidDataGridViewTextBoxColumn";
            this.invAccidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custSupAccidDataGridViewTextBoxColumn
            // 
            this.custSupAccidDataGridViewTextBoxColumn.DataPropertyName = "Cust_Sup_Accid";
            resources.ApplyResources(this.custSupAccidDataGridViewTextBoxColumn, "custSupAccidDataGridViewTextBoxColumn");
            this.custSupAccidDataGridViewTextBoxColumn.Name = "custSupAccidDataGridViewTextBoxColumn";
            this.custSupAccidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentAccidDataGridViewTextBoxColumn
            // 
            this.paymentAccidDataGridViewTextBoxColumn.DataPropertyName = "PaymentAccid";
            resources.ApplyResources(this.paymentAccidDataGridViewTextBoxColumn, "paymentAccidDataGridViewTextBoxColumn");
            this.paymentAccidDataGridViewTextBoxColumn.Name = "paymentAccidDataGridViewTextBoxColumn";
            this.paymentAccidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            resources.ApplyResources(this.empIdDataGridViewTextBoxColumn, "empIdDataGridViewTextBoxColumn");
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentValueDataGridViewTextBoxColumn
            // 
            this.paymentValueDataGridViewTextBoxColumn.DataPropertyName = "PaymentValue";
            resources.ApplyResources(this.paymentValueDataGridViewTextBoxColumn, "paymentValueDataGridViewTextBoxColumn");
            this.paymentValueDataGridViewTextBoxColumn.Name = "paymentValueDataGridViewTextBoxColumn";
            this.paymentValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invPaymentDataGridViewTextBoxColumn
            // 
            this.invPaymentDataGridViewTextBoxColumn.DataPropertyName = "InvPayment";
            resources.ApplyResources(this.invPaymentDataGridViewTextBoxColumn, "invPaymentDataGridViewTextBoxColumn");
            this.invPaymentDataGridViewTextBoxColumn.Name = "invPaymentDataGridViewTextBoxColumn";
            this.invPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invRemainDataGridViewTextBoxColumn
            // 
            this.invRemainDataGridViewTextBoxColumn.DataPropertyName = "InvRemain";
            resources.ApplyResources(this.invRemainDataGridViewTextBoxColumn, "invRemainDataGridViewTextBoxColumn");
            this.invRemainDataGridViewTextBoxColumn.Name = "invRemainDataGridViewTextBoxColumn";
            this.invRemainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReferID
            // 
            this.ReferID.DataPropertyName = "ReferID";
            resources.ApplyResources(this.ReferID, "ReferID");
            this.ReferID.Name = "ReferID";
            this.ReferID.ReadOnly = true;
            // 
            // paymentCostDataGridViewTextBoxColumn
            // 
            this.paymentCostDataGridViewTextBoxColumn.DataPropertyName = "PaymentCost";
            resources.ApplyResources(this.paymentCostDataGridViewTextBoxColumn, "paymentCostDataGridViewTextBoxColumn");
            this.paymentCostDataGridViewTextBoxColumn.Name = "paymentCostDataGridViewTextBoxColumn";
            this.paymentCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            resources.ApplyResources(this.chequeNoDataGridViewTextBoxColumn, "chequeNoDataGridViewTextBoxColumn");
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeFlagDataGridViewCheckBoxColumn
            // 
            this.chequeFlagDataGridViewCheckBoxColumn.DataPropertyName = "ChequeFlag";
            resources.ApplyResources(this.chequeFlagDataGridViewCheckBoxColumn, "chequeFlagDataGridViewCheckBoxColumn");
            this.chequeFlagDataGridViewCheckBoxColumn.Name = "chequeFlagDataGridViewCheckBoxColumn";
            this.chequeFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // totalAddCostDataGridViewTextBoxColumn
            // 
            this.totalAddCostDataGridViewTextBoxColumn.DataPropertyName = "TotalAddCost";
            resources.ApplyResources(this.totalAddCostDataGridViewTextBoxColumn, "totalAddCostDataGridViewTextBoxColumn");
            this.totalAddCostDataGridViewTextBoxColumn.Name = "totalAddCostDataGridViewTextBoxColumn";
            this.totalAddCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalReoderDataGridViewTextBoxColumn
            // 
            this.totalReoderDataGridViewTextBoxColumn.DataPropertyName = "TotalReoder";
            resources.ApplyResources(this.totalReoderDataGridViewTextBoxColumn, "totalReoderDataGridViewTextBoxColumn");
            this.totalReoderDataGridViewTextBoxColumn.Name = "totalReoderDataGridViewTextBoxColumn";
            this.totalReoderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalReoderNetDataGridViewTextBoxColumn
            // 
            this.totalReoderNetDataGridViewTextBoxColumn.DataPropertyName = "TotalReoderNet";
            resources.ApplyResources(this.totalReoderNetDataGridViewTextBoxColumn, "totalReoderNetDataGridViewTextBoxColumn");
            this.totalReoderNetDataGridViewTextBoxColumn.Name = "totalReoderNetDataGridViewTextBoxColumn";
            this.totalReoderNetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPCUSTIDDataGridViewTextBoxColumn
            // 
            this.sUPCUSTIDDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_ID";
            resources.ApplyResources(this.sUPCUSTIDDataGridViewTextBoxColumn, "sUPCUSTIDDataGridViewTextBoxColumn");
            this.sUPCUSTIDDataGridViewTextBoxColumn.Name = "sUPCUSTIDDataGridViewTextBoxColumn";
            this.sUPCUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectValueDataGridViewTextBoxColumn
            // 
            this.collectValueDataGridViewTextBoxColumn.DataPropertyName = "CollectValue";
            resources.ApplyResources(this.collectValueDataGridViewTextBoxColumn, "collectValueDataGridViewTextBoxColumn");
            this.collectValueDataGridViewTextBoxColumn.Name = "collectValueDataGridViewTextBoxColumn";
            this.collectValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvType
            // 
            this.InvType.DataPropertyName = "InvType";
            resources.ApplyResources(this.InvType, "InvType");
            this.InvType.Name = "InvType";
            this.InvType.ReadOnly = true;
            // 
            // aCCOUNTNameDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNameDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTName";
            resources.ApplyResources(this.aCCOUNTNameDataGridViewTextBoxColumn, "aCCOUNTNameDataGridViewTextBoxColumn");
            this.aCCOUNTNameDataGridViewTextBoxColumn.Name = "aCCOUNTNameDataGridViewTextBoxColumn";
            this.aCCOUNTNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            resources.ApplyResources(this.PaymentType, "PaymentType");
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            // 
            // PayFinish
            // 
            this.PayFinish.DataPropertyName = "PayFinish";
            resources.ApplyResources(this.PayFinish, "PayFinish");
            this.PayFinish.Name = "PayFinish";
            this.PayFinish.ReadOnly = true;
            // 
            // InvoicesList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.labelCustSup);
            this.Controls.Add(this.CmbCustSupAccid);
            this.Controls.Add(this.ChkReoderFlag);
            this.Controls.Add(this.txtPayToDate);
            this.Controls.Add(this.txtPayFromDate);
            this.Controls.Add(this.ddlPayToDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlPayFromDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.CmbBranches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CmbInvTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmboxCenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.enterDateDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCode);
            this.Name = "InvoicesList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter sTORESTableAdapter;
        internal System.Windows.Forms.DataGridView StoresDGView;
        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.BindingSource cDEUNITTYPESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter cDE_UNIT_TYPESTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.BindingSource product_Units_PricesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter product_Units_PricesTableAdapter;
        private System.Windows.Forms.DateTimePicker enterDateDateTimePicker;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox CmbInvTypes;
        private System.Windows.Forms.ComboBox CmbBranches;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource invoiceViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InvoiceViewTableAdapter invoiceViewTableAdapter;
        private System.Windows.Forms.ComboBox CmboxCenter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource costCentersBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter costCentersTableAdapter;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtPayToDate;
        private System.Windows.Forms.TextBox txtPayFromDate;
        private System.Windows.Forms.DateTimePicker ddlPayToDate;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ddlPayFromDate;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChkReoderFlag;
        public System.Windows.Forms.Label labelCustSup;
        private System.Windows.Forms.ComboBox CmbCustSupAccid;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvTypeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTotalNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn costIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSupAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invRemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chequeFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAddCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReoderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReoderNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PayFinish;

    }
}