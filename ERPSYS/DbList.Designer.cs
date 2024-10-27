namespace ERPSYS
{
    partial class DbList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbList));
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DBlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveCmd = new System.Windows.Forms.Button();
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InvoiceschkBox = new System.Windows.Forms.CheckBox();
            this.QidschkBox = new System.Windows.Forms.CheckBox();
            this.AccountchkBox = new System.Windows.Forms.CheckBox();
            this.ProductschkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDbName
            // 
            resources.ApplyResources(this.txtDbName, "txtDbName");
            this.txtDbName.Name = "txtDbName";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // DBlistView
            // 
            this.DBlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.DBlistView, "DBlistView");
            this.DBlistView.FullRowSelect = true;
            this.DBlistView.HideSelection = false;
            this.DBlistView.Name = "DBlistView";
            this.DBlistView.UseCompatibleStateImageBehavior = false;
            this.DBlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
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
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InvoiceschkBox);
            this.groupBox1.Controls.Add(this.QidschkBox);
            this.groupBox1.Controls.Add(this.AccountchkBox);
            this.groupBox1.Controls.Add(this.ProductschkBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDbName);
            this.groupBox1.Controls.Add(this.SaveCmd);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // InvoiceschkBox
            // 
            resources.ApplyResources(this.InvoiceschkBox, "InvoiceschkBox");
            this.InvoiceschkBox.Name = "InvoiceschkBox";
            this.InvoiceschkBox.UseVisualStyleBackColor = true;
            this.InvoiceschkBox.CheckedChanged += new System.EventHandler(this.InvoiceschkBox_CheckedChanged);
            // 
            // QidschkBox
            // 
            resources.ApplyResources(this.QidschkBox, "QidschkBox");
            this.QidschkBox.Name = "QidschkBox";
            this.QidschkBox.UseVisualStyleBackColor = true;
            this.QidschkBox.CheckedChanged += new System.EventHandler(this.QidschkBox_CheckedChanged);
            // 
            // AccountchkBox
            // 
            resources.ApplyResources(this.AccountchkBox, "AccountchkBox");
            this.AccountchkBox.Name = "AccountchkBox";
            this.AccountchkBox.UseVisualStyleBackColor = true;
            // 
            // ProductschkBox
            // 
            resources.ApplyResources(this.ProductschkBox, "ProductschkBox");
            this.ProductschkBox.Name = "ProductschkBox";
            this.ProductschkBox.UseVisualStyleBackColor = true;
            // 
            // DbList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DBlistView);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.CmdCancel);
            this.Name = "DbList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.TextBox txtDbName;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DBlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AccountchkBox;
        private System.Windows.Forms.CheckBox ProductschkBox;
        private System.Windows.Forms.CheckBox InvoiceschkBox;
        private System.Windows.Forms.CheckBox QidschkBox;

    }
}