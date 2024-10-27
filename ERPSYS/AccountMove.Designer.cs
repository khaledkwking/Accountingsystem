namespace ERPSYS
{
    partial class AccountMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountMove));
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(5, 34);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(191, 18);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "«·Õ”«» «·—∆Ì”Ï «·„ÿ·Ê» «·‰ﬁ· ⁄·ÌÂ";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 49);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(174, 12);
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
            this.CmdAdd.Location = new System.Drawing.Point(293, 13);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(82, 33);
            this.CmdAdd.TabIndex = 49;
            this.CmdAdd.Text = "‰ﬁ·";
            this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
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
            // cmbAccount
            // 
            this.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccount.DataSource = this.accountingBindingSource;
            this.cmbAccount.DisplayMember = "accountname";
            this.cmbAccount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(204, 31);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(377, 26);
            this.cmbAccount.TabIndex = 128;
            this.cmbAccount.ValueMember = "accountid";
            // 
            // AccountMove
            // 
            this.AcceptButton = this.CmdAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(585, 149);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.groupBox4);
            this.Name = "AccountMove";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "«·Õ”«»« ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label7;
        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.ComboBox cmbAccount;

    }
}