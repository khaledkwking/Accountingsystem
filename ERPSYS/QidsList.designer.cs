namespace ERPSYS
{
    partial class QidsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QidsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.qididDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recitetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.underupdateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brachIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repeatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bankAccIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderInvIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.Qidtypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qidsTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.CausesValidation = false;
            resources.ApplyResources(this.CmdClose, "CmdClose");
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // dtFromDate
            // 
            resources.ApplyResources(this.dtFromDate, "dtFromDate");
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // dtToDate
            // 
            resources.ApplyResources(this.dtToDate, "dtToDate");
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            resources.ApplyResources(this.txtFromDate, "txtFromDate");
            this.txtFromDate.Name = "txtFromDate";
            // 
            // txtToDate
            // 
            resources.ApplyResources(this.txtToDate, "txtToDate");
            this.txtToDate.Name = "txtToDate";
            // 
            // StockDGView
            // 
            this.StockDGView.AllowUserToAddRows = false;
            this.StockDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.StockDGView, "StockDGView");
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
            this.qididDataGridViewTextBoxColumn,
            this.qidcodeDataGridViewTextBoxColumn,
            this.qidDateDataGridViewTextBoxColumn,
            this.recitetypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.editDataGridViewCheckBoxColumn,
            this.underupdateDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brachIdDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.repeatedDataGridViewCheckBoxColumn,
            this.bankAccIdDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.invIdDataGridViewTextBoxColumn,
            this.reorderInvIdDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewCheckBoxColumn});
            this.StockDGView.DataSource = this.qidsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.ReadOnly = true;
            this.StockDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StockDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StockDGView_CellMouseDoubleClick);
            // 
            // qididDataGridViewTextBoxColumn
            // 
            this.qididDataGridViewTextBoxColumn.DataPropertyName = "qidid";
            resources.ApplyResources(this.qididDataGridViewTextBoxColumn, "qididDataGridViewTextBoxColumn");
            this.qididDataGridViewTextBoxColumn.Name = "qididDataGridViewTextBoxColumn";
            this.qididDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qidcodeDataGridViewTextBoxColumn
            // 
            this.qidcodeDataGridViewTextBoxColumn.DataPropertyName = "qidcode";
            resources.ApplyResources(this.qidcodeDataGridViewTextBoxColumn, "qidcodeDataGridViewTextBoxColumn");
            this.qidcodeDataGridViewTextBoxColumn.Name = "qidcodeDataGridViewTextBoxColumn";
            this.qidcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qidDateDataGridViewTextBoxColumn
            // 
            this.qidDateDataGridViewTextBoxColumn.DataPropertyName = "qidDate";
            resources.ApplyResources(this.qidDateDataGridViewTextBoxColumn, "qidDateDataGridViewTextBoxColumn");
            this.qidDateDataGridViewTextBoxColumn.Name = "qidDateDataGridViewTextBoxColumn";
            this.qidDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recitetypeDataGridViewTextBoxColumn
            // 
            this.recitetypeDataGridViewTextBoxColumn.DataPropertyName = "recitetype";
            resources.ApplyResources(this.recitetypeDataGridViewTextBoxColumn, "recitetypeDataGridViewTextBoxColumn");
            this.recitetypeDataGridViewTextBoxColumn.Name = "recitetypeDataGridViewTextBoxColumn";
            this.recitetypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editDataGridViewCheckBoxColumn
            // 
            this.editDataGridViewCheckBoxColumn.DataPropertyName = "edit";
            resources.ApplyResources(this.editDataGridViewCheckBoxColumn, "editDataGridViewCheckBoxColumn");
            this.editDataGridViewCheckBoxColumn.Name = "editDataGridViewCheckBoxColumn";
            this.editDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // underupdateDataGridViewCheckBoxColumn
            // 
            this.underupdateDataGridViewCheckBoxColumn.DataPropertyName = "underupdate";
            resources.ApplyResources(this.underupdateDataGridViewCheckBoxColumn, "underupdateDataGridViewCheckBoxColumn");
            this.underupdateDataGridViewCheckBoxColumn.Name = "underupdateDataGridViewCheckBoxColumn";
            this.underupdateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brachIdDataGridViewTextBoxColumn
            // 
            this.brachIdDataGridViewTextBoxColumn.DataPropertyName = "BrachId";
            resources.ApplyResources(this.brachIdDataGridViewTextBoxColumn, "brachIdDataGridViewTextBoxColumn");
            this.brachIdDataGridViewTextBoxColumn.Name = "brachIdDataGridViewTextBoxColumn";
            this.brachIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            resources.ApplyResources(this.empIdDataGridViewTextBoxColumn, "empIdDataGridViewTextBoxColumn");
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn, "activeDataGridViewCheckBoxColumn");
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // repeatedDataGridViewCheckBoxColumn
            // 
            this.repeatedDataGridViewCheckBoxColumn.DataPropertyName = "repeated";
            resources.ApplyResources(this.repeatedDataGridViewCheckBoxColumn, "repeatedDataGridViewCheckBoxColumn");
            this.repeatedDataGridViewCheckBoxColumn.Name = "repeatedDataGridViewCheckBoxColumn";
            this.repeatedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bankAccIdDataGridViewTextBoxColumn
            // 
            this.bankAccIdDataGridViewTextBoxColumn.DataPropertyName = "BankAccId";
            resources.ApplyResources(this.bankAccIdDataGridViewTextBoxColumn, "bankAccIdDataGridViewTextBoxColumn");
            this.bankAccIdDataGridViewTextBoxColumn.Name = "bankAccIdDataGridViewTextBoxColumn";
            this.bankAccIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            resources.ApplyResources(this.chequeNoDataGridViewTextBoxColumn, "chequeNoDataGridViewTextBoxColumn");
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invIdDataGridViewTextBoxColumn
            // 
            this.invIdDataGridViewTextBoxColumn.DataPropertyName = "InvId";
            resources.ApplyResources(this.invIdDataGridViewTextBoxColumn, "invIdDataGridViewTextBoxColumn");
            this.invIdDataGridViewTextBoxColumn.Name = "invIdDataGridViewTextBoxColumn";
            this.invIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reorderInvIdDataGridViewTextBoxColumn
            // 
            this.reorderInvIdDataGridViewTextBoxColumn.DataPropertyName = "ReorderInvId";
            resources.ApplyResources(this.reorderInvIdDataGridViewTextBoxColumn, "reorderInvIdDataGridViewTextBoxColumn");
            this.reorderInvIdDataGridViewTextBoxColumn.Name = "reorderInvIdDataGridViewTextBoxColumn";
            this.reorderInvIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewCheckBoxColumn
            // 
            this.paymentTypeDataGridViewCheckBoxColumn.DataPropertyName = "PaymentType";
            resources.ApplyResources(this.paymentTypeDataGridViewCheckBoxColumn, "paymentTypeDataGridViewCheckBoxColumn");
            this.paymentTypeDataGridViewCheckBoxColumn.Name = "paymentTypeDataGridViewCheckBoxColumn";
            this.paymentTypeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // qidsBindingSource
            // 
            this.qidsBindingSource.DataMember = "qids";
            this.qidsBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Qidtypes
            // 
            resources.ApplyResources(this.Qidtypes, "Qidtypes");
            this.Qidtypes.DisplayMember = "DESC";
            this.Qidtypes.FormattingEnabled = true;
            this.Qidtypes.Name = "Qidtypes";
            this.Qidtypes.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // qidsTableAdapter
            // 
            this.qidsTableAdapter.ClearBeforeFill = true;
            // 
            // QidsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Qidtypes);
            this.Controls.Add(this.StockDGView);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QidsList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.DataGridView StockDGView;
        private System.Windows.Forms.BindingSource qidsBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.qidsTableAdapter qidsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qididDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recitetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn underupdateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brachIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repeatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderInvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentTypeDataGridViewCheckBoxColumn;
        internal System.Windows.Forms.ComboBox Qidtypes;
        public System.Windows.Forms.Label label3;
       
        

    }
}