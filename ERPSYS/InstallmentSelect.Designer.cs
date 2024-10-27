namespace ERPSYS
{
    partial class InstallmentSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallmentSelect));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCollectorAccid = new System.Windows.Forms.ComboBox();
            this.cmbCustaccId = new System.Windows.Forms.ComboBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.RequiredFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PayFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.radioBtnReqired = new System.Windows.Forms.RadioButton();
            this.radioBtnPayment = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installmentDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installment_DistributionTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter();
            this.installmentTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.accountingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchBtn);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(654, 54);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(344, 15);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBtn.Size = new System.Drawing.Size(86, 33);
            this.SearchBtn.TabIndex = 133;
            this.SearchBtn.Text = "√” ⁄—«÷";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(225, 15);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(89, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(22, 15);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "«·Õ”«»";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(22, 53);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Õ / «·„Õ’·";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(272, 83);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(21, 22);
            this.dtPaymentDate.TabIndex = 103;
            this.dtPaymentDate.ValueChanged += new System.EventHandler(this.dtPaymentDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "„‰ «· «—ÌŒ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbCollectorAccid
            // 
            this.CmbCollectorAccid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCollectorAccid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCollectorAccid.DataSource = this.accountingBindingSource;
            this.CmbCollectorAccid.DisplayMember = "accountname";
            this.CmbCollectorAccid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbCollectorAccid.Location = new System.Drawing.Point(92, 48);
            this.CmbCollectorAccid.Name = "CmbCollectorAccid";
            this.CmbCollectorAccid.Size = new System.Drawing.Size(262, 24);
            this.CmbCollectorAccid.TabIndex = 109;
            this.CmbCollectorAccid.ValueMember = "accountid";
            // 
            // cmbCustaccId
            // 
            this.cmbCustaccId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustaccId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustaccId.DataSource = this.accountingBindingSource1;
            this.cmbCustaccId.DisplayMember = "accountname";
            this.cmbCustaccId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbCustaccId.Location = new System.Drawing.Point(92, 12);
            this.cmbCustaccId.Name = "cmbCustaccId";
            this.cmbCustaccId.Size = new System.Drawing.Size(262, 24);
            this.cmbCustaccId.TabIndex = 110;
            this.cmbCustaccId.ValueMember = "accountid";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFromDate.Location = new System.Drawing.Point(92, 83);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(178, 22);
            this.txtFromDate.TabIndex = 131;
            // 
            // RequiredFlag
            // 
            this.RequiredFlag.DataPropertyName = "RequiredFlag";
            this.RequiredFlag.HeaderText = " „ «·«” Õﬁ«ﬁ";
            this.RequiredFlag.Name = "RequiredFlag";
            // 
            // PayFlag
            // 
            this.PayFlag.DataPropertyName = "PayFlag";
            this.PayFlag.HeaderText = " „ «· ”œÌœ";
            this.PayFlag.Name = "PayFlag";
            // 
            // distubIdDataGridViewTextBoxColumn
            // 
            this.distubIdDataGridViewTextBoxColumn.DataPropertyName = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.HeaderText = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.Name = "distubIdDataGridViewTextBoxColumn";
            this.distubIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // installIdDataGridViewTextBoxColumn
            // 
            this.installIdDataGridViewTextBoxColumn.DataPropertyName = "InstallId";
            this.installIdDataGridViewTextBoxColumn.HeaderText = "InstallId";
            this.installIdDataGridViewTextBoxColumn.Name = "installIdDataGridViewTextBoxColumn";
            this.installIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // distDateDataGridViewTextBoxColumn
            // 
            this.distDateDataGridViewTextBoxColumn.DataPropertyName = "DistDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.distDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.distDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.distDateDataGridViewTextBoxColumn.Name = "distDateDataGridViewTextBoxColumn";
            this.distDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // distValueDataGridViewTextBoxColumn
            // 
            this.distValueDataGridViewTextBoxColumn.DataPropertyName = "DistValue";
            this.distValueDataGridViewTextBoxColumn.HeaderText = "ﬁÌ„… «·ﬁ”ÿ";
            this.distValueDataGridViewTextBoxColumn.Name = "distValueDataGridViewTextBoxColumn";
            this.distValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtToDate.Location = new System.Drawing.Point(92, 116);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(178, 22);
            this.txtToDate.TabIndex = 134;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 22);
            this.dateTimePicker1.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "«·Ï «· «—ÌŒ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioBtnAll
            // 
            this.radioBtnAll.AutoSize = true;
            this.radioBtnAll.Location = new System.Drawing.Point(149, 19);
            this.radioBtnAll.Name = "radioBtnAll";
            this.radioBtnAll.Size = new System.Drawing.Size(50, 18);
            this.radioBtnAll.TabIndex = 135;
            this.radioBtnAll.TabStop = true;
            this.radioBtnAll.Text = "«·ﬂ·";
            this.radioBtnAll.UseVisualStyleBackColor = true;
            // 
            // radioBtnReqired
            // 
            this.radioBtnReqired.AutoSize = true;
            this.radioBtnReqired.Location = new System.Drawing.Point(64, 48);
            this.radioBtnReqired.Name = "radioBtnReqired";
            this.radioBtnReqired.Size = new System.Drawing.Size(135, 18);
            this.radioBtnReqired.TabIndex = 135;
            this.radioBtnReqired.TabStop = true;
            this.radioBtnReqired.Text = "«·«ﬁ”«ÿ «·„” Õﬁ…";
            this.radioBtnReqired.UseVisualStyleBackColor = true;
            // 
            // radioBtnPayment
            // 
            this.radioBtnPayment.AutoSize = true;
            this.radioBtnPayment.Location = new System.Drawing.Point(72, 77);
            this.radioBtnPayment.Name = "radioBtnPayment";
            this.radioBtnPayment.Size = new System.Drawing.Size(127, 18);
            this.radioBtnPayment.TabIndex = 135;
            this.radioBtnPayment.TabStop = true;
            this.radioBtnPayment.Text = "«·«ﬁ”«ÿ «·„”œœ…";
            this.radioBtnPayment.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPayment);
            this.groupBox1.Controls.Add(this.radioBtnAll);
            this.groupBox1.Controls.Add(this.radioBtnReqired);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(421, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 115);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "√ŸÂ«—";
            // 
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // installmentBindingSource
            // 
            this.installmentBindingSource.DataMember = "Installment";
            this.installmentBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // installmentDistributionBindingSource
            // 
            this.installmentDistributionBindingSource.DataMember = "Installment_Distribution";
            this.installmentDistributionBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // installment_DistributionTableAdapter
            // 
            this.installment_DistributionTableAdapter.ClearBeforeFill = true;
            // 
            // installmentTableAdapter
            // 
            this.installmentTableAdapter.ClearBeforeFill = true;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // accountingBindingSource2
            // 
            this.accountingBindingSource2.DataMember = "accounting";
            this.accountingBindingSource2.DataSource = this.nEWERPDataSet;
            // 
            // accountingBindingSource3
            // 
            this.accountingBindingSource3.DataMember = "accounting";
            this.accountingBindingSource3.DataSource = this.nEWERPDataSet;
            // 
            // InstallmentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(654, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.cmbCustaccId);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCollectorAccid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallmentSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "√” ⁄—«÷ «·«ﬁ”«ÿ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCollectorAccid;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource installmentDistributionBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter installment_DistributionTableAdapter;
        private System.Windows.Forms.BindingSource installmentBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter installmentTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.ComboBox cmbCustaccId;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.BindingSource accountingBindingSource2;
        private System.Windows.Forms.BindingSource accountingBindingSource3;
     
    
    
      
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiredFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PayFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn distubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distValueDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnAll;
        private System.Windows.Forms.RadioButton radioBtnReqired;
        private System.Windows.Forms.RadioButton radioBtnPayment;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}