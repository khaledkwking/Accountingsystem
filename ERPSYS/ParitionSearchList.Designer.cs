namespace ERPSYS
{
    partial class ParitionSearchList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParitionSearchList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enterDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unitIDComboBox = new System.Windows.Forms.ComboBox();
            this.cDEUNITTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.movmentQtyTextBox = new System.Windows.Forms.TextBox();
            this.pRODUCTIDComboBox = new System.Windows.Forms.ComboBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREFromIDComboBox = new System.Windows.Forms.ComboBox();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StoresDGView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRODUCTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDEUNITTYPESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOREIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.partitionTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.PartitionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionBindingSource)).BeginInit();
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
            this.Id,
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.sTOREIDDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.StoresDGView.DataSource = this.partitionBindingSource;
            this.StoresDGView.EnableHeadersVisualStyles = false;
            this.StoresDGView.MultiSelect = false;
            this.StoresDGView.Name = "StoresDGView";
            this.StoresDGView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoresDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StoresDGView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StoresDGView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StoresDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.StoresDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StoresDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoresDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StoresDGView_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.DataSource = this.pRODUCTSBindingSource1;
            this.pRODUCTIDDataGridViewTextBoxColumn.DisplayMember = "productname";
            this.pRODUCTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.pRODUCTIDDataGridViewTextBoxColumn, "pRODUCTIDDataGridViewTextBoxColumn");
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRODUCTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pRODUCTIDDataGridViewTextBoxColumn.ValueMember = "PRODUCTID";
            // 
            // pRODUCTSBindingSource1
            // 
            this.pRODUCTSBindingSource1.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.cDEUNITTYPESBindingSource1;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "UNITDESC";
            this.unitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.unitIDDataGridViewTextBoxColumn, "unitIDDataGridViewTextBoxColumn");
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "UINTID";
            // 
            // cDEUNITTYPESBindingSource1
            // 
            this.cDEUNITTYPESBindingSource1.DataMember = "CDE_UNIT_TYPES";
            this.cDEUNITTYPESBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            resources.ApplyResources(this.qtyDataGridViewTextBoxColumn, "qtyDataGridViewTextBoxColumn");
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOREIDDataGridViewTextBoxColumn
            // 
            this.sTOREIDDataGridViewTextBoxColumn.DataPropertyName = "STOREID";
            this.sTOREIDDataGridViewTextBoxColumn.DataSource = this.sTORESBindingSource1;
            this.sTOREIDDataGridViewTextBoxColumn.DisplayMember = "STORNAME";
            this.sTOREIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.sTOREIDDataGridViewTextBoxColumn, "sTOREIDDataGridViewTextBoxColumn");
            this.sTOREIDDataGridViewTextBoxColumn.Name = "sTOREIDDataGridViewTextBoxColumn";
            this.sTOREIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOREIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTOREIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTOREIDDataGridViewTextBoxColumn.ValueMember = "STOREID";
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            resources.ApplyResources(this.enterDateDataGridViewTextBoxColumn, "enterDateDataGridViewTextBoxColumn");
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            this.enterDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partitionBindingSource
            // 
            this.partitionBindingSource.DataMember = "Partition";
            this.partitionBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
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
            // partitionTableAdapter
            // 
            this.partitionTableAdapter.ClearBeforeFill = true;
            // 
            // ParitionSearchList
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
            this.Controls.Add(this.pRODUCTIDComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterDateDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movmentQtyTextBox);
            this.Controls.Add(this.sTOREFromIDComboBox);
            this.Name = "ParitionSearchList";
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
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEUNITTYPESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox sTOREFromIDComboBox;
        private System.Windows.Forms.ComboBox unitIDComboBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.BindingSource partitionBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.PartitionTableAdapter partitionTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource1;
        private System.Windows.Forms.BindingSource cDEUNITTYPESBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTOREIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;

    }
}