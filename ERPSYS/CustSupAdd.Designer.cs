namespace ERPSYS
{
    partial class CustSupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustSupAdd));
            this.sALEADMINComboBox = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSCUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.txtADMIN_TITLE = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtWEEKEND = new System.Windows.Forms.TextBox();
            this.txtWORKHOURS = new System.Windows.Forms.TextBox();
            this.txtPOSTOFFICE = new System.Windows.Forms.TextBox();
            this.txtCOUNTRY = new System.Windows.Forms.TextBox();
            this.txtCITY = new System.Windows.Forms.TextBox();
            this.txtGOVERNERATE = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtFAX = new System.Windows.Forms.TextBox();
            this.txtPHONE2 = new System.Windows.Forms.TextBox();
            this.txtPHONE1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtADMIN_NAME = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSUP_CUST_SNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSUP_CUST_FNAME = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SupCustradioBtn = new System.Windows.Forms.RadioButton();
            this.SupradioBtn = new System.Windows.Forms.RadioButton();
            this.txtSUP_CUST_ID = new System.Windows.Forms.TextBox();
            this.txtAccCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCustSuptype = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtSUP_CUST_CODE = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPAYPEROID = new System.Windows.Forms.TextBox();
            this.txtCREDITPEROID = new System.Windows.Forms.TextBox();
            this.txtCREDITLIMIT = new System.Windows.Forms.TextBox();
            this.sUPPLIERS_CUSTOMERSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter();
            this.setupCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupCodesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sALEADMINComboBox
            // 
            this.sALEADMINComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sUPPLIERSCUSTOMERSBindingSource, "SALEADMIN", true));
            this.sALEADMINComboBox.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.sALEADMINComboBox.DisplayMember = "FullName";
            resources.ApplyResources(this.sALEADMINComboBox, "sALEADMINComboBox");
            this.sALEADMINComboBox.FormattingEnabled = true;
            this.sALEADMINComboBox.Name = "sALEADMINComboBox";
            this.sALEADMINComboBox.ValueMember = "EMP_CODE";
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
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtADMIN_TITLE
            // 
            this.txtADMIN_TITLE.AcceptsReturn = true;
            this.txtADMIN_TITLE.BackColor = System.Drawing.SystemColors.Window;
            this.txtADMIN_TITLE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtADMIN_TITLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "ADMIN_TITLE", true));
            resources.ApplyResources(this.txtADMIN_TITLE, "txtADMIN_TITLE");
            this.txtADMIN_TITLE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtADMIN_TITLE.Name = "txtADMIN_TITLE";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label24, "label24");
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Name = "label24";
            // 
            // txtWEEKEND
            // 
            this.txtWEEKEND.AcceptsReturn = true;
            this.txtWEEKEND.BackColor = System.Drawing.SystemColors.Window;
            this.txtWEEKEND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWEEKEND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "WEEKEND", true));
            resources.ApplyResources(this.txtWEEKEND, "txtWEEKEND");
            this.txtWEEKEND.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWEEKEND.Name = "txtWEEKEND";
            // 
            // txtWORKHOURS
            // 
            this.txtWORKHOURS.AcceptsReturn = true;
            this.txtWORKHOURS.BackColor = System.Drawing.SystemColors.Window;
            this.txtWORKHOURS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWORKHOURS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "WORKHOURS", true));
            resources.ApplyResources(this.txtWORKHOURS, "txtWORKHOURS");
            this.txtWORKHOURS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWORKHOURS.Name = "txtWORKHOURS";
            // 
            // txtPOSTOFFICE
            // 
            this.txtPOSTOFFICE.AcceptsReturn = true;
            this.txtPOSTOFFICE.BackColor = System.Drawing.SystemColors.Window;
            this.txtPOSTOFFICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPOSTOFFICE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "POSTOFFICE", true));
            resources.ApplyResources(this.txtPOSTOFFICE, "txtPOSTOFFICE");
            this.txtPOSTOFFICE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPOSTOFFICE.Name = "txtPOSTOFFICE";
            // 
            // txtCOUNTRY
            // 
            this.txtCOUNTRY.AcceptsReturn = true;
            this.txtCOUNTRY.BackColor = System.Drawing.SystemColors.Window;
            this.txtCOUNTRY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCOUNTRY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "COUNTRY", true));
            resources.ApplyResources(this.txtCOUNTRY, "txtCOUNTRY");
            this.txtCOUNTRY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCOUNTRY.Name = "txtCOUNTRY";
            // 
            // txtCITY
            // 
            this.txtCITY.AcceptsReturn = true;
            this.txtCITY.BackColor = System.Drawing.SystemColors.Window;
            this.txtCITY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCITY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "CITY", true));
            resources.ApplyResources(this.txtCITY, "txtCITY");
            this.txtCITY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCITY.Name = "txtCITY";
            // 
            // txtGOVERNERATE
            // 
            this.txtGOVERNERATE.AcceptsReturn = true;
            this.txtGOVERNERATE.BackColor = System.Drawing.SystemColors.Window;
            this.txtGOVERNERATE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGOVERNERATE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "GOVERNERATE", true));
            resources.ApplyResources(this.txtGOVERNERATE, "txtGOVERNERATE");
            this.txtGOVERNERATE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGOVERNERATE.Name = "txtGOVERNERATE";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.AcceptsReturn = true;
            this.txtEMAIL.BackColor = System.Drawing.SystemColors.Window;
            this.txtEMAIL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMAIL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "EMAIL", true));
            resources.ApplyResources(this.txtEMAIL, "txtEMAIL");
            this.txtEMAIL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEMAIL.Name = "txtEMAIL";
            // 
            // txtFAX
            // 
            this.txtFAX.AcceptsReturn = true;
            this.txtFAX.BackColor = System.Drawing.SystemColors.Window;
            this.txtFAX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "FAX", true));
            resources.ApplyResources(this.txtFAX, "txtFAX");
            this.txtFAX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFAX.Name = "txtFAX";
            // 
            // txtPHONE2
            // 
            this.txtPHONE2.AcceptsReturn = true;
            this.txtPHONE2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPHONE2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPHONE2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "PHONE2", true));
            resources.ApplyResources(this.txtPHONE2, "txtPHONE2");
            this.txtPHONE2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPHONE2.Name = "txtPHONE2";
            // 
            // txtPHONE1
            // 
            this.txtPHONE1.AcceptsReturn = true;
            this.txtPHONE1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPHONE1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPHONE1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "PHONE1", true));
            resources.ApplyResources(this.txtPHONE1, "txtPHONE1");
            this.txtPHONE1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPHONE1.Name = "txtPHONE1";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Name = "label20";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Name = "label19";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Name = "label17";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Name = "label15";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // txtADMIN_NAME
            // 
            this.txtADMIN_NAME.AcceptsReturn = true;
            this.txtADMIN_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.txtADMIN_NAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtADMIN_NAME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "ADMIN_NAME", true));
            resources.ApplyResources(this.txtADMIN_NAME, "txtADMIN_NAME");
            this.txtADMIN_NAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtADMIN_NAME.Name = "txtADMIN_NAME";
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.AcceptsReturn = true;
            this.txtADDRESS.BackColor = System.Drawing.SystemColors.Window;
            this.txtADDRESS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtADDRESS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "ADDRESS", true));
            resources.ApplyResources(this.txtADDRESS, "txtADDRESS");
            this.txtADDRESS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtADDRESS.Name = "txtADDRESS";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "NOTES", true));
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotes.Name = "txtNotes";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // txtSUP_CUST_SNAME
            // 
            this.txtSUP_CUST_SNAME.AcceptsReturn = true;
            this.txtSUP_CUST_SNAME.BackColor = System.Drawing.SystemColors.Window;
            this.txtSUP_CUST_SNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSUP_CUST_SNAME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "SUP_CUST_SNAME", true));
            resources.ApplyResources(this.txtSUP_CUST_SNAME, "txtSUP_CUST_SNAME");
            this.txtSUP_CUST_SNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSUP_CUST_SNAME.Name = "txtSUP_CUST_SNAME";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtSUP_CUST_FNAME
            // 
            this.txtSUP_CUST_FNAME.BackColor = System.Drawing.SystemColors.Window;
            this.txtSUP_CUST_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSUP_CUST_FNAME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "SUP_CUST_FNAME", true));
            resources.ApplyResources(this.txtSUP_CUST_FNAME, "txtSUP_CUST_FNAME");
            this.txtSUP_CUST_FNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSUP_CUST_FNAME.Name = "txtSUP_CUST_FNAME";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SupCustradioBtn);
            this.groupBox2.Controls.Add(this.SupradioBtn);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // SupCustradioBtn
            // 
            resources.ApplyResources(this.SupCustradioBtn, "SupCustradioBtn");
            this.SupCustradioBtn.Name = "SupCustradioBtn";
            this.SupCustradioBtn.UseVisualStyleBackColor = true;
            this.SupCustradioBtn.CheckedChanged += new System.EventHandler(this.SupCustradioBtn_CheckedChanged);
            // 
            // SupradioBtn
            // 
            resources.ApplyResources(this.SupradioBtn, "SupradioBtn");
            this.SupradioBtn.Checked = true;
            this.SupradioBtn.Name = "SupradioBtn";
            this.SupradioBtn.TabStop = true;
            this.SupradioBtn.UseVisualStyleBackColor = true;
            this.SupradioBtn.CheckedChanged += new System.EventHandler(this.SupradioBtn_CheckedChanged);
            // 
            // txtSUP_CUST_ID
            // 
            this.txtSUP_CUST_ID.BackColor = System.Drawing.SystemColors.Window;
            this.txtSUP_CUST_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSUP_CUST_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "SUP_CUST_ID", true));
            resources.ApplyResources(this.txtSUP_CUST_ID, "txtSUP_CUST_ID");
            this.txtSUP_CUST_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSUP_CUST_ID.Name = "txtSUP_CUST_ID";
            // 
            // txtAccCode
            // 
            this.txtAccCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtAccCode, "txtAccCode");
            this.txtAccCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccCode.Name = "txtAccCode";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Name = "label26";
            // 
            // txtCustSuptype
            // 
            this.txtCustSuptype.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustSuptype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustSuptype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "SUP_CUST_TYPE", true));
            resources.ApplyResources(this.txtCustSuptype, "txtCustSuptype");
            this.txtCustSuptype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustSuptype.Name = "txtCustSuptype";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Name = "label25";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // txtCostNum
            // 
            this.txtCostNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtCostNum, "txtCostNum");
            this.txtCostNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCostNum.Name = "txtCostNum";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // txtAccountId
            // 
            this.txtAccountId.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "accountid", true));
            resources.ApplyResources(this.txtAccountId, "txtAccountId");
            this.txtAccountId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccountId.Name = "txtAccountId";
            // 
            // txtSUP_CUST_CODE
            // 
            this.txtSUP_CUST_CODE.BackColor = System.Drawing.SystemColors.Window;
            this.txtSUP_CUST_CODE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSUP_CUST_CODE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "SUP_CUST_CODE", true));
            resources.ApplyResources(this.txtSUP_CUST_CODE, "txtSUP_CUST_CODE");
            this.txtSUP_CUST_CODE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSUP_CUST_CODE.Name = "txtSUP_CUST_CODE";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Name = "label21";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Name = "label22";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Name = "label23";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtPAYPEROID);
            this.groupBox5.Controls.Add(this.txtCREDITPEROID);
            this.groupBox5.Controls.Add(this.txtCREDITLIMIT);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Name = "label28";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Name = "label27";
            // 
            // txtPAYPEROID
            // 
            this.txtPAYPEROID.AcceptsReturn = true;
            this.txtPAYPEROID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPAYPEROID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPAYPEROID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "PAYPEROID", true));
            resources.ApplyResources(this.txtPAYPEROID, "txtPAYPEROID");
            this.txtPAYPEROID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPAYPEROID.Name = "txtPAYPEROID";
            // 
            // txtCREDITPEROID
            // 
            this.txtCREDITPEROID.AcceptsReturn = true;
            this.txtCREDITPEROID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCREDITPEROID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCREDITPEROID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "CREDITPEROID", true));
            resources.ApplyResources(this.txtCREDITPEROID, "txtCREDITPEROID");
            this.txtCREDITPEROID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCREDITPEROID.Name = "txtCREDITPEROID";
            // 
            // txtCREDITLIMIT
            // 
            this.txtCREDITLIMIT.AcceptsReturn = true;
            this.txtCREDITLIMIT.BackColor = System.Drawing.SystemColors.Window;
            this.txtCREDITLIMIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCREDITLIMIT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERSCUSTOMERSBindingSource, "CREDITLIMIT", true));
            resources.ApplyResources(this.txtCREDITLIMIT, "txtCREDITLIMIT");
            this.txtCREDITLIMIT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCREDITLIMIT.Name = "txtCREDITLIMIT";
            // 
            // sUPPLIERS_CUSTOMERSTableAdapter
            // 
            this.sUPPLIERS_CUSTOMERSTableAdapter.ClearBeforeFill = true;
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
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Blue;
            this.label30.Name = "label30";
            // 
            // CustSupAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtSUP_CUST_ID);
            this.Controls.Add(this.sALEADMINComboBox);
            this.Controls.Add(this.txtAccCode);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtCustSuptype);
            this.Controls.Add(this.txtADMIN_TITLE);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtCostNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWEEKEND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.txtWORKHOURS);
            this.Controls.Add(this.txtSUP_CUST_CODE);
            this.Controls.Add(this.txtSUP_CUST_FNAME);
            this.Controls.Add(this.txtPOSTOFFICE);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCOUNTRY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCITY);
            this.Controls.Add(this.txtSUP_CUST_SNAME);
            this.Controls.Add(this.txtGOVERNERATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtFAX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPHONE2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPHONE1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtADMIN_NAME);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustSupAdd";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.Activated += new System.EventHandler(this.CustSupAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSCUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSUP_CUST_SNAME;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSUP_CUST_FNAME;
        public System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.RadioButton SupCustradioBtn;
        private System.Windows.Forms.RadioButton SupradioBtn;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCostNum;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAccountId;
        public System.Windows.Forms.TextBox txtSUP_CUST_CODE;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtADMIN_NAME;
        public System.Windows.Forms.TextBox txtADDRESS;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtPHONE1;
        public System.Windows.Forms.TextBox txtWEEKEND;
        public System.Windows.Forms.TextBox txtWORKHOURS;
        public System.Windows.Forms.TextBox txtPOSTOFFICE;
        public System.Windows.Forms.TextBox txtCOUNTRY;
        public System.Windows.Forms.TextBox txtCITY;
        public System.Windows.Forms.TextBox txtGOVERNERATE;
        public System.Windows.Forms.TextBox txtEMAIL;
        public System.Windows.Forms.TextBox txtFAX;
        public System.Windows.Forms.TextBox txtPHONE2;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txtPAYPEROID;
        public System.Windows.Forms.TextBox txtCREDITPEROID;
        public System.Windows.Forms.TextBox txtCREDITLIMIT;
        public System.Windows.Forms.TextBox txtADMIN_TITLE;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.BindingSource sUPPLIERSCUSTOMERSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SUPPLIERS_CUSTOMERSTableAdapter sUPPLIERS_CUSTOMERSTableAdapter;
        internal System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox txtCustSuptype;
        internal System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox txtAccCode;
        private System.Windows.Forms.BindingSource setupCodesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter setupCodesTableAdapter;
        public System.Windows.Forms.TextBox txtSUP_CUST_ID;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.ComboBox sALEADMINComboBox;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label30;

    }
}