namespace Cheetah
{
    partial class CloseDialog
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
            this.lblCheetah = new System.Windows.Forms.Label();
            this.lbldes = new System.Windows.Forms.Label();
            this.CBdontshow = new System.Windows.Forms.CheckBox();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYes = new Cheetah.MetroToolkit.MetroButton();
            this.btnNo = new Cheetah.MetroToolkit.MetroButton();
            this.SuspendLayout();
            // 
            // lblCheetah
            // 
            this.lblCheetah.AutoSize = true;
            this.lblCheetah.BackColor = System.Drawing.Color.Transparent;
            this.lblCheetah.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheetah.ForeColor = System.Drawing.Color.Black;
            this.lblCheetah.Location = new System.Drawing.Point(9, 22);
            this.lblCheetah.Name = "lblCheetah";
            this.lblCheetah.Size = new System.Drawing.Size(111, 37);
            this.lblCheetah.TabIndex = 19;
            this.lblCheetah.Text = "Cheetah";
            this.lblCheetah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.BackColor = System.Drawing.Color.Transparent;
            this.lbldes.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.ForeColor = System.Drawing.Color.Black;
            this.lbldes.Location = new System.Drawing.Point(12, 77);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(381, 19);
            this.lbldes.TabIndex = 20;
            this.lbldes.Text = "You have tabs running. Are you sure you want to close Cheetah?";
            this.lbldes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBdontshow
            // 
            this.CBdontshow.AutoSize = true;
            this.CBdontshow.BackColor = System.Drawing.Color.Transparent;
            this.CBdontshow.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBdontshow.ForeColor = System.Drawing.Color.Black;
            this.CBdontshow.Location = new System.Drawing.Point(16, 99);
            this.CBdontshow.Name = "CBdontshow";
            this.CBdontshow.Size = new System.Drawing.Size(105, 19);
            this.CBdontshow.TabIndex = 22;
            this.CBdontshow.Text = "Don\'t show this ";
            this.CBdontshow.UseVisualStyleBackColor = false;
            this.CBdontshow.CheckedChanged += new System.EventHandler(this.CBdontshow_CheckedChanged);
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
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 5);
            this.panel1.TabIndex = 25;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Gold;
            this.btnYes.ButtonText = "YES";
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnYes.ForceUppercase = false;
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Location = new System.Drawing.Point(215, 126);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(86, 26);
            this.btnYes.TabIndex = 149;
            this.btnYes.Load += new System.EventHandler(this.btnYes_Load);
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Gold;
            this.btnNo.ButtonText = "NO";
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNo.ForceUppercase = false;
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.Location = new System.Drawing.Point(307, 126);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(86, 26);
            this.btnNo.TabIndex = 150;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // CloseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 168);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBdontshow);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.lblCheetah);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloseDialog";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CloseDialog_Load);
            this.VisibleChanged += new System.EventHandler(this.CloseDialog_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseDialog_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCheetah;
        internal System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.CheckBox CBdontshow;
        internal System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Panel panel1;
        private MetroToolkit.MetroButton btnYes;
        private MetroToolkit.MetroButton btnNo;
    }
}