namespace ERPSYS
{
    partial class LoanAddOld
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
            System.Windows.Forms.Label sTOP_FLAGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAddOld));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.sTOP_FLAGCheckBox = new System.Windows.Forms.CheckBox();
            this.pRLEMPLOANDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.CmbEmpName = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtTOTAL_MON_NUM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSTART_DATE = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pRL_EMP_LOAN_DETAILTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PRL_EMP_LOAN_DETAILTableAdapter();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.perEmpLoanDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perEmpLoanDetailsReportTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PerEmpLoanDetailsReportTableAdapter();
            this.txtTOT_PAID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.loanDetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTH_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sTOP_FLAGLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRLEMPLOANDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perEmpLoanDetailsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTOP_FLAGLabel
            // 
            sTOP_FLAGLabel.AutoSize = true;
            sTOP_FLAGLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTOP_FLAGLabel.ForeColor = System.Drawing.Color.Blue;
            sTOP_FLAGLabel.Location = new System.Drawing.Point(391, 105);
            sTOP_FLAGLabel.Name = "sTOP_FLAGLabel";
            sTOP_FLAGLabel.Size = new System.Drawing.Size(65, 16);
            sTOP_FLAGLabel.TabIndex = 90;
            sTOP_FLAGLabel.Text = "«‰ Â«¡ «·”·›";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 54);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(355, 15);
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
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(227, 15);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(95, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // sTOP_FLAGCheckBox
            // 
            this.sTOP_FLAGCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pRLEMPLOANDETAILBindingSource, "STOP_FLAG", true));
            this.sTOP_FLAGCheckBox.Enabled = false;
            this.sTOP_FLAGCheckBox.Location = new System.Drawing.Point(466, 101);
            this.sTOP_FLAGCheckBox.Name = "sTOP_FLAGCheckBox";
            this.sTOP_FLAGCheckBox.Size = new System.Drawing.Size(20, 24);
            this.sTOP_FLAGCheckBox.TabIndex = 91;
            // 
            // pRLEMPLOANDETAILBindingSource
            // 
            this.pRLEMPLOANDETAILBindingSource.DataMember = "PRL_EMP_LOAN_DETAIL";
            this.pRLEMPLOANDETAILBindingSource.DataSource = this.personalDataSet;
            this.pRLEMPLOANDETAILBindingSource.PositionChanged += new System.EventHandler(this.pRLEMPLOANDETAILBindingSource_PositionChanged);
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbEmpName
            // 
            this.CmbEmpName.AccessibleDescription = "";
            this.CmbEmpName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRLEMPLOANDETAILBindingSource, "EMP_CODE", true));
            this.CmbEmpName.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmpName.DisplayMember = "EMPNAME";
            this.CmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmbEmpName.Enabled = false;
            this.CmbEmpName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpName.FormattingEnabled = true;
            this.CmbEmpName.Location = new System.Drawing.Point(84, 10);
            this.CmbEmpName.Name = "CmbEmpName";
            this.CmbEmpName.Size = new System.Drawing.Size(243, 24);
            this.CmbEmpName.TabIndex = 90;
            this.CmbEmpName.ValueMember = "EMP_CODE";
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "«·„ÊŸ›";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTOTAL_MON_NUM
            // 
            this.txtTOTAL_MON_NUM.AcceptsReturn = true;
            this.txtTOTAL_MON_NUM.BackColor = System.Drawing.SystemColors.Window;
            this.txtTOTAL_MON_NUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTOTAL_MON_NUM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOTAL_MON_NUM", true));
            this.txtTOTAL_MON_NUM.Enabled = false;
            this.txtTOTAL_MON_NUM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL_MON_NUM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTOTAL_MON_NUM.Location = new System.Drawing.Point(84, 69);
            this.txtTOTAL_MON_NUM.MaxLength = 0;
            this.txtTOTAL_MON_NUM.Name = "txtTOTAL_MON_NUM";
            this.txtTOTAL_MON_NUM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTOTAL_MON_NUM.Size = new System.Drawing.Size(147, 22);
            this.txtTOTAL_MON_NUM.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 75);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "⁄œœ «·«ﬁ”«ÿ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtSTART_DATE
            // 
            this.dtSTART_DATE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "START_DATE", true));
            this.dtSTART_DATE.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pRLEMPLOANDETAILBindingSource, "START_DATE", true));
            this.dtSTART_DATE.Enabled = false;
            this.dtSTART_DATE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSTART_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSTART_DATE.Location = new System.Drawing.Point(84, 40);
            this.dtSTART_DATE.Name = "dtSTART_DATE";
            this.dtSTART_DATE.Size = new System.Drawing.Size(147, 22);
            this.dtSTART_DATE.TabIndex = 86;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AcceptsReturn = true;
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOTAL_AMOUNT", true));
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalAmount.Location = new System.Drawing.Point(465, 8);
            this.txtTotalAmount.MaxLength = 0;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(185, 22);
            this.txtTotalAmount.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(391, 11);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "«·„»·€ «·«Ã„«·Ï";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(345, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 14);
            this.label4.TabIndex = 81;
            this.label4.Text = "*";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "NOTE", true));
            this.txtNotes.Enabled = false;
            this.txtNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Location = new System.Drawing.Point(84, 99);
            this.txtNotes.MaxLength = 0;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(300, 73);
            this.txtNotes.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "„·«ÕŸ« ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(9, 40);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(63, 16);
            this.Label7.TabIndex = 70;
            this.Label7.Text = " «—ÌŒ «·”·›";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pRL_EMP_LOAN_DETAILTableAdapter
            // 
            this.pRL_EMP_LOAN_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            this.StoresDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StoresDGView.AutoGenerateColumns = false;
            this.StoresDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanDetIDDataGridViewTextBoxColumn,
            this.LoanDate,
            this.YEAR_CODE,
            this.MONTH_CODE,
            this.LoanAmount,
            this.loanIDDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.perEmpLoanDetailsReportBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.Location = new System.Drawing.Point(9, 186);
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StoresDGView.RowHeadersVisible = false;
            this.StoresDGView.RowHeadersWidth = 45;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StoresDGView.Size = new System.Drawing.Size(660, 282);
            this.StoresDGView.TabIndex = 92;
            this.StoresDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.StoresDGView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValueChanged);
            // 
            // perEmpLoanDetailsReportBindingSource
            // 
            this.perEmpLoanDetailsReportBindingSource.DataMember = "PerEmpLoanDetailsReport";
            this.perEmpLoanDetailsReportBindingSource.DataSource = this.personalDataSet;
            this.perEmpLoanDetailsReportBindingSource.PositionChanged += new System.EventHandler(this.perEmpLoanDetailsReportBindingSource_PositionChanged);
            // 
            // perEmpLoanDetailsReportTableAdapter
            // 
            this.perEmpLoanDetailsReportTableAdapter.ClearBeforeFill = true;
            // 
            // txtTOT_PAID
            // 
            this.txtTOT_PAID.AcceptsReturn = true;
            this.txtTOT_PAID.BackColor = System.Drawing.SystemColors.Window;
            this.txtTOT_PAID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTOT_PAID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOT_PAID", true));
            this.txtTOT_PAID.Enabled = false;
            this.txtTOT_PAID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOT_PAID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTOT_PAID.Location = new System.Drawing.Point(465, 40);
            this.txtTOT_PAID.MaxLength = 0;
            this.txtTOT_PAID.Name = "txtTOT_PAID";
            this.txtTOT_PAID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTOT_PAID.Size = new System.Drawing.Size(167, 22);
            this.txtTOT_PAID.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(391, 40);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "«·„»·€ «·„”œœ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Blue;
            this.label36.Location = new System.Drawing.Point(12, 484);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(112, 16);
            this.label36.TabIndex = 101;
            this.label36.Text = "«·„»·€ «·«Ã„«·Ï «·„” Õﬁ";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalToValue
            // 
            this.txtTotalToValue.AcceptsReturn = true;
            this.txtTotalToValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalToValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalToValue.Enabled = false;
            this.txtTotalToValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalToValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalToValue.Location = new System.Drawing.Point(149, 481);
            this.txtTotalToValue.MaxLength = 0;
            this.txtTotalToValue.Name = "txtTotalToValue";
            this.txtTotalToValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalToValue.Size = new System.Drawing.Size(211, 25);
            this.txtTotalToValue.TabIndex = 102;
            // 
            // loanDetIDDataGridViewTextBoxColumn
            // 
            this.loanDetIDDataGridViewTextBoxColumn.DataPropertyName = "LoanDetID";
            this.loanDetIDDataGridViewTextBoxColumn.HeaderText = "LoanDetID";
            this.loanDetIDDataGridViewTextBoxColumn.Name = "loanDetIDDataGridViewTextBoxColumn";
            this.loanDetIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // LoanDate
            // 
            this.LoanDate.DataPropertyName = "LoanDate";
            dataGridViewCellStyle2.Format = "d";
            this.LoanDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoanDate.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.Width = 150;
            // 
            // YEAR_CODE
            // 
            this.YEAR_CODE.DataPropertyName = "YEAR_CODE";
            this.YEAR_CODE.HeaderText = "«·”‰…";
            this.YEAR_CODE.Name = "YEAR_CODE";
            this.YEAR_CODE.Width = 120;
            // 
            // MONTH_CODE
            // 
            this.MONTH_CODE.DataPropertyName = "MONTH_CODE";
            this.MONTH_CODE.HeaderText = "«·‘Â—";
            this.MONTH_CODE.Name = "MONTH_CODE";
            this.MONTH_CODE.Width = 120;
            // 
            // LoanAmount
            // 
            this.LoanAmount.DataPropertyName = "LoanAmount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.LoanAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoanAmount.HeaderText = "ﬁÌ„… «·ﬁ”ÿ";
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Width = 150;
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // LoanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(676, 566);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(sTOP_FLAGLabel);
            this.Controls.Add(this.sTOP_FLAGCheckBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CmbEmpName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtTOTAL_MON_NUM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtSTART_DATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTOT_PAID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAmount);
            this.Name = "LoanAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " √” Õﬁ«ﬁ «·”·›";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRLEMPLOANDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perEmpLoanDetailsReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSTART_DATE;
        internal System.Windows.Forms.Label label4;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pRLEMPLOANDETAILBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PRL_EMP_LOAN_DETAILTableAdapter pRL_EMP_LOAN_DETAILTableAdapter;
        public System.Windows.Forms.TextBox txtTOTAL_MON_NUM;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox CmbEmpName;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.CheckBox sTOP_FLAGCheckBox;
        internal System.Windows.Forms.DataGridView StoresDGView;
        private System.Windows.Forms.BindingSource perEmpLoanDetailsReportBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PerEmpLoanDetailsReportTableAdapter perEmpLoanDetailsReportTableAdapter;
        public System.Windows.Forms.TextBox txtTOT_PAID;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.TextBox txtTotalToValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanDetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTH_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;

    }
}