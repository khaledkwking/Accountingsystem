namespace ERPSYS
{
    partial class InstallmentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallmentAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSTART_DATE = new System.Windows.Forms.DateTimePicker();
            this.installmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtInstallmentValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbCollectorAccid = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlInstall = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbPaymentType = new System.Windows.Forms.ComboBox();
            this.txtInvId = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustAccId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblInvTotValue = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DistDGView = new System.Windows.Forms.DataGridView();
            this.installmentDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installment_DistributionTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter();
            this.installmentTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotInstall = new System.Windows.Forms.Label();
            this.distubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PayFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.tabControlInstall.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 436);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 58);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(401, 16);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(96, 36);
            this.CmdSave.TabIndex = 50;
            this.CmdSave.Text = "Õ›Ÿ";
            this.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(268, 16);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(96, 36);
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
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(713, 16);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 89;
            this.label8.Text = "«·Õ”«»";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(687, 48);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "Õ / «·„Õ’·";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtSTART_DATE
            // 
            this.dtSTART_DATE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "StartDate", true));
            this.dtSTART_DATE.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.installmentBindingSource, "StartDate", true));
            this.dtSTART_DATE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSTART_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSTART_DATE.Location = new System.Drawing.Point(495, 88);
            this.dtSTART_DATE.Name = "dtSTART_DATE";
            this.dtSTART_DATE.Size = new System.Drawing.Size(171, 22);
            this.dtSTART_DATE.TabIndex = 86;
            // 
            // installmentBindingSource
            // 
            this.installmentBindingSource.DataMember = "Installment";
            this.installmentBindingSource.DataSource = this.nEWERPDataSet;
            this.installmentBindingSource.PositionChanged += new System.EventHandler(this.installmentBindingSource_PositionChanged);
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "TotalValue", true));
            this.txtTotalValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalValue.Location = new System.Drawing.Point(28, 11);
            this.txtTotalValue.MaxLength = 0;
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalValue.Size = new System.Drawing.Size(186, 22);
            this.txtTotalValue.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(238, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "«·ﬁÌ„… «·„ﬁ”ÿÂ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "Notes", true));
            this.txtNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Location = new System.Drawing.Point(219, 271);
            this.txtNotes.MaxLength = 0;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(446, 78);
            this.txtNotes.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(707, 275);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "„·«ÕŸ« ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(715, 95);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(42, 18);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "«· «—ÌŒ";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInstallmentValue
            // 
            this.txtInstallmentValue.AcceptsReturn = true;
            this.txtInstallmentValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstallmentValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstallmentValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "InstallmentValue", true));
            this.txtInstallmentValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstallmentValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInstallmentValue.Location = new System.Drawing.Point(28, 48);
            this.txtInstallmentValue.MaxLength = 0;
            this.txtInstallmentValue.Name = "txtInstallmentValue";
            this.txtInstallmentValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInstallmentValue.Size = new System.Drawing.Size(186, 22);
            this.txtInstallmentValue.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(254, 48);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "ﬁÌ„… «·ﬁ”ÿ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Blue;
            this.label36.Location = new System.Drawing.Point(698, 207);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(59, 18);
            this.label36.TabIndex = 101;
            this.label36.Text = "√”„ «·ﬂ›Ì·";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdminName
            // 
            this.txtAdminName.AcceptsReturn = true;
            this.txtAdminName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "AdminName", true));
            this.txtAdminName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdminName.Location = new System.Drawing.Point(219, 197);
            this.txtAdminName.MaxLength = 0;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdminName.Size = new System.Drawing.Size(446, 25);
            this.txtAdminName.TabIndex = 102;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "PaymentDate", true));
            this.dtPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.installmentBindingSource, "PaymentDate", true));
            this.dtPaymentDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(495, 122);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(171, 22);
            this.dtPaymentDate.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(694, 128);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "»œ¡ «· ”œÌœ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(685, 242);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 105;
            this.label4.Text = "⁄‰Ê«‰ «·ﬂ›Ì·";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdminAddress
            // 
            this.txtAdminAddress.AcceptsReturn = true;
            this.txtAdminAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdminAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "AdminAddress", true));
            this.txtAdminAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdminAddress.Location = new System.Drawing.Point(219, 238);
            this.txtAdminAddress.MaxLength = 0;
            this.txtAdminAddress.Name = "txtAdminAddress";
            this.txtAdminAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdminAddress.Size = new System.Drawing.Size(446, 25);
            this.txtAdminAddress.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(694, 366);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 107;
            this.label9.Text = "«·ﬁÌ„… «·ﬂ·Ì…";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbCollectorAccid
            // 
            this.CmbCollectorAccid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCollectorAccid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCollectorAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.installmentBindingSource, "CollectorAccid", true));
            this.CmbCollectorAccid.DataSource = this.accountingBindingSource;
            this.CmbCollectorAccid.DisplayMember = "accountname";
            this.CmbCollectorAccid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbCollectorAccid.Location = new System.Drawing.Point(383, 45);
            this.CmbCollectorAccid.Name = "CmbCollectorAccid";
            this.CmbCollectorAccid.Size = new System.Drawing.Size(283, 24);
            this.CmbCollectorAccid.TabIndex = 109;
            this.CmbCollectorAccid.ValueMember = "accountid";
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // tabControlInstall
            // 
            this.tabControlInstall.Controls.Add(this.tabPage1);
            this.tabControlInstall.Controls.Add(this.tabPage2);
            this.tabControlInstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlInstall.Location = new System.Drawing.Point(0, 0);
            this.tabControlInstall.Name = "tabControlInstall";
            this.tabControlInstall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlInstall.RightToLeftLayout = true;
            this.tabControlInstall.SelectedIndex = 0;
            this.tabControlInstall.Size = new System.Drawing.Size(789, 440);
            this.tabControlInstall.TabIndex = 110;
            this.tabControlInstall.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.CmbPaymentType);
            this.tabPage1.Controls.Add(this.txtInvId);
            this.tabPage1.Controls.Add(this.txtCustId);
            this.tabPage1.Controls.Add(this.txtCustAccId);
            this.tabPage1.Controls.Add(this.txtCustName);
            this.tabPage1.Controls.Add(this.lblInvTotValue);
            this.tabPage1.Controls.Add(this.txtInstallmentValue);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CmbCollectorAccid);
            this.tabPage1.Controls.Add(this.txtTotalValue);
            this.tabPage1.Controls.Add(this.txtAdminAddress);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAdminName);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.dtPaymentDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.dtSTART_DATE);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ŒÌ«—« ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(687, 160);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 116;
            this.label10.Text = "ﬂÌ›Ì…«· ”œÌœ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbPaymentType
            // 
            this.CmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.installmentBindingSource, "TypeId", true));
            this.CmbPaymentType.DisplayMember = "Desc";
            this.CmbPaymentType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbPaymentType.Location = new System.Drawing.Point(482, 160);
            this.CmbPaymentType.Name = "CmbPaymentType";
            this.CmbPaymentType.Size = new System.Drawing.Size(184, 24);
            this.CmbPaymentType.TabIndex = 115;
            this.CmbPaymentType.ValueMember = "Id";
            // 
            // txtInvId
            // 
            this.txtInvId.AcceptsReturn = true;
            this.txtInvId.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "InvId", true));
            this.txtInvId.Enabled = false;
            this.txtInvId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvId.Location = new System.Drawing.Point(51, 166);
            this.txtInvId.MaxLength = 0;
            this.txtInvId.Name = "txtInvId";
            this.txtInvId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInvId.Size = new System.Drawing.Size(0, 22);
            this.txtInvId.TabIndex = 114;
            // 
            // txtCustId
            // 
            this.txtCustId.AcceptsReturn = true;
            this.txtCustId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "CustID", true));
            this.txtCustId.Enabled = false;
            this.txtCustId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustId.Location = new System.Drawing.Point(51, 122);
            this.txtCustId.MaxLength = 0;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustId.Size = new System.Drawing.Size(0, 22);
            this.txtCustId.TabIndex = 113;
            // 
            // txtCustAccId
            // 
            this.txtCustAccId.AcceptsReturn = true;
            this.txtCustAccId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustAccId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustAccId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installmentBindingSource, "CustAccid", true));
            this.txtCustAccId.Enabled = false;
            this.txtCustAccId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAccId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustAccId.Location = new System.Drawing.Point(51, 88);
            this.txtCustAccId.MaxLength = 0;
            this.txtCustAccId.Name = "txtCustAccId";
            this.txtCustAccId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustAccId.Size = new System.Drawing.Size(0, 22);
            this.txtCustAccId.TabIndex = 112;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.Enabled = false;
            this.txtCustName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustName.Location = new System.Drawing.Point(383, 15);
            this.txtCustName.MaxLength = 0;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustName.Size = new System.Drawing.Size(283, 22);
            this.txtCustName.TabIndex = 111;
            // 
            // lblInvTotValue
            // 
            this.lblInvTotValue.AutoSize = true;
            this.lblInvTotValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvTotValue.Location = new System.Drawing.Point(594, 364);
            this.lblInvTotValue.Name = "lblInvTotValue";
            this.lblInvTotValue.Size = new System.Drawing.Size(65, 18);
            this.lblInvTotValue.TabIndex = 110;
            this.lblInvTotValue.Text = "label10";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotInstall);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.DistDGView);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "«·«ﬁ”«ÿ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DistDGView
            // 
            this.DistDGView.AllowUserToAddRows = false;
            this.DistDGView.AllowUserToDeleteRows = false;
            this.DistDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DistDGView.AutoGenerateColumns = false;
            this.DistDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DistDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DistDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distubIdDataGridViewTextBoxColumn,
            this.installIdDataGridViewTextBoxColumn,
            this.distDateDataGridViewTextBoxColumn,
            this.distValue,
            this.RequiredFlag,
            this.PayFlag});
            this.DistDGView.DataSource = this.installmentDistributionBindingSource;
            this.DistDGView.EnableHeadersVisualStyles = false;
            this.DistDGView.Location = new System.Drawing.Point(8, 9);
            this.DistDGView.MultiSelect = false;
            this.DistDGView.Name = "DistDGView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DistDGView.RowHeadersWidth = 45;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DistDGView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DistDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DistDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.DistDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DistDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DistDGView.Size = new System.Drawing.Size(762, 361);
            this.DistDGView.TabIndex = 93;
            this.DistDGView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DistDGView_CellValidated);
            this.DistDGView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DistDGView_RowsAdded);
            this.DistDGView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DistDGView_CellValueChanged);
            this.DistDGView.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DistDGView_CellValuePushed);
            // 
            // installmentDistributionBindingSource
            // 
            this.installmentDistributionBindingSource.DataMember = "Installment_Distribution";
            this.installmentDistributionBindingSource.DataSource = this.nEWERPDataSet;
            this.installmentDistributionBindingSource.PositionChanged += new System.EventHandler(this.installmentDistributionBindingSource_PositionChanged);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(625, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "«·„Ã„Ê⁄ «·ﬂ·Ï ··«ﬁ”«ÿ :";
            // 
            // lblTotInstall
            // 
            this.lblTotInstall.AutoSize = true;
            this.lblTotInstall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotInstall.ForeColor = System.Drawing.Color.Blue;
            this.lblTotInstall.Location = new System.Drawing.Point(527, 383);
            this.lblTotInstall.Name = "lblTotInstall";
            this.lblTotInstall.Size = new System.Drawing.Size(18, 19);
            this.lblTotInstall.TabIndex = 95;
            this.lblTotInstall.Text = "0";
            // 
            // distubIdDataGridViewTextBoxColumn
            // 
            this.distubIdDataGridViewTextBoxColumn.DataPropertyName = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.HeaderText = "DistubId";
            this.distubIdDataGridViewTextBoxColumn.Name = "distubIdDataGridViewTextBoxColumn";
            this.distubIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.distDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.distDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «·«” Õﬁ«ﬁ";
            this.distDateDataGridViewTextBoxColumn.Name = "distDateDataGridViewTextBoxColumn";
            this.distDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // distValue
            // 
            this.distValue.DataPropertyName = "DistValue";
            this.distValue.HeaderText = "ﬁÌ„… «·ﬁ”ÿ";
            this.distValue.Name = "distValue";
            this.distValue.Width = 200;
            // 
            // RequiredFlag
            // 
            this.RequiredFlag.DataPropertyName = "RequiredFlag";
            this.RequiredFlag.HeaderText = "√” Õﬁ«ﬁ";
            this.RequiredFlag.Name = "RequiredFlag";
            this.RequiredFlag.ReadOnly = true;
            // 
            // PayFlag
            // 
            this.PayFlag.DataPropertyName = "PayFlag";
            this.PayFlag.HeaderText = " ”œÌœ";
            this.PayFlag.Name = "PayFlag";
            this.PayFlag.ReadOnly = true;
            // 
            // InstallmentAdd
            // 
            this.AcceptButton = this.CmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(789, 494);
            this.Controls.Add(this.tabControlInstall);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallmentAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ﬁ”Ìÿ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.tabControlInstall.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDistributionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.TextBox txtTotalValue;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSTART_DATE;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtInstallmentValue;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtAdminAddress;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbCollectorAccid;
        private System.Windows.Forms.TabControl tabControlInstall;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInvTotValue;
        internal System.Windows.Forms.DataGridView DistDGView;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource installmentDistributionBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.Installment_DistributionTableAdapter installment_DistributionTableAdapter;
        private System.Windows.Forms.BindingSource installmentBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.InstallmentTableAdapter installmentTableAdapter;
        public System.Windows.Forms.TextBox txtCustName;
        public System.Windows.Forms.TextBox txtCustId;
        public System.Windows.Forms.TextBox txtCustAccId;
        public System.Windows.Forms.TextBox txtInvId;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbPaymentType;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.Label lblTotInstall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn distubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiredFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PayFlag;

    }
}