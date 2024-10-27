namespace ERPSYS
{
    partial class EmpList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.UnitsDGView = new System.Windows.Forms.DataGridView();
            this.txtFoName = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cDEDEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.cDENATIONALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.cDE_DEPTTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter();
            this.cDE_NATIONALITYTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter();
            this.EMP_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIVILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEngNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEngNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEngNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foEngNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPBIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPHIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECTYPECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATIONALITYCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gOVERCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationMajoredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationMajoredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationMajoredPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceIssueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIssueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "≈”„ «·„ÊŸ›";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCode.Location = new System.Drawing.Point(100, 9);
            this.txtCode.MaxLength = 0;
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCode.Size = new System.Drawing.Size(125, 25);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(14, 12);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(69, 18);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "ﬂÊœ «·„ÊŸ›";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DelCmd
            // 
            this.DelCmd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.DelCmd.ForeColor = System.Drawing.Color.Black;
            this.DelCmd.Image = ((System.Drawing.Image)(resources.GetObject("DelCmd.Image")));
            this.DelCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelCmd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelCmd.Location = new System.Drawing.Point(354, 463);
            this.DelCmd.Name = "DelCmd";
            this.DelCmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DelCmd.Size = new System.Drawing.Size(82, 33);
            this.DelCmd.TabIndex = 50;
            this.DelCmd.Text = "Õ–›";
            this.DelCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelCmd.UseVisualStyleBackColor = true;
            this.DelCmd.Click += new System.EventHandler(this.DelCmd_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmdCancel.Location = new System.Drawing.Point(487, 463);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(82, 33);
            this.CmdCancel.TabIndex = 7;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // UnitsDGView
            // 
            this.UnitsDGView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UnitsDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsDGView.AutoGenerateColumns = false;
            this.UnitsDGView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UnitsDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UnitsDGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UnitsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMP_CODE,
            this.cIVILIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.foNameDataGridViewTextBoxColumn,
            this.fEngNameDataGridViewTextBoxColumn,
            this.sEngNameDataGridViewTextBoxColumn,
            this.tEngNameDataGridViewTextBoxColumn,
            this.foEngNameDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.eMPGENDERDataGridViewTextBoxColumn,
            this.eMPBIRTHDATEDataGridViewTextBoxColumn,
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn,
            this.dEPTCODEDataGridViewTextBoxColumn,
            this.eMPEMAILDataGridViewTextBoxColumn,
            this.eMPHIREDATEDataGridViewTextBoxColumn,
            this.fILENUMDataGridViewTextBoxColumn,
            this.rECTYPECODEDataGridViewTextBoxColumn,
            this.nATIONALITYCODEDataGridViewTextBoxColumn,
            this.gOVERCODEDataGridViewTextBoxColumn,
            this.passportNoDataGridViewTextBoxColumn,
            this.passTypeDataGridViewTextBoxColumn,
            this.passDateDataGridViewTextBoxColumn,
            this.passEndDateDataGridViewTextBoxColumn,
            this.passplaceDataGridViewTextBoxColumn,
            this.entrydateDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.religionIdDataGridViewTextBoxColumn,
            this.educationIdDataGridViewTextBoxColumn,
            this.educationMajoredDataGridViewTextBoxColumn,
            this.educationMajoredDateDataGridViewTextBoxColumn,
            this.educationMajoredPlaceDataGridViewTextBoxColumn,
            this.locationIdDataGridViewTextBoxColumn,
            this.regionIdDataGridViewTextBoxColumn,
            this.divisionIdDataGridViewTextBoxColumn,
            this.residenceIdDataGridViewTextBoxColumn,
            this.residenceNoDataGridViewTextBoxColumn,
            this.residenceRemarkDataGridViewTextBoxColumn,
            this.residenceIssueDateDataGridViewTextBoxColumn,
            this.residenceEndDateDataGridViewTextBoxColumn,
            this.licenseNoDataGridViewTextBoxColumn,
            this.licenseTypeIdDataGridViewTextBoxColumn,
            this.licenseIssueDateDataGridViewTextBoxColumn,
            this.licenseEndDateDataGridViewTextBoxColumn,
            this.workTelDataGridViewTextBoxColumn,
            this.mobile1DataGridViewTextBoxColumn});
            this.UnitsDGView.DataSource = this.pEREMPLOYEEDATABindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDGView.DefaultCellStyle = dataGridViewCellStyle7;
            this.UnitsDGView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UnitsDGView.EnableHeadersVisualStyles = false;
            this.UnitsDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.UnitsDGView.Location = new System.Drawing.Point(8, 85);
            this.UnitsDGView.MultiSelect = false;
            this.UnitsDGView.Name = "UnitsDGView";
            this.UnitsDGView.ReadOnly = true;
            this.UnitsDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.UnitsDGView.RowHeadersWidth = 30;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.UnitsDGView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitsDGView.Size = new System.Drawing.Size(933, 351);
            this.UnitsDGView.TabIndex = 6;
            this.UnitsDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnitsDGView_CellDoubleClick);
            this.UnitsDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.UnitsDGView_DataError);
            // 
            // txtFoName
            // 
            this.txtFoName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFoName.Location = new System.Drawing.Point(520, 40);
            this.txtFoName.MaxLength = 0;
            this.txtFoName.Name = "txtFoName";
            this.txtFoName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFoName.Size = new System.Drawing.Size(136, 25);
            this.txtFoName.TabIndex = 4;
            this.txtFoName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFoName_KeyUp);
            // 
            // txtTName
            // 
            this.txtTName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTName.Location = new System.Drawing.Point(381, 40);
            this.txtTName.MaxLength = 0;
            this.txtTName.Name = "txtTName";
            this.txtTName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTName.Size = new System.Drawing.Size(136, 25);
            this.txtTName.TabIndex = 3;
            this.txtTName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTName_KeyUp);
            // 
            // txtSName
            // 
            this.txtSName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSName.Location = new System.Drawing.Point(240, 40);
            this.txtSName.MaxLength = 0;
            this.txtSName.Name = "txtSName";
            this.txtSName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSName.Size = new System.Drawing.Size(136, 25);
            this.txtSName.TabIndex = 2;
            this.txtSName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSName_KeyUp);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.SystemColors.Window;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFname.Location = new System.Drawing.Point(100, 40);
            this.txtFname.MaxLength = 0;
            this.txtFname.Name = "txtFname";
            this.txtFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFname.Size = new System.Drawing.Size(136, 25);
            this.txtFname.TabIndex = 1;
            this.txtFname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFname_KeyUp);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.Location = new System.Drawing.Point(748, 35);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearch.Size = new System.Drawing.Size(78, 33);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "»ÕÀ";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            // cDENATIONALITYBindingSource
            // 
            this.cDENATIONALITYBindingSource.DataMember = "CDE_NATIONALITY";
            this.cDENATIONALITYBindingSource.DataSource = this.personalDataSet;
            // 
            // pEREMPLOYEEDATABindingSource
            // 
            this.pEREMPLOYEEDATABindingSource.DataMember = "PER_EMPLOYEE_DATA";
            this.pEREMPLOYEEDATABindingSource.DataSource = this.personalDataSet;
            // 
            // pER_EMPLOYEE_DATATableAdapter
            // 
            this.pER_EMPLOYEE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // cDE_DEPTTableAdapter
            // 
            this.cDE_DEPTTableAdapter.ClearBeforeFill = true;
            // 
            // cDE_NATIONALITYTableAdapter
            // 
            this.cDE_NATIONALITYTableAdapter.ClearBeforeFill = true;
            // 
            // EMP_CODE
            // 
            this.EMP_CODE.DataPropertyName = "EMP_CODE";
            this.EMP_CODE.HeaderText = "«·ﬂÊœ";
            this.EMP_CODE.Name = "EMP_CODE";
            this.EMP_CODE.ReadOnly = true;
            this.EMP_CODE.Width = 60;
            // 
            // cIVILIDDataGridViewTextBoxColumn
            // 
            this.cIVILIDDataGridViewTextBoxColumn.DataPropertyName = "CIVILID";
            this.cIVILIDDataGridViewTextBoxColumn.HeaderText = "«·—ﬁ„ «·„œ‰Ï";
            this.cIVILIDDataGridViewTextBoxColumn.Name = "cIVILIDDataGridViewTextBoxColumn";
            this.cIVILIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIVILIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "«·«”„ «·«Ê·";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "SName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "«·«”„ «·À«‰Ï";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "TName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "«·«”„ «·À«·À";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foNameDataGridViewTextBoxColumn
            // 
            this.foNameDataGridViewTextBoxColumn.DataPropertyName = "FoName";
            this.foNameDataGridViewTextBoxColumn.HeaderText = "«·«”„ «·—«»⁄";
            this.foNameDataGridViewTextBoxColumn.Name = "foNameDataGridViewTextBoxColumn";
            this.foNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fEngNameDataGridViewTextBoxColumn
            // 
            this.fEngNameDataGridViewTextBoxColumn.DataPropertyName = "FEngName";
            this.fEngNameDataGridViewTextBoxColumn.HeaderText = "FEngName";
            this.fEngNameDataGridViewTextBoxColumn.Name = "fEngNameDataGridViewTextBoxColumn";
            this.fEngNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fEngNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // sEngNameDataGridViewTextBoxColumn
            // 
            this.sEngNameDataGridViewTextBoxColumn.DataPropertyName = "SEngName";
            this.sEngNameDataGridViewTextBoxColumn.HeaderText = "SEngName";
            this.sEngNameDataGridViewTextBoxColumn.Name = "sEngNameDataGridViewTextBoxColumn";
            this.sEngNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEngNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // tEngNameDataGridViewTextBoxColumn
            // 
            this.tEngNameDataGridViewTextBoxColumn.DataPropertyName = "TEngName";
            this.tEngNameDataGridViewTextBoxColumn.HeaderText = "TEngName";
            this.tEngNameDataGridViewTextBoxColumn.Name = "tEngNameDataGridViewTextBoxColumn";
            this.tEngNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEngNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // foEngNameDataGridViewTextBoxColumn
            // 
            this.foEngNameDataGridViewTextBoxColumn.DataPropertyName = "FoEngName";
            this.foEngNameDataGridViewTextBoxColumn.HeaderText = "FoEngName";
            this.foEngNameDataGridViewTextBoxColumn.Name = "foEngNameDataGridViewTextBoxColumn";
            this.foEngNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.foEngNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "«·ÊŸÌ›…";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPGENDERDataGridViewTextBoxColumn
            // 
            this.eMPGENDERDataGridViewTextBoxColumn.DataPropertyName = "EMP_GENDER";
            this.eMPGENDERDataGridViewTextBoxColumn.HeaderText = "EMP_GENDER";
            this.eMPGENDERDataGridViewTextBoxColumn.Name = "eMPGENDERDataGridViewTextBoxColumn";
            this.eMPGENDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPGENDERDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMPBIRTHDATEDataGridViewTextBoxColumn
            // 
            this.eMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "EMP_BIRTH_DATE";
            dataGridViewCellStyle3.Format = "d";
            this.eMPBIRTHDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.eMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «·„Ì·«œ";
            this.eMPBIRTHDATEDataGridViewTextBoxColumn.Name = "eMPBIRTHDATEDataGridViewTextBoxColumn";
            this.eMPBIRTHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPBIRTHPLACEDataGridViewTextBoxColumn
            // 
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn.DataPropertyName = "EMP_BIRTH_PLACE";
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn.HeaderText = "EMP_BIRTH_PLACE";
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn.Name = "eMPBIRTHPLACEDataGridViewTextBoxColumn";
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPBIRTHPLACEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dEPTCODEDataGridViewTextBoxColumn
            // 
            this.dEPTCODEDataGridViewTextBoxColumn.DataPropertyName = "DEPTCODE";
            this.dEPTCODEDataGridViewTextBoxColumn.DataSource = this.cDEDEPTBindingSource;
            this.dEPTCODEDataGridViewTextBoxColumn.DisplayMember = "DEPT_DESC";
            this.dEPTCODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dEPTCODEDataGridViewTextBoxColumn.HeaderText = "«·ﬁ”„";
            this.dEPTCODEDataGridViewTextBoxColumn.Name = "dEPTCODEDataGridViewTextBoxColumn";
            this.dEPTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPTCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dEPTCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dEPTCODEDataGridViewTextBoxColumn.ValueMember = "DEPT_CODE";
            // 
            // eMPEMAILDataGridViewTextBoxColumn
            // 
            this.eMPEMAILDataGridViewTextBoxColumn.DataPropertyName = "EMP_EMAIL";
            this.eMPEMAILDataGridViewTextBoxColumn.HeaderText = "«·»—Ìœ «·«·ﬂ —Ê‰Ì";
            this.eMPEMAILDataGridViewTextBoxColumn.Name = "eMPEMAILDataGridViewTextBoxColumn";
            this.eMPEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPEMAILDataGridViewTextBoxColumn.Width = 130;
            // 
            // eMPHIREDATEDataGridViewTextBoxColumn
            // 
            this.eMPHIREDATEDataGridViewTextBoxColumn.DataPropertyName = "EMP_HIREDATE";
            this.eMPHIREDATEDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «· ⁄Ì‰";
            this.eMPHIREDATEDataGridViewTextBoxColumn.Name = "eMPHIREDATEDataGridViewTextBoxColumn";
            this.eMPHIREDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fILENUMDataGridViewTextBoxColumn
            // 
            this.fILENUMDataGridViewTextBoxColumn.DataPropertyName = "FILE_NUM";
            this.fILENUMDataGridViewTextBoxColumn.HeaderText = "—ﬁ„ «·„·›";
            this.fILENUMDataGridViewTextBoxColumn.Name = "fILENUMDataGridViewTextBoxColumn";
            this.fILENUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECTYPECODEDataGridViewTextBoxColumn
            // 
            this.rECTYPECODEDataGridViewTextBoxColumn.DataPropertyName = "REC_TYPE_CODE";
            this.rECTYPECODEDataGridViewTextBoxColumn.HeaderText = "REC_TYPE_CODE";
            this.rECTYPECODEDataGridViewTextBoxColumn.Name = "rECTYPECODEDataGridViewTextBoxColumn";
            this.rECTYPECODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nATIONALITYCODEDataGridViewTextBoxColumn
            // 
            this.nATIONALITYCODEDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY_CODE";
            this.nATIONALITYCODEDataGridViewTextBoxColumn.DataSource = this.cDENATIONALITYBindingSource;
            this.nATIONALITYCODEDataGridViewTextBoxColumn.DisplayMember = "NATIONALITY_CODE";
            this.nATIONALITYCODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nATIONALITYCODEDataGridViewTextBoxColumn.HeaderText = "«·Ã‰”Ì…";
            this.nATIONALITYCODEDataGridViewTextBoxColumn.Name = "nATIONALITYCODEDataGridViewTextBoxColumn";
            this.nATIONALITYCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nATIONALITYCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nATIONALITYCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nATIONALITYCODEDataGridViewTextBoxColumn.ValueMember = "NATIONALITY_CODE";
            // 
            // gOVERCODEDataGridViewTextBoxColumn
            // 
            this.gOVERCODEDataGridViewTextBoxColumn.DataPropertyName = "GOVER_CODE";
            this.gOVERCODEDataGridViewTextBoxColumn.HeaderText = "GOVER_CODE";
            this.gOVERCODEDataGridViewTextBoxColumn.Name = "gOVERCODEDataGridViewTextBoxColumn";
            this.gOVERCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.gOVERCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportNoDataGridViewTextBoxColumn
            // 
            this.passportNoDataGridViewTextBoxColumn.DataPropertyName = "PassportNo";
            this.passportNoDataGridViewTextBoxColumn.HeaderText = "—ﬁ„ «·ÃÊ«“";
            this.passportNoDataGridViewTextBoxColumn.Name = "passportNoDataGridViewTextBoxColumn";
            this.passportNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passTypeDataGridViewTextBoxColumn
            // 
            this.passTypeDataGridViewTextBoxColumn.DataPropertyName = "PassType";
            this.passTypeDataGridViewTextBoxColumn.HeaderText = "PassType";
            this.passTypeDataGridViewTextBoxColumn.Name = "passTypeDataGridViewTextBoxColumn";
            this.passTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.passTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // passDateDataGridViewTextBoxColumn
            // 
            this.passDateDataGridViewTextBoxColumn.DataPropertyName = "PassDate";
            this.passDateDataGridViewTextBoxColumn.HeaderText = "PassDate";
            this.passDateDataGridViewTextBoxColumn.Name = "passDateDataGridViewTextBoxColumn";
            this.passDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // passEndDateDataGridViewTextBoxColumn
            // 
            this.passEndDateDataGridViewTextBoxColumn.DataPropertyName = "PassEndDate";
            dataGridViewCellStyle4.Format = "d";
            this.passEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.passEndDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «‰ Â«¡ «·ÃÊ«“";
            this.passEndDateDataGridViewTextBoxColumn.Name = "passEndDateDataGridViewTextBoxColumn";
            this.passEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.passEndDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // passplaceDataGridViewTextBoxColumn
            // 
            this.passplaceDataGridViewTextBoxColumn.DataPropertyName = "Passplace";
            this.passplaceDataGridViewTextBoxColumn.HeaderText = "Passplace";
            this.passplaceDataGridViewTextBoxColumn.Name = "passplaceDataGridViewTextBoxColumn";
            this.passplaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.passplaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // entrydateDataGridViewTextBoxColumn
            // 
            this.entrydateDataGridViewTextBoxColumn.DataPropertyName = "entrydate";
            this.entrydateDataGridViewTextBoxColumn.HeaderText = "entrydate";
            this.entrydateDataGridViewTextBoxColumn.Name = "entrydateDataGridViewTextBoxColumn";
            this.entrydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.entrydateDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // religionIdDataGridViewTextBoxColumn
            // 
            this.religionIdDataGridViewTextBoxColumn.DataPropertyName = "ReligionId";
            this.religionIdDataGridViewTextBoxColumn.HeaderText = "ReligionId";
            this.religionIdDataGridViewTextBoxColumn.Name = "religionIdDataGridViewTextBoxColumn";
            this.religionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // educationIdDataGridViewTextBoxColumn
            // 
            this.educationIdDataGridViewTextBoxColumn.DataPropertyName = "EducationId";
            this.educationIdDataGridViewTextBoxColumn.HeaderText = "EducationId";
            this.educationIdDataGridViewTextBoxColumn.Name = "educationIdDataGridViewTextBoxColumn";
            this.educationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.educationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // educationMajoredDataGridViewTextBoxColumn
            // 
            this.educationMajoredDataGridViewTextBoxColumn.DataPropertyName = "EducationMajored";
            this.educationMajoredDataGridViewTextBoxColumn.HeaderText = "EducationMajored";
            this.educationMajoredDataGridViewTextBoxColumn.Name = "educationMajoredDataGridViewTextBoxColumn";
            this.educationMajoredDataGridViewTextBoxColumn.ReadOnly = true;
            this.educationMajoredDataGridViewTextBoxColumn.Visible = false;
            // 
            // educationMajoredDateDataGridViewTextBoxColumn
            // 
            this.educationMajoredDateDataGridViewTextBoxColumn.DataPropertyName = "EducationMajoredDate";
            this.educationMajoredDateDataGridViewTextBoxColumn.HeaderText = "EducationMajoredDate";
            this.educationMajoredDateDataGridViewTextBoxColumn.Name = "educationMajoredDateDataGridViewTextBoxColumn";
            this.educationMajoredDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.educationMajoredDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // educationMajoredPlaceDataGridViewTextBoxColumn
            // 
            this.educationMajoredPlaceDataGridViewTextBoxColumn.DataPropertyName = "EducationMajoredPlace";
            this.educationMajoredPlaceDataGridViewTextBoxColumn.HeaderText = "EducationMajoredPlace";
            this.educationMajoredPlaceDataGridViewTextBoxColumn.Name = "educationMajoredPlaceDataGridViewTextBoxColumn";
            this.educationMajoredPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.educationMajoredPlaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationIdDataGridViewTextBoxColumn
            // 
            this.locationIdDataGridViewTextBoxColumn.DataPropertyName = "LocationId";
            this.locationIdDataGridViewTextBoxColumn.HeaderText = "LocationId";
            this.locationIdDataGridViewTextBoxColumn.Name = "locationIdDataGridViewTextBoxColumn";
            this.locationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // regionIdDataGridViewTextBoxColumn
            // 
            this.regionIdDataGridViewTextBoxColumn.DataPropertyName = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.HeaderText = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.Name = "regionIdDataGridViewTextBoxColumn";
            this.regionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionIdDataGridViewTextBoxColumn
            // 
            this.divisionIdDataGridViewTextBoxColumn.DataPropertyName = "DivisionId";
            this.divisionIdDataGridViewTextBoxColumn.HeaderText = "DivisionId";
            this.divisionIdDataGridViewTextBoxColumn.Name = "divisionIdDataGridViewTextBoxColumn";
            this.divisionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // residenceIdDataGridViewTextBoxColumn
            // 
            this.residenceIdDataGridViewTextBoxColumn.DataPropertyName = "ResidenceId";
            this.residenceIdDataGridViewTextBoxColumn.HeaderText = "ResidenceId";
            this.residenceIdDataGridViewTextBoxColumn.Name = "residenceIdDataGridViewTextBoxColumn";
            this.residenceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.residenceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // residenceNoDataGridViewTextBoxColumn
            // 
            this.residenceNoDataGridViewTextBoxColumn.DataPropertyName = "ResidenceNo";
            this.residenceNoDataGridViewTextBoxColumn.HeaderText = "—ﬁ„ «·«ﬁ«„…";
            this.residenceNoDataGridViewTextBoxColumn.Name = "residenceNoDataGridViewTextBoxColumn";
            this.residenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residenceRemarkDataGridViewTextBoxColumn
            // 
            this.residenceRemarkDataGridViewTextBoxColumn.DataPropertyName = "ResidenceRemark";
            this.residenceRemarkDataGridViewTextBoxColumn.HeaderText = "ResidenceRemark";
            this.residenceRemarkDataGridViewTextBoxColumn.Name = "residenceRemarkDataGridViewTextBoxColumn";
            this.residenceRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.residenceRemarkDataGridViewTextBoxColumn.Visible = false;
            // 
            // residenceIssueDateDataGridViewTextBoxColumn
            // 
            this.residenceIssueDateDataGridViewTextBoxColumn.DataPropertyName = "ResidenceIssueDate";
            this.residenceIssueDateDataGridViewTextBoxColumn.HeaderText = "ResidenceIssueDate";
            this.residenceIssueDateDataGridViewTextBoxColumn.Name = "residenceIssueDateDataGridViewTextBoxColumn";
            this.residenceIssueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.residenceIssueDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // residenceEndDateDataGridViewTextBoxColumn
            // 
            this.residenceEndDateDataGridViewTextBoxColumn.DataPropertyName = "ResidenceEndDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.residenceEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.residenceEndDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «‰ Â«¡ «·«ﬁ«„…";
            this.residenceEndDateDataGridViewTextBoxColumn.Name = "residenceEndDateDataGridViewTextBoxColumn";
            this.residenceEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.residenceEndDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // licenseNoDataGridViewTextBoxColumn
            // 
            this.licenseNoDataGridViewTextBoxColumn.DataPropertyName = "LicenseNo";
            this.licenseNoDataGridViewTextBoxColumn.HeaderText = "—ﬁ„ «·—«Œ’…";
            this.licenseNoDataGridViewTextBoxColumn.Name = "licenseNoDataGridViewTextBoxColumn";
            this.licenseNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenseTypeIdDataGridViewTextBoxColumn
            // 
            this.licenseTypeIdDataGridViewTextBoxColumn.DataPropertyName = "LicenseTypeId";
            this.licenseTypeIdDataGridViewTextBoxColumn.HeaderText = "LicenseTypeId";
            this.licenseTypeIdDataGridViewTextBoxColumn.Name = "licenseTypeIdDataGridViewTextBoxColumn";
            this.licenseTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // licenseIssueDateDataGridViewTextBoxColumn
            // 
            this.licenseIssueDateDataGridViewTextBoxColumn.DataPropertyName = "LicenseIssueDate";
            this.licenseIssueDateDataGridViewTextBoxColumn.HeaderText = "LicenseIssueDate";
            this.licenseIssueDateDataGridViewTextBoxColumn.Name = "licenseIssueDateDataGridViewTextBoxColumn";
            this.licenseIssueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseIssueDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // licenseEndDateDataGridViewTextBoxColumn
            // 
            this.licenseEndDateDataGridViewTextBoxColumn.DataPropertyName = "LicenseEndDate";
            dataGridViewCellStyle6.Format = "d";
            this.licenseEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.licenseEndDateDataGridViewTextBoxColumn.HeaderText = " «—ÌŒ «‰ Â«¡ «·—«Œ’…";
            this.licenseEndDateDataGridViewTextBoxColumn.Name = "licenseEndDateDataGridViewTextBoxColumn";
            this.licenseEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseEndDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // workTelDataGridViewTextBoxColumn
            // 
            this.workTelDataGridViewTextBoxColumn.DataPropertyName = "HomeTel";
            this.workTelDataGridViewTextBoxColumn.HeaderText = "Â« › «·„‰“·";
            this.workTelDataGridViewTextBoxColumn.Name = "workTelDataGridViewTextBoxColumn";
            this.workTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobile1DataGridViewTextBoxColumn
            // 
            this.mobile1DataGridViewTextBoxColumn.DataPropertyName = "Mobile1";
            this.mobile1DataGridViewTextBoxColumn.HeaderText = "«·„Ê»Ì·";
            this.mobile1DataGridViewTextBoxColumn.Name = "mobile1DataGridViewTextBoxColumn";
            this.mobile1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(953, 518);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtFoName);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.UnitsDGView);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.Label7);
            this.Name = "EmpList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "⁄—÷ »Ì«‰«  «·„ÊŸ›Ì‰";
            this.Text = "»Ì«‰«  «·„ÊŸ›Ì‰";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button DelCmd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACTYPECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACTYPEDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEMFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALECYCLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dECFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCUMFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDURONCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDEDPERCENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACATIONCLASSCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIODFLAGDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView UnitsDGView;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        private System.Windows.Forms.BindingSource cDEDEPTBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_DEPTTableAdapter cDE_DEPTTableAdapter;
        private System.Windows.Forms.BindingSource cDENATIONALITYBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter cDE_NATIONALITYTableAdapter;
        public System.Windows.Forms.TextBox txtFoName;
        public System.Windows.Forms.TextBox txtTName;
        public System.Windows.Forms.TextBox txtSName;
        public System.Windows.Forms.TextBox txtFname;
        internal System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIVILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEngNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEngNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEngNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foEngNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPBIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPBIRTHPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dEPTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPHIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECTYPECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nATIONALITYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOVERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationMajoredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationMajoredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationMajoredPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceIssueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIssueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile1DataGridViewTextBoxColumn;

    }
}