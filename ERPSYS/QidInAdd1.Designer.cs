namespace ERPSYS
{
    partial class QidInAdd1
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
            System.Windows.Forms.Label brachIdLabel;
            System.Windows.Forms.Label empIdLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QidInAdd1));
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.fromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qididDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.qididTextBox = new System.Windows.Forms.TextBox();
            this.qidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qidcodeTextBox = new System.Windows.Forms.TextBox();
            this.qidDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recitetypeTextBox = new System.Windows.Forms.TextBox();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.qidsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter();
            this.qidsDetailsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.txtTotalToValue = new System.Windows.Forms.TextBox();
            this.CmdActiveSave = new System.Windows.Forms.Button();
            this.CmdPerview = new System.Windows.Forms.Button();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BankRdBtn = new System.Windows.Forms.RadioButton();
            this.BoxRdBtn = new System.Windows.Forms.RadioButton();
            this.txtrecitetype = new System.Windows.Forms.TextBox();
            qidDateLabel = new System.Windows.Forms.Label();
            brachIdLabel = new System.Windows.Forms.Label();
            empIdLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qidDateLabel
            // 
            qidDateLabel.AutoSize = true;
            qidDateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qidDateLabel.ForeColor = System.Drawing.Color.Blue;
            qidDateLabel.Location = new System.Drawing.Point(20, 14);
            qidDateLabel.Name = "qidDateLabel";
            qidDateLabel.Size = new System.Drawing.Size(42, 18);
            qidDateLabel.TabIndex = 86;
            qidDateLabel.Text = "«· «—ÌŒ";
            // 
            // brachIdLabel
            // 
            brachIdLabel.AutoSize = true;
            brachIdLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brachIdLabel.ForeColor = System.Drawing.Color.Blue;
            brachIdLabel.Location = new System.Drawing.Point(337, 12);
            brachIdLabel.Name = "brachIdLabel";
            brachIdLabel.Size = new System.Drawing.Size(35, 18);
            brachIdLabel.TabIndex = 91;
            brachIdLabel.Text = "«·›—⁄";
            // 
            // empIdLabel
            // 
            empIdLabel.AutoSize = true;
            empIdLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empIdLabel.ForeColor = System.Drawing.Color.Blue;
            empIdLabel.Location = new System.Drawing.Point(607, 13);
            empIdLabel.Name = "empIdLabel";
            empIdLabel.Size = new System.Drawing.Size(68, 18);
            empIdLabel.TabIndex = 92;
            empIdLabel.Text = "—ﬁ„ «·„ÊŸ›";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.Color.Blue;
            notesLabel.Location = new System.Drawing.Point(20, 43);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(44, 18);
            notesLabel.TabIndex = 93;
            notesLabel.Text = "„·«ÕŸ…";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StockDGView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDGView.AutoGenerateColumns = false;
            this.StockDGView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.fromValueDataGridViewTextBoxColumn,
            this.AccountName,
            this.descriptionDataGridViewTextBoxColumn,
            this.EnterDate,
            this.toValueDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.qididDataGridViewTextBoxColumn,
            this.aCCOUNTIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.StockDGView.DataSource = this.qidsDetailsBindingSource;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockDGView.Location = new System.Drawing.Point(23, 120);
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StockDGView.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StockDGView.Size = new System.Drawing.Size(829, 335);
            this.StockDGView.TabIndex = 16;
            this.StockDGView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGView_CellValueChanged);
            // 
            // fromValueDataGridViewTextBoxColumn
            // 
            this.fromValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fromValueDataGridViewTextBoxColumn.DataPropertyName = "FromValue";
            this.fromValueDataGridViewTextBoxColumn.HeaderText = "«·„ﬁ»Ê÷";
            this.fromValueDataGridViewTextBoxColumn.Name = "fromValueDataGridViewTextBoxColumn";
            this.fromValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // AccountName
            // 
            this.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AccountName.DataPropertyName = "ACCOUNTID";
            this.AccountName.DataSource = this.accountingBindingSource;
            this.AccountName.DisplayMember = "accountname";
            this.AccountName.HeaderText = "√”„ «·Õ”«»";
            this.AccountName.Name = "AccountName";
            this.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccountName.ValueMember = "accountid";
            this.AccountName.Width = 250;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "«·»Ì«‰";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // EnterDate
            // 
            this.EnterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnterDate.DataPropertyName = "EnterDate";
            this.EnterDate.HeaderText = "«· «—ÌŒ";
            this.EnterDate.Name = "EnterDate";
            this.EnterDate.Width = 150;
            // 
            // toValueDataGridViewTextBoxColumn
            // 
            this.toValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toValueDataGridViewTextBoxColumn.DataPropertyName = "ToValue";
            this.toValueDataGridViewTextBoxColumn.HeaderText = "„œÌ‰";
            this.toValueDataGridViewTextBoxColumn.Name = "toValueDataGridViewTextBoxColumn";
            this.toValueDataGridViewTextBoxColumn.Visible = false;
            this.toValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qididDataGridViewTextBoxColumn
            // 
            this.qididDataGridViewTextBoxColumn.DataPropertyName = "qidid";
            this.qididDataGridViewTextBoxColumn.HeaderText = "qidid";
            this.qididDataGridViewTextBoxColumn.Name = "qididDataGridViewTextBoxColumn";
            this.qididDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTIDDataGridViewTextBoxColumn
            // 
            this.aCCOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.Name = "aCCOUNTIDDataGridViewTextBoxColumn";
            this.aCCOUNTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // qidsDetailsBindingSource
            // 
            this.qidsDetailsBindingSource.DataMember = "qidsDetails";
            this.qidsDetailsBindingSource.DataSource = this.nEWERPDataSet;
            this.qidsDetailsBindingSource.PositionChanged += new System.EventHandler(this.qidsDetailsBindingSource_PositionChanged);
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(368, 505);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(78, 33);
            this.CmdSave.TabIndex = 84;
            this.CmdSave.Text = "Õ›Ÿ";
            this.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click_1);
            // 
            // CmdClose
            // 
            this.CmdClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.Image = ((System.Drawing.Image)(resources.GetObject("CmdClose.Image")));
            this.CmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdClose.Location = new System.Drawing.Point(586, 505);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdClose.Size = new System.Drawing.Size(78, 33);
            this.CmdClose.TabIndex = 83;
            this.CmdClose.Text = "Œ—ÊÃ";
            this.CmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // qididTextBox
            // 
            this.qididTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "qidid", true));
            this.qididTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qididTextBox.Location = new System.Drawing.Point(794, 38);
            this.qididTextBox.Name = "qididTextBox";
            this.qididTextBox.Size = new System.Drawing.Size(55, 22);
            this.qididTextBox.TabIndex = 85;
            // 
            // qidsBindingSource
            // 
            this.qidsBindingSource.DataMember = "qids";
            this.qidsBindingSource.DataSource = this.nEWERPDataSet;
            this.qidsBindingSource.PositionChanged += new System.EventHandler(this.qidsBindingSource_PositionChanged);
            // 
            // qidcodeTextBox
            // 
            this.qidcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "qidcode", true));
            this.qidcodeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qidcodeTextBox.Location = new System.Drawing.Point(794, 66);
            this.qidcodeTextBox.Name = "qidcodeTextBox";
            this.qidcodeTextBox.Size = new System.Drawing.Size(55, 22);
            this.qidcodeTextBox.TabIndex = 86;
            // 
            // qidDateDateTimePicker
            // 
            this.qidDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.qidsBindingSource, "qidDate", true));
            this.qidDateDateTimePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qidDateDateTimePicker.Location = new System.Drawing.Point(74, 14);
            this.qidDateDateTimePicker.Name = "qidDateDateTimePicker";
            this.qidDateDateTimePicker.Size = new System.Drawing.Size(187, 21);
            this.qidDateDateTimePicker.TabIndex = 87;
            // 
            // recitetypeTextBox
            // 
            this.recitetypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "recitetype", true));
            this.recitetypeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recitetypeTextBox.Location = new System.Drawing.Point(794, 6);
            this.recitetypeTextBox.Name = "recitetypeTextBox";
            this.recitetypeTextBox.Size = new System.Drawing.Size(55, 22);
            this.recitetypeTextBox.TabIndex = 90;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "EmpId", true));
            this.empIdTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdTextBox.Location = new System.Drawing.Point(675, 13);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.empIdTextBox.TabIndex = 93;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(74, 41);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(308, 36);
            this.notesTextBox.TabIndex = 94;
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // CmbBranch
            // 
            this.CmbBranch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qidsBindingSource, "BrachId", true));
            this.CmbBranch.DataSource = this.bRANCHESBindingSource;
            this.CmbBranch.DisplayMember = "BRANCHNAME";
            this.CmbBranch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(397, 12);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(186, 23);
            this.CmbBranch.TabIndex = 95;
            this.CmbBranch.ValueMember = "BRANCHCODE";
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
            // txtTotalToValue
            // 
            this.txtTotalToValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalToValue.Location = new System.Drawing.Point(64, 469);
            this.txtTotalToValue.Name = "txtTotalToValue";
            this.txtTotalToValue.Size = new System.Drawing.Size(133, 25);
            this.txtTotalToValue.TabIndex = 97;
            this.txtTotalToValue.Text = "0";
            // 
            // CmdActiveSave
            // 
            this.CmdActiveSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdActiveSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdActiveSave.Image")));
            this.CmdActiveSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdActiveSave.Location = new System.Drawing.Point(477, 505);
            this.CmdActiveSave.Name = "CmdActiveSave";
            this.CmdActiveSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdActiveSave.Size = new System.Drawing.Size(78, 33);
            this.CmdActiveSave.TabIndex = 102;
            this.CmdActiveSave.Text = " —ÕÌ·";
            this.CmdActiveSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdActiveSave.UseVisualStyleBackColor = true;
            // 
            // CmdPerview
            // 
            this.CmdPerview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPerview.Image = ((System.Drawing.Image)(resources.GetObject("CmdPerview.Image")));
            this.CmdPerview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdPerview.Location = new System.Drawing.Point(259, 505);
            this.CmdPerview.Name = "CmdPerview";
            this.CmdPerview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdPerview.Size = new System.Drawing.Size(78, 33);
            this.CmdPerview.TabIndex = 103;
            this.CmdPerview.Text = "⁄—÷";
            this.CmdPerview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdPerview.UseVisualStyleBackColor = true;
            // 
            // txtActive
            // 
            this.txtActive.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qidsBindingSource, "Active", true));
            this.txtActive.Location = new System.Drawing.Point(822, 94);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(27, 20);
            this.txtActive.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BankRdBtn);
            this.groupBox1.Controls.Add(this.BoxRdBtn);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 50);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÿ—Ìﬁ… «·œ›⁄";
            // 
            // BankRdBtn
            // 
            this.BankRdBtn.AutoSize = true;
            this.BankRdBtn.Location = new System.Drawing.Point(13, 21);
            this.BankRdBtn.Name = "BankRdBtn";
            this.BankRdBtn.Size = new System.Drawing.Size(54, 18);
            this.BankRdBtn.TabIndex = 0;
            this.BankRdBtn.TabStop = true;
            this.BankRdBtn.Text = "‘Ìﬂ";
            this.BankRdBtn.UseVisualStyleBackColor = true;
            // 
            // BoxRdBtn
            // 
            this.BoxRdBtn.AutoSize = true;
            this.BoxRdBtn.Location = new System.Drawing.Point(104, 21);
            this.BoxRdBtn.Name = "BoxRdBtn";
            this.BoxRdBtn.Size = new System.Drawing.Size(47, 18);
            this.BoxRdBtn.TabIndex = 0;
            this.BoxRdBtn.TabStop = true;
            this.BoxRdBtn.Text = "‰ﬁœ«";
            this.BoxRdBtn.UseVisualStyleBackColor = true;
            // 
            // txtrecitetype
            // 
            this.txtrecitetype.Location = new System.Drawing.Point(748, 82);
            this.txtrecitetype.Name = "txtrecitetype";
            this.txtrecitetype.Size = new System.Drawing.Size(27, 20);
            this.txtrecitetype.TabIndex = 107;
            this.txtrecitetype.Text = "2";
            // 
            // QidInAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(875, 553);
            this.Controls.Add(this.txtrecitetype);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtActive);
            this.Controls.Add(this.CmdPerview);
            this.Controls.Add(this.CmdActiveSave);
            this.Controls.Add(this.txtTotalToValue);
            this.Controls.Add(this.StockDGView);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(empIdLabel);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(brachIdLabel);
            this.Controls.Add(this.recitetypeTextBox);
            this.Controls.Add(qidDateLabel);
            this.Controls.Add(this.qidDateDateTimePicker);
            this.Controls.Add(this.qidcodeTextBox);
            this.Controls.Add(this.qididTextBox);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QidInAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "”‰œ ﬁ»÷";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.DataGridView StockDGView;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCostPrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox qididTextBox;
        private System.Windows.Forms.TextBox qidcodeTextBox;
        private System.Windows.Forms.DateTimePicker qidDateDateTimePicker;
        private System.Windows.Forms.TextBox recitetypeTextBox;
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
        internal System.Windows.Forms.Button CmdPerview;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qididDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BankRdBtn;
        private System.Windows.Forms.RadioButton BoxRdBtn;
        private System.Windows.Forms.TextBox txtrecitetype;

    }
}