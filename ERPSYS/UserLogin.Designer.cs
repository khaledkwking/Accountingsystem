namespace ERPSYS
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBranch = new System.Windows.Forms.Label();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter();
            this.bRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter();
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.ForeColor = System.Drawing.Color.Blue;
            this.Cancel.Name = "Cancel";
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.OK.ForeColor = System.Drawing.Color.Blue;
            this.OK.Name = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // UsernameTextBox
            // 
            resources.ApplyResources(this.UsernameTextBox, "UsernameTextBox");
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsernameTextBox_KeyUp);
            this.UsernameTextBox.Validated += new System.EventHandler(this.UsernameTextBox_Validated);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblBranch
            // 
            resources.ApplyResources(this.lblBranch, "lblBranch");
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.ForeColor = System.Drawing.Color.Red;
            this.lblBranch.Name = "lblBranch";
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
            // bRANCHESBindingSource
            // 
            this.bRANCHESBindingSource.DataMember = "BRANCHES";
            this.bRANCHESBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // bRANCHESTableAdapter
            // 
            this.bRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // uSERBindingSource1
            // 
            this.uSERBindingSource1.DataMember = "USER";
            this.uSERBindingSource1.DataSource = this.nEWERPDataSet;
            // 
            // UserLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource bRANCHESBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.BRANCHESTableAdapter bRANCHESTableAdapter;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.BindingSource uSERBindingSource1;

    }
}
