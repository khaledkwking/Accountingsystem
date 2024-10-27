namespace ERPSYS
{
    partial class PENALTYList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PENALTYList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveCmd = new System.Windows.Forms.Button();
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.cDEPERPENALTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.UnitsDGView = new System.Windows.Forms.DataGridView();
            this.pENCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cDE_PER_PENALTYTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_PER_PENALTYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERPENALTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // txDesc
            // 
            this.txDesc.AcceptsReturn = true;
            this.txDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERPENALTYBindingSource, "PEN_DESC", true));
            resources.ApplyResources(this.txDesc, "txDesc");
            this.txDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txDesc.Name = "txDesc";
            // 
            // cDEPERPENALTYBindingSource
            // 
            this.cDEPERPENALTYBindingSource.DataMember = "CDE_PER_PENALTY";
            this.cDEPERPENALTYBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDEPERPENALTYBindingSource, "PEN_CODE", true));
            resources.ApplyResources(this.txtUnitCode, "txtUnitCode");
            this.txtUnitCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUnitCode.Name = "txtUnitCode";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // UnitsDGView
            // 
            this.UnitsDGView.AllowUserToAddRows = false;
            this.UnitsDGView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.UnitsDGView, "UnitsDGView");
            this.UnitsDGView.AutoGenerateColumns = false;
            this.UnitsDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UnitsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pENCODEDataGridViewTextBoxColumn,
            this.pENDESCDataGridViewTextBoxColumn});
            this.UnitsDGView.DataSource = this.cDEPERPENALTYBindingSource;
            this.UnitsDGView.EnableHeadersVisualStyles = false;
            this.UnitsDGView.MultiSelect = false;
            this.UnitsDGView.Name = "UnitsDGView";
            this.UnitsDGView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UnitsDGView.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.UnitsDGView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitsDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.UnitsDGView_DataError);
            this.UnitsDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // pENCODEDataGridViewTextBoxColumn
            // 
            this.pENCODEDataGridViewTextBoxColumn.DataPropertyName = "PEN_CODE";
            resources.ApplyResources(this.pENCODEDataGridViewTextBoxColumn, "pENCODEDataGridViewTextBoxColumn");
            this.pENCODEDataGridViewTextBoxColumn.Name = "pENCODEDataGridViewTextBoxColumn";
            this.pENCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pENDESCDataGridViewTextBoxColumn
            // 
            this.pENDESCDataGridViewTextBoxColumn.DataPropertyName = "PEN_DESC";
            resources.ApplyResources(this.pENDESCDataGridViewTextBoxColumn, "pENDESCDataGridViewTextBoxColumn");
            this.pENDESCDataGridViewTextBoxColumn.Name = "pENDESCDataGridViewTextBoxColumn";
            this.pENDESCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cDE_PER_PENALTYTableAdapter
            // 
            this.cDE_PER_PENALTYTableAdapter.ClearBeforeFill = true;
            // 
            // PENALTYList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.UnitsDGView);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.txDesc);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.Label7);
            this.Name = "PENALTYList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cDEPERPENALTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox txDesc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnitCode;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView UnitsDGView;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.BindingSource cDEPERPENALTYBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_PER_PENALTYTableAdapter cDE_PER_PENALTYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pENCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pENDESCDataGridViewTextBoxColumn;

    }
}