namespace ERPSYS
{
    partial class UnitsTypeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitsTypeAdd));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUintDesc = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.txtUintDesc);
            this.groupBox3.Controls.Add(this.lblEmpName);
            this.errorProvider1.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtUintDesc
            // 
            this.txtUintDesc.AccessibleDescription = null;
            this.txtUintDesc.AccessibleName = null;
            resources.ApplyResources(this.txtUintDesc, "txtUintDesc");
            this.txtUintDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtUintDesc.BackgroundImage = null;
            this.txtUintDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errorProvider1.SetError(this.txtUintDesc, resources.GetString("txtUintDesc.Error"));
            this.txtUintDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.txtUintDesc, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUintDesc.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtUintDesc, ((int)(resources.GetObject("txtUintDesc.IconPadding"))));
            this.txtUintDesc.Name = "txtUintDesc";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AccessibleDescription = null;
            this.lblEmpName.AccessibleName = null;
            resources.ApplyResources(this.lblEmpName, "lblEmpName");
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider1.SetError(this.lblEmpName, resources.GetString("lblEmpName.Error"));
            this.lblEmpName.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.lblEmpName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmpName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblEmpName, ((int)(resources.GetObject("lblEmpName.IconPadding"))));
            this.lblEmpName.Name = "lblEmpName";
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleDescription = null;
            this.BtnAdd.AccessibleName = null;
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.BackgroundImage = null;
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorProvider1.SetError(this.BtnAdd, resources.GetString("BtnAdd.Error"));
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.BtnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BtnAdd.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.BtnAdd, ((int)(resources.GetObject("BtnAdd.IconPadding"))));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.AccessibleDescription = null;
            this.CmdCancel.AccessibleName = null;
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.BackgroundImage = null;
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.CmdCancel, resources.GetString("CmdCancel.Error"));
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.CmdCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CmdCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CmdCancel, ((int)(resources.GetObject("CmdCancel.IconPadding"))));
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.AccessibleDescription = null;
            this.CmdAdd.AccessibleName = null;
            resources.ApplyResources(this.CmdAdd, "CmdAdd");
            this.CmdAdd.BackgroundImage = null;
            this.errorProvider1.SetError(this.CmdAdd, resources.GetString("CmdAdd.Error"));
            this.CmdAdd.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.CmdAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CmdAdd.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CmdAdd, ((int)(resources.GetObject("CmdAdd.IconPadding"))));
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.UseVisualStyleBackColor = true;
            // 
            // UnitsTypeAdd
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = null;
            this.CausesValidation = false;
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.groupBox3);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = null;
            this.Name = "UnitsTypeAdd";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtUintDesc;
        public System.Windows.Forms.Label lblEmpName;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button BtnAdd;
      
        

    }
}