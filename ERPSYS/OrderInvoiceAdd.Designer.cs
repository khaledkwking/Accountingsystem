namespace ERPSYS
{
    partial class OrderInvoiceAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInvoiceAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbCustSupAccid = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupCustId = new System.Windows.Forms.TextBox();
            this.txtInvType = new System.Windows.Forms.TextBox();
            this.InvtabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProductsDGView = new System.Windows.Forms.DataGridView();
            this.OrderSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSupAccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.labelCustSup = new System.Windows.Forms.Label();
            this.oRDERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.ORDERSTableAdapter();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmbBillType = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            this.InvtabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUserId
            // 
            this.txtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "EmpId", true));
            resources.ApplyResources(this.txtUserId, "txtUserId");
            this.txtUserId.Name = "txtUserId";
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.nEWERPDataSet;
            this.oRDERSBindingSource.PositionChanged += new System.EventHandler(this.oRDERSBindingSource_PositionChanged);
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
            // txtSupCustId
            // 
            this.txtSupCustId.AcceptsReturn = true;
            this.txtSupCustId.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupCustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupCustId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "SUP_CUST_ID", true));
            resources.ApplyResources(this.txtSupCustId, "txtSupCustId");
            this.txtSupCustId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSupCustId.Name = "txtSupCustId";
            // 
            // txtInvType
            // 
            this.txtInvType.AcceptsReturn = true;
            this.txtInvType.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "InvType", true));
            resources.ApplyResources(this.txtInvType, "txtInvType");
            this.txtInvType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvType.Name = "txtInvType";
            // 
            // InvtabControl
            // 
            this.InvtabControl.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.InvtabControl, "InvtabControl");
            this.InvtabControl.Name = "InvtabControl";
            this.InvtabControl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProductsDGView);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // ProductsDGView
            // 
            this.ProductsDGView.AllowUserToAddRows = false;
            this.ProductsDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDGView.AutoGenerateColumns = false;
            this.ProductsDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderSel,
            this.orderIdDataGridViewTextBoxColumn,
            this.orderCodeDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.custSupAccidDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.invTypeDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.sUPCUSTIDDataGridViewTextBoxColumn});
            this.ProductsDGView.DataSource = this.oRDERSBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsDGView.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.ProductsDGView, "ProductsDGView");
            this.ProductsDGView.MultiSelect = false;
            this.ProductsDGView.Name = "ProductsDGView";
            this.ProductsDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ProductsDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProductsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProductsDGView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.ProductsDGView_CellValueNeeded);
            this.ProductsDGView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductsDGView_CellFormatting);
            // 
            // OrderSel
            // 
            this.OrderSel.DataPropertyName = "SelFlag";
            resources.ApplyResources(this.OrderSel, "OrderSel");
            this.OrderSel.Name = "OrderSel";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            resources.ApplyResources(this.orderIdDataGridViewTextBoxColumn, "orderIdDataGridViewTextBoxColumn");
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderCodeDataGridViewTextBoxColumn
            // 
            this.orderCodeDataGridViewTextBoxColumn.DataPropertyName = "OrderCode";
            resources.ApplyResources(this.orderCodeDataGridViewTextBoxColumn, "orderCodeDataGridViewTextBoxColumn");
            this.orderCodeDataGridViewTextBoxColumn.Name = "orderCodeDataGridViewTextBoxColumn";
            this.orderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.orderDateDataGridViewTextBoxColumn, "orderDateDataGridViewTextBoxColumn");
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custSupAccidDataGridViewTextBoxColumn
            // 
            this.custSupAccidDataGridViewTextBoxColumn.DataPropertyName = "Cust_Sup_Accid";
            resources.ApplyResources(this.custSupAccidDataGridViewTextBoxColumn, "custSupAccidDataGridViewTextBoxColumn");
            this.custSupAccidDataGridViewTextBoxColumn.Name = "custSupAccidDataGridViewTextBoxColumn";
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
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
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
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPCUSTIDDataGridViewTextBoxColumn
            // 
            this.sUPCUSTIDDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_ID";
            resources.ApplyResources(this.sUPCUSTIDDataGridViewTextBoxColumn, "sUPCUSTIDDataGridViewTextBoxColumn");
            this.sUPCUSTIDDataGridViewTextBoxColumn.Name = "sUPCUSTIDDataGridViewTextBoxColumn";
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // CmdCancel
            // 
            this.CmdCancel.CausesValidation = false;
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // labelCustSup
            // 
            resources.ApplyResources(this.labelCustSup, "labelCustSup");
            this.labelCustSup.BackColor = System.Drawing.Color.Transparent;
            this.labelCustSup.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCustSup.ForeColor = System.Drawing.Color.Blue;
            this.labelCustSup.Name = "labelCustSup";
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
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
            // dtToDate
            // 
            resources.ApplyResources(this.dtToDate, "dtToDate");
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // dtFromDate
            // 
            resources.ApplyResources(this.dtFromDate, "dtFromDate");
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmbBillType
            // 
            resources.ApplyResources(this.CmbBillType, "CmbBillType");
            this.CmbBillType.DisplayMember = "DESC";
            this.CmbBillType.Name = "CmbBillType";
            this.CmbBillType.ValueMember = "ID";
            this.CmbBillType.SelectionChangeCommitted += new System.EventHandler(this.CmbBillType_SelectionChangeCommitted);
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.Color.Blue;
            this.Label8.Name = "Label8";
            // 
            // OrderInvoiceAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CausesValidation = false;
            this.Controls.Add(this.CmbBillType);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvtabControl);
            this.Controls.Add(this.labelCustSup);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtSupCustId);
            this.Controls.Add(this.CmbCustSupAccid);
            this.Controls.Add(this.txtInvType);
            this.Name = "OrderInvoiceAdd";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            this.InvtabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        public System.Windows.Forms.TextBox txtInvType;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.TabControl InvtabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView ProductsDGView;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txtSupCustId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.ComboBox CmbCustSupAccid;
        public System.Windows.Forms.Label labelCustSup;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSupAccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTIDDataGridViewTextBoxColumn;
        internal System.Windows.Forms.ComboBox CmbBillType;
        public System.Windows.Forms.Label Label8;

    }
}