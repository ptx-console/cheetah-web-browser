namespace Cheetah
{
    partial class CheetahMessage
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
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.DialogText = new System.Windows.Forms.Label();
            this.DialogTitle = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.pctclose = new System.Windows.Forms.PictureBox();
            this.CancelBttn = new Cheetah.MetroToolkit.MetroButton();
            this.btnOk = new Cheetah.MetroToolkit.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctclose)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.Gold;
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 195);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(400, 5);
            this.BorderBottom.TabIndex = 5;
            // 
            // DialogText
            // 
            this.DialogText.AutoEllipsis = true;
            this.DialogText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogText.ForeColor = System.Drawing.Color.Black;
            this.DialogText.Location = new System.Drawing.Point(13, 47);
            this.DialogText.Name = "DialogText";
            this.DialogText.Size = new System.Drawing.Size(375, 110);
            this.DialogText.TabIndex = 4;
            this.DialogText.Text = "This is the text of the dialog box, accessable through the \'Message\' property.";
            // 
            // DialogTitle
            // 
            this.DialogTitle.AutoEllipsis = true;
            this.DialogTitle.AutoSize = true;
            this.DialogTitle.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTitle.ForeColor = System.Drawing.Color.Black;
            this.DialogTitle.Location = new System.Drawing.Point(12, 7);
            this.DialogTitle.Name = "DialogTitle";
            this.DialogTitle.Size = new System.Drawing.Size(220, 25);
            this.DialogTitle.TabIndex = 3;
            this.DialogTitle.Text = "Dialog Title (\'Title\' Property)";
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // pctclose
            // 
            this.pctclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctclose.BackColor = System.Drawing.Color.Transparent;
            this.pctclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctclose.Image = global::Cheetah.Properties.Resources.Closes;
            this.pctclose.Location = new System.Drawing.Point(368, 12);
            this.pctclose.Name = "pctclose";
            this.pctclose.Size = new System.Drawing.Size(20, 16);
            this.pctclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctclose.TabIndex = 138;
            this.pctclose.TabStop = false;
            // 
            // CancelBttn
            // 
            this.CancelBttn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBttn.ButtonText = "CANCEL";
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CancelBttn.ForceUppercase = false;
            this.CancelBttn.ForeColor = System.Drawing.Color.Gray;
            this.CancelBttn.Location = new System.Drawing.Point(9, 160);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(86, 26);
            this.CancelBttn.TabIndex = 139;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Gold;
            this.btnOk.ButtonText = "OK";
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnOk.ForceUppercase = true;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(302, 160);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 26);
            this.btnOk.TabIndex = 147;
            this.btnOk.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CheetahMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pctclose);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.DialogText);
            this.Controls.Add(this.DialogTitle);
            this.Controls.Add(this.CancelBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheetahMessage";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MetroDialog_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageCheetah_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel BorderBottom;
        internal System.Windows.Forms.Label DialogText;
        internal System.Windows.Forms.Label DialogTitle;
        internal System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.PictureBox pctclose;
        private Cheetah.MetroToolkit.MetroButton CancelBttn;
        private Cheetah.MetroToolkit.MetroButton btnOk;
    }
}