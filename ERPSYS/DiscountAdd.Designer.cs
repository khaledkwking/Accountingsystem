namespace ERPSYS
{
    partial class DiscountAdd
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
            System.Windows.Forms.Label dISCOUNT_DATELabel;
            System.Windows.Forms.Label aMOUNTLabel;
            System.Windows.Forms.Label dESLabel;
            System.Windows.Forms.Label yEAR_CODELabel;
            System.Windows.Forms.Label mONTH_CODELabel;
            System.Windows.Forms.Label pEN_CODELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.pEN_CODEComboBox = new System.Windows.Forms.ComboBox();
            this.pER_EMP_DISCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.cDEPERPENALTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTH_CODETextBox = new System.Windows.Forms.TextBox();
            this.yEAR_CODETextBox = new System.Windows.Forms.TextBox();
            this.dESTextBox = new System.Windows.Forms.TextBox();
            this.aMOUNTTextBox = new System.Windows.Forms.TextBox();
            this.dISCOUNT_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CmbEmpName = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.pER_EMP_DISCOUNTTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMP_DISCOUNTTableAdapter();
            this.cDE_PER_PENALTYTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_PER_PENALTYTableAdapter();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.dISCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.yEARCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTHCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dISCOUNT_DATELabel = new System.Windows.Forms.Label();
            aMOUNTLabel = new System.Windows.Forms.Label();
            dESLabel = new System.Windows.Forms.Label();
            yEAR_CODELabel = new System.Windows.Forms.Label();
            mONTH_CODELabel = new System.Windows.Forms.Label();
            pEN_CODELabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pER_EMP_DISCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERPENALTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dISCOUNT_DATELabel
            // 
            dISCOUNT_DATELabel.AutoSize = true;
            dISCOUNT_DATELabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dISCOUNT_DATELabel.ForeColor = System.Drawing.Color.Blue;
            dISCOUNT_DATELabel.Location = new System.Drawing.Point(6, 46);
            dISCOUNT_DATELabel.Name = "dISCOUNT_DATELabel";
            dISCOUNT_DATELabel.Size = new System.Drawing.Size(64, 16);
            dISCOUNT_DATELabel.TabIndex = 90;
            dISCOUNT_DATELabel.Text = " «—ÌŒ «·Œ’„";
            // 
            // aMOUNTLabel
            // 
            aMOUNTLabel.AutoSize = true;
            aMOUNTLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aMOUNTLabel.ForeColor = System.Drawing.Color.Blue;
            aMOUNTLabel.Location = new System.Drawing.Point(6, 83);
            aMOUNTLabel.Name = "aMOUNTLabel";
            aMOUNTLabel.Size = new System.Drawing.Size(32, 16);
            aMOUNTLabel.TabIndex = 91;
            aMOUNTLabel.Text = "«·„»·€";
            // 
            // dESLabel
            // 
            dESLabel.AutoSize = true;
            dESLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESLabel.ForeColor = System.Drawing.Color.Blue;
            dESLabel.Location = new System.Drawing.Point(355, 83);
            dESLabel.Name = "dESLabel";
            dESLabel.Size = new System.Drawing.Size(45, 16);
            dESLabel.TabIndex = 92;
            dESLabel.Text = "„·«ÕŸ« ";
            // 
            // yEAR_CODELabel
            // 
            yEAR_CODELabel.AutoSize = true;
            yEAR_CODELabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yEAR_CODELabel.ForeColor = System.Drawing.Color.Blue;
            yEAR_CODELabel.Location = new System.Drawing.Point(364, 48);
            yEAR_CODELabel.Name = "yEAR_CODELabel";
            yEAR_CODELabel.Size = new System.Drawing.Size(31, 16);
            yEAR_CODELabel.TabIndex = 94;
            yEAR_CODELabel.Text = "«·”‰…";
            // 
            // mONTH_CODELabel
            // 
            mONTH_CODELabel.AutoSize = true;
            mONTH_CODELabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mONTH_CODELabel.ForeColor = System.Drawing.Color.Blue;
            mONTH_CODELabel.Location = new System.Drawing.Point(572, 43);
            mONTH_CODELabel.Name = "mONTH_CODELabel";
            mONTH_CODELabel.Size = new System.Drawing.Size(34, 16);
            mONTH_CODELabel.TabIndex = 95;
            mONTH_CODELabel.Text = "«·‘Â—";
            // 
            // pEN_CODELabel
            // 
            pEN_CODELabel.AutoSize = true;
            pEN_CODELabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pEN_CODELabel.ForeColor = System.Drawing.Color.Blue;
            pEN_CODELabel.Location = new System.Drawing.Point(364, 9);
            pEN_CODELabel.Name = "pEN_CODELabel";
            pEN_CODELabel.Size = new System.Drawing.Size(38, 16);
            pEN_CODELabel.TabIndex = 96;
            pEN_CODELabel.Text = "«·⁄ﬁÊ»…";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 54);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdDel
            // 
            this.CmdDel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDel.Image = ((System.Drawing.Image)(resources.GetObject("CmdDel.Image")));
            this.CmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdDel.Location = new System.Drawing.Point(385, 16);
            this.CmdDel.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdDel.Size = new System.Drawing.Size(95, 33);
            this.CmdDel.TabIndex = 48;
            this.CmdDel.Text = "Õ–›";
            this.CmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(267, 16);
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
            this.CmdCancel.Location = new System.Drawing.Point(139, 16);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(95, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdd.Image")));
            this.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAdd.Location = new System.Drawing.Point(498, 16);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(95, 33);
            this.CmdAdd.TabIndex = 49;
            this.CmdAdd.Text = "√÷«›…";
            this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // pEN_CODEComboBox
            // 
            this.pEN_CODEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pER_EMP_DISCOUNTBindingSource, "PEN_CODE", true));
            this.pEN_CODEComboBox.DataSource = this.cDEPERPENALTYBindingSource;
            this.pEN_CODEComboBox.DisplayMember = "PEN_DESC";
            this.pEN_CODEComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.pEN_CODEComboBox.FormattingEnabled = true;
            this.pEN_CODEComboBox.Location = new System.Drawing.Point(441, 9);
            this.pEN_CODEComboBox.Name = "pEN_CODEComboBox";
            this.pEN_CODEComboBox.Size = new System.Drawing.Size(288, 24);
            this.pEN_CODEComboBox.TabIndex = 97;
            this.pEN_CODEComboBox.ValueMember = "PEN_CODE";
            // 
            // pER_EMP_DISCOUNTBindingSource
            // 
            this.pER_EMP_DISCOUNTBindingSource.DataMember = "PER_EMP_DISCOUNT";
            this.pER_EMP_DISCOUNTBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDEPERPENALTYBindingSource
            // 
            this.cDEPERPENALTYBindingSource.DataMember = "CDE_PER_PENALTY";
            this.cDEPERPENALTYBindingSource.DataSource = this.personalDataSet;
            // 
            // mONTH_CODETextBox
            // 
            this.mONTH_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pER_EMP_DISCOUNTBindingSource, "MONTH_CODE", true));
            this.mONTH_CODETextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.mONTH_CODETextBox.Location = new System.Drawing.Point(629, 39);
            this.mONTH_CODETextBox.Name = "mONTH_CODETextBox";
            this.mONTH_CODETextBox.Size = new System.Drawing.Size(100, 22);
            this.mONTH_CODETextBox.TabIndex = 96;
            // 
            // yEAR_CODETextBox
            // 
            this.yEAR_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pER_EMP_DISCOUNTBindingSource, "YEAR_CODE", true));
            this.yEAR_CODETextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.yEAR_CODETextBox.Location = new System.Drawing.Point(441, 42);
            this.yEAR_CODETextBox.Name = "yEAR_CODETextBox";
            this.yEAR_CODETextBox.Size = new System.Drawing.Size(100, 22);
            this.yEAR_CODETextBox.TabIndex = 95;
            // 
            // dESTextBox
            // 
            this.dESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pER_EMP_DISCOUNTBindingSource, "DES", true));
            this.dESTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.dESTextBox.Location = new System.Drawing.Point(441, 81);
            this.dESTextBox.Multiline = true;
            this.dESTextBox.Name = "dESTextBox";
            this.dESTextBox.Size = new System.Drawing.Size(288, 71);
            this.dESTextBox.TabIndex = 93;
            // 
            // aMOUNTTextBox
            // 
            this.aMOUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pER_EMP_DISCOUNTBindingSource, "AMOUNT", true));
            this.aMOUNTTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.aMOUNTTextBox.Location = new System.Drawing.Point(85, 77);
            this.aMOUNTTextBox.Name = "aMOUNTTextBox";
            this.aMOUNTTextBox.Size = new System.Drawing.Size(100, 22);
            this.aMOUNTTextBox.TabIndex = 92;
            // 
            // dISCOUNT_DATEDateTimePicker
            // 
            this.dISCOUNT_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pER_EMP_DISCOUNTBindingSource, "DISCOUNT_DATE", true));
            this.dISCOUNT_DATEDateTimePicker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.dISCOUNT_DATEDateTimePicker.Location = new System.Drawing.Point(85, 42);
            this.dISCOUNT_DATEDateTimePicker.Name = "dISCOUNT_DATEDateTimePicker";
            this.dISCOUNT_DATEDateTimePicker.Size = new System.Drawing.Size(259, 22);
            this.dISCOUNT_DATEDateTimePicker.TabIndex = 91;
            // 
            // CmbEmpName
            // 
            this.CmbEmpName.AccessibleDescription = "";
            this.CmbEmpName.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmpName.DisplayMember = "EMPNAME";
            this.CmbEmpName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpName.FormattingEnabled = true;
            this.CmbEmpName.Location = new System.Drawing.Point(88, 7);
            this.CmbEmpName.Name = "CmbEmpName";
            this.CmbEmpName.Size = new System.Drawing.Size(259, 24);
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
            this.label8.Location = new System.Drawing.Point(6, 11);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "«·„ÊŸ›";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // pER_EMP_DISCOUNTTableAdapter
            // 
            this.pER_EMP_DISCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_PER_PENALTYTableAdapter
            // 
            this.cDE_PER_PENALTYTableAdapter.ClearBeforeFill = true;
            // 
            // StoresDGView
            // 
            this.StoresDGView.AllowUserToAddRows = false;
            this.StoresDGView.AllowUserToDeleteRows = false;
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
            this.dISCOUNTIDDataGridViewTextBoxColumn,
            this.eMPCODEDataGridViewTextBoxColumn,
            this.dISCOUNTDATEDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.pENCODEDataGridViewTextBoxColumn,
            this.yEARCODEDataGridViewTextBoxColumn,
            this.mONTHCODEDataGridViewTextBoxColumn,
            this.dESDataGridViewTextBoxColumn,
            this.accountidDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.pER_EMP_DISCOUNTBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.Location = new System.Drawing.Point(9, 158);
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StoresDGView.RowHeadersVisible = false;
            this.StoresDGView.RowHeadersWidth = 45;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.Size = new System.Drawing.Size(720, 298);
            this.StoresDGView.TabIndex = 98;
            // 
            // dISCOUNTIDDataGridViewTextBoxColumn
            // 
            this.dISCOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNTID";
            this.dISCOUNTIDDataGridViewTextBoxColumn.HeaderText = "DISCOUNTID";
            this.dISCOUNTIDDataGridViewTextBoxColumn.Name = "dISCOUNTIDDataGridViewTextBoxColumn";
            this.dISCOUNTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dISCOUNTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMPCODEDataGridViewTextBoxColumn
            // 
            this.eMPCODEDataGridViewTextBoxColumn.DataPropertyName = "EMP_CODE";
            this.eMPCODEDataGridViewTextBoxColumn.HeaderText = "EMP_CODE";
            this.eMPCODEDataGridViewTextBoxColumn.Name = "eMPCODEDataGridViewTextBoxColumn";
            this.eMPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dISCOUNTDATEDataGridViewTextBoxColumn
            // 
            this.dISCOUNTDATEDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT_DATE";
            this.dISCOUNTDATEDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «·Œ’„";
            this.dISCOUNTDATEDataGridViewTextBoxColumn.Name = "dISCOUNTDATEDataGridViewTextBoxColumn";
            this.dISCOUNTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dISCOUNTDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "«·„»·€";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aMOUNTDataGridViewTextBoxColumn.Width = 150;
            // 
            // pENCODEDataGridViewTextBoxColumn
            // 
            this.pENCODEDataGridViewTextBoxColumn.DataPropertyName = "PEN_CODE";
            this.pENCODEDataGridViewTextBoxColumn.DataSource = this.cDEPERPENALTYBindingSource;
            this.pENCODEDataGridViewTextBoxColumn.DisplayMember = "PEN_DESC";
            this.pENCODEDataGridViewTextBoxColumn.HeaderText = "«·⁄ﬁÊ»…";
            this.pENCODEDataGridViewTextBoxColumn.Name = "pENCODEDataGridViewTextBoxColumn";
            this.pENCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pENCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pENCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pENCODEDataGridViewTextBoxColumn.ValueMember = "PEN_CODE";
            // 
            // yEARCODEDataGridViewTextBoxColumn
            // 
            this.yEARCODEDataGridViewTextBoxColumn.DataPropertyName = "YEAR_CODE";
            this.yEARCODEDataGridViewTextBoxColumn.HeaderText = "«·”‰Â";
            this.yEARCODEDataGridViewTextBoxColumn.Name = "yEARCODEDataGridViewTextBoxColumn";
            this.yEARCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.yEARCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // mONTHCODEDataGridViewTextBoxColumn
            // 
            this.mONTHCODEDataGridViewTextBoxColumn.DataPropertyName = "MONTH_CODE";
            this.mONTHCODEDataGridViewTextBoxColumn.HeaderText = "«·‘Â—";
            this.mONTHCODEDataGridViewTextBoxColumn.Name = "mONTHCODEDataGridViewTextBoxColumn";
            this.mONTHCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTHCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // dESDataGridViewTextBoxColumn
            // 
            this.dESDataGridViewTextBoxColumn.DataPropertyName = "DES";
            this.dESDataGridViewTextBoxColumn.HeaderText = "DES";
            this.dESDataGridViewTextBoxColumn.Name = "dESDataGridViewTextBoxColumn";
            this.dESDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "accountid";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "accountid";
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            this.accountidDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountidDataGridViewTextBoxColumn.Visible = false;
            // 
            // DiscountAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(733, 516);
            this.Controls.Add(this.StoresDGView);
            this.Controls.Add(this.dESTextBox);
            this.Controls.Add(dESLabel);
            this.Controls.Add(this.mONTH_CODETextBox);
            this.Controls.Add(mONTH_CODELabel);
            this.Controls.Add(this.aMOUNTTextBox);
            this.Controls.Add(aMOUNTLabel);
            this.Controls.Add(this.pEN_CODEComboBox);
            this.Controls.Add(pEN_CODELabel);
            this.Controls.Add(this.yEAR_CODETextBox);
            this.Controls.Add(yEAR_CODELabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbEmpName);
            this.Controls.Add(dISCOUNT_DATELabel);
            this.Controls.Add(this.dISCOUNT_DATEDateTimePicker);
            this.Name = "DiscountAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "«·Œ’Ê„« ";
            this.Activated += new System.EventHandler(this.DiscountAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pER_EMP_DISCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERPENALTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        private PersonalDataSet personalDataSet;
        public System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox CmbEmpName;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.BindingSource pER_EMP_DISCOUNTBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMP_DISCOUNTTableAdapter pER_EMP_DISCOUNTTableAdapter;
        private System.Windows.Forms.TextBox mONTH_CODETextBox;
        private System.Windows.Forms.TextBox yEAR_CODETextBox;
        private System.Windows.Forms.TextBox dESTextBox;
        private System.Windows.Forms.TextBox aMOUNTTextBox;
        private System.Windows.Forms.DateTimePicker dISCOUNT_DATEDateTimePicker;
        private System.Windows.Forms.ComboBox pEN_CODEComboBox;
        private System.Windows.Forms.BindingSource cDEPERPENALTYBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_PER_PENALTYTableAdapter cDE_PER_PENALTYTableAdapter;
        internal System.Windows.Forms.DataGridView StoresDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pENCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTHCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;

    }
}