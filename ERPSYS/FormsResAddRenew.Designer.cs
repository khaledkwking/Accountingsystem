namespace ERPSYS
{
    partial class FormsResAddRenew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsResAddRenew));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmbEmpApplay = new System.Windows.Forms.ComboBox();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.txtSignPerson = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.txtApplyDate = new System.Windows.Forms.TextBox();
            this.txtworkOnwer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtsCompanyName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGovContract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApplyNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsePeroid = new System.Windows.Forms.TextBox();
            this.txtNewTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFils = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDinar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(216, 629);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(82, 33);
            this.CmdCancel.TabIndex = 48;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmbEmpApplay
            // 
            this.CmbEmpApplay.AccessibleDescription = "";
            this.CmbEmpApplay.DisplayMember = "DESC";
            this.CmbEmpApplay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpApplay.FormattingEnabled = true;
            this.CmbEmpApplay.Location = new System.Drawing.Point(237, 126);
            this.CmbEmpApplay.Name = "CmbEmpApplay";
            this.CmbEmpApplay.Size = new System.Drawing.Size(283, 26);
            this.CmbEmpApplay.TabIndex = 190;
            this.CmbEmpApplay.ValueMember = "ID";
            // 
            // CmbEmp
            // 
            this.CmbEmp.AccessibleDescription = "";
            this.CmbEmp.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmp.DisplayMember = "FullName";
            this.CmbEmp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmp.FormattingEnabled = true;
            this.CmbEmp.Location = new System.Drawing.Point(111, 77);
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.Size = new System.Drawing.Size(409, 26);
            this.CmbEmp.TabIndex = 189;
            this.CmbEmp.ValueMember = "EMP_CODE";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(529, 80);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(70, 18);
            this.label20.TabIndex = 192;
            this.label20.Text = "√”„ «·„ÊŸ›";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(555, 129);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 191;
            this.label11.Text = "«·«Ã—«¡";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnPrint.Location = new System.Drawing.Point(344, 629);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPrint.Size = new System.Drawing.Size(78, 33);
            this.BtnPrint.TabIndex = 193;
            this.BtnPrint.Text = "„⁄«Ì‰…";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtSignPerson
            // 
            this.txtSignPerson.BackColor = System.Drawing.SystemColors.Window;
            this.txtSignPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignPerson.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPerson.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSignPerson.Location = new System.Drawing.Point(193, 248);
            this.txtSignPerson.MaxLength = 0;
            this.txtSignPerson.Name = "txtSignPerson";
            this.txtSignPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSignPerson.Size = new System.Drawing.Size(259, 25);
            this.txtSignPerson.TabIndex = 2;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Cursor = System.Windows.Forms.Cursors.Default;
            this.label71.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.Blue;
            this.label71.Location = new System.Drawing.Point(484, 254);
            this.label71.Name = "label71";
            this.label71.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label71.Size = new System.Drawing.Size(115, 18);
            this.label71.TabIndex = 236;
            this.label71.Text = "√”„ «·„›Ê÷ »«· ÊﬁÌ⁄";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Cursor = System.Windows.Forms.Cursors.Default;
            this.label68.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.Blue;
            this.label68.Location = new System.Drawing.Point(531, 175);
            this.label68.Name = "label68";
            this.label68.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label68.Size = new System.Drawing.Size(68, 18);
            this.label68.TabIndex = 235;
            this.label68.Text = " «—ÌŒ «·ÿ·»";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApplyDate
            // 
            this.txtApplyDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtApplyDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApplyDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplyDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApplyDate.Location = new System.Drawing.Point(237, 174);
            this.txtApplyDate.MaxLength = 0;
            this.txtApplyDate.Name = "txtApplyDate";
            this.txtApplyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtApplyDate.Size = new System.Drawing.Size(215, 25);
            this.txtApplyDate.TabIndex = 0;
            // 
            // txtworkOnwer
            // 
            this.txtworkOnwer.BackColor = System.Drawing.SystemColors.Window;
            this.txtworkOnwer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtworkOnwer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkOnwer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtworkOnwer.Location = new System.Drawing.Point(193, 211);
            this.txtworkOnwer.MaxLength = 0;
            this.txtworkOnwer.Name = "txtworkOnwer";
            this.txtworkOnwer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtworkOnwer.Size = new System.Drawing.Size(259, 25);
            this.txtworkOnwer.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(505, 214);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(94, 18);
            this.label21.TabIndex = 234;
            this.label21.Text = "√”„ ’«Õ» «·⁄„·";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtsCompanyName
            // 
            this.txtsCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtsCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsCompanyName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsCompanyName.Location = new System.Drawing.Point(193, 284);
            this.txtsCompanyName.MaxLength = 0;
            this.txtsCompanyName.Name = "txtsCompanyName";
            this.txtsCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsCompanyName.Size = new System.Drawing.Size(259, 25);
            this.txtsCompanyName.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(522, 288);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(77, 18);
            this.label15.TabIndex = 233;
            this.label15.Text = "«·«”„ «· Ã«—Ì";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGovContract
            // 
            this.txtGovContract.BackColor = System.Drawing.SystemColors.Window;
            this.txtGovContract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGovContract.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGovContract.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGovContract.Location = new System.Drawing.Point(193, 355);
            this.txtGovContract.MaxLength = 0;
            this.txtGovContract.Name = "txtGovContract";
            this.txtGovContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGovContract.Size = new System.Drawing.Size(259, 25);
            this.txtGovContract.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(521, 363);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 242;
            this.label1.Text = "«·⁄ﬁœ «·ÕﬂÊ„Ì";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileNo
            // 
            this.txtFileNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtFileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFileNo.Location = new System.Drawing.Point(193, 319);
            this.txtFileNo.MaxLength = 0;
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFileNo.Size = new System.Drawing.Size(259, 25);
            this.txtFileNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(542, 324);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 241;
            this.label2.Text = "—ﬁ„ «·„·›";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApplyNo
            // 
            this.txtApplyNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtApplyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApplyNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplyNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApplyNo.Location = new System.Drawing.Point(193, 391);
            this.txtApplyNo.MaxLength = 0;
            this.txtApplyNo.Name = "txtApplyNo";
            this.txtApplyNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtApplyNo.Size = new System.Drawing.Size(259, 25);
            this.txtApplyNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(525, 395);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 240;
            this.label3.Text = "—ﬁ„ «· —ŒÌ’";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsePeroid
            // 
            this.txtUsePeroid.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsePeroid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsePeroid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsePeroid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsePeroid.Location = new System.Drawing.Point(193, 463);
            this.txtUsePeroid.MaxLength = 0;
            this.txtUsePeroid.Name = "txtUsePeroid";
            this.txtUsePeroid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsePeroid.Size = new System.Drawing.Size(259, 25);
            this.txtUsePeroid.TabIndex = 8;
            // 
            // txtNewTitle
            // 
            this.txtNewTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewTitle.Location = new System.Drawing.Point(193, 427);
            this.txtNewTitle.MaxLength = 0;
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewTitle.Size = new System.Drawing.Size(259, 25);
            this.txtNewTitle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(521, 430);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 247;
            this.label5.Text = "«·„Â‰… «·ÃœÌœ…";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFils
            // 
            this.txtFils.BackColor = System.Drawing.SystemColors.Window;
            this.txtFils.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFils.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFils.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFils.Location = new System.Drawing.Point(326, 500);
            this.txtFils.MaxLength = 0;
            this.txtFils.Name = "txtFils";
            this.txtFils.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFils.Size = new System.Drawing.Size(126, 25);
            this.txtFils.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(527, 504);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 246;
            this.label6.Text = "«·«Ã— »«·œÌ‰«—";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(290, 503);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 249;
            this.label7.Text = "›·”";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(138, 505);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 250;
            this.label8.Text = "œ.ﬂ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDinar
            // 
            this.txtDinar.BackColor = System.Drawing.SystemColors.Window;
            this.txtDinar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDinar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDinar.Location = new System.Drawing.Point(168, 501);
            this.txtDinar.MaxLength = 0;
            this.txtDinar.Name = "txtDinar";
            this.txtDinar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDinar.Size = new System.Drawing.Size(116, 25);
            this.txtDinar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(525, 471);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 248;
            this.label4.Text = "„œ… «·«” Œœ«„";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(252, 20);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 251;
            this.label9.Text = "‰„«–Ã «·‘∆Ê‰";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormsResAddRenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 727);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDinar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsePeroid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFils);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGovContract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApplyNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSignPerson);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.txtApplyDate);
            this.Controls.Add(this.txtworkOnwer);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtsCompanyName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmbEmpApplay);
            this.Controls.Add(this.CmbEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormsResAddRenew";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRes";
            this.Load += new System.EventHandler(this.FormsResAddRenew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.ComboBox CmbEmpApplay;
        internal System.Windows.Forms.ComboBox CmbEmp;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label11;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        internal System.Windows.Forms.Button BtnPrint;
        public System.Windows.Forms.TextBox txtSignPerson;
        public System.Windows.Forms.Label label71;
        public System.Windows.Forms.Label label68;
        public System.Windows.Forms.TextBox txtApplyDate;
        public System.Windows.Forms.TextBox txtworkOnwer;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtsCompanyName;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtGovContract;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFileNo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtApplyNo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUsePeroid;
        public System.Windows.Forms.TextBox txtNewTitle;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFils;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDinar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label9;
    }
}