namespace ERPSYS
{
    partial class HomeCustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeCustomerAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmdDel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.telPhoneTextBox = new System.Windows.Forms.TextBox();
            this.homeCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.BranchesDGView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.recoderCodeTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.homeCustomerTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.HomeCustomerTableAdapter();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulidingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.homeCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // telPhoneTextBox
            // 
            this.telPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "CustTel", true));
            resources.ApplyResources(this.telPhoneTextBox, "telPhoneTextBox");
            this.telPhoneTextBox.Name = "telPhoneTextBox";
            // 
            // homeCustomerBindingSource
            // 
            this.homeCustomerBindingSource.DataMember = "HomeCustomer";
            this.homeCustomerBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "CustName", true));
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // Label22
            // 
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Name = "Label22";
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Address", true));
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Name = "txtAddress";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // BranchesDGView
            // 
            this.BranchesDGView.AllowUserToAddRows = false;
            resources.ApplyResources(this.BranchesDGView, "BranchesDGView");
            this.BranchesDGView.AutoGenerateColumns = false;
            this.BranchesDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchesDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BranchesDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchesDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustId,
            this.custNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.custTelDataGridViewTextBoxColumn,
            this.blockDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.gadaDataGridViewTextBoxColumn,
            this.bulidingDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.notesDataGridViewImageColumn});
            this.BranchesDGView.DataSource = this.homeCustomerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BranchesDGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BranchesDGView.EnableHeadersVisualStyles = false;
            this.BranchesDGView.MultiSelect = false;
            this.BranchesDGView.Name = "BranchesDGView";
            this.BranchesDGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchesDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.BranchesDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchesDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.BranchesDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BranchesDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BranchesDGView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StoresDGView_RowValidating);
            this.BranchesDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_CellValidated);
            this.BranchesDGView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoresDGView_RowLeave);
            this.BranchesDGView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StoresDGView_CellValidating);
            this.BranchesDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StoresDGView_RowsAdded);
            this.BranchesDGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BranchesDGView_CellMouseDoubleClick);
            this.BranchesDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StoresDGView_DataError);
            this.BranchesDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "block", true));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Name = "textBox1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "street", true));
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Gada", true));
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Name = "textBox3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Buliding", true));
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Name = "textBox4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // textBox5
            // 
            this.textBox5.AcceptsReturn = true;
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Flat", true));
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Name = "textBox5";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Cursor = System.Windows.Forms.Cursors.Default;
            this.label30.ForeColor = System.Drawing.Color.Blue;
            this.label30.Name = "label30";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Name = "label29";
            // 
            // recoderCodeTextBox
            // 
            resources.ApplyResources(this.recoderCodeTextBox, "recoderCodeTextBox");
            this.recoderCodeTextBox.Name = "recoderCodeTextBox";
            // 
            // textBox6
            // 
            this.textBox6.AcceptsReturn = true;
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "House", true));
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            this.textBox7.AcceptsReturn = true;
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Floor", true));
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Name = "textBox7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // textBox8
            // 
            this.textBox8.AcceptsReturn = true;
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCustomerBindingSource, "Notes", true));
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Name = "textBox8";
            // 
            // homeCustomerTableAdapter
            // 
            this.homeCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            resources.ApplyResources(this.CustId, "CustId");
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            resources.ApplyResources(this.custNameDataGridViewTextBoxColumn, "custNameDataGridViewTextBoxColumn");
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.addressDataGridViewTextBoxColumn, "addressDataGridViewTextBoxColumn");
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custTelDataGridViewTextBoxColumn
            // 
            this.custTelDataGridViewTextBoxColumn.DataPropertyName = "CustTel";
            resources.ApplyResources(this.custTelDataGridViewTextBoxColumn, "custTelDataGridViewTextBoxColumn");
            this.custTelDataGridViewTextBoxColumn.Name = "custTelDataGridViewTextBoxColumn";
            this.custTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blockDataGridViewTextBoxColumn
            // 
            this.blockDataGridViewTextBoxColumn.DataPropertyName = "block";
            resources.ApplyResources(this.blockDataGridViewTextBoxColumn, "blockDataGridViewTextBoxColumn");
            this.blockDataGridViewTextBoxColumn.Name = "blockDataGridViewTextBoxColumn";
            this.blockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            resources.ApplyResources(this.streetDataGridViewTextBoxColumn, "streetDataGridViewTextBoxColumn");
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gadaDataGridViewTextBoxColumn
            // 
            this.gadaDataGridViewTextBoxColumn.DataPropertyName = "Gada";
            resources.ApplyResources(this.gadaDataGridViewTextBoxColumn, "gadaDataGridViewTextBoxColumn");
            this.gadaDataGridViewTextBoxColumn.Name = "gadaDataGridViewTextBoxColumn";
            this.gadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bulidingDataGridViewTextBoxColumn
            // 
            this.bulidingDataGridViewTextBoxColumn.DataPropertyName = "Buliding";
            resources.ApplyResources(this.bulidingDataGridViewTextBoxColumn, "bulidingDataGridViewTextBoxColumn");
            this.bulidingDataGridViewTextBoxColumn.Name = "bulidingDataGridViewTextBoxColumn";
            this.bulidingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "Flat";
            resources.ApplyResources(this.flatDataGridViewTextBoxColumn, "flatDataGridViewTextBoxColumn");
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            this.flatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            resources.ApplyResources(this.houseDataGridViewTextBoxColumn, "houseDataGridViewTextBoxColumn");
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            resources.ApplyResources(this.floorDataGridViewTextBoxColumn, "floorDataGridViewTextBoxColumn");
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewImageColumn
            // 
            this.notesDataGridViewImageColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewImageColumn, "notesDataGridViewImageColumn");
            this.notesDataGridViewImageColumn.Name = "notesDataGridViewImageColumn";
            this.notesDataGridViewImageColumn.ReadOnly = true;
            // 
            // HomeCustomerAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.recoderCodeTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDel);
            this.Controls.Add(this.BranchesDGView);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telPhoneTextBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label22);
            this.Name = "HomeCustomerAdd";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.homeCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Label Label22;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label7;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.DataGridView BranchesDGView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox telPhoneTextBox;
        private System.Windows.Forms.BindingSource homeCustomerBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.HomeCustomerTableAdapter homeCustomerTableAdapter;
        public System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox recoderCodeTextBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulidingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn notesDataGridViewImageColumn;

    }
}