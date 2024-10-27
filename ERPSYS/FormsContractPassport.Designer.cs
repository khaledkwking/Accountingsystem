namespace ERPSYS
{
    partial class FormsContractPassport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsContractPassport));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label20 = new System.Windows.Forms.Label();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonRel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFamNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVisatype = new System.Windows.Forms.ComboBox();
            this.cmbApplyType = new System.Windows.Forms.ComboBox();
            this.cmbResType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
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
            this.CmdCancel.Location = new System.Drawing.Point(77, 475);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(82, 33);
            this.CmdCancel.TabIndex = 48;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmbEmp
            // 
            this.CmbEmp.AccessibleDescription = "";
            this.CmbEmp.DataSource = this.pEREMPLOYEEDATABindingSource;
            this.CmbEmp.DisplayMember = "FullName";
            this.CmbEmp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmp.FormattingEnabled = true;
            this.CmbEmp.Location = new System.Drawing.Point(43, 106);
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.Size = new System.Drawing.Size(439, 26);
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
            this.label20.Location = new System.Drawing.Point(547, 110);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(70, 18);
            this.label20.TabIndex = 192;
            this.label20.Text = "√”„ «·„ÊŸ›";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BtnPrint.Location = new System.Drawing.Point(412, 475);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPrint.Size = new System.Drawing.Size(100, 33);
            this.BtnPrint.TabIndex = 193;
            this.BtnPrint.Text = "ÿ»«⁄… ‰„Ê–Ã";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(546, 306);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 248;
            this.label4.Text = "‰Ê⁄ «· «‘Ì—…";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(556, 222);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 247;
            this.label5.Text = "‰Ê⁄ «·ÿ·»";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonRel
            // 
            this.txtPersonRel.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonRel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonRel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonRel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPersonRel.Location = new System.Drawing.Point(354, 339);
            this.txtPersonRel.MaxLength = 0;
            this.txtPersonRel.Name = "txtPersonRel";
            this.txtPersonRel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonRel.Size = new System.Drawing.Size(126, 25);
            this.txtPersonRel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(517, 343);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 246;
            this.label6.Text = "’·… «·ﬁ—»Â »«·ﬂ›Ì·";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(230, 342);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 249;
            this.label7.Text = "⁄œœ «·„—«›ﬁÌ‰";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFamNo
            // 
            this.txtFamNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtFamNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFamNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFamNo.Location = new System.Drawing.Point(102, 340);
            this.txtFamNo.MaxLength = 0;
            this.txtFamNo.Name = "txtFamNo";
            this.txtFamNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFamNo.Size = new System.Drawing.Size(116, 25);
            this.txtFamNo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(554, 262);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 251;
            this.label9.Text = "‰Ê⁄ «·«ﬁ«„…";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVisatype
            // 
            this.cmbVisatype.AccessibleDescription = "";
            this.cmbVisatype.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVisatype.FormattingEnabled = true;
            this.cmbVisatype.Items.AddRange(new object[] {
            "“Ì«—…",
            "⁄œ„ „„«‰⁄…",
            "”„… „—Ê—",
            "”„… ⁄Êœ…"});
            this.cmbVisatype.Location = new System.Drawing.Point(167, 297);
            this.cmbVisatype.Name = "cmbVisatype";
            this.cmbVisatype.Size = new System.Drawing.Size(313, 26);
            this.cmbVisatype.TabIndex = 253;
            // 
            // cmbApplyType
            // 
            this.cmbApplyType.AccessibleDescription = "";
            this.cmbApplyType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApplyType.FormattingEnabled = true;
            this.cmbApplyType.Items.AddRange(new object[] {
            "√ﬁ«„… «Ê· „—…",
            "‰ﬁ· ﬂ›«·…",
            " ÃœÌœ √ﬁ«„…",
            " ⁄œÌ· »Ì«‰« ",
            "‰ﬁ· «·≈ﬁ«„… »ÃÊ«“ ”›— ÃœÌœ",
            "≈·€«¡ ≈ﬁ«„…",
            "≈÷«›… „—«›ﬁ",
            "Õ–› „—«›ﬁ",
            "ﬂ«—  “Ì«—…"});
            this.cmbApplyType.Location = new System.Drawing.Point(167, 218);
            this.cmbApplyType.Name = "cmbApplyType";
            this.cmbApplyType.Size = new System.Drawing.Size(313, 26);
            this.cmbApplyType.TabIndex = 254;
            // 
            // cmbResType
            // 
            this.cmbResType.AccessibleDescription = "";
            this.cmbResType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResType.FormattingEnabled = true;
            this.cmbResType.Items.AddRange(new object[] {
            "≈ﬁ«„… „ƒﬁ …",
            "⁄„· »«·ÕﬂÊ„…",
            "⁄„· »«·ﬁÿ«⁄ «·√Â·Ì",
            "„“«Ê·… ‰‘«ÿ Õ—",
            "«·⁄„· ﬂŒ«œ„",
            "··œ—«”…",
            "≈· Õ«ﬁ »⁄«∆·",
            "„’œ— ≈‰›«ﬁ"});
            this.cmbResType.Location = new System.Drawing.Point(167, 257);
            this.cmbResType.Name = "cmbResType";
            this.cmbResType.Size = new System.Drawing.Size(313, 26);
            this.cmbResType.TabIndex = 255;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(299, 475);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 256;
            this.button1.Text = "ÿ»«⁄… ﬂ«— ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(171, 475);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 257;
            this.button2.Text = "ÿ»«⁄… «·Œ·›Ì… ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(243, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 258;
            this.label1.Text = "‰„«–Ã «·ÃÊ«“« ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleDescription = "";
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(167, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 26);
            this.comboBox1.TabIndex = 259;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(492, 150);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 260;
            this.label2.Text = "√”„ «·„ÊŸ› »«·«‰Ã·Ì“Ì…";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEngName
            // 
            this.txtEngName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEngName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEngName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEngName.Location = new System.Drawing.Point(41, 146);
            this.txtEngName.MaxLength = 0;
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEngName.Size = new System.Drawing.Size(442, 25);
            this.txtEngName.TabIndex = 261;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(558, 188);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 262;
            this.label3.Text = "«”„ «·ﬂ›Ì·";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOwner
            // 
            this.txtOwner.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwner.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOwner.Location = new System.Drawing.Point(41, 183);
            this.txtOwner.MaxLength = 0;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOwner.Size = new System.Drawing.Size(442, 25);
            this.txtOwner.TabIndex = 263;
            // 
            // FormsContractPassport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 727);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbResType);
            this.Controls.Add(this.cmbApplyType);
            this.Controls.Add(this.cmbVisatype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFamNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersonRel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmbEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormsContractPassport";
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
        internal System.Windows.Forms.ComboBox CmbEmp;
        public System.Windows.Forms.Label label20;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource pEREMPLOYEEDATABindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter;
        internal System.Windows.Forms.Button BtnPrint;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPersonRel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtFamNo;
        public System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbVisatype;
        internal System.Windows.Forms.ComboBox cmbApplyType;
        internal System.Windows.Forms.ComboBox cmbResType;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEngName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOwner;
    }
}