namespace ERPSYS
{
    partial class InstallmentRequiredAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallmentRequiredAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.installmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCollectorAccid = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installmentDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installment_DistributionTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter();
            this.installmentTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.CmbCustAccId = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDate = new System.Windows.Forms.TextBox();
            this.accountingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.RequiredFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PayFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DistDGView = new System.Windows.Forms.DataGridView();
            this.requiredFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distubIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.collectorAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.payFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.qidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qidsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter();
            this.qidsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qidsDetailsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 466);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(814, 54);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(416, 15);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(95, 33);
            this.CmdSave.TabIndex = 50;
            this.CmdSave.Text = "Õ›Ÿ";
            this.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(288, 15);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(95, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "«·Õ”«»";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(8, 53);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Õ / «·„Õ’·";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // installmentBindingSource
            // 
            this.installmentBindingSource.DataMember = "Installment";
            this.installmentBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(662, 48);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(21, 22);
            this.dtPaymentDate.TabIndex = 103;
            this.dtPaymentDate.ValueChanged += new System.EventHandler(this.dtPaymentDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(434, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "«· «—ÌŒ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbCollectorAccid
            // 
            this.CmbCollectorAccid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCollectorAccid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCollectorAccid.DataSource = this.accountingBindingSource;
            this.CmbCollectorAccid.DisplayMember = "accountname";
            this.CmbCollectorAccid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbCollectorAccid.Location = new System.Drawing.Point(92, 48);
            this.CmbCollectorAccid.Name = "CmbCollectorAccid";
            this.CmbCollectorAccid.Size = new System.Drawing.Size(262, 24);
            this.CmbCollectorAccid.TabIndex = 109;
            this.CmbCollectorAccid.ValueMember = "accountid";
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // installmentDistributionBindingSource
            // 
            this.installmentDistributionBindingSource.DataMember = "Installment_Distribution";
            this.installmentDistributionBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // installment_DistributionTableAdapter
            // 
            this.installment_DistributionTableAdapter.ClearBeforeFill = true;
            // 
            // installmentTableAdapter
            // 
            this.installmentTableAdapter.ClearBeforeFill = true;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // CmbCustAccId
            // 
            this.CmbCustAccId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustAccId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCustAccId.DataSource = this.accountingBindingSource1;
            this.CmbCustAccId.DisplayMember = "accountname";
            this.CmbCustAccId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbCustAccId.Location = new System.Drawing.Point(92, 12);
            this.CmbCustAccId.Name = "CmbCustAccId";
            this.CmbCustAccId.Size = new System.Drawing.Size(262, 24);
            this.CmbCustAccId.TabIndex = 110;
            this.CmbCustAccId.ValueMember = "accountid";
            // 
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(482, 48);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 22);
            this.txtDate.TabIndex = 131;
            // 
            // accountingBindingSource2
            // 
            this.accountingBindingSource2.DataMember = "accounting";
            this.accountingBindingSource2.DataSource = this.nEWERPDataSet;
            // 
            // accountingBindingSource3
            // 
            this.accountingBindingSource3.DataMember = "accounting";
            this.accountingBindingSource3.DataSource = this.nEWERPDataSet;
            // 
            // RequiredFlag
            // 
            this.RequiredFlag.DataPropertyName = "RequiredFlag";
            this.RequiredFlag.HeaderText = " „ «·«” Õﬁ«ﬁ";
            this.RequiredFlag.Name = "RequiredFlag";
            // 
            // PayFlag
            // 
            this.PayFlag.DataPropertyName = "PayFlag";
            this.PayFlag.HeaderText = " „ «· ”œÌœ";
            this.PayFlag.Name = "PayFlag";
            // 
            // DistDGView
            // 
            this.DistDGView.AllowUserToAddRows = false;
            this.DistDGView.AllowUserToDeleteRows = false;
            this.DistDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DistDGView.AutoGenerateColumns = false;
            this.DistDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DistDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DistDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requiredFlagDataGridViewCheckBoxColumn,
            this.distubIdDataGridViewTextBoxColumn1,
            this.installIdDataGridViewTextBoxColumn1,
            this.distValueDataGridViewTextBoxColumn1,
            this.distDateDataGridViewTextBoxColumn1,
            this.custAccidDataGridViewTextBoxColumn,
            this.collectorAccidDataGridViewTextBoxColumn,
            this.payFlagDataGridViewCheckBoxColumn});
            this.DistDGView.DataSource = this.installmentDistributionBindingSource;
            this.DistDGView.EnableHeadersVisualStyles = false;
            this.DistDGView.Location = new System.Drawing.Point(9, 100);
            this.DistDGView.MultiSelect = false;
            this.DistDGView.Name = "DistDGView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DistDGView.RowHeadersVisible = false;
            this.DistDGView.RowHeadersWidth = 45;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DistDGView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DistDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DistDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.DistDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DistDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DistDGView.Size = new System.Drawing.Size(793, 346);
            this.DistDGView.TabIndex = 132;
            // 
            // requiredFlagDataGridViewCheckBoxColumn
            // 
            this.requiredFlagDataGridViewCheckBoxColumn.DataPropertyName = "RequiredFlag";
            this.requiredFlagDataGridViewCheckBoxColumn.HeaderText = "«” Õﬁ«ﬁ";
            this.requiredFlagDataGridViewCheckBoxColumn.Name = "requiredFlagDataGridViewCheckBoxColumn";
            // 
            // distubIdDataGridViewTextBoxColumn1
            // 
            this.distubIdDataGridViewTextBoxColumn1.DataPropertyName = "DistubId";
            this.distubIdDataGridViewTextBoxColumn1.HeaderText = "DistubId";
            this.distubIdDataGridViewTextBoxColumn1.Name = "distubIdDataGridViewTextBoxColumn1";
            this.distubIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.distubIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // installIdDataGridViewTextBoxColumn1
            // 
            this.installIdDataGridViewTextBoxColumn1.DataPropertyName = "InstallId";
            this.installIdDataGridViewTextBoxColumn1.HeaderText = "InstallId";
            this.installIdDataGridViewTextBoxColumn1.Name = "installIdDataGridViewTextBoxColumn1";
            this.installIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // distValueDataGridViewTextBoxColumn1
            // 
            this.distValueDataGridViewTextBoxColumn1.DataPropertyName = "DistValue";
            this.distValueDataGridViewTextBoxColumn1.HeaderText = "ﬁÌ„… «·ﬁ”ÿ";
            this.distValueDataGridViewTextBoxColumn1.Name = "distValueDataGridViewTextBoxColumn1";
            this.distValueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.distValueDataGridViewTextBoxColumn1.Width = 150;
            // 
            // distDateDataGridViewTextBoxColumn1
            // 
            this.distDateDataGridViewTextBoxColumn1.DataPropertyName = "DistDate";
            dataGridViewCellStyle7.Format = "d";
            this.distDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.distDateDataGridViewTextBoxColumn1.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.distDateDataGridViewTextBoxColumn1.Name = "distDateDataGridViewTextBoxColumn1";
            this.distDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.distDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // custAccidDataGridViewTextBoxColumn
            // 
            this.custAccidDataGridViewTextBoxColumn.DataPropertyName = "CustAccid";
            this.custAccidDataGridViewTextBoxColumn.DataSource = this.accountingBindingSource2;
            this.custAccidDataGridViewTextBoxColumn.DisplayMember = "accountname";
            this.custAccidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.custAccidDataGridViewTextBoxColumn.HeaderText = "√”„ «·Õ”«»";
            this.custAccidDataGridViewTextBoxColumn.Name = "custAccidDataGridViewTextBoxColumn";
            this.custAccidDataGridViewTextBoxColumn.ReadOnly = true;
            this.custAccidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.custAccidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.custAccidDataGridViewTextBoxColumn.ValueMember = "accountid";
            this.custAccidDataGridViewTextBoxColumn.Width = 150;
            // 
            // collectorAccidDataGridViewTextBoxColumn
            // 
            this.collectorAccidDataGridViewTextBoxColumn.DataPropertyName = "CollectorAccid";
            this.collectorAccidDataGridViewTextBoxColumn.DataSource = this.accountingBindingSource3;
            this.collectorAccidDataGridViewTextBoxColumn.DisplayMember = "accountname";
            this.collectorAccidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.collectorAccidDataGridViewTextBoxColumn.HeaderText = "√”„ «·„Õ’·";
            this.collectorAccidDataGridViewTextBoxColumn.Name = "collectorAccidDataGridViewTextBoxColumn";
            this.collectorAccidDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectorAccidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.collectorAccidDataGridViewTextBoxColumn.ValueMember = "accountid";
            this.collectorAccidDataGridViewTextBoxColumn.Width = 150;
            // 
            // payFlagDataGridViewCheckBoxColumn
            // 
            this.payFlagDataGridViewCheckBoxColumn.DataPropertyName = "PayFlag";
            this.payFlagDataGridViewCheckBoxColumn.HeaderText = " ”œÌœ";
            this.payFlagDataGridViewCheckBoxColumn.Name = "payFlagDataGridViewCheckBoxColumn";
            this.payFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.payFlagDataGridViewCheckBoxColumn.Width = 150;
            // 
            // distubIdDataGridViewTextBoxColumn
            // 
            this.distubIdDataGridViewTextBoxColumn.DataPropertyName = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.HeaderText = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.Name = "distubIdDataGridViewTextBoxColumn";
            this.distubIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // installIdDataGridViewTextBoxColumn
            // 
            this.installIdDataGridViewTextBoxColumn.DataPropertyName = "InstallId";
            this.installIdDataGridViewTextBoxColumn.HeaderText = "InstallId";
            this.installIdDataGridViewTextBoxColumn.Name = "installIdDataGridViewTextBoxColumn";
            this.installIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // distDateDataGridViewTextBoxColumn
            // 
            this.distDateDataGridViewTextBoxColumn.DataPropertyName = "DistDate";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.distDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.distDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.distDateDataGridViewTextBoxColumn.Name = "distDateDataGridViewTextBoxColumn";
            this.distDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // distValueDataGridViewTextBoxColumn
            // 
            this.distValueDataGridViewTextBoxColumn.DataPropertyName = "DistValue";
            this.distValueDataGridViewTextBoxColumn.HeaderText = "ﬁÌ„… «·ﬁ”ÿ";
            this.distValueDataGridViewTextBoxColumn.Name = "distValueDataGridViewTextBoxColumn";
            this.distValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(700, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBtn.Size = new System.Drawing.Size(86, 33);
            this.SearchBtn.TabIndex = 133;
            this.SearchBtn.Text = " ÿ»Ìﬁ";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // qidsBindingSource
            // 
            this.qidsBindingSource.DataMember = "qids";
            this.qidsBindingSource.DataSource = this.nEWERPDataSet;
            this.qidsBindingSource.PositionChanged += new System.EventHandler(this.qidsBindingSource_PositionChanged);
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
            // InstallmentRequiredAdd
            // 
            this.AcceptButton = this.CmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(814, 520);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DistDGView);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.CmbCustAccId);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCollectorAccid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallmentRequiredAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "√” Õﬁ«ﬁ «·«ﬁ”«ÿ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCollectorAccid;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource installmentDistributionBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter installment_DistributionTableAdapter;
        private System.Windows.Forms.BindingSource installmentBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter installmentTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.ComboBox CmbCustAccId;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.BindingSource accountingBindingSource2;
        private System.Windows.Forms.BindingSource accountingBindingSource3;
     
    
    
      
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiredFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PayFlag;
        internal System.Windows.Forms.DataGridView DistDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn distubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distValueDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiredFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distubIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn installIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn custAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn collectorAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource qidsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter qidsTableAdapter;
        private System.Windows.Forms.BindingSource qidsDetailsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter qidsDetailsTableAdapter;

    }
}