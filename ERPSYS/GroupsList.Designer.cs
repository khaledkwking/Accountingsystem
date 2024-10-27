namespace ERPSYS
{
    partial class GroupsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsList));
            this.SaveCmd = new System.Windows.Forms.Button();
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.empGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.emp_GroupsTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.Emp_GroupsTableAdapter();
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMonthDays = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSickVac = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.applyVactionDaysCheckBox = new System.Windows.Forms.CheckBox();
            this.absenceDayPercentageTextBox = new System.Windows.Forms.TextBox();
            this.hourInVactionTextBox = new System.Windows.Forms.TextBox();
            this.additionPercentageTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.absenceHourPercentageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vactionNumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workHourTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryCulComboBox = new System.Windows.Forms.ComboBox();
            this.nutalAttendanceComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.loanAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.taxAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salaryAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.bindingNavigatorInv = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControlProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInv)).BeginInit();
            this.bindingNavigatorInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveCmd
            // 
            resources.ApplyResources(this.SaveCmd, "SaveCmd");
            this.SaveCmd.ForeColor = System.Drawing.Color.Black;
            this.SaveCmd.Name = "SaveCmd";
            this.SaveCmd.UseVisualStyleBackColor = true;
            this.SaveCmd.Click += new System.EventHandler(this.SaveCmd_Click);
            // 
            // DelCmd
            // 
            resources.ApplyResources(this.DelCmd, "DelCmd");
            this.DelCmd.ForeColor = System.Drawing.Color.Black;
            this.DelCmd.Name = "DelCmd";
            this.DelCmd.UseVisualStyleBackColor = true;
            this.DelCmd.Click += new System.EventHandler(this.DelCmd_Click);
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
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.AcceptsReturn = true;
            this.txtGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "GroupName", true));
            resources.ApplyResources(this.txtGroupName, "txtGroupName");
            this.txtGroupName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupName.Name = "txtGroupName";
            // 
            // empGroupsBindingSource
            // 
            this.empGroupsBindingSource.DataMember = "Emp_Groups";
            this.empGroupsBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // emp_GroupsTableAdapter
            // 
            this.emp_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Controls.Add(this.tabPage1);
            this.tabControlProduct.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControlProduct, "tabControlProduct");
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.txtMonthDays);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtSickVac);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.applyVactionDaysCheckBox);
            this.tabPage1.Controls.Add(this.absenceDayPercentageTextBox);
            this.tabPage1.Controls.Add(this.hourInVactionTextBox);
            this.tabPage1.Controls.Add(this.additionPercentageTextBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.absenceHourPercentageTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.vactionNumTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.workHourTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.defDateTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.salaryCulComboBox);
            this.tabPage1.Controls.Add(this.nutalAttendanceComboBox);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMonthDays
            // 
            this.txtMonthDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "SickVactionNum", true));
            resources.ApplyResources(this.txtMonthDays, "txtMonthDays");
            this.txtMonthDays.Name = "txtMonthDays";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Name = "label19";
            // 
            // txtSickVac
            // 
            this.txtSickVac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "SickVactionNum", true));
            resources.ApplyResources(this.txtSickVac, "txtSickVac");
            this.txtSickVac.Name = "txtSickVac";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Name = "label16";
            // 
            // applyVactionDaysCheckBox
            // 
            this.applyVactionDaysCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.empGroupsBindingSource, "ApplyVactionDays", true));
            resources.ApplyResources(this.applyVactionDaysCheckBox, "applyVactionDaysCheckBox");
            this.applyVactionDaysCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.applyVactionDaysCheckBox.Name = "applyVactionDaysCheckBox";
            // 
            // absenceDayPercentageTextBox
            // 
            this.absenceDayPercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "AbsenceDayPercentage", true));
            resources.ApplyResources(this.absenceDayPercentageTextBox, "absenceDayPercentageTextBox");
            this.absenceDayPercentageTextBox.Name = "absenceDayPercentageTextBox";
            // 
            // hourInVactionTextBox
            // 
            this.hourInVactionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "HourInVaction", true));
            resources.ApplyResources(this.hourInVactionTextBox, "hourInVactionTextBox");
            this.hourInVactionTextBox.Name = "hourInVactionTextBox";
            // 
            // additionPercentageTextBox
            // 
            this.additionPercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "AdditionPercentage", true));
            resources.ApplyResources(this.additionPercentageTextBox, "additionPercentageTextBox");
            this.additionPercentageTextBox.Name = "additionPercentageTextBox";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // absenceHourPercentageTextBox
            // 
            this.absenceHourPercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "AbsenceHourPercentage", true));
            resources.ApplyResources(this.absenceHourPercentageTextBox, "absenceHourPercentageTextBox");
            this.absenceHourPercentageTextBox.Name = "absenceHourPercentageTextBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // vactionNumTextBox
            // 
            this.vactionNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "VactionNum", true));
            resources.ApplyResources(this.vactionNumTextBox, "vactionNumTextBox");
            this.vactionNumTextBox.Name = "vactionNumTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // workHourTextBox
            // 
            this.workHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "WorkHour", true));
            resources.ApplyResources(this.workHourTextBox, "workHourTextBox");
            this.workHourTextBox.Name = "workHourTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // defDateTextBox
            // 
            this.defDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "DefDate", true));
            resources.ApplyResources(this.defDateTextBox, "defDateTextBox");
            this.defDateTextBox.Name = "defDateTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // salaryCulComboBox
            // 
            this.salaryCulComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "SalaryCul", true));
            this.salaryCulComboBox.DisplayMember = "DESC";
            this.salaryCulComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.salaryCulComboBox, "salaryCulComboBox");
            this.salaryCulComboBox.Name = "salaryCulComboBox";
            this.salaryCulComboBox.ValueMember = "ID";
            // 
            // nutalAttendanceComboBox
            // 
            this.nutalAttendanceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "NutalAttendance", true));
            this.nutalAttendanceComboBox.DisplayMember = "DESC";
            this.nutalAttendanceComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.nutalAttendanceComboBox, "nutalAttendanceComboBox");
            this.nutalAttendanceComboBox.Name = "nutalAttendanceComboBox";
            this.nutalAttendanceComboBox.ValueMember = "ID";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.boxAccountIdComboBox);
            this.tabPage2.Controls.Add(this.loanAccountIdComboBox);
            this.tabPage2.Controls.Add(this.taxAccountIdComboBox);
            this.tabPage2.Controls.Add(this.salaryAccountIdComboBox);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // boxAccountIdComboBox
            // 
            this.boxAccountIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "BoxAccountId", true));
            this.boxAccountIdComboBox.DataSource = this.accountingBindingSource3;
            this.boxAccountIdComboBox.DisplayMember = "accountname";
            this.boxAccountIdComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.boxAccountIdComboBox, "boxAccountIdComboBox");
            this.boxAccountIdComboBox.Name = "boxAccountIdComboBox";
            this.boxAccountIdComboBox.ValueMember = "accountid";
            // 
            // accountingBindingSource3
            // 
            this.accountingBindingSource3.DataMember = "accounting";
            this.accountingBindingSource3.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanAccountIdComboBox
            // 
            this.loanAccountIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "LoanAccountId", true));
            this.loanAccountIdComboBox.DataSource = this.accountingBindingSource2;
            this.loanAccountIdComboBox.DisplayMember = "accountname";
            this.loanAccountIdComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.loanAccountIdComboBox, "loanAccountIdComboBox");
            this.loanAccountIdComboBox.Name = "loanAccountIdComboBox";
            this.loanAccountIdComboBox.ValueMember = "accountid";
            // 
            // accountingBindingSource2
            // 
            this.accountingBindingSource2.DataMember = "accounting";
            this.accountingBindingSource2.DataSource = this.nEWERPDataSet;
            // 
            // taxAccountIdComboBox
            // 
            this.taxAccountIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "TaxAccountId", true));
            this.taxAccountIdComboBox.DataSource = this.accountingBindingSource1;
            this.taxAccountIdComboBox.DisplayMember = "accountname";
            this.taxAccountIdComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.taxAccountIdComboBox, "taxAccountIdComboBox");
            this.taxAccountIdComboBox.Name = "taxAccountIdComboBox";
            this.taxAccountIdComboBox.ValueMember = "accountid";
            // 
            // accountingBindingSource1
            // 
            this.accountingBindingSource1.DataMember = "accounting";
            this.accountingBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // salaryAccountIdComboBox
            // 
            this.salaryAccountIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empGroupsBindingSource, "SalaryAccountId", true));
            this.salaryAccountIdComboBox.DataSource = this.accountingBindingSource;
            this.salaryAccountIdComboBox.DisplayMember = "accountname";
            this.salaryAccountIdComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.salaryAccountIdComboBox, "salaryAccountIdComboBox");
            this.salaryAccountIdComboBox.Name = "salaryAccountIdComboBox";
            this.salaryAccountIdComboBox.ValueMember = "accountid";
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorInv
            // 
            this.bindingNavigatorInv.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorInv.BindingSource = this.empGroupsBindingSource;
            this.bindingNavigatorInv.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorInv.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorInv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            resources.ApplyResources(this.bindingNavigatorInv, "bindingNavigatorInv");
            this.bindingNavigatorInv.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorInv.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorInv.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorInv.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorInv.Name = "bindingNavigatorInv";
            this.bindingNavigatorInv.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Name = "label17";
            // 
            // GroupsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bindingNavigatorInv);
            this.Controls.Add(this.tabControlProduct);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Name = "GroupsList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControlProduct.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInv)).EndInit();
            this.bindingNavigatorInv.ResumeLayout(false);
            this.bindingNavigatorInv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txtGroupName;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource empGroupsBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.Emp_GroupsTableAdapter emp_GroupsTableAdapter;
        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox salaryCulComboBox;
        private System.Windows.Forms.ComboBox nutalAttendanceComboBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defDateTextBox;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox workHourTextBox;
        private System.Windows.Forms.TextBox vactionNumTextBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox absenceHourPercentageTextBox;
        private System.Windows.Forms.TextBox additionPercentageTextBox;
        private System.Windows.Forms.TextBox hourInVactionTextBox;
        private System.Windows.Forms.TextBox absenceDayPercentageTextBox;
        private System.Windows.Forms.CheckBox applyVactionDaysCheckBox;
        private System.Windows.Forms.ComboBox boxAccountIdComboBox;
        private System.Windows.Forms.ComboBox loanAccountIdComboBox;
        private System.Windows.Forms.ComboBox taxAccountIdComboBox;
        private System.Windows.Forms.ComboBox salaryAccountIdComboBox;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource3;
        private System.Windows.Forms.BindingSource accountingBindingSource2;
        private System.Windows.Forms.BindingSource accountingBindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorInv;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSickVac;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMonthDays;

    }
}