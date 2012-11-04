namespace Cheetah.Forms
{
    partial class AboutCheetah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCheetah));
            this.lblCheetah = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.linkSurf = new System.Windows.Forms.LinkLabel();
            this.linkGtlite = new System.Windows.Forms.LinkLabel();
            this.linkCredit = new System.Windows.Forms.LinkLabel();
            this.linkPlugins = new System.Windows.Forms.LinkLabel();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.linkJoinUs = new System.Windows.Forms.LinkLabel();
            this.lblver = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Cheetah.MetroToolkit.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheetah
            // 
            this.lblCheetah.AutoSize = true;
            this.lblCheetah.BackColor = System.Drawing.Color.Transparent;
            this.lblCheetah.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheetah.ForeColor = System.Drawing.Color.Black;
            this.lblCheetah.Location = new System.Drawing.Point(209, 12);
            this.lblCheetah.Name = "lblCheetah";
            this.lblCheetah.Size = new System.Drawing.Size(111, 37);
            this.lblCheetah.TabIndex = 8;
            this.lblCheetah.Text = "Cheetah";
            this.lblCheetah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.Color.Transparent;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.Black;
            this.lblDes.Location = new System.Drawing.Point(213, 60);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(332, 45);
            this.lblDes.TabIndex = 9;
            this.lblDes.Text = "Copyright ©  2012 Praken && GT Web Software. All right reserved.\r\nCheetah is a we" +
    "b-browser powered by Awesomium.\r\nThe successor of Praken Surf  and GTLite Naviga" +
    "tor";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkSurf
            // 
            this.linkSurf.AutoSize = true;
            this.linkSurf.BackColor = System.Drawing.Color.Transparent;
            this.linkSurf.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSurf.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSurf.Location = new System.Drawing.Point(299, 94);
            this.linkSurf.Name = "linkSurf";
            this.linkSurf.Size = new System.Drawing.Size(63, 15);
            this.linkSurf.TabIndex = 10;
            this.linkSurf.TabStop = true;
            this.linkSurf.Text = "Praken Surf";
            this.linkSurf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSurf_LinkClicked);
            // 
            // linkGtlite
            // 
            this.linkGtlite.AutoSize = true;
            this.linkGtlite.BackColor = System.Drawing.Color.Transparent;
            this.linkGtlite.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGtlite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGtlite.Location = new System.Drawing.Point(382, 94);
            this.linkGtlite.Name = "linkGtlite";
            this.linkGtlite.Size = new System.Drawing.Size(91, 15);
            this.linkGtlite.TabIndex = 11;
            this.linkGtlite.TabStop = true;
            this.linkGtlite.Text = "GTLite Navigator";
            this.linkGtlite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGtlite_LinkClicked);
            // 
            // linkCredit
            // 
            this.linkCredit.AutoSize = true;
            this.linkCredit.BackColor = System.Drawing.Color.Transparent;
            this.linkCredit.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCredit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCredit.Location = new System.Drawing.Point(12, 208);
            this.linkCredit.Name = "linkCredit";
            this.linkCredit.Size = new System.Drawing.Size(45, 19);
            this.linkCredit.TabIndex = 12;
            this.linkCredit.TabStop = true;
            this.linkCredit.Text = "Credit";
            this.linkCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCredit_LinkClicked);
            // 
            // linkPlugins
            // 
            this.linkPlugins.AutoSize = true;
            this.linkPlugins.BackColor = System.Drawing.Color.Transparent;
            this.linkPlugins.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPlugins.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPlugins.Location = new System.Drawing.Point(86, 208);
            this.linkPlugins.Name = "linkPlugins";
            this.linkPlugins.Size = new System.Drawing.Size(117, 19);
            this.linkPlugins.TabIndex = 13;
            this.linkPlugins.TabStop = true;
            this.linkPlugins.Text = "Check for Updates";
            this.linkPlugins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlugins_LinkClicked);
            // 
            // linkLicense
            // 
            this.linkLicense.AutoSize = true;
            this.linkLicense.BackColor = System.Drawing.Color.Transparent;
            this.linkLicense.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLicense.Location = new System.Drawing.Point(237, 208);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Size = new System.Drawing.Size(50, 19);
            this.linkLicense.TabIndex = 14;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "License";
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicense_LinkClicked);
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.BackColor = System.Drawing.Color.Transparent;
            this.linkUpdate.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkUpdate.Location = new System.Drawing.Point(212, 119);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(130, 19);
            this.linkUpdate.TabIndex = 17;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "Update Cheetah to v";
            // 
            // linkJoinUs
            // 
            this.linkJoinUs.AutoSize = true;
            this.linkJoinUs.BackColor = System.Drawing.Color.Transparent;
            this.linkJoinUs.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkJoinUs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkJoinUs.Location = new System.Drawing.Point(333, 208);
            this.linkJoinUs.Name = "linkJoinUs";
            this.linkJoinUs.Size = new System.Drawing.Size(50, 19);
            this.linkJoinUs.TabIndex = 18;
            this.linkJoinUs.TabStop = true;
            this.linkJoinUs.Text = "Join Us";
            this.linkJoinUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJoinUs_LinkClicked);
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.BackColor = System.Drawing.Color.Transparent;
            this.lblver.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.ForeColor = System.Drawing.Color.Black;
            this.lblver.Location = new System.Drawing.Point(210, 118);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(341, 19);
            this.lblver.TabIndex = 19;
            this.lblver.Text = "You run the latest version of Cheetah (1.0.1.3456-release)";
            this.lblver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 5);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Beta 1 - For testing purposes mainly";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gold;
            this.btnClose.ButtonText = "CLOSE";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnClose.ForceUppercase = false;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(458, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 26);
            this.btnClose.TabIndex = 25;
            this.btnClose.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AboutCheetah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 248);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.linkJoinUs);
            this.Controls.Add(this.linkUpdate);
            this.Controls.Add(this.linkLicense);
            this.Controls.Add(this.linkPlugins);
            this.Controls.Add(this.linkCredit);
            this.Controls.Add(this.linkGtlite);
            this.Controls.Add(this.linkSurf);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblCheetah);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutCheetah";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Cheetah";
            this.Load += new System.EventHandler(this.AboutCheetah_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutCheetah_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCheetah;
        internal System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.LinkLabel linkSurf;
        private System.Windows.Forms.LinkLabel linkGtlite;
        private System.Windows.Forms.LinkLabel linkCredit;
        private System.Windows.Forms.LinkLabel linkPlugins;
        private System.Windows.Forms.LinkLabel linkLicense;
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.LinkLabel linkJoinUs;
        internal System.Windows.Forms.Label lblver;
        internal System.Windows.Forms.Timer CloseTimer;
        private MetroToolkit.MetroButton metroButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label1;
        private MetroToolkit.MetroButton btnClose;
    }
}