namespace ERPSYS
{
    partial class FormsRepresentPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsRepresentPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.txtApplyDate = new System.Windows.Forms.TextBox();
            this.txtworkOnwer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVisatype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StockDGView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(216, 663);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(82, 33);
            this.CmdCancel.TabIndex = 48;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
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
            this.BtnPrint.Location = new System.Drawing.Point(344, 663);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPrint.Size = new System.Drawing.Size(78, 33);
            this.BtnPrint.TabIndex = 193;
            this.BtnPrint.Text = "„⁄«Ì‰…";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Cursor = System.Windows.Forms.Cursors.Default;
            this.label68.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.Blue;
            this.label68.Location = new System.Drawing.Point(556, 91);
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
            this.txtApplyDate.Location = new System.Drawing.Point(298, 90);
            this.txtApplyDate.MaxLength = 0;
            this.txtApplyDate.Name = "txtApplyDate";
            this.txtApplyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtApplyDate.Size = new System.Drawing.Size(193, 25);
            this.txtApplyDate.TabIndex = 0;
            // 
            // txtworkOnwer
            // 
            this.txtworkOnwer.BackColor = System.Drawing.SystemColors.Window;
            this.txtworkOnwer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtworkOnwer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkOnwer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtworkOnwer.Location = new System.Drawing.Point(112, 167);
            this.txtworkOnwer.MaxLength = 0;
            this.txtworkOnwer.Name = "txtworkOnwer";
            this.txtworkOnwer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtworkOnwer.Size = new System.Drawing.Size(380, 25);
            this.txtworkOnwer.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(560, 170);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(64, 18);
            this.label21.TabIndex = 234;
            this.label21.Text = "√”„ «·‘—ﬂ…";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(190, 35);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(259, 32);
            this.label9.TabIndex = 251;
            this.label9.Text = "‰„Ê–Ã «’œ«— »ÿ«ﬁ… „‰œÊ» ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVisatype
            // 
            this.cmbVisatype.AccessibleDescription = "";
            this.cmbVisatype.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVisatype.FormattingEnabled = true;
            this.cmbVisatype.Items.AddRange(new object[] {
            "≈’œ«—",
            "≈·€«¡",
            " ⁄œÌ· »Ì«‰« "});
            this.cmbVisatype.Location = new System.Drawing.Point(179, 208);
            this.cmbVisatype.Name = "cmbVisatype";
            this.cmbVisatype.Size = new System.Drawing.Size(313, 26);
            this.cmbVisatype.TabIndex = 255;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(563, 214);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 254;
            this.label10.Text = "‰Ê⁄ «·ÿ·»";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 25);
            this.dateTimePicker1.TabIndex = 256;
            // 
            // CmbEmp
            // 
            this.CmbEmp.AccessibleDescription = "";
            this.CmbEmp.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmp.DisplayMember = "FullName";
            this.CmbEmp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmp.FormattingEnabled = true;
            this.CmbEmp.Location = new System.Drawing.Point(191, 127);
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.Size = new System.Drawing.Size(301, 26);
            this.CmbEmp.TabIndex = 257;
            this.CmbEmp.ValueMember = "EMP_CODE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(591, 130);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(33, 18);
            this.label20.TabIndex = 258;
            this.label20.Text = "«·«”„";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(539, 257);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 259;
            this.label1.Text = "’·«ÕÌ… «·»ÿ«ﬁ…";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 250);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(20, 25);
            this.dateTimePicker2.TabIndex = 261;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(298, 250);
            this.textBox1.MaxLength = 0;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(171, 25);
            this.textBox1.TabIndex = 260;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(475, 253);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 262;
            this.label2.Text = "„‰";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(233, 253);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 263;
            this.label3.Text = "«·Ï";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker3.Location = new System.Drawing.Point(22, 249);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(20, 25);
            this.dateTimePicker3.TabIndex = 265;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(45, 250);
            this.textBox2.MaxLength = 0;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(171, 25);
            this.textBox2.TabIndex = 264;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(203, 374);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(268, 22);
            this.label4.TabIndex = 266;
            this.label4.Text = "·œÌ «·”«œ… «’Õ«» «· «·Ì… «·«⁄„«·  »Ì«‰« Â„";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StockDGView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDGView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StockDGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockDGView.EnableHeadersVisualStyles = false;
            this.StockDGView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockDGView.Location = new System.Drawing.Point(12, 304);
            this.StockDGView.MultiSelect = false;
            this.StockDGView.Name = "StockDGView";
            this.StockDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockDGView.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StockDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StockDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StockDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StockDGView.Size = new System.Drawing.Size(614, 308);
            this.StockDGView.TabIndex = 267;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "√”„ ’«Õ» «·⁄„·";
            this.Column1.Name = "Column1";
            this.Column1.Width = 420;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "—ﬁ„ «·„·›";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // FormsRepresentPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 727);
            this.Controls.Add(this.StockDGView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbVisatype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.txtApplyDate);
            this.Controls.Add(this.txtworkOnwer);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormsRepresentPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRes";
            this.Load += new System.EventHandler(this.FormsResAddRenew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pEREMPLOYEEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        internal System.Windows.Forms.Button BtnPrint;
        public System.Windows.Forms.Label label68;
        public System.Windows.Forms.TextBox txtApplyDate;
        public System.Windows.Forms.TextBox txtworkOnwer;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbVisatype;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.ComboBox CmbEmp;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DataGridView StockDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}