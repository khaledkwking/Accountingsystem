namespace ERPSYS
{
    partial class StockMoveSearchList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMoveSearchList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enterDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unitIDComboBox = new System.Windows.Forms.ComboBox();
            this.cDEUNITTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.movmentQtyTextBox = new System.Windows.Forms.TextBox();
            this.pRODUCTIDComboBox = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREToIDComboBox = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREFromIDComboBox = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.moveCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovPRODUCTID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MovUINTID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MovMovmentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOREFromID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.STOREToID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMovementViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.sTORESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.STORESTableAdapter();
            this.cDE_UNIT_TYPESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter();
            this.pRODUCTSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter();
            this.product_Units_PricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Units_PricesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBarCode = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnterDate = new System.Windows.Forms.TextBox();
            this.stockMovementViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.StockMovementViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMovementViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enterDateDateTimePicker
            // 
            resources.ApplyResources(this.enterDateDateTimePicker, "enterDateDateTimePicker");
            this.enterDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enterDateDateTimePicker.Name = "enterDateDateTimePicker";
            this.enterDateDateTimePicker.ValueChanged += new System.EventHandler(this.enterDateDateTimePicker_ValueChanged);
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // unitIDComboBox
            // 
            this.unitIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitIDComboBox.DataSource = this.cDEUNITTYPESBindingSource;
            this.unitIDComboBox.DisplayMember = "UNITDESC";
            resources.ApplyResources(this.unitIDComboBox, "unitIDComboBox");
            this.unitIDComboBox.FormattingEnabled = true;
            this.unitIDComboBox.Name = "unitIDComboBox";
            this.unitIDComboBox.ValueMember = "UINTID";
            // 
            // cDEUNITTYPESBindingSource
            // 
            this.cDEUNITTYPESBindingSource.DataMember = "CDE_UNIT_TYPES";
            this.cDEUNITTYPESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // movmentQtyTextBox
            // 
            resources.ApplyResources(this.movmentQtyTextBox, "movmentQtyTextBox");
            this.movmentQtyTextBox.Name = "movmentQtyTextBox";
            // 
            // pRODUCTIDComboBox
            // 
            this.pRODUCTIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pRODUCTIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pRODUCTIDComboBox.DataSource = this.pRODUCTSBindingSource;
            this.pRODUCTIDComboBox.DisplayMember = "PRODUCTCODE";
            resources.ApplyResources(this.pRODUCTIDComboBox, "pRODUCTIDComboBox");
            this.pRODUCTIDComboBox.FormattingEnabled = true;
            this.pRODUCTIDComboBox.Name = "pRODUCTIDComboBox";
            this.pRODUCTIDComboBox.ValueMember = "PRODUCTID";
            this.pRODUCTIDComboBox.SelectedIndexChanged += new System.EventHandler(this.pRODUCTIDComboBox_SelectedIndexChanged);
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // sTOREToIDComboBox
            // 
            this.sTOREToIDComboBox.DataSource = this.sTORESBindingSource1;
            this.sTOREToIDComboBox.DisplayMember = "STORNAME";
            resources.ApplyResources(this.sTOREToIDComboBox, "sTOREToIDComboBox");
            this.sTOREToIDComboBox.FormattingEnabled = true;
            this.sTOREToIDComboBox.Name = "sTOREToIDComboBox";
            this.sTOREToIDComboBox.ValueMember = "STOREID";
            // 
            // sTORESBindingSource1
            // 
            this.sTORESBindingSource1.DataMember = "STORES";
            this.sTORESBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // sTOREFromIDComboBox
            // 
            this.sTOREFromIDComboBox.DataSource = this.sTORESBindingSource;
            this.sTOREFromIDComboBox.DisplayMember = "STORNAME";
            resources.ApplyResources(this.sTOREFromIDComboBox, "sTOREFromIDComboBox");
            this.sTOREFromIDComboBox.FormattingEnabled = true;
            this.sTOREFromIDComboBox.Name = "sTOREFromIDComboBox";
            this.sTOREFromIDComboBox.ValueMember = "STOREID";
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
            this.moveCodeDataGridViewTextBoxColumn,
            this.EnterDate,
            this.detIdDataGridViewTextBoxColumn,
            this.MoveId,
            this.MovPRODUCTID,
            this.MovUINTID,
            this.MovMovmentQty,
            this.STOREFromID,
            this.STOREToID,
            this.userIdDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.stockMovementViewBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StoresDGView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StoresDGView_CellMouseDoubleClick);
            // 
            // moveCodeDataGridViewTextBoxColumn
            // 
            this.moveCodeDataGridViewTextBoxColumn.DataPropertyName = "MoveCode";
            resources.ApplyResources(this.moveCodeDataGridViewTextBoxColumn, "moveCodeDataGridViewTextBoxColumn");
            this.moveCodeDataGridViewTextBoxColumn.Name = "moveCodeDataGridViewTextBoxColumn";
            this.moveCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EnterDate
            // 
            this.EnterDate.DataPropertyName = "EnterDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.EnterDate.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.EnterDate, "EnterDate");
            this.EnterDate.Name = "EnterDate";
            this.EnterDate.ReadOnly = true;
            // 
            // detIdDataGridViewTextBoxColumn
            // 
            this.detIdDataGridViewTextBoxColumn.DataPropertyName = "DetId";
            resources.ApplyResources(this.detIdDataGridViewTextBoxColumn, "detIdDataGridViewTextBoxColumn");
            this.detIdDataGridViewTextBoxColumn.Name = "detIdDataGridViewTextBoxColumn";
            this.detIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MoveId
            // 
            this.MoveId.DataPropertyName = "MoveId";
            resources.ApplyResources(this.MoveId, "MoveId");
            this.MoveId.Name = "MoveId";
            this.MoveId.ReadOnly = true;
            // 
            // MovPRODUCTID
            // 
            this.MovPRODUCTID.DataPropertyName = "PRODUCTID";
            this.MovPRODUCTID.DataSource = this.pRODUCTSBindingSource;
            this.MovPRODUCTID.DisplayMember = "productname";
            this.MovPRODUCTID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.MovPRODUCTID, "MovPRODUCTID");
            this.MovPRODUCTID.Name = "MovPRODUCTID";
            this.MovPRODUCTID.ReadOnly = true;
            this.MovPRODUCTID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovPRODUCTID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MovPRODUCTID.ValueMember = "PRODUCTID";
            // 
            // MovUINTID
            // 
            this.MovUINTID.DataPropertyName = "UnitID";
            this.MovUINTID.DataSource = this.cDEUNITTYPESBindingSource;
            this.MovUINTID.DisplayMember = "UNITDESC";
            this.MovUINTID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.MovUINTID, "MovUINTID");
            this.MovUINTID.Name = "MovUINTID";
            this.MovUINTID.ReadOnly = true;
            this.MovUINTID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovUINTID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MovUINTID.ValueMember = "UINTID";
            // 
            // MovMovmentQty
            // 
            this.MovMovmentQty.DataPropertyName = "MovmentQty";
            resources.ApplyResources(this.MovMovmentQty, "MovMovmentQty");
            this.MovMovmentQty.Name = "MovMovmentQty";
            this.MovMovmentQty.ReadOnly = true;
            // 
            // STOREFromID
            // 
            this.STOREFromID.DataPropertyName = "STOREFromID";
            this.STOREFromID.DataSource = this.sTORESBindingSource;
            this.STOREFromID.DisplayMember = "STORNAME";
            this.STOREFromID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.STOREFromID, "STOREFromID");
            this.STOREFromID.Name = "STOREFromID";
            this.STOREFromID.ReadOnly = true;
            this.STOREFromID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STOREFromID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STOREFromID.ValueMember = "STOREID";
            // 
            // STOREToID
            // 
            this.STOREToID.DataPropertyName = "STOREToID";
            this.STOREToID.DataSource = this.sTORESBindingSource1;
            this.STOREToID.DisplayMember = "STORNAME";
            this.STOREToID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.STOREToID, "STOREToID");
            this.STOREToID.Name = "STOREToID";
            this.STOREToID.ReadOnly = true;
            this.STOREToID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STOREToID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STOREToID.ValueMember = "STOREID";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId";
            resources.ApplyResources(this.branchIdDataGridViewTextBoxColumn, "branchIdDataGridViewTextBoxColumn");
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockMovementViewBindingSource
            // 
            this.stockMovementViewBindingSource.DataMember = "StockMovementView";
            this.stockMovementViewBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
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
            // BtnPrint
            // 
            this.BtnPrint.CausesValidation = false;
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdSearch
            // 
            resources.ApplyResources(this.CmdSearch, "CmdSearch");
            this.CmdSearch.ForeColor = System.Drawing.Color.Black;
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
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
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.pRODUCTSBindingSource;
            this.comboBox1.DisplayMember = "productname";
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "PRODUCTID";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // cmbBarCode
            // 
            this.cmbBarCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBarCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBarCode.DataSource = this.product_Units_PricesBindingSource;
            this.cmbBarCode.DisplayMember = "PRODUCTBRAND";
            resources.ApplyResources(this.cmbBarCode, "cmbBarCode");
            this.cmbBarCode.FormattingEnabled = true;
            this.cmbBarCode.Name = "cmbBarCode";
            this.cmbBarCode.ValueMember = "PRODUCTID";
            this.cmbBarCode.SelectionChangeCommitted += new System.EventHandler(this.cmbBarCode_SelectionChangeCommitted);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // txtEnterDate
            // 
            resources.ApplyResources(this.txtEnterDate, "txtEnterDate");
            this.txtEnterDate.Name = "txtEnterDate";
            // 
            // stockMovementViewTableAdapter
            // 
            this.stockMovementViewTableAdapter.ClearBeforeFill = true;
            // 
            // StockMoveSearchList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.txtEnterDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBarCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.unitIDComboBox);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pRODUCTIDComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterDateDateTimePicker);
            this.Controls.Add(this.sTOREToIDComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movmentQtyTextBox);
            this.Controls.Add(this.sTOREFromIDComboBox);
            this.Name = "StockMoveSearchList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMovementViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Units_PricesBindingSource)).EndInit();
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
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.BindingSource cDEUNITTYPESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_UNIT_TYPESTableAdapter cDE_UNIT_TYPESTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource sTORESBindingSource1;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox movmentQtyTextBox;
        private System.Windows.Forms.ComboBox pRODUCTIDComboBox;
        private System.Windows.Forms.ComboBox sTOREToIDComboBox;
        private System.Windows.Forms.ComboBox sTOREFromIDComboBox;
        private System.Windows.Forms.ComboBox unitIDComboBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource product_Units_PricesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Product_Units_PricesTableAdapter product_Units_PricesTableAdapter;
        private System.Windows.Forms.DateTimePicker enterDateDateTimePicker;
        public System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridViewComboBoxColumn PRODUCTID;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovmentQty;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBarCode;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnterDate;
        private System.Windows.Forms.BindingSource stockMovementViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.StockMovementViewTableAdapter stockMovementViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn detIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveId;
        private System.Windows.Forms.DataGridViewComboBoxColumn MovPRODUCTID;
        private System.Windows.Forms.DataGridViewComboBoxColumn MovUINTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovMovmentQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn STOREFromID;
        private System.Windows.Forms.DataGridViewComboBoxColumn STOREToID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;

    }
}