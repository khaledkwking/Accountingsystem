namespace ERPSYS
{
    partial class EmpAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpAdd));
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.cDENATIONALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDEGOVERNORATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDEDEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpAccountId = new System.Windows.Forms.TextBox();
            this.salesAdminFalgCheckBox = new System.Windows.Forms.CheckBox();
            this.CmbEmpMatStatus = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.CmbEmpNat = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CmbEmpGender = new System.Windows.Forms.ComboBox();
            this.dtEmpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.CmbEmpDept = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPassPlace = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCivilId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassportNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpEngName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.cDE_NATIONALITYTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter();
            this.cDE_GOVERNORATETableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_GOVERNORATETableAdapter();
            this.cDE_DEPTTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter();
            this.cDEMONTHSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cDE_MONTHSTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_MONTHSTableAdapter();
            this.setupCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupCodesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEGOVERNORATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEMONTHSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            this.pEREMPLOYEEDATABindingSource.PositionChanged += new System.EventHandler(this.pEREMPLOYEEDATABindingSource_PositionChanged);
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDENATIONALITYBindingSource
            // 
            this.cDENATIONALITYBindingSource.DataMember = "CDE_NATIONALITY";
            this.cDENATIONALITYBindingSource.DataSource = this.personalDataSet;
            // 
            // cDEGOVERNORATEBindingSource
            // 
            this.cDEGOVERNORATEBindingSource.DataMember = "CDE_GOVERNORATE";
            this.cDEGOVERNORATEBindingSource.DataSource = this.personalDataSet;
            // 
            // cDEDEPTBindingSource
            // 
            this.cDEDEPTBindingSource.DataMember = "CDE_DEPT";
            this.cDEDEPTBindingSource.DataSource = this.personalDataSet;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Name = "label28";
            // 
            // txtcom
            // 
            this.txtcom.BackColor = System.Drawing.SystemColors.Window;
            this.txtcom.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtcom, "txtcom");
            this.txtcom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcom.Name = "txtcom";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // txtEmpAccountId
            // 
            this.txtEmpAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "AccountID", true));
            resources.ApplyResources(this.txtEmpAccountId, "txtEmpAccountId");
            this.txtEmpAccountId.Name = "txtEmpAccountId";
            // 
            // salesAdminFalgCheckBox
            // 
            this.salesAdminFalgCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pEREMPLOYEEDATABindingSource, "SalesAdminFalg", true));
            resources.ApplyResources(this.salesAdminFalgCheckBox, "salesAdminFalgCheckBox");
            this.salesAdminFalgCheckBox.Name = "salesAdminFalgCheckBox";
            this.salesAdminFalgCheckBox.CheckedChanged += new System.EventHandler(this.salesAdminFalgCheckBox_CheckedChanged);
            // 
            // CmbEmpMatStatus
            // 
            resources.ApplyResources(this.CmbEmpMatStatus, "CmbEmpMatStatus");
            this.CmbEmpMatStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pEREMPLOYEEDATABindingSource, "MARITAL_STATUS_CODE", true));
            this.CmbEmpMatStatus.DisplayMember = "DESC";
            this.CmbEmpMatStatus.FormattingEnabled = true;
            this.CmbEmpMatStatus.Name = "CmbEmpMatStatus";
            this.CmbEmpMatStatus.ValueMember = "ID";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.label27.ForeColor = System.Drawing.Color.Blue;
            this.label27.Name = "label27";
            // 
            // CmbEmpNat
            // 
            resources.ApplyResources(this.CmbEmpNat, "CmbEmpNat");
            this.CmbEmpNat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pEREMPLOYEEDATABindingSource, "NATIONALITY_CODE", true));
            this.CmbEmpNat.DataSource = this.cDENATIONALITYBindingSource;
            this.CmbEmpNat.DisplayMember = "NATIONALITY_DESC";
            this.CmbEmpNat.FormattingEnabled = true;
            this.CmbEmpNat.Name = "CmbEmpNat";
            this.CmbEmpNat.ValueMember = "NATIONALITY_CODE";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Name = "label22";
            // 
            // CmbEmpGender
            // 
            resources.ApplyResources(this.CmbEmpGender, "CmbEmpGender");
            this.CmbEmpGender.DisplayMember = "DESC";
            this.CmbEmpGender.FormattingEnabled = true;
            this.CmbEmpGender.Name = "CmbEmpGender";
            this.CmbEmpGender.ValueMember = "ID";
            // 
            // dtEmpBirthDate
            // 
            resources.ApplyResources(this.dtEmpBirthDate, "dtEmpBirthDate");
            this.dtEmpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "EMP_BIRTH_DATE", true));
            this.dtEmpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pEREMPLOYEEDATABindingSource, "EMP_BIRTH_DATE", true));
            this.dtEmpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmpBirthDate.Name = "dtEmpBirthDate";
            // 
            // dtEndHireDate
            // 
            resources.ApplyResources(this.dtEndHireDate, "dtEndHireDate");
            this.dtEndHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "Emp_End_HIREDATE", true));
            this.dtEndHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pEREMPLOYEEDATABindingSource, "Emp_End_HIREDATE", true));
            this.dtEndHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndHireDate.Name = "dtEndHireDate";
            // 
            // dtHireDate
            // 
            resources.ApplyResources(this.dtHireDate, "dtHireDate");
            this.dtHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "EMP_HIREDATE", true));
            this.dtHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pEREMPLOYEEDATABindingSource, "EMP_HIREDATE", true));
            this.dtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHireDate.Name = "dtHireDate";
            // 
            // CmbEmpDept
            // 
            resources.ApplyResources(this.CmbEmpDept, "CmbEmpDept");
            this.CmbEmpDept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pEREMPLOYEEDATABindingSource, "DEPTCODE", true));
            this.CmbEmpDept.DataSource = this.cDEDEPTBindingSource;
            this.CmbEmpDept.DisplayMember = "DEPT_DESC";
            this.CmbEmpDept.FormattingEnabled = true;
            this.CmbEmpDept.Name = "CmbEmpDept";
            this.CmbEmpDept.ValueMember = "DEPT_CODE";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Name = "label19";
            // 
            // txtPassPlace
            // 
            this.txtPassPlace.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "passplace", true));
            resources.ApplyResources(this.txtPassPlace, "txtPassPlace");
            this.txtPassPlace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassPlace.Name = "txtPassPlace";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtEmpAddress, "txtEmpAddress");
            this.txtEmpAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpAddress.Name = "txtEmpAddress";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // txtPassType
            // 
            this.txtPassType.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "passtype", true));
            resources.ApplyResources(this.txtPassType, "txtPassType");
            this.txtPassType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassType.Name = "txtPassType";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // txtCivilId
            // 
            this.txtCivilId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCivilId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCivilId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "FEngName", true));
            resources.ApplyResources(this.txtCivilId, "txtCivilId");
            this.txtCivilId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCivilId.Name = "txtCivilId";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Name = "label15";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
            // 
            // txtPassportNo
            // 
            this.txtPassportNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassportNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassportNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "passportNo", true));
            resources.ApplyResources(this.txtPassportNo, "txtPassportNo");
            this.txtPassportNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassportNo.Name = "txtPassportNo";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // txtEmpEngName
            // 
            this.txtEmpEngName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpEngName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpEngName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "CIVILID", true));
            resources.ApplyResources(this.txtEmpEngName, "txtEmpEngName");
            this.txtEmpEngName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpEngName.Name = "txtEmpEngName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "FullName", true));
            resources.ApplyResources(this.txtEmpName, "txtEmpName");
            this.txtEmpName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpName.Name = "txtEmpName";
            // 
            // lblEmpName
            // 
            resources.ApplyResources(this.lblEmpName, "lblEmpName");
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmpName.ForeColor = System.Drawing.Color.Blue;
            this.lblEmpName.Name = "lblEmpName";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEREMPLOYEEDATABindingSource, "EMP_CODE", true));
            resources.ApplyResources(this.txtEmpCode, "txtEmpCode");
            this.txtEmpCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpCode.Name = "txtEmpCode";
            // 
            // lblEmpCode
            // 
            resources.ApplyResources(this.lblEmpCode, "lblEmpCode");
            this.lblEmpCode.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmpCode.ForeColor = System.Drawing.Color.Blue;
            this.lblEmpCode.Name = "lblEmpCode";
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // cDE_NATIONALITYTableAdapter
            // 
            this.cDE_NATIONALITYTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_GOVERNORATETableAdapter
            // 
            this.cDE_GOVERNORATETableAdapter.ClearBeforeFill = true;
            // 
            // cDE_DEPTTableAdapter
            // 
            this.cDE_DEPTTableAdapter.ClearBeforeFill = true;
            // 
            // cDEMONTHSBindingSource
            // 
            this.cDEMONTHSBindingSource.DataMember = "CDE_MONTHS";
            this.cDEMONTHSBindingSource.DataSource = this.personalDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDE_MONTHSTableAdapter
            // 
            this.cDE_MONTHSTableAdapter.ClearBeforeFill = true;
            // 
            // setupCodesBindingSource
            // 
            this.setupCodesBindingSource.DataMember = "SetupCodes";
            this.setupCodesBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupCodesTableAdapter
            // 
            this.setupCodesTableAdapter.ClearBeforeFill = true;
            // 
            // EmpAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CausesValidation = false;
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.txtEmpAccountId);
            this.Controls.Add(this.salesAdminFalgCheckBox);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.CmbEmpMatStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtEmpEngName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassportNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCivilId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbEmpNat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.CmbEmpGender);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtEmpBirthDate);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.dtEndHireDate);
            this.Controls.Add(this.dtHireDate);
            this.Controls.Add(this.CmbEmpDept);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPassPlace);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpAdd";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEGOVERNORATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEMONTHSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.BindingSource cDENATIONALITYBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter cDE_NATIONALITYTableAdapter;
        private System.Windows.Forms.BindingSource cDEGOVERNORATEBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_GOVERNORATETableAdapter cDE_GOVERNORATETableAdapter;
        private System.Windows.Forms.BindingSource cDEDEPTBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter cDE_DEPTTableAdapter;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource cDEMONTHSBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_MONTHSTableAdapter cDE_MONTHSTableAdapter;
        internal System.Windows.Forms.ComboBox CmbEmpMatStatus;
        public System.Windows.Forms.Label label27;
        internal System.Windows.Forms.ComboBox CmbEmpNat;
        public System.Windows.Forms.Label label22;
        internal System.Windows.Forms.ComboBox CmbEmpGender;
        private System.Windows.Forms.DateTimePicker dtEmpBirthDate;
        private System.Windows.Forms.DateTimePicker dtEndHireDate;
        private System.Windows.Forms.DateTimePicker dtHireDate;
        internal System.Windows.Forms.ComboBox CmbEmpDept;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtPassPlace;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtEmpAddress;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPassType;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCivilId;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPassportNo;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtEmpEngName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmpName;
        public System.Windows.Forms.Label lblEmpName;
        public System.Windows.Forms.TextBox txtEmpCode;
        public System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.BindingSource setupCodesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter setupCodesTableAdapter;
        public System.Windows.Forms.TextBox txtEmpAccountId;
        public System.Windows.Forms.TextBox txtcom;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.CheckBox salesAdminFalgCheckBox;
      
        

    }
}