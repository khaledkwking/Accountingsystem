namespace ERPSYS
{
    partial class CurrencyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyList));
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dEPT_CODETextBox = new System.Windows.Forms.TextBox();
            this.cDECurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.dEPT_DESCTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitsDGView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDE_CurrencyTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDECurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).BeginInit();
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
            this.DelCmd.Name = "DelCmd";
            this.DelCmd.Click += new System.EventHandler(this.DelCmd_Click);
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Name = "Label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dEPT_CODETextBox
            // 
            this.dEPT_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDECurrencyBindingSource, "CurId", true));
            resources.ApplyResources(this.dEPT_CODETextBox, "dEPT_CODETextBox");
            this.dEPT_CODETextBox.Name = "dEPT_CODETextBox";
            // 
            // cDECurrencyBindingSource
            // 
            this.cDECurrencyBindingSource.DataMember = "CDE_Currency";
            this.cDECurrencyBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPT_DESCTextBox
            // 
            this.dEPT_DESCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDECurrencyBindingSource, "CurDesc", true));
            resources.ApplyResources(this.dEPT_DESCTextBox, "dEPT_DESCTextBox");
            this.dEPT_DESCTextBox.Name = "dEPT_DESCTextBox";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDECurrencyBindingSource, "TransFactor", true));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.UnitsDGView.DataSource = this.cDECurrencyBindingSource;
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitsDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UnitsDGView.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.UnitsDGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsDGView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.UnitsDGView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CurId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CurDesc";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TransFactor";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cDE_CurrencyTableAdapter
            // 
            this.cDE_CurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // CurrencyList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.UnitsDGView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dEPT_DESCTextBox);
            this.Controls.Add(this.dEPT_CODETextBox);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.DelCmd);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label7);
            this.Name = "CurrencyList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDECurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button DelCmd;
        internal System.Windows.Forms.Button SaveCmd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox dEPT_DESCTextBox;
        private System.Windows.Forms.TextBox dEPT_CODETextBox;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn curIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transFactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView UnitsDGView;
        private System.Windows.Forms.BindingSource cDECurrencyBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.CDE_CurrencyTableAdapter cDE_CurrencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}