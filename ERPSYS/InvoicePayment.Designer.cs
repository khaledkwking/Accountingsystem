namespace ERPSYS
{
    partial class InvoicePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.CmbBanks = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BankRdBtn = new System.Windows.Forms.RadioButton();
            this.BoxRdBtn = new System.Windows.Forms.RadioButton();
            this.CmdSave = new System.Windows.Forms.Button();
            this.recoderCodeTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtchequeFlag = new System.Windows.Forms.TextBox();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtInvPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCustSupAccid = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustSupId = new System.Windows.Forms.TextBox();
            this.txtInvType = new System.Windows.Forms.TextBox();
            this.labelCustSup = new System.Windows.Forms.Label();
            this.qidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.invoicesTableAdapter();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPaymented = new System.Windows.Forms.TextBox();
            this.txtRequired = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceDGView = new System.Windows.Forms.DataGridView();
            this.CmbInvPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.invTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurpaymentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRemainValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSupAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTotalNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invRemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chequeFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalAddCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReoderNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReoderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.qidsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter();
            this.qidsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qidsDetailsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.BtnPrint);
            this.groupBox1.Controls.Add(this.CmbEmp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtChequeNo);
            this.groupBox1.Controls.Add(this.CmbBanks);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CmdSave);
            this.groupBox1.Controls.Add(this.recoderCodeTextBox);
            this.groupBox1.Controls.Add(this.txtchequeFlag);
            this.groupBox1.Controls.Add(this.dtPaymentDate);
            this.groupBox1.Controls.Add(this.CmbBranch);
            this.groupBox1.Controls.Add(this.txtInvPayment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbCustSupAccid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCustSupId);
            this.groupBox1.Controls.Add(this.txtInvType);
            this.groupBox1.Controls.Add(this.labelCustSup);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkAll
            // 
            resources.ApplyResources(this.chkAll, "chkAll");
            this.chkAll.Name = "chkAll";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.CausesValidation = false;
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmbEmp
            // 
            resources.ApplyResources(this.CmbEmp, "CmbEmp");
            this.CmbEmp.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmp.DisplayMember = "FName";
            this.CmbEmp.FormattingEnabled = true;
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.ValueMember = "EMP_CODE";
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.Name = "txtNotes";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // txtChequeNo
            // 
            resources.ApplyResources(this.txtChequeNo, "txtChequeNo");
            this.txtChequeNo.Name = "txtChequeNo";
            // 
            // CmbBanks
            // 
            resources.ApplyResources(this.CmbBanks, "CmbBanks");
            this.CmbBanks.DataSource = this.accountingBindingSource;
            this.CmbBanks.DisplayMember = "accountname";
            this.CmbBanks.FormattingEnabled = true;
            this.CmbBanks.Name = "CmbBanks";
            this.CmbBanks.ValueMember = "accountid";
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.BankRdBtn);
            this.groupBox2.Controls.Add(this.BoxRdBtn);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // BankRdBtn
            // 
            resources.ApplyResources(this.BankRdBtn, "BankRdBtn");
            this.BankRdBtn.Name = "BankRdBtn";
            this.BankRdBtn.TabStop = true;
            this.BankRdBtn.UseVisualStyleBackColor = true;
            this.BankRdBtn.CheckedChanged += new System.EventHandler(this.BankRdBtn_CheckedChanged);
            // 
            // BoxRdBtn
            // 
            resources.ApplyResources(this.BoxRdBtn, "BoxRdBtn");
            this.BoxRdBtn.Checked = true;
            this.BoxRdBtn.Name = "BoxRdBtn";
            this.BoxRdBtn.TabStop = true;
            this.BoxRdBtn.UseVisualStyleBackColor = true;
            this.BoxRdBtn.CheckedChanged += new System.EventHandler(this.BoxRdBtn_CheckedChanged);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // recoderCodeTextBox
            // 
            this.recoderCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "RecoderCode", true));
            resources.ApplyResources(this.recoderCodeTextBox, "recoderCodeTextBox");
            this.recoderCodeTextBox.Name = "recoderCodeTextBox";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "invoices";
            this.invoicesBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txtchequeFlag
            // 
            this.txtchequeFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "ChequeFlag", true));
            resources.ApplyResources(this.txtchequeFlag, "txtchequeFlag");
            this.txtchequeFlag.Name = "txtchequeFlag";
            // 
            // dtPaymentDate
            // 
            resources.ApplyResources(this.dtPaymentDate, "dtPaymentDate");
            this.dtPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "PaymentDate", true));
            this.dtPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "PaymentDate", true));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Name = "dtPaymentDate";
            // 
            // CmbBranch
            // 
            resources.ApplyResources(this.CmbBranch, "CmbBranch");
            this.CmbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbBranch.DataSource = this.bRANCHESBindingSource;
            this.CmbBranch.DisplayMember = "BRANCHNAME";
            this.CmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.ValueMember = "BRANCHCODE";
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.CmbBranch_SelectedIndexChanged);
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // txtInvPayment
            // 
            this.txtInvPayment.AcceptsReturn = true;
            resources.ApplyResources(this.txtInvPayment, "txtInvPayment");
            this.txtInvPayment.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvPayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvPayment.Name = "txtInvPayment";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // CmbCustSupAccid
            // 
            resources.ApplyResources(this.CmbCustSupAccid, "CmbCustSupAccid");
            this.CmbCustSupAccid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustSupAccid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            this.CmbCustSupAccid.FormattingEnabled = true;
            this.CmbCustSupAccid.Name = "CmbCustSupAccid";
            this.CmbCustSupAccid.ValueMember = "SUP_CUST_ID";
            this.CmbCustSupAccid.SelectedIndexChanged += new System.EventHandler(this.CmbCustSupAccid_SelectedIndexChanged);
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // txtCustSupId
            // 
            this.txtCustSupId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustSupId.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtCustSupId, "txtCustSupId");
            this.txtCustSupId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustSupId.Name = "txtCustSupId";
            // 
            // txtInvType
            // 
            this.txtInvType.AcceptsReturn = true;
            resources.ApplyResources(this.txtInvType, "txtInvType");
            this.txtInvType.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvType", true));
            this.txtInvType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvType.Name = "txtInvType";
            // 
            // labelCustSup
            // 
            resources.ApplyResources(this.labelCustSup, "labelCustSup");
            this.labelCustSup.BackColor = System.Drawing.Color.Transparent;
            this.labelCustSup.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCustSup.ForeColor = System.Drawing.Color.Blue;
            this.labelCustSup.Name = "labelCustSup";
            // 
            // qidsBindingSource
            // 
            this.qidsBindingSource.DataMember = "qids";
            this.qidsBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.CausesValidation = false;
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.txtPaymented);
            this.groupBox4.Controls.Add(this.txtRequired);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtPaymented
            // 
            this.txtPaymented.AcceptsReturn = true;
            resources.ApplyResources(this.txtPaymented, "txtPaymented");
            this.txtPaymented.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaymented.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymented.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPaymented.Name = "txtPaymented";
            this.txtPaymented.ReadOnly = true;
            // 
            // txtRequired
            // 
            this.txtRequired.AcceptsReturn = true;
            resources.ApplyResources(this.txtRequired, "txtRequired");
            this.txtRequired.BackColor = System.Drawing.SystemColors.Window;
            this.txtRequired.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequired.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRequired.Name = "txtRequired";
            this.txtRequired.ReadOnly = true;
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
            // InvoiceDGView
            // 
            this.InvoiceDGView.AllowUserToAddRows = false;
            this.InvoiceDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.InvoiceDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.InvoiceDGView, "InvoiceDGView");
            this.InvoiceDGView.AutoGenerateColumns = false;
            this.InvoiceDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmbInvPay,
            this.invIdDataGridViewTextBoxColumn,
            this.invCodeDataGridViewTextBoxColumn,
            this.invDateDataGridViewTextBoxColumn,
            this.sUPCUSTIDDataGridViewTextBoxColumn,
            this.invTotalDataGridViewTextBoxColumn,
            this.CurpaymentValue,
            this.CollectValue,
            this.TotalRemainValue,
            this.custSupAccidDataGridViewTextBoxColumn,
            this.invAccidDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.paymentAccidDataGridViewTextBoxColumn,
            this.invTypeDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.invTotalNetDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.invPaymentDataGridViewTextBoxColumn,
            this.invRemainDataGridViewTextBoxColumn,
            this.referIDDataGridViewTextBoxColumn,
            this.paymentCostDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.chequeFlagDataGridViewCheckBoxColumn,
            this.totalAddCostDataGridViewTextBoxColumn,
            this.recoderCodeDataGridViewTextBoxColumn,
            this.totalReoderNetDataGridViewTextBoxColumn,
            this.totalReoderDataGridViewTextBoxColumn,
            this.costIdDataGridViewTextBoxColumn});
            this.InvoiceDGView.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceDGView.DefaultCellStyle = dataGridViewCellStyle10;
            this.InvoiceDGView.EnableHeadersVisualStyles = false;
            this.InvoiceDGView.MultiSelect = false;
            this.InvoiceDGView.Name = "InvoiceDGView";
            this.InvoiceDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.InvoiceDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.InvoiceDGView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.InvoiceDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.InvoiceDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InvoiceDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.InvoiceDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDGView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.InvoiceDGView_CellFormatting);
            this.InvoiceDGView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.InvoiceDGView_DefaultValuesNeeded);
            this.InvoiceDGView.SelectionChanged += new System.EventHandler(this.InvoiceDGView_SelectionChanged);
            // 
            // CmbInvPay
            // 
            this.CmbInvPay.FalseValue = "1";
            resources.ApplyResources(this.CmbInvPay, "CmbInvPay");
            this.CmbInvPay.Name = "CmbInvPay";
            this.CmbInvPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CmbInvPay.TrueValue = "0";
            // 
            // invIdDataGridViewTextBoxColumn
            // 
            this.invIdDataGridViewTextBoxColumn.DataPropertyName = "InvId";
            resources.ApplyResources(this.invIdDataGridViewTextBoxColumn, "invIdDataGridViewTextBoxColumn");
            this.invIdDataGridViewTextBoxColumn.Name = "invIdDataGridViewTextBoxColumn";
            this.invIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invCodeDataGridViewTextBoxColumn
            // 
            this.invCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.invCodeDataGridViewTextBoxColumn.DataPropertyName = "InvCode";
            resources.ApplyResources(this.invCodeDataGridViewTextBoxColumn, "invCodeDataGridViewTextBoxColumn");
            this.invCodeDataGridViewTextBoxColumn.Name = "invCodeDataGridViewTextBoxColumn";
            this.invCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invDateDataGridViewTextBoxColumn
            // 
            this.invDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.invDateDataGridViewTextBoxColumn.DataPropertyName = "InvDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.invDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.invDateDataGridViewTextBoxColumn, "invDateDataGridViewTextBoxColumn");
            this.invDateDataGridViewTextBoxColumn.Name = "invDateDataGridViewTextBoxColumn";
            this.invDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPCUSTIDDataGridViewTextBoxColumn
            // 
            this.sUPCUSTIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sUPCUSTIDDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_ID";
            this.sUPCUSTIDDataGridViewTextBoxColumn.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            this.sUPCUSTIDDataGridViewTextBoxColumn.DisplayMember = "SUP_CUST_FNAME";
            this.sUPCUSTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.sUPCUSTIDDataGridViewTextBoxColumn, "sUPCUSTIDDataGridViewTextBoxColumn");
            this.sUPCUSTIDDataGridViewTextBoxColumn.Name = "sUPCUSTIDDataGridViewTextBoxColumn";
            this.sUPCUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPCUSTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sUPCUSTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sUPCUSTIDDataGridViewTextBoxColumn.ValueMember = "SUP_CUST_ID";
            // 
            // invTotalDataGridViewTextBoxColumn
            // 
            this.invTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.invTotalDataGridViewTextBoxColumn.DataPropertyName = "InvTotalNet";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.invTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.invTotalDataGridViewTextBoxColumn, "invTotalDataGridViewTextBoxColumn");
            this.invTotalDataGridViewTextBoxColumn.Name = "invTotalDataGridViewTextBoxColumn";
            this.invTotalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CurpaymentValue
            // 
            this.CurpaymentValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurpaymentValue.DataPropertyName = "InvPayment";
            dataGridViewCellStyle5.Format = "N3";
            this.CurpaymentValue.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.CurpaymentValue, "CurpaymentValue");
            this.CurpaymentValue.Name = "CurpaymentValue";
            this.CurpaymentValue.ReadOnly = true;
            this.CurpaymentValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CollectValue
            // 
            this.CollectValue.DataPropertyName = "CollectValue";
            resources.ApplyResources(this.CollectValue, "CollectValue");
            this.CollectValue.Name = "CollectValue";
            this.CollectValue.ReadOnly = true;
            // 
            // TotalRemainValue
            // 
            this.TotalRemainValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Format = "N3";
            this.TotalRemainValue.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.TotalRemainValue, "TotalRemainValue");
            this.TotalRemainValue.Name = "TotalRemainValue";
            this.TotalRemainValue.ReadOnly = true;
            // 
            // custSupAccidDataGridViewTextBoxColumn
            // 
            this.custSupAccidDataGridViewTextBoxColumn.DataPropertyName = "Cust_Sup_Accid";
            resources.ApplyResources(this.custSupAccidDataGridViewTextBoxColumn, "custSupAccidDataGridViewTextBoxColumn");
            this.custSupAccidDataGridViewTextBoxColumn.Name = "custSupAccidDataGridViewTextBoxColumn";
            // 
            // invAccidDataGridViewTextBoxColumn
            // 
            this.invAccidDataGridViewTextBoxColumn.DataPropertyName = "InvAccid";
            resources.ApplyResources(this.invAccidDataGridViewTextBoxColumn, "invAccidDataGridViewTextBoxColumn");
            this.invAccidDataGridViewTextBoxColumn.Name = "invAccidDataGridViewTextBoxColumn";
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            resources.ApplyResources(this.paymentTypeDataGridViewTextBoxColumn, "paymentTypeDataGridViewTextBoxColumn");
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            // 
            // paymentAccidDataGridViewTextBoxColumn
            // 
            this.paymentAccidDataGridViewTextBoxColumn.DataPropertyName = "PaymentAccid";
            resources.ApplyResources(this.paymentAccidDataGridViewTextBoxColumn, "paymentAccidDataGridViewTextBoxColumn");
            this.paymentAccidDataGridViewTextBoxColumn.Name = "paymentAccidDataGridViewTextBoxColumn";
            // 
            // invTypeDataGridViewTextBoxColumn
            // 
            this.invTypeDataGridViewTextBoxColumn.DataPropertyName = "InvType";
            resources.ApplyResources(this.invTypeDataGridViewTextBoxColumn, "invTypeDataGridViewTextBoxColumn");
            this.invTypeDataGridViewTextBoxColumn.Name = "invTypeDataGridViewTextBoxColumn";
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            resources.ApplyResources(this.empIdDataGridViewTextBoxColumn, "empIdDataGridViewTextBoxColumn");
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.paymentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.paymentDateDataGridViewTextBoxColumn, "paymentDateDataGridViewTextBoxColumn");
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            dataGridViewCellStyle8.Format = "N3";
            this.discountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.discountDataGridViewTextBoxColumn, "discountDataGridViewTextBoxColumn");
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invTotalNetDataGridViewTextBoxColumn
            // 
            this.invTotalNetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.invTotalNetDataGridViewTextBoxColumn.DataPropertyName = "InvTotalNet";
            dataGridViewCellStyle9.Format = "N3";
            this.invTotalNetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.invTotalNetDataGridViewTextBoxColumn, "invTotalNetDataGridViewTextBoxColumn");
            this.invTotalNetDataGridViewTextBoxColumn.Name = "invTotalNetDataGridViewTextBoxColumn";
            this.invTotalNetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // invPaymentDataGridViewTextBoxColumn
            // 
            this.invPaymentDataGridViewTextBoxColumn.DataPropertyName = "InvPayment";
            resources.ApplyResources(this.invPaymentDataGridViewTextBoxColumn, "invPaymentDataGridViewTextBoxColumn");
            this.invPaymentDataGridViewTextBoxColumn.Name = "invPaymentDataGridViewTextBoxColumn";
            // 
            // invRemainDataGridViewTextBoxColumn
            // 
            this.invRemainDataGridViewTextBoxColumn.DataPropertyName = "InvRemain";
            resources.ApplyResources(this.invRemainDataGridViewTextBoxColumn, "invRemainDataGridViewTextBoxColumn");
            this.invRemainDataGridViewTextBoxColumn.Name = "invRemainDataGridViewTextBoxColumn";
            // 
            // referIDDataGridViewTextBoxColumn
            // 
            this.referIDDataGridViewTextBoxColumn.DataPropertyName = "ReferID";
            resources.ApplyResources(this.referIDDataGridViewTextBoxColumn, "referIDDataGridViewTextBoxColumn");
            this.referIDDataGridViewTextBoxColumn.Name = "referIDDataGridViewTextBoxColumn";
            // 
            // paymentCostDataGridViewTextBoxColumn
            // 
            this.paymentCostDataGridViewTextBoxColumn.DataPropertyName = "PaymentCost";
            resources.ApplyResources(this.paymentCostDataGridViewTextBoxColumn, "paymentCostDataGridViewTextBoxColumn");
            this.paymentCostDataGridViewTextBoxColumn.Name = "paymentCostDataGridViewTextBoxColumn";
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            resources.ApplyResources(this.chequeNoDataGridViewTextBoxColumn, "chequeNoDataGridViewTextBoxColumn");
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // chequeFlagDataGridViewCheckBoxColumn
            // 
            this.chequeFlagDataGridViewCheckBoxColumn.DataPropertyName = "ChequeFlag";
            resources.ApplyResources(this.chequeFlagDataGridViewCheckBoxColumn, "chequeFlagDataGridViewCheckBoxColumn");
            this.chequeFlagDataGridViewCheckBoxColumn.Name = "chequeFlagDataGridViewCheckBoxColumn";
            // 
            // totalAddCostDataGridViewTextBoxColumn
            // 
            this.totalAddCostDataGridViewTextBoxColumn.DataPropertyName = "TotalAddCost";
            resources.ApplyResources(this.totalAddCostDataGridViewTextBoxColumn, "totalAddCostDataGridViewTextBoxColumn");
            this.totalAddCostDataGridViewTextBoxColumn.Name = "totalAddCostDataGridViewTextBoxColumn";
            // 
            // recoderCodeDataGridViewTextBoxColumn
            // 
            this.recoderCodeDataGridViewTextBoxColumn.DataPropertyName = "RecoderCode";
            resources.ApplyResources(this.recoderCodeDataGridViewTextBoxColumn, "recoderCodeDataGridViewTextBoxColumn");
            this.recoderCodeDataGridViewTextBoxColumn.Name = "recoderCodeDataGridViewTextBoxColumn";
            // 
            // totalReoderNetDataGridViewTextBoxColumn
            // 
            this.totalReoderNetDataGridViewTextBoxColumn.DataPropertyName = "TotalReoderNet";
            resources.ApplyResources(this.totalReoderNetDataGridViewTextBoxColumn, "totalReoderNetDataGridViewTextBoxColumn");
            this.totalReoderNetDataGridViewTextBoxColumn.Name = "totalReoderNetDataGridViewTextBoxColumn";
            // 
            // totalReoderDataGridViewTextBoxColumn
            // 
            this.totalReoderDataGridViewTextBoxColumn.DataPropertyName = "TotalReoder";
            resources.ApplyResources(this.totalReoderDataGridViewTextBoxColumn, "totalReoderDataGridViewTextBoxColumn");
            this.totalReoderDataGridViewTextBoxColumn.Name = "totalReoderDataGridViewTextBoxColumn";
            // 
            // costIdDataGridViewTextBoxColumn
            // 
            this.costIdDataGridViewTextBoxColumn.DataPropertyName = "CostId";
            resources.ApplyResources(this.costIdDataGridViewTextBoxColumn, "costIdDataGridViewTextBoxColumn");
            this.costIdDataGridViewTextBoxColumn.Name = "costIdDataGridViewTextBoxColumn";
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // qidsTableAdapter
            // 
            this.qidsTableAdapter.ClearBeforeFill = true;
            // 
            // qidsDetailsBindingSource
            // 
            this.qidsDetailsBindingSource.DataMember = "qidsDetails";
            this.qidsDetailsBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // qidsDetailsTableAdapter
            // 
            this.qidsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicePayment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.InvoiceDGView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "InvoicePayment";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.InvoicePayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        public System.Windows.Forms.Label labelCustSup;
        public System.Windows.Forms.TextBox txtInvType;
        public System.Windows.Forms.TextBox txtCustSupId;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtInvPayment;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.invoicesTableAdapter invoicesTableAdapter;
        internal System.Windows.Forms.ComboBox CmbCustSupAccid;
        internal System.Windows.Forms.ComboBox CmbBranch;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.TextBox txtchequeFlag;
        private System.Windows.Forms.TextBox recoderCodeTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.DataGridView InvoiceDGView;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource qidsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter qidsTableAdapter;
        private System.Windows.Forms.BindingSource qidsDetailsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter qidsDetailsTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPaymented;
        public System.Windows.Forms.TextBox txtRequired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.ComboBox CmbBanks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BankRdBtn;
        private System.Windows.Forms.RadioButton BoxRdBtn;
        private System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbEmp;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostAddDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CmbInvPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sUPCUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurpaymentValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRemainValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSupAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTotalNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invRemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chequeFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAddCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReoderNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReoderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costIdDataGridViewTextBoxColumn;

    }
}