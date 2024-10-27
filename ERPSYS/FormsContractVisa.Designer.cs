namespace ERPSYS
{
    partial class FormsContractVisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsContractVisa));
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
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVisatype = new System.Windows.Forms.ComboBox();
            this.cmbApplyType = new System.Windows.Forms.ComboBox();
            this.cmbResType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFamNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.CmdCancel.Location = new System.Drawing.Point(206, 475);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(96, 33);
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
            this.CmbEmp.Location = new System.Drawing.Point(35, 116);
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
            this.label20.Location = new System.Drawing.Point(511, 119);
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
            this.BtnPrint.Location = new System.Drawing.Point(332, 475);
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
            this.label4.Location = new System.Drawing.Point(510, 163);
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
            this.label5.Location = new System.Drawing.Point(521, 239);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 247;
            this.label5.Text = "‰Ê⁄ «·ﬂ›Ì·";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonRel
            // 
            this.txtPersonRel.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonRel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonRel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonRel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPersonRel.Location = new System.Drawing.Point(161, 279);
            this.txtPersonRel.MaxLength = 0;
            this.txtPersonRel.Name = "txtPersonRel";
            this.txtPersonRel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonRel.Size = new System.Drawing.Size(303, 25);
            this.txtPersonRel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(481, 282);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 246;
            this.label6.Text = "’·… «·ﬁ—»Â »«·ﬂ›Ì·";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(518, 201);
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
            this.cmbVisatype.Location = new System.Drawing.Point(161, 158);
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
            "ÕﬂÊ„…",
            "‘—ﬂ…",
            "√›—«œ"});
            this.cmbApplyType.Location = new System.Drawing.Point(161, 234);
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
            this.cmbResType.Location = new System.Drawing.Point(161, 197);
            this.cmbResType.Name = "cmbResType";
            this.cmbResType.Size = new System.Drawing.Size(313, 26);
            this.cmbResType.TabIndex = 255;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(505, 322);
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
            this.txtFamNo.Location = new System.Drawing.Point(317, 319);
            this.txtFamNo.MaxLength = 0;
            this.txtFamNo.Name = "txtFamNo";
            this.txtFamNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFamNo.Size = new System.Drawing.Size(147, 25);
            this.txtFamNo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 256;
            this.label1.Text = "«” Œ—«Ã «· √‘Ì—…";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormsContractVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 727);
            this.Controls.Add(this.label1);
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
            this.Name = "FormsContractVisa";
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
        public System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbVisatype;
        internal System.Windows.Forms.ComboBox cmbApplyType;
        internal System.Windows.Forms.ComboBox cmbResType;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtFamNo;
        public System.Windows.Forms.Label label1;
    }
}