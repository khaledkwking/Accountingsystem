namespace ERPSYS
{
    partial class VactionTypesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VactionTypesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaveCmd = new System.Windows.Forms.Button();
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.UnitsDGView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAXNUM = new System.Windows.Forms.TextBox();
            this.txtSALDEDPERCENT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dEC_FLAGCheckBox = new System.Windows.Forms.CheckBox();
            this.pERIOD_FLAGCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cDEPERVACSUBCLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDE_PER_VAC_SUB_CLASSTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_PER_VAC_SUB_CLASSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERVACSUBCLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txDesc
            // 
            this.txDesc.AcceptsReturn = true;
            this.txDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERVACSUBCLASSBindingSource, "VAC_TYPE_DESC", true));
            this.txDesc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txDesc.Location = new System.Drawing.Point(113, 33);
            this.txDesc.MaxLength = 0;
            this.txDesc.Name = "txDesc";
            this.txDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txDesc.Size = new System.Drawing.Size(483, 25);
            this.txDesc.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "≈”„ «·«Ã«“…";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERVACSUBCLASSBindingSource, "VAC_TYPE_CODE", true));
            this.txtUnitCode.Enabled = false;
            this.txtUnitCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUnitCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUnitCode.Location = new System.Drawing.Point(113, 3);
            this.txtUnitCode.MaxLength = 0;
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitCode.Size = new System.Drawing.Size(115, 25);
            this.txtUnitCode.TabIndex = 69;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(14, 6);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(63, 18);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "ﬂÊœ «·«Ã«“…";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SaveCmd
            // 
            this.SaveCmd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.SaveCmd.ForeColor = System.Drawing.Color.Black;
            this.SaveCmd.Image = ((System.Drawing.Image)(resources.GetObject("SaveCmd.Image")));
            this.SaveCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveCmd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveCmd.Location = new System.Drawing.Point(277, 431);
            this.SaveCmd.Name = "SaveCmd";
            this.SaveCmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveCmd.Size = new System.Drawing.Size(82, 33);
            this.SaveCmd.TabIndex = 51;
            this.SaveCmd.Text = "Õ›Ÿ";
            this.SaveCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveCmd.UseVisualStyleBackColor = true;
            this.SaveCmd.Click += new System.EventHandler(this.SaveCmd_Click);
            // 
            // DelCmd
            // 
            this.DelCmd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.DelCmd.ForeColor = System.Drawing.Color.Black;
            this.DelCmd.Image = ((System.Drawing.Image)(resources.GetObject("DelCmd.Image")));
            this.DelCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelCmd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelCmd.Location = new System.Drawing.Point(389, 431);
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
            this.CmdCancel.Location = new System.Drawing.Point(501, 431);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(82, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdd.Image")));
            this.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmdAdd.Location = new System.Drawing.Point(165, 431);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(82, 33);
            this.CmdAdd.TabIndex = 49;
            this.CmdAdd.Text = "√÷«›…";
            this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.UnitsDGView.DataSource = this.cDEPERVACSUBCLASSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitsDGView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UnitsDGView.EnableHeadersVisualStyles = false;
            this.UnitsDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.UnitsDGView.Location = new System.Drawing.Point(14, 167);
            this.UnitsDGView.MultiSelect = false;
            this.UnitsDGView.Name = "UnitsDGView";
            this.UnitsDGView.ReadOnly = true;
            this.UnitsDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UnitsDGView.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.UnitsDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitsDGView.Size = new System.Drawing.Size(720, 251);
            this.UnitsDGView.TabIndex = 76;
            this.UnitsDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.UnitsDGView_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "«ﬁ’Ï ⁄œœ «Ì«„";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "√Ã«“… ”‰ÊÌ…";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "€Ì— „œ›Ê⁄… «·«Ã—";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMAXNUM
            // 
            this.txtMAXNUM.AcceptsReturn = true;
            this.txtMAXNUM.BackColor = System.Drawing.SystemColors.Window;
            this.txtMAXNUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMAXNUM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERVACSUBCLASSBindingSource, "MAX_NUM", true));
            this.txtMAXNUM.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMAXNUM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMAXNUM.Location = new System.Drawing.Point(113, 64);
            this.txtMAXNUM.MaxLength = 0;
            this.txtMAXNUM.Name = "txtMAXNUM";
            this.txtMAXNUM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMAXNUM.Size = new System.Drawing.Size(235, 25);
            this.txtMAXNUM.TabIndex = 80;
            // 
            // txtSALDEDPERCENT
            // 
            this.txtSALDEDPERCENT.AcceptsReturn = true;
            this.txtSALDEDPERCENT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSALDEDPERCENT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSALDEDPERCENT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERVACSUBCLASSBindingSource, "SAL_DED_PERCENT", true));
            this.txtSALDEDPERCENT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSALDEDPERCENT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSALDEDPERCENT.Location = new System.Drawing.Point(255, 120);
            this.txtSALDEDPERCENT.MaxLength = 0;
            this.txtSALDEDPERCENT.Name = "txtSALDEDPERCENT";
            this.txtSALDEDPERCENT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSALDEDPERCENT.Size = new System.Drawing.Size(235, 25);
            this.txtSALDEDPERCENT.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(165, 123);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "‰”»… «·«” ﬁÿ«⁄";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dEC_FLAGCheckBox
            // 
            this.dEC_FLAGCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cDEPERVACSUBCLASSBindingSource, "DEC_FLAG", true));
            this.dEC_FLAGCheckBox.Location = new System.Drawing.Point(115, 121);
            this.dEC_FLAGCheckBox.Name = "dEC_FLAGCheckBox";
            this.dEC_FLAGCheckBox.Size = new System.Drawing.Size(26, 24);
            this.dEC_FLAGCheckBox.TabIndex = 83;
            // 
            // pERIOD_FLAGCheckBox
            // 
            this.pERIOD_FLAGCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cDEPERVACSUBCLASSBindingSource, "PERIOD_FLAG", true));
            this.pERIOD_FLAGCheckBox.Location = new System.Drawing.Point(114, 93);
            this.pERIOD_FLAGCheckBox.Name = "pERIOD_FLAGCheckBox";
            this.pERIOD_FLAGCheckBox.Size = new System.Drawing.Size(25, 24);
            this.pERIOD_FLAGCheckBox.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(498, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "%";
            // 
            // cDEPERVACSUBCLASSBindingSource
            // 
            this.cDEPERVACSUBCLASSBindingSource.DataMember = "CDE_PER_VAC_SUB_CLASS";
            this.cDEPERVACSUBCLASSBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VAC_TYPE_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "«·ﬂÊœ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VAC_TYPE_DESC";
            this.dataGridViewTextBoxColumn3.HeaderText = "√”„ «·«Ã«“…";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAX_NUM";
            this.dataGridViewTextBoxColumn4.HeaderText = "√ﬁ’Ï ⁄œœ «Ì«„";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PERIOD_FLAG";
            this.dataGridViewTextBoxColumn1.HeaderText = "œÊ—Ì…";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DEC_FLAG";
            this.dataGridViewTextBoxColumn7.HeaderText = " ” ﬁÿ⁄ „‰ «·—« »";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SAL_DED_PERCENT";
            this.dataGridViewTextBoxColumn11.HeaderText = "‰”»… «·«” ﬁÿ«⁄";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FEM_FLAG";
            this.dataGridViewTextBoxColumn5.HeaderText = "FEM_FLAG";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CALE_CYCLE";
            this.dataGridViewTextBoxColumn6.HeaderText = "CALE_CYCLE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ACCUM_FLAG";
            this.dataGridViewTextBoxColumn8.HeaderText = "ACCUM_FLAG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MAX_DUR_ONCE";
            this.dataGridViewTextBoxColumn9.HeaderText = "MAX_DUR_ONCE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MAX_DUR";
            this.dataGridViewTextBoxColumn10.HeaderText = "MAX_DUR";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BALANCE_FLAG";
            this.dataGridViewTextBoxColumn12.HeaderText = "BALANCE_FLAG";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VACATION_CLASS_CODE";
            this.dataGridViewTextBoxColumn13.HeaderText = "VACATION_CLASS_CODE";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // cDE_PER_VAC_SUB_CLASSTableAdapter
            // 
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.ClearBeforeFill = true;
            // 
            // VactionTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(740, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pERIOD_FLAGCheckBox);
            this.Controls.Add(this.dEC_FLAGCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSALDEDPERCENT);
            this.Controls.Add(this.txtMAXNUM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnitsDGView);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.txDesc);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.Label7);
            this.Name = "VactionTypesList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "«·«Ã«“« ";
            this.Text = "«·«Ã«“« ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERVACSUBCLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txDesc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnitCode;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
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
        private System.Windows.Forms.BindingSource cDEPERVACSUBCLASSBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_PER_VAC_SUB_CLASSTableAdapter cDE_PER_VAC_SUB_CLASSTableAdapter;
        internal System.Windows.Forms.DataGridView UnitsDGView;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSALDEDPERCENT;
        public System.Windows.Forms.TextBox txtMAXNUM;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dEC_FLAGCheckBox;
        private System.Windows.Forms.CheckBox pERIOD_FLAGCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label6;

    }
}