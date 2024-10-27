namespace ERPSYS
{
    partial class FormsContractWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsContractWork));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.pEREMPLOYEEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label20 = new System.Windows.Forms.Label();
            this.pER_EMPLOYEE_DATATableAdapter = new ERPSYS.PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.txtUsePeroid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDinar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.CmdCancel.Location = new System.Drawing.Point(193, 425);
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
            this.CmbEmp.Location = new System.Drawing.Point(123, 135);
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.Size = new System.Drawing.Size(397, 26);
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
            this.label20.Location = new System.Drawing.Point(533, 138);
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
            this.BtnPrint.Location = new System.Drawing.Point(321, 425);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPrint.Size = new System.Drawing.Size(90, 33);
            this.BtnPrint.TabIndex = 193;
            this.BtnPrint.Text = "ÿ»«⁄… «·⁄ﬁœ";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtUsePeroid
            // 
            this.txtUsePeroid.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsePeroid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsePeroid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsePeroid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsePeroid.Location = new System.Drawing.Point(52, 258);
            this.txtUsePeroid.MaxLength = 0;
            this.txtUsePeroid.Name = "txtUsePeroid";
            this.txtUsePeroid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsePeroid.Size = new System.Drawing.Size(468, 25);
            this.txtUsePeroid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(577, 261);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 248;
            this.label4.Text = "›ﬁÿ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartDate.Location = new System.Drawing.Point(354, 186);
            this.txtStartDate.MaxLength = 0;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartDate.Size = new System.Drawing.Size(166, 25);
            this.txtStartDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(534, 189);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 247;
            this.label5.Text = "„œ… «·⁄ﬁœ „‰";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(563, 228);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 246;
            this.label6.Text = "«·—« »";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(351, 228);
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
            this.txtDinar.Location = new System.Drawing.Point(382, 225);
            this.txtDinar.MaxLength = 0;
            this.txtDinar.Name = "txtDinar";
            this.txtDinar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDinar.Size = new System.Drawing.Size(138, 25);
            this.txtDinar.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(318, 189);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 251;
            this.label9.Text = "«·Ï";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndDate.Location = new System.Drawing.Point(131, 189);
            this.txtEndDate.MaxLength = 0;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndDate.Size = new System.Drawing.Size(166, 25);
            this.txtEndDate.TabIndex = 252;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(277, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 253;
            this.label1.Text = "⁄ﬁ‹‹‹œ ⁄„‹‹‹‹‹‹·";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtsCompanyName
            // 
            this.txtsCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtsCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsCompanyName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsCompanyName.Location = new System.Drawing.Point(52, 94);
            this.txtsCompanyName.MaxLength = 0;
            this.txtsCompanyName.Name = "txtsCompanyName";
            this.txtsCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsCompanyName.Size = new System.Drawing.Size(468, 25);
            this.txtsCompanyName.TabIndex = 254;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(539, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 255;
            this.label2.Text = "√”„ «·‘—ﬂ…";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormsContractWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 780);
            this.Controls.Add(this.txtsCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDinar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsePeroid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CmbEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormsContractWork";
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
        public System.Windows.Forms.TextBox txtUsePeroid;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtStartDate;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDinar;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtEndDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtsCompanyName;
        public System.Windows.Forms.Label label2;
    }
}