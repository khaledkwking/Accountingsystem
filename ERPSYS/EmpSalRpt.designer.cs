namespace ERPSYS
{
    partial class EmpSalRpt
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
            System.Windows.Forms.Label label43;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpSalRpt));
            System.Windows.Forms.Label label44;
            this.label5 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.cmbDepts = new System.Windows.Forms.ComboBox();
            this.cDEDEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.cmbEmpName = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpNo = new System.Windows.Forms.TextBox();
            this.cDE_DEPTTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.pRL_EMP_SAL_CALCULATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRL_EMP_SAL_CALCULATIONTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PRL_EMP_SAL_CALCULATIONTableAdapter();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtYEARCODE = new System.Windows.Forms.TextBox();
            this.cDEMONTHSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDE_MONTHSTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_MONTHSTableAdapter();
            label43 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRL_EMP_SAL_CALCULATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEMONTHSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label43
            // 
            resources.ApplyResources(label43, "label43");
            label43.ForeColor = System.Drawing.Color.Blue;
            label43.Name = "label43";
            // 
            // label44
            // 
            resources.ApplyResources(label44, "label44");
            label44.ForeColor = System.Drawing.Color.Blue;
            label44.Name = "label44";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDepts
            // 
            this.cmbDepts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepts.DataSource = this.cDEDEPTBindingSource;
            this.cmbDepts.DisplayMember = "DEPT_DESC";
            resources.ApplyResources(this.cmbDepts, "cmbDepts");
            this.cmbDepts.FormattingEnabled = true;
            this.cmbDepts.Name = "cmbDepts";
            this.cmbDepts.ValueMember = "DEPT_CODE";
            // 
            // cDEDEPTBindingSource
            // 
            this.cDEDEPTBindingSource.DataMember = "CDE_DEPT";
            this.cDEDEPTBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cmbEmpName
            // 
            this.cmbEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpName.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.cmbEmpName.DisplayMember = "FullName";
            resources.ApplyResources(this.cmbEmpName, "cmbEmpName");
            this.cmbEmpName.FormattingEnabled = true;
            this.cmbEmpName.Name = "cmbEmpName";
            this.cmbEmpName.ValueMember = "EMP_CODE";
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // EmpNo
            // 
            resources.ApplyResources(this.EmpNo, "EmpNo");
            this.EmpNo.Name = "EmpNo";
            // 
            // cDE_DEPTTableAdapter
            // 
            this.cDE_DEPTTableAdapter.ClearBeforeFill = true;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // pRL_EMP_SAL_CALCULATIONBindingSource
            // 
            this.pRL_EMP_SAL_CALCULATIONBindingSource.DataMember = "PRL_EMP_SAL_CALCULATION";
            this.pRL_EMP_SAL_CALCULATIONBindingSource.DataSource = this.personalDataSet;
            // 
            // pRL_EMP_SAL_CALCULATIONTableAdapter
            // 
            this.pRL_EMP_SAL_CALCULATIONTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DataSource = this.cDEMONTHSBindingSource;
            this.cmbMonth.DisplayMember = "MON_DESC";
            resources.ApplyResources(this.cmbMonth, "cmbMonth");
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.ValueMember = "MON_CODE";
            // 
            // txtYEARCODE
            // 
            resources.ApplyResources(this.txtYEARCODE, "txtYEARCODE");
            this.txtYEARCODE.Name = "txtYEARCODE";
            // 
            // cDEMONTHSBindingSource
            // 
            this.cDEMONTHSBindingSource.DataMember = "CDE_MONTHS";
            this.cDEMONTHSBindingSource.DataSource = this.personalDataSet;
            // 
            // cDE_MONTHSTableAdapter
            // 
            this.cDE_MONTHSTableAdapter.ClearBeforeFill = true;
            // 
            // EmpSalRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.txtYEARCODE);
            this.Controls.Add(label43);
            this.Controls.Add(label44);
            this.Controls.Add(this.EmpNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmpName);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.cmbDepts);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpSalRpt";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRL_EMP_SAL_CALCULATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEMONTHSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ComboBox cmbDepts;
        public System.Windows.Forms.Label label5;
        private NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.ComboBox cmbEmpName;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATotalBalance;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmpNo;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource cDEDEPTBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter cDE_DEPTTableAdapter;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.BindingSource pRL_EMP_SAL_CALCULATIONBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PRL_EMP_SAL_CALCULATIONTableAdapter pRL_EMP_SAL_CALCULATIONTableAdapter;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtYEARCODE;
        private System.Windows.Forms.BindingSource cDEMONTHSBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_MONTHSTableAdapter cDE_MONTHSTableAdapter;
       
        

    }
}