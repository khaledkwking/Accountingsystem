namespace ERPSYS
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.qidsDetailsClosedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.qidsDetailsClosedTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsClosedTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qididDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BlamceBtn = new System.Windows.Forms.Button();
            this.IncomeListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsClosedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDGView
            // 
            this.StockDGView.AllowUserToAddRows = false;
            this.StockDGView.AllowUserToDeleteRows = false;
            this.StockDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDGView.AutoGenerateColumns = false;
            this.StockDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StockDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.qididDataGridViewTextBoxColumn,
            this.aCCOUNTIDDataGridViewTextBoxColumn,
            this.fromValueDataGridViewTextBoxColumn,
            this.toValueDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn,
            this.detcodeDataGridViewTextBoxColumn,
            this.qidTypeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.actionTypeDataGridViewTextBoxColumn,
            this.costIdDataGridViewTextBoxColumn});
            this.StockDGView.DataSource = this.qidsDetailsClosedBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGView.DefaultCellStyle = dataGridViewCellStyle8;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.Location = new System.Drawing.Point(12, 46);
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.StockDGView.RowHeadersVisible = false;
            this.StockDGView.RowHeadersWidth = 45;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.StockDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDGView.Size = new System.Drawing.Size(856, 359);
            this.StockDGView.TabIndex = 85;
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
            // qidsDetailsClosedBindingSource
            // 
            this.qidsDetailsClosedBindingSource.DataMember = "qidsDetailsClosed";
            this.qidsDetailsClosedBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // qidsDetailsClosedTableAdapter
            // 
            this.qidsDetailsClosedTableAdapter.ClearBeforeFill = true;
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
            this.qididDataGridViewTextBoxColumn.ReadOnly = true;
            this.qididDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTIDDataGridViewTextBoxColumn
            // 
            this.aCCOUNTIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.aCCOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.DataSource = this.accountingBindingSource;
            this.aCCOUNTIDDataGridViewTextBoxColumn.DisplayMember = "accountname";
            this.aCCOUNTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.aCCOUNTIDDataGridViewTextBoxColumn.HeaderText = "√”„ «·Õ”«»";
            this.aCCOUNTIDDataGridViewTextBoxColumn.Name = "aCCOUNTIDDataGridViewTextBoxColumn";
            this.aCCOUNTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aCCOUNTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aCCOUNTIDDataGridViewTextBoxColumn.ValueMember = "accountid";
            this.aCCOUNTIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // fromValueDataGridViewTextBoxColumn
            // 
            this.fromValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fromValueDataGridViewTextBoxColumn.DataPropertyName = "FromValue";
            this.fromValueDataGridViewTextBoxColumn.HeaderText = "œ«∆‰";
            this.fromValueDataGridViewTextBoxColumn.Name = "fromValueDataGridViewTextBoxColumn";
            this.fromValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // toValueDataGridViewTextBoxColumn
            // 
            this.toValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toValueDataGridViewTextBoxColumn.DataPropertyName = "ToValue";
            this.toValueDataGridViewTextBoxColumn.HeaderText = "„œÌ‰";
            this.toValueDataGridViewTextBoxColumn.Name = "toValueDataGridViewTextBoxColumn";
            this.toValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.toValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.enterDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "«· «—ÌŒ";
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            this.enterDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.enterDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // detcodeDataGridViewTextBoxColumn
            // 
            this.detcodeDataGridViewTextBoxColumn.DataPropertyName = "Detcode";
            this.detcodeDataGridViewTextBoxColumn.HeaderText = "Detcode";
            this.detcodeDataGridViewTextBoxColumn.Name = "detcodeDataGridViewTextBoxColumn";
            this.detcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.detcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // qidTypeDataGridViewTextBoxColumn
            // 
            this.qidTypeDataGridViewTextBoxColumn.DataPropertyName = "QidType";
            this.qidTypeDataGridViewTextBoxColumn.HeaderText = "QidType";
            this.qidTypeDataGridViewTextBoxColumn.Name = "qidTypeDataGridViewTextBoxColumn";
            this.qidTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.qidTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            this.actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            this.actionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // costIdDataGridViewTextBoxColumn
            // 
            this.costIdDataGridViewTextBoxColumn.DataPropertyName = "CostId";
            this.costIdDataGridViewTextBoxColumn.HeaderText = "CostId";
            this.costIdDataGridViewTextBoxColumn.Name = "costIdDataGridViewTextBoxColumn";
            this.costIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.costIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.Location = new System.Drawing.Point(445, 417);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPrint.Size = new System.Drawing.Size(102, 33);
            this.BtnPrint.TabIndex = 128;
            this.BtnPrint.Text = "ÿ«»⁄…";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // CmdClose
            // 
            this.CmdClose.CausesValidation = false;
            this.CmdClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Image = ((System.Drawing.Image)(resources.GetObject("CmdClose.Image")));
            this.CmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdClose.Location = new System.Drawing.Point(556, 417);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdClose.Size = new System.Drawing.Size(102, 33);
            this.CmdClose.TabIndex = 127;
            this.CmdClose.Text = "Œ—ÊÃ";
            this.CmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDate.Location = new System.Drawing.Point(91, 6);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(234, 25);
            this.txtToDate.TabIndex = 135;
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(331, 6);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(22, 25);
            this.dtToDate.TabIndex = 134;
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 133;
            this.label1.Text = "«·Ï  «—ÌŒ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BlamceBtn
            // 
            this.BlamceBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlamceBtn.ForeColor = System.Drawing.Color.Black;
            this.BlamceBtn.Image = ((System.Drawing.Image)(resources.GetObject("BlamceBtn.Image")));
            this.BlamceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BlamceBtn.Location = new System.Drawing.Point(223, 417);
            this.BlamceBtn.Name = "BlamceBtn";
            this.BlamceBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlamceBtn.Size = new System.Drawing.Size(102, 33);
            this.BlamceBtn.TabIndex = 136;
            this.BlamceBtn.Text = "⁄—÷ «·„Ì“«‰Ì…";
            this.BlamceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlamceBtn.UseVisualStyleBackColor = true;
            this.BlamceBtn.Click += new System.EventHandler(this.BlamceBtn_Click);
            // 
            // IncomeListBtn
            // 
            this.IncomeListBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeListBtn.ForeColor = System.Drawing.Color.Black;
            this.IncomeListBtn.Image = ((System.Drawing.Image)(resources.GetObject("IncomeListBtn.Image")));
            this.IncomeListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IncomeListBtn.Location = new System.Drawing.Point(334, 417);
            this.IncomeListBtn.Name = "IncomeListBtn";
            this.IncomeListBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncomeListBtn.Size = new System.Drawing.Size(102, 33);
            this.IncomeListBtn.TabIndex = 137;
            this.IncomeListBtn.Text = "ﬁ«∆„… «·œŒ·";
            this.IncomeListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncomeListBtn.UseVisualStyleBackColor = true;
            this.IncomeListBtn.Click += new System.EventHandler(this.IncomeListBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(880, 456);
            this.Controls.Add(this.IncomeListBtn);
            this.Controls.Add(this.BlamceBtn);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.StockDGView);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "√€·«ﬁ „Ì“«‰Ì…";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsDetailsClosedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.BindingSource qidsDetailsClosedBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsDetailsClosedTableAdapter qidsDetailsClosedTableAdapter;
        internal System.Windows.Forms.DataGridView StockDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qididDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aCCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costIdDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BlamceBtn;
        internal System.Windows.Forms.Button IncomeListBtn;
    }
}