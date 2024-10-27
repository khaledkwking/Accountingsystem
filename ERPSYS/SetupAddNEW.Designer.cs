namespace ERPSYS
{
    partial class SetupAddNEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupAddNEW));
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.InvtabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.compActivtyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPic = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.companyNameEngTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.telPhoneEngTextBox = new System.Windows.Forms.TextBox();
            this.telPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressEngTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            this.InvtabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            resources.ApplyResources(this.CmdSave, "CmdSave");
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // InvtabControl
            // 
            this.InvtabControl.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.InvtabControl, "InvtabControl");
            this.InvtabControl.Name = "InvtabControl";
            this.InvtabControl.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.compActivtyTextBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.companyNameEngTextBox);
            this.tabPage2.Controls.Add(this.companyNameTextBox);
            this.tabPage2.Controls.Add(this.telPhoneEngTextBox);
            this.tabPage2.Controls.Add(this.telPhoneTextBox);
            this.tabPage2.Controls.Add(this.addressEngTextBox);
            this.tabPage2.Controls.Add(this.addressTextBox);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "Email", true));
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "FaxEng", true));
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "Fax", true));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Name = "label20";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Name = "label19";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Name = "label17";
            // 
            // compActivtyTextBox
            // 
            this.compActivtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "CompActivty", true));
            resources.ApplyResources(this.compActivtyTextBox, "compActivtyTextBox");
            this.compActivtyTextBox.Name = "compActivtyTextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPic);
            this.groupBox2.Controls.Add(this.logoPictureBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // BtnPic
            // 
            resources.ApplyResources(this.BtnPic, "BtnPic");
            this.BtnPic.ForeColor = System.Drawing.Color.Black;
            this.BtnPic.Name = "BtnPic";
            this.BtnPic.UseVisualStyleBackColor = true;
            this.BtnPic.Click += new System.EventHandler(this.BtnPic_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.setupBindingSource, "Logo", true));
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.DoubleClick += new System.EventHandler(this.logoPictureBox_DoubleClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // companyNameEngTextBox
            // 
            this.companyNameEngTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "CompanyNameEng", true));
            resources.ApplyResources(this.companyNameEngTextBox, "companyNameEngTextBox");
            this.companyNameEngTextBox.Name = "companyNameEngTextBox";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "CompanyName", true));
            resources.ApplyResources(this.companyNameTextBox, "companyNameTextBox");
            this.companyNameTextBox.Name = "companyNameTextBox";
            // 
            // telPhoneEngTextBox
            // 
            this.telPhoneEngTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "TelPhoneEng", true));
            resources.ApplyResources(this.telPhoneEngTextBox, "telPhoneEngTextBox");
            this.telPhoneEngTextBox.Name = "telPhoneEngTextBox";
            // 
            // telPhoneTextBox
            // 
            this.telPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "TelPhone", true));
            resources.ApplyResources(this.telPhoneTextBox, "telPhoneTextBox");
            this.telPhoneTextBox.Name = "telPhoneTextBox";
            // 
            // addressEngTextBox
            // 
            this.addressEngTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "AddressEng", true));
            resources.ApplyResources(this.addressEngTextBox, "addressEngTextBox");
            this.addressEngTextBox.Name = "addressEngTextBox";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "Address", true));
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SetupAddNEW
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.InvtabControl);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Name = "SetupAddNEW";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.SetupAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            this.InvtabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ERPSYS.NEWERPDataSet nEWERPDataSet;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.TabControl InvtabControl;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox companyNameEngTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox telPhoneEngTextBox;
        private System.Windows.Forms.TextBox telPhoneTextBox;
        private System.Windows.Forms.TextBox addressEngTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        internal System.Windows.Forms.Button BtnPic;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox compActivtyTextBox;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}