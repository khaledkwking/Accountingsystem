namespace ERPSYS
{
    partial class UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.MEMBER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AdaraDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.FunStat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.FunctionsDGView = new System.Windows.Forms.DataGridView();
            this.FunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioBtnManager = new System.Windows.Forms.RadioButton();
            this.RadioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.RadioBtnUser = new System.Windows.Forms.RadioButton();
            this.UsersDGView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdaraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGView)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdd.Image")));
            this.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAdd.Location = new System.Drawing.Point(622, 13);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(80, 33);
            this.CmdAdd.TabIndex = 49;
            this.CmdAdd.Text = "√÷«›…";
            this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.Location = new System.Drawing.Point(208, 13);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancel.Size = new System.Drawing.Size(80, 33);
            this.CmdCancel.TabIndex = 47;
            this.CmdCancel.Text = "Œ—ÊÃ";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSave.Location = new System.Drawing.Point(346, 13);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(80, 33);
            this.CmdSave.TabIndex = 50;
            this.CmdSave.Text = "Õ›Ÿ";
            this.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDel
            // 
            this.CmdDel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDel.Image = ((System.Drawing.Image)(resources.GetObject("CmdDel.Image")));
            this.CmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdDel.Location = new System.Drawing.Point(484, 13);
            this.CmdDel.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdDel.Size = new System.Drawing.Size(80, 33);
            this.CmdDel.TabIndex = 48;
            this.CmdDel.Text = "Õ–›";
            this.CmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdDel.UseVisualStyleBackColor = true;
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.CausesValidation = false;
            this.groupBox4.Controls.Add(this.CmdDel);
            this.groupBox4.Controls.Add(this.CmdSave);
            this.groupBox4.Controls.Add(this.CmdCancel);
            this.groupBox4.Controls.Add(this.CmdAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 530);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1014, 47);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(30, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Õ–›";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(171, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(100, 33);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = " ⁄œÌ·";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(320, 295);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddUser.Size = new System.Drawing.Size(100, 33);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "√÷«›…";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // MEMBER_ID
            // 
            this.MEMBER_ID.DataPropertyName = "MEMBER_ID";
            this.MEMBER_ID.HeaderText = "MEMBER_ID";
            this.MEMBER_ID.Name = "MEMBER_ID";
            this.MEMBER_ID.ReadOnly = true;
            this.MEMBER_ID.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Õ«·Ì/„⁄ÿ·";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STATUS.Width = 80;
            // 
            // AdaraDesc
            // 
            this.AdaraDesc.HeaderText = "«·«œ«—… «· «»⁄ ·Â«";
            this.AdaraDesc.Name = "AdaraDesc";
            this.AdaraDesc.ReadOnly = true;
            // 
            // USER_TYPE
            // 
            this.USER_TYPE.DataPropertyName = "USER_TYPE";
            this.USER_TYPE.HeaderText = "USER_TYPE";
            this.USER_TYPE.Name = "USER_TYPE";
            this.USER_TYPE.ReadOnly = true;
            this.USER_TYPE.Visible = false;
            // 
            // TEXT
            // 
            this.TEXT.DataPropertyName = "TEXT";
            this.TEXT.HeaderText = "«·’·«ÕÌ…";
            this.TEXT.Name = "TEXT";
            this.TEXT.ReadOnly = true;
            this.TEXT.Width = 250;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "Name";
            this.FName.HeaderText = "Name";
            this.FName.Name = "FName";
            this.FName.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(447, 442);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSave.Size = new System.Drawing.Size(100, 33);
            this.BtnSave.TabIndex = 489;
            this.BtnSave.Text = "Õ›Ÿ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // FunStat
            // 
            this.FunStat.HeaderText = "";
            this.FunStat.Name = "FunStat";
            this.FunStat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FunStat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FunStat.Width = 80;
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox3.Controls.Add(this.FunctionsDGView);
            this.GroupBox3.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox3.Location = new System.Drawing.Point(583, 71);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox3.Size = new System.Drawing.Size(403, 341);
            this.GroupBox3.TabIndex = 488;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "«·’·«ÕÌ« ";
            // 
            // FunctionsDGView
            // 
            this.FunctionsDGView.AllowUserToAddRows = false;
            this.FunctionsDGView.AllowUserToDeleteRows = false;
            this.FunctionsDGView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.FunctionsDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FunctionsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FunctionsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunID,
            this.FunStat,
            this.TEXT,
            this.FName});
            this.FunctionsDGView.Location = new System.Drawing.Point(19, 23);
            this.FunctionsDGView.Name = "FunctionsDGView";
            this.FunctionsDGView.RowHeadersVisible = false;
            this.FunctionsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FunctionsDGView.Size = new System.Drawing.Size(367, 279);
            this.FunctionsDGView.TabIndex = 15;
            // 
            // FunID
            // 
            this.FunID.DataPropertyName = "ID";
            this.FunID.HeaderText = "ID";
            this.FunID.Name = "FunID";
            this.FunID.Visible = false;
            // 
            // RadioBtnManager
            // 
            this.RadioBtnManager.AutoSize = true;
            this.RadioBtnManager.Location = new System.Drawing.Point(396, 18);
            this.RadioBtnManager.Name = "RadioBtnManager";
            this.RadioBtnManager.Size = new System.Drawing.Size(70, 19);
            this.RadioBtnManager.TabIndex = 480;
            this.RadioBtnManager.TabStop = true;
            this.RadioBtnManager.Text = "„œÌ— «·ﬁ”„";
            this.RadioBtnManager.UseVisualStyleBackColor = true;
            // 
            // RadioBtnAdmin
            // 
            this.RadioBtnAdmin.AutoSize = true;
            this.RadioBtnAdmin.Location = new System.Drawing.Point(210, 18);
            this.RadioBtnAdmin.Name = "RadioBtnAdmin";
            this.RadioBtnAdmin.Size = new System.Drawing.Size(72, 19);
            this.RadioBtnAdmin.TabIndex = 480;
            this.RadioBtnAdmin.TabStop = true;
            this.RadioBtnAdmin.Text = "„œÌ— «·‰Ÿ«„";
            this.RadioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // RadioBtnUser
            // 
            this.RadioBtnUser.AutoSize = true;
            this.RadioBtnUser.Location = new System.Drawing.Point(580, 18);
            this.RadioBtnUser.Name = "RadioBtnUser";
            this.RadioBtnUser.Size = new System.Drawing.Size(58, 19);
            this.RadioBtnUser.TabIndex = 480;
            this.RadioBtnUser.TabStop = true;
            this.RadioBtnUser.Text = "„” Œœ„";
            this.RadioBtnUser.UseVisualStyleBackColor = true;
            // 
            // UsersDGView
            // 
            this.UsersDGView.AllowUserToAddRows = false;
            this.UsersDGView.AllowUserToDeleteRows = false;
            this.UsersDGView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.UsersDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AdaraId,
            this.USER_NAME,
            this.PASSWORD,
            this.STATUS,
            this.AdaraDesc,
            this.USER_TYPE,
            this.MEMBER_ID});
            this.UsersDGView.Location = new System.Drawing.Point(6, 23);
            this.UsersDGView.Name = "UsersDGView";
            this.UsersDGView.ReadOnly = true;
            this.UsersDGView.RowHeadersVisible = false;
            this.UsersDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDGView.Size = new System.Drawing.Size(426, 263);
            this.UsersDGView.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // AdaraId
            // 
            this.AdaraId.DataPropertyName = "AdaraId";
            this.AdaraId.HeaderText = "AdaraId";
            this.AdaraId.Name = "AdaraId";
            this.AdaraId.ReadOnly = true;
            this.AdaraId.Visible = false;
            // 
            // USER_NAME
            // 
            this.USER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "√”„ «·„” Œœ„";
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            this.USER_NAME.Width = 120;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "ﬂ·„… «·”—";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(620, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 485;
            this.btnCancel.Text = "Œ—ÊÃ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox1.Controls.Add(this.RadioBtnManager);
            this.GroupBox1.Controls.Add(this.RadioBtnUser);
            this.GroupBox1.Controls.Add(this.RadioBtnAdmin);
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(137, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox1.Size = new System.Drawing.Size(849, 43);
            this.GroupBox1.TabIndex = 486;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "„” ÊÌ «·’·«ÕÌ…";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox2.Controls.Add(this.btnDelete);
            this.GroupBox2.Controls.Add(this.btnEdit);
            this.GroupBox2.Controls.Add(this.btnAddUser);
            this.GroupBox2.Controls.Add(this.UsersDGView);
            this.GroupBox2.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox2.Location = new System.Drawing.Point(136, 71);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox2.Size = new System.Drawing.Size(441, 341);
            this.GroupBox2.TabIndex = 487;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "«·„” Œœ„Ì‰";
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1014, 577);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "UserList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "«·„ÊŸ›Ì‰";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductAdd_FormClosing);
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.groupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGView)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button CmdDel;
        internal System.Windows.Forms.Button CmdSave;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MEMBER_ID;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn STATUS;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AdaraDesc;
        internal System.Windows.Forms.DataGridViewTextBoxColumn USER_TYPE;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TEXT;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FName;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn FunStat;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.DataGridView FunctionsDGView;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FunID;
        internal System.Windows.Forms.RadioButton RadioBtnManager;
        internal System.Windows.Forms.RadioButton RadioBtnAdmin;
        internal System.Windows.Forms.RadioButton RadioBtnUser;
        internal System.Windows.Forms.DataGridView UsersDGView;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AdaraId;
        internal System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
      
        

    }
}