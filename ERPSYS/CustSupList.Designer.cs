namespace ERPSYS
{
    partial class CustSupList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustSupList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txCustSupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustSupCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustSupDGView = new System.Windows.Forms.DataGridView();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.accountingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingViewTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter();
            this.SUP_CUST_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_CUST_FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITLIMIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPCUSTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gOVERNERATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSTOFFICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERACOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONVICTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustSupDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // CmdDel
            // 
            resources.ApplyResources(this.CmdDel, "CmdDel");
            this.CmdDel.ForeColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
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
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            // 
            // txCustSupName
            // 
            this.txCustSupName.AcceptsReturn = true;
            this.txCustSupName.BackColor = System.Drawing.SystemColors.Window;
            this.txCustSupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txCustSupName, "txCustSupName");
            this.txCustSupName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txCustSupName.Name = "txCustSupName";
            this.txCustSupName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txCustSupName_KeyUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtCustSupCode
            // 
            this.txtCustSupCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustSupCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtCustSupCode, "txtCustSupCode");
            this.txtCustSupCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustSupCode.Name = "txtCustSupCode";
            this.txtCustSupCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustSupCode_KeyUp);
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.CustSupDGView);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // CustSupDGView
            // 
            this.CustSupDGView.AllowUserToAddRows = false;
            this.CustSupDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.CustSupDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.CustSupDGView, "CustSupDGView");
            this.CustSupDGView.AutoGenerateColumns = false;
            this.CustSupDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustSupDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustSupDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustSupDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUP_CUST_CODE,
            this.SUP_CUST_FNAME,
            this.accountid,
            this.CREDITLIMIT,
            this.pHONE1DataGridViewTextBoxColumn,
            this.pHONE2DataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.aDMINNAMEDataGridViewTextBoxColumn,
            this.sUPCUSTSNAMEDataGridViewTextBoxColumn,
            this.sUPCUSTTYPEDataGridViewTextBoxColumn,
            this.aDMINTITLEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.gOVERNERATEDataGridViewTextBoxColumn,
            this.cOUNTRYDataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn,
            this.pOSTOFFICEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.sUPPLIERACOUNTDataGridViewTextBoxColumn,
            this.cONVICTDataGridViewTextBoxColumn,
            this.SUP_CUST_ID});
            this.CustSupDGView.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustSupDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustSupDGView.EnableHeadersVisualStyles = false;
            this.CustSupDGView.MultiSelect = false;
            this.CustSupDGView.Name = "CustSupDGView";
            this.CustSupDGView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustSupDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.CustSupDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CustSupDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSupDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CustSupDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.CustSupDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustSupDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustSupDGView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CustSupDGView_CellFormatting);
            this.CustSupDGView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustSupDGView_RowEnter);
            this.CustSupDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CustSupDGView_RowsAdded);
            this.CustSupDGView.DoubleClick += new System.EventHandler(this.CustSupDGView_DoubleClick);
            // 
            // sUPPLIERSCUSTOMERSBindingSource
            // 
            this.sUPPLIERSCUSTOMERSBindingSource.DataMember = "SUPPLIERS_CUSTOMERS";
            this.sUPPLIERSCUSTOMERSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // accountingViewBindingSource
            // 
            this.accountingViewBindingSource.DataMember = "AccountingView";
            this.accountingViewBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountingViewTableAdapter
            // 
            this.accountingViewTableAdapter.ClearBeforeFill = true;
            // 
            // SUP_CUST_CODE
            // 
            this.SUP_CUST_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SUP_CUST_CODE.DataPropertyName = "SUP_CUST_CODE";
            resources.ApplyResources(this.SUP_CUST_CODE, "SUP_CUST_CODE");
            this.SUP_CUST_CODE.Name = "SUP_CUST_CODE";
            this.SUP_CUST_CODE.ReadOnly = true;
            // 
            // SUP_CUST_FNAME
            // 
            this.SUP_CUST_FNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SUP_CUST_FNAME.DataPropertyName = "SUP_CUST_FNAME";
            resources.ApplyResources(this.SUP_CUST_FNAME, "SUP_CUST_FNAME");
            this.SUP_CUST_FNAME.Name = "SUP_CUST_FNAME";
            this.SUP_CUST_FNAME.ReadOnly = true;
            // 
            // accountid
            // 
            this.accountid.DataPropertyName = "accountid";
            resources.ApplyResources(this.accountid, "accountid");
            this.accountid.Name = "accountid";
            this.accountid.ReadOnly = true;
            // 
            // CREDITLIMIT
            // 
            this.CREDITLIMIT.DataPropertyName = "CREDITLIMIT";
            resources.ApplyResources(this.CREDITLIMIT, "CREDITLIMIT");
            this.CREDITLIMIT.Name = "CREDITLIMIT";
            this.CREDITLIMIT.ReadOnly = true;
            // 
            // pHONE1DataGridViewTextBoxColumn
            // 
            this.pHONE1DataGridViewTextBoxColumn.DataPropertyName = "PHONE1";
            resources.ApplyResources(this.pHONE1DataGridViewTextBoxColumn, "pHONE1DataGridViewTextBoxColumn");
            this.pHONE1DataGridViewTextBoxColumn.Name = "pHONE1DataGridViewTextBoxColumn";
            this.pHONE1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONE2DataGridViewTextBoxColumn
            // 
            this.pHONE2DataGridViewTextBoxColumn.DataPropertyName = "PHONE2";
            resources.ApplyResources(this.pHONE2DataGridViewTextBoxColumn, "pHONE2DataGridViewTextBoxColumn");
            this.pHONE2DataGridViewTextBoxColumn.Name = "pHONE2DataGridViewTextBoxColumn";
            this.pHONE2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            resources.ApplyResources(this.aDDRESSDataGridViewTextBoxColumn, "aDDRESSDataGridViewTextBoxColumn");
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDMINNAMEDataGridViewTextBoxColumn
            // 
            this.aDMINNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.aDMINNAMEDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_NAME";
            resources.ApplyResources(this.aDMINNAMEDataGridViewTextBoxColumn, "aDMINNAMEDataGridViewTextBoxColumn");
            this.aDMINNAMEDataGridViewTextBoxColumn.Name = "aDMINNAMEDataGridViewTextBoxColumn";
            this.aDMINNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPCUSTSNAMEDataGridViewTextBoxColumn
            // 
            this.sUPCUSTSNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_SNAME";
            resources.ApplyResources(this.sUPCUSTSNAMEDataGridViewTextBoxColumn, "sUPCUSTSNAMEDataGridViewTextBoxColumn");
            this.sUPCUSTSNAMEDataGridViewTextBoxColumn.Name = "sUPCUSTSNAMEDataGridViewTextBoxColumn";
            this.sUPCUSTSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPCUSTTYPEDataGridViewTextBoxColumn
            // 
            this.sUPCUSTTYPEDataGridViewTextBoxColumn.DataPropertyName = "SUP_CUST_TYPE";
            resources.ApplyResources(this.sUPCUSTTYPEDataGridViewTextBoxColumn, "sUPCUSTTYPEDataGridViewTextBoxColumn");
            this.sUPCUSTTYPEDataGridViewTextBoxColumn.Name = "sUPCUSTTYPEDataGridViewTextBoxColumn";
            this.sUPCUSTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDMINTITLEDataGridViewTextBoxColumn
            // 
            this.aDMINTITLEDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_TITLE";
            resources.ApplyResources(this.aDMINTITLEDataGridViewTextBoxColumn, "aDMINTITLEDataGridViewTextBoxColumn");
            this.aDMINTITLEDataGridViewTextBoxColumn.Name = "aDMINTITLEDataGridViewTextBoxColumn";
            this.aDMINTITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            resources.ApplyResources(this.cITYDataGridViewTextBoxColumn, "cITYDataGridViewTextBoxColumn");
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gOVERNERATEDataGridViewTextBoxColumn
            // 
            this.gOVERNERATEDataGridViewTextBoxColumn.DataPropertyName = "GOVERNERATE";
            resources.ApplyResources(this.gOVERNERATEDataGridViewTextBoxColumn, "gOVERNERATEDataGridViewTextBoxColumn");
            this.gOVERNERATEDataGridViewTextBoxColumn.Name = "gOVERNERATEDataGridViewTextBoxColumn";
            this.gOVERNERATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUNTRYDataGridViewTextBoxColumn
            // 
            this.cOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY";
            resources.ApplyResources(this.cOUNTRYDataGridViewTextBoxColumn, "cOUNTRYDataGridViewTextBoxColumn");
            this.cOUNTRYDataGridViewTextBoxColumn.Name = "cOUNTRYDataGridViewTextBoxColumn";
            this.cOUNTRYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fAXDataGridViewTextBoxColumn
            // 
            this.fAXDataGridViewTextBoxColumn.DataPropertyName = "FAX";
            resources.ApplyResources(this.fAXDataGridViewTextBoxColumn, "fAXDataGridViewTextBoxColumn");
            this.fAXDataGridViewTextBoxColumn.Name = "fAXDataGridViewTextBoxColumn";
            this.fAXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSTOFFICEDataGridViewTextBoxColumn
            // 
            this.pOSTOFFICEDataGridViewTextBoxColumn.DataPropertyName = "POSTOFFICE";
            resources.ApplyResources(this.pOSTOFFICEDataGridViewTextBoxColumn, "pOSTOFFICEDataGridViewTextBoxColumn");
            this.pOSTOFFICEDataGridViewTextBoxColumn.Name = "pOSTOFFICEDataGridViewTextBoxColumn";
            this.pOSTOFFICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            resources.ApplyResources(this.eMAILDataGridViewTextBoxColumn, "eMAILDataGridViewTextBoxColumn");
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPPLIERACOUNTDataGridViewTextBoxColumn
            // 
            this.sUPPLIERACOUNTDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIERACOUNT";
            resources.ApplyResources(this.sUPPLIERACOUNTDataGridViewTextBoxColumn, "sUPPLIERACOUNTDataGridViewTextBoxColumn");
            this.sUPPLIERACOUNTDataGridViewTextBoxColumn.Name = "sUPPLIERACOUNTDataGridViewTextBoxColumn";
            this.sUPPLIERACOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONVICTDataGridViewTextBoxColumn
            // 
            this.cONVICTDataGridViewTextBoxColumn.DataPropertyName = "CONVICT";
            resources.ApplyResources(this.cONVICTDataGridViewTextBoxColumn, "cONVICTDataGridViewTextBoxColumn");
            this.cONVICTDataGridViewTextBoxColumn.Name = "cONVICTDataGridViewTextBoxColumn";
            this.cONVICTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SUP_CUST_ID
            // 
            this.SUP_CUST_ID.DataPropertyName = "SUP_CUST_ID";
            resources.ApplyResources(this.SUP_CUST_ID, "SUP_CUST_ID");
            this.SUP_CUST_ID.Name = "SUP_CUST_ID";
            this.SUP_CUST_ID.ReadOnly = true;
            // 
            // CustSupList
            // 
            this.AcceptButton = this.CmdAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.Controls.Add(this.txtCustSupCode);
            this.Controls.Add(this.txCustSupName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustSupList";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.CustSupList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustSupDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txCustSupName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCustSupCode;
        public System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.DataGridView CustSupDGView;
        internal System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOMEPAGEDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.BindingSource accountingViewBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.AccountingViewTableAdapter accountingViewTableAdapter;
        internal System.Windows.Forms.Button CmdDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_CUST_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_CUST_FNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITLIMIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPCUSTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOVERNERATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTOFFICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERACOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONVICTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_CUST_ID;

    }
}