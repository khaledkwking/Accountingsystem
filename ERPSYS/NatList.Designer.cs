namespace ERPSYS
{
    partial class NatList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NatList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveCmd = new System.Windows.Forms.Button();
            this.DelCmd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.UnitsDGView = new System.Windows.Forms.DataGridView();
            this.nATIONALITYCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATIONALITYDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDENATIONALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataSet = new ERPSYS.PersonalDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.cDE_NATIONALITYTableAdapter = new ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).BeginInit();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.UnitsDGView, "UnitsDGView");
            this.UnitsDGView.AutoGenerateColumns = false;
            this.UnitsDGView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UnitsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nATIONALITYCODEDataGridViewTextBoxColumn,
            this.nATIONALITYDESCDataGridViewTextBoxColumn});
            this.UnitsDGView.DataSource = this.cDENATIONALITYBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitsDGView.EnableHeadersVisualStyles = false;
            this.UnitsDGView.MultiSelect = false;
            this.UnitsDGView.Name = "UnitsDGView";
            this.UnitsDGView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UnitsDGView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.UnitsDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitsDGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.UnitsDGView_DataError);
            this.UnitsDGView.SelectionChanged += new System.EventHandler(this.StoresDGView_SelectionChanged);
            // 
            // nATIONALITYCODEDataGridViewTextBoxColumn
            // 
            this.nATIONALITYCODEDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY_CODE";
            resources.ApplyResources(this.nATIONALITYCODEDataGridViewTextBoxColumn, "nATIONALITYCODEDataGridViewTextBoxColumn");
            this.nATIONALITYCODEDataGridViewTextBoxColumn.Name = "nATIONALITYCODEDataGridViewTextBoxColumn";
            this.nATIONALITYCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nATIONALITYDESCDataGridViewTextBoxColumn
            // 
            this.nATIONALITYDESCDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY_DESC";
            resources.ApplyResources(this.nATIONALITYDESCDataGridViewTextBoxColumn, "nATIONALITYDESCDataGridViewTextBoxColumn");
            this.nATIONALITYDESCDataGridViewTextBoxColumn.Name = "nATIONALITYDESCDataGridViewTextBoxColumn";
            this.nATIONALITYDESCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDENATIONALITYBindingSource
            // 
            this.cDENATIONALITYBindingSource.DataMember = "CDE_NATIONALITY";
            this.cDENATIONALITYBindingSource.DataSource = this.personalDataSet;
            // 
            // personalDataSet
            // 
            this.personalDataSet.DataSetName = "PersonalDataSet";
            this.personalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDENATIONALITYBindingSource, "NATIONALITY_CODE", true));
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            // 
            // txtdesc
            // 
            this.txtdesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDENATIONALITYBindingSource, "NATIONALITY_DESC", true));
            resources.ApplyResources(this.txtdesc, "txtdesc");
            this.txtdesc.Name = "txtdesc";
            // 
            // cDE_NATIONALITYTableAdapter
            // 
            this.cDE_NATIONALITYTableAdapter.ClearBeforeFill = true;
            // 
            // NatList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.UnitsDGView);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label7);
            this.Name = "NatList";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDENATIONALITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView UnitsDGView;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonalDataSet personalDataSet;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.BindingSource cDENATIONALITYBindingSource;
        private ERPSYS.PersonalDataSetTableAdapters.CDE_NATIONALITYTableAdapter cDE_NATIONALITYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATIONALITYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATIONALITYDESCDataGridViewTextBoxColumn;

    }
}