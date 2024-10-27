namespace ERPSYS
{
    partial class ChangeUserPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserPassword));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CmdCancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.errorProvider1.SetError(this.txtNewPassword, resources.GetString("txtNewPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNewPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNewPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNewPassword, ((int)(resources.GetObject("txtNewPassword.IconPadding"))));
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // txtOldPassword
            // 
            resources.ApplyResources(this.txtOldPassword, "txtOldPassword");
            this.errorProvider1.SetError(this.txtOldPassword, resources.GetString("txtOldPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtOldPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtOldPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtOldPassword, ((int)(resources.GetObject("txtOldPassword.IconPadding"))));
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsernameTextBox_KeyUp);
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.errorProvider1.SetError(this.PasswordLabel, resources.GetString("PasswordLabel.Error"));
            this.errorProvider1.SetIconAlignment(this.PasswordLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PasswordLabel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.PasswordLabel, ((int)(resources.GetObject("PasswordLabel.IconPadding"))));
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.errorProvider1.SetError(this.UsernameLabel, resources.GetString("UsernameLabel.Error"));
            this.errorProvider1.SetIconAlignment(this.UsernameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("UsernameLabel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.UsernameLabel, ((int)(resources.GetObject("UsernameLabel.IconPadding"))));
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // CmdCancel
            // 
            resources.ApplyResources(this.CmdCancel, "CmdCancel");
            this.CmdCancel.CausesValidation = false;
            this.errorProvider1.SetError(this.CmdCancel, resources.GetString("CmdCancel.Error"));
            this.CmdCancel.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.CmdCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CmdCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CmdCancel, ((int)(resources.GetObject("CmdCancel.IconPadding"))));
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.errorProvider1.SetError(this.OK, resources.GetString("OK.Error"));
            this.errorProvider1.SetIconAlignment(this.OK, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("OK.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.OK, ((int)(resources.GetObject("OK.IconPadding"))));
            this.OK.Name = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.errorProvider1.SetError(this.LogoPictureBox, resources.GetString("LogoPictureBox.Error"));
            this.errorProvider1.SetIconAlignment(this.LogoPictureBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LogoPictureBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.LogoPictureBox, ((int)(resources.GetObject("LogoPictureBox.IconPadding"))));
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeUserPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox txtNewPassword;
        internal System.Windows.Forms.TextBox txtOldPassword;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter  userTableAdapter;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Button CmdCancel;

    }
}
