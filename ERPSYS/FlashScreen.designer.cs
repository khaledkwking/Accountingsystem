namespace ERPSYS
{
    partial class FlashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashScreen));
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationTitle.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ApplicationTitle.Location = new System.Drawing.Point(268, 9);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ApplicationTitle.Size = new System.Drawing.Size(237, 37);
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.Text = "»—‰«„Ã «·„Õ«”»…";
            this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.logoPictureBox);
            this.Panel1.Controls.Add(this.Copyright);
            this.Panel1.Controls.Add(this.ApplicationTitle);
            this.Panel1.Controls.Add(this.Version);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(517, 255);
            this.Panel1.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(194, 255);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // Copyright
            // 
            this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Copyright.Location = new System.Drawing.Point(267, 197);
            this.Copyright.Name = "Copyright";
            this.Copyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Copyright.Size = new System.Drawing.Size(236, 29);
            this.Copyright.TabIndex = 2;
            this.Copyright.Tag = "";
            this.Copyright.Text = "Ã„Ì⁄ «·ÕﬁÊﬁ „Õ›ÊŸ… ";
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Version.ForeColor = System.Drawing.Color.Blue;
            this.Version.Location = new System.Drawing.Point(267, 101);
            this.Version.Name = "Version";
            this.Version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Version.Size = new System.Drawing.Size(133, 30);
            this.Version.TabIndex = 1;
            this.Version.Text = "«·«’œ«— —ﬁ„ 1.0";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 999999999;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(140, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "«·«’œ«— —ﬁ„ 5.0";
            // 
            // FlashScreen
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 244);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label ApplicationTitle;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Copyright;
        internal System.Windows.Forms.Label Version;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        internal System.Windows.Forms.Label label3;
    }
}