namespace ERPSYS
{
    partial class LoanAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.sTOP_FLAGCheckBox = new System.Windows.Forms.CheckBox();
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
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.txtTOT_PAID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEmpName = new System.Windows.Forms.TextBox();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.txtLoanBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pRLEMPLOANDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.perEmpLoanDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRL_EMP_LOAN_DETAILTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PRL_EMP_LOAN_DETAILTableAdapter();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.perEmpLoanDetailsReportTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PerEmpLoanDetailsReportTableAdapter();
            this.loanDetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MonthlyIncrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTH_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sTOP_FLAGLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRLEMPLOANDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perEmpLoanDetailsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTOP_FLAGLabel
            // 
            sTOP_FLAGLabel.AutoSize = true;
            sTOP_FLAGLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTOP_FLAGLabel.ForeColor = System.Drawing.Color.Blue;
            sTOP_FLAGLabel.Location = new System.Drawing.Point(554, 111);
            sTOP_FLAGLabel.Name = "sTOP_FLAGLabel";
            sTOP_FLAGLabel.Size = new System.Drawing.Size(71, 14);
            sTOP_FLAGLabel.TabIndex = 90;
            sTOP_FLAGLabel.Text = "«‰ Â«¡ «·”·›";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 566);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 58);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(414, 15);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(94, 36);
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
            this.CmdCancel.Location = new System.Drawing.Point(301, 16);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(94, 36);
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
            this.sTOP_FLAGCheckBox.Location = new System.Drawing.Point(631, 107);
            this.sTOP_FLAGCheckBox.Name = "sTOP_FLAGCheckBox";
            this.sTOP_FLAGCheckBox.Size = new System.Drawing.Size(23, 26);
            this.sTOP_FLAGCheckBox.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 89;
            this.label8.Text = "«”„ «·„ÊŸ›";
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
            this.txtTOTAL_MON_NUM.Location = new System.Drawing.Point(101, 86);
            this.txtTOTAL_MON_NUM.MaxLength = 0;
            this.txtTOTAL_MON_NUM.Name = "txtTOTAL_MON_NUM";
            this.txtTOTAL_MON_NUM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTOTAL_MON_NUM.Size = new System.Drawing.Size(171, 22);
            this.txtTOTAL_MON_NUM.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(17, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(71, 14);
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
            this.dtSTART_DATE.Location = new System.Drawing.Point(101, 57);
            this.dtSTART_DATE.Name = "dtSTART_DATE";
            this.dtSTART_DATE.Size = new System.Drawing.Size(171, 22);
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
            this.txtTotalAmount.Location = new System.Drawing.Point(546, 29);
            this.txtTotalAmount.MaxLength = 0;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(215, 22);
            this.txtTotalAmount.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(459, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 82;
            this.label2.Text = "«·„»·€ «·«Ã„«·Ï";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(406, 32);
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
            this.txtNotes.Location = new System.Drawing.Point(101, 113);
            this.txtNotes.MaxLength = 0;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(438, 45);
            this.txtNotes.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 78;
            this.label3.Text = "„·«ÕŸ« ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(17, 61);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(67, 14);
            this.Label7.TabIndex = 70;
            this.Label7.Text = " «—ÌŒ «·”·›";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StoresDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanDetIDDataGridViewTextBoxColumn,
            this.LoanDate,
            this.Balance,
            this.deducted,
            this.MonthlyIncrease,
            this.YEAR_CODE,
            this.MONTH_CODE,
            this.LoanAmount,
            this.loanIDDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.perEmpLoanDetailsReportBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.Location = new System.Drawing.Point(8, 167);
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.StoresDGView.Size = new System.Drawing.Size(769, 346);
            this.StoresDGView.TabIndex = 92;
            this.StoresDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.StoresDGView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValueChanged);
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
            this.txtTOT_PAID.Location = new System.Drawing.Point(546, 54);
            this.txtTOT_PAID.MaxLength = 0;
            this.txtTOT_PAID.Name = "txtTOT_PAID";
            this.txtTOT_PAID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTOT_PAID.Size = new System.Drawing.Size(215, 22);
            this.txtTOT_PAID.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(459, 55);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(78, 14);
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
            this.label36.Location = new System.Drawing.Point(16, 528);
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
            this.txtTotalToValue.Location = new System.Drawing.Point(155, 524);
            this.txtTotalToValue.MaxLength = 0;
            this.txtTotalToValue.Name = "txtTotalToValue";
            this.txtTotalToValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalToValue.Size = new System.Drawing.Size(245, 25);
            this.txtTotalToValue.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "—ﬁ„ «·ÿ·»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbEmpName
            // 
            this.CmbEmpName.AcceptsReturn = true;
            this.CmbEmpName.BackColor = System.Drawing.SystemColors.Window;
            this.CmbEmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmbEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOTAL_MON_NUM", true));
            this.CmbEmpName.Enabled = false;
            this.CmbEmpName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbEmpName.Location = new System.Drawing.Point(101, 29);
            this.CmbEmpName.MaxLength = 0;
            this.CmbEmpName.Name = "CmbEmpName";
            this.CmbEmpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbEmpName.Size = new System.Drawing.Size(299, 22);
            this.CmbEmpName.TabIndex = 104;
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.AcceptsReturn = true;
            this.txtLoanNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoanNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOTAL_MON_NUM", true));
            this.txtLoanNo.Enabled = false;
            this.txtLoanNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLoanNo.Location = new System.Drawing.Point(101, 3);
            this.txtLoanNo.MaxLength = 0;
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoanNo.Size = new System.Drawing.Size(158, 22);
            this.txtLoanNo.TabIndex = 105;
            // 
            // txtLoanBalance
            // 
            this.txtLoanBalance.AcceptsReturn = true;
            this.txtLoanBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoanBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoanBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRLEMPLOANDETAILBindingSource, "TOT_PAID", true));
            this.txtLoanBalance.Enabled = false;
            this.txtLoanBalance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLoanBalance.Location = new System.Drawing.Point(545, 81);
            this.txtLoanBalance.MaxLength = 0;
            this.txtLoanBalance.Name = "txtLoanBalance";
            this.txtLoanBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoanBalance.Size = new System.Drawing.Size(215, 22);
            this.txtLoanBalance.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(458, 83);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(75, 14);
            this.label9.TabIndex = 106;
            this.label9.Text = "«·—’Ìœ «·Õ«·Ï";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // perEmpLoanDetailsReportBindingSource
            // 
            this.perEmpLoanDetailsReportBindingSource.DataMember = "PerEmpLoanDetailsReport";
            this.perEmpLoanDetailsReportBindingSource.DataSource = this.personalDataSet;
            this.perEmpLoanDetailsReportBindingSource.PositionChanged += new System.EventHandler(this.perEmpLoanDetailsReportBindingSource_PositionChanged);
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // pRL_EMP_LOAN_DETAILTableAdapter
            // 
            this.pRL_EMP_LOAN_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // perEmpLoanDetailsReportTableAdapter
            // 
            this.perEmpLoanDetailsReportTableAdapter.ClearBeforeFill = true;
            // 
            // loanDetIDDataGridViewTextBoxColumn
            // 
            this.loanDetIDDataGridViewTextBoxColumn.DataPropertyName = "LoanDetID";
            this.loanDetIDDataGridViewTextBoxColumn.HeaderText = "„";
            this.loanDetIDDataGridViewTextBoxColumn.Name = "loanDetIDDataGridViewTextBoxColumn";
            this.loanDetIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // LoanDate
            // 
            this.LoanDate.DataPropertyName = "LoanDate";
            dataGridViewCellStyle2.Format = "d";
            this.LoanDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoanDate.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.Width = 120;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "«·—’Ìœ";
            this.Balance.Name = "Balance";
            // 
            // deducted
            // 
            this.deducted.DataPropertyName = "deducted";
            this.deducted.HeaderText = " „ «·Œ’„";
            this.deducted.Name = "deducted";
            this.deducted.ReadOnly = true;
            // 
            // MonthlyIncrease
            // 
            this.MonthlyIncrease.DataPropertyName = "MonthlyIncrease";
            this.MonthlyIncrease.HeaderText = "“Ì«œ… ‘Â—Ì«";
            this.MonthlyIncrease.Name = "MonthlyIncrease";
            // 
            // YEAR_CODE
            // 
            this.YEAR_CODE.DataPropertyName = "YEAR_CODE";
            this.YEAR_CODE.HeaderText = "«·”‰…";
            this.YEAR_CODE.Name = "YEAR_CODE";
            this.YEAR_CODE.Visible = false;
            this.YEAR_CODE.Width = 120;
            // 
            // MONTH_CODE
            // 
            this.MONTH_CODE.DataPropertyName = "MONTH_CODE";
            this.MONTH_CODE.HeaderText = "«·‘Â—";
            this.MONTH_CODE.Name = "MONTH_CODE";
            this.MONTH_CODE.Visible = false;
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
            this.LoanAmount.Width = 120;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(789, 624);
            this.Controls.Add(this.txtLoanBalance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLoanNo);
            this.Controls.Add(this.CmbEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(sTOP_FLAGLabel);
            this.Controls.Add(this.sTOP_FLAGCheckBox);
            this.Controls.Add(this.groupBox4);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoanAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " √” Õﬁ«ﬁ «·”·›";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRLEMPLOANDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perEmpLoanDetailsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
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
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CmbEmpName;
        public System.Windows.Forms.TextBox txtLoanNo;
        public System.Windows.Forms.TextBox txtLoanBalance;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanDetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deducted;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyIncrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTH_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;

    }
}