namespace ERPSYS
{
    partial class DbChangeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbChangeList));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.DBlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdChangeDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DBlistView
            // 
            this.DBlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.DBlistView, "DBlistView");
            this.DBlistView.FullRowSelect = true;
            this.DBlistView.HideSelection = false;
            this.DBlistView.MultiSelect = false;
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            // 
            // CmdChangeDB
            // 
            resources.ApplyResources(this.CmdChangeDB, "CmdChangeDB");
            this.CmdChangeDB.ForeColor = System.Drawing.Color.Black;
            this.CmdChangeDB.Name = "CmdChangeDB";
            this.CmdChangeDB.UseVisualStyleBackColor = true;
            this.CmdChangeDB.Click += new System.EventHandler(this.CmdChangeDB_Click);
            // 
            // DbChangeList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.CmdChangeDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DBlistView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdCancel);
            this.Name = "DbChangeList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DBlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button CmdChangeDB;

    }
}