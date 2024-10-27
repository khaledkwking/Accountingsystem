namespace ERPSYS
{
    partial class Form4
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
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.accountingTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            this.dockLayoutManager = new Xceed.DockingWindows.DockLayoutManager();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockLayoutManager)).BeginInit();
            this.SuspendLayout();
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // dockLayoutManager
            // 
            this.dockLayoutManager.Initialize(this, null);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(531, 273);
            this.IsMdiContainer = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Validated += new System.EventHandler(this.Form4_Validated);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockLayoutManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter accountingTableAdapter;
        private Xceed.DockingWindows.DockLayoutManager dockLayoutManager;
    }
}