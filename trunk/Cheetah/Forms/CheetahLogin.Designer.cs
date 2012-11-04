namespace Cheetah.Forms
{
    partial class CheetahAuthentication
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
            this.DialogTitle = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.pctclose = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.OKButton = new Cheetah.MetroToolkit.MetroButton();
            this.CancelBttn = new Cheetah.MetroToolkit.MetroButton();
            this.waterMarkTextBox2 = new Cheetah.WaterMarkTextBox();
            this.waterMarkTextBox1 = new Cheetah.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctclose)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.Gold;
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 173);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(400, 5);
            this.BorderBottom.TabIndex = 5;
            // 
            // DialogTitle
            // 
            this.DialogTitle.AutoEllipsis = true;
            this.DialogTitle.AutoSize = true;
            this.DialogTitle.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTitle.ForeColor = System.Drawing.Color.Black;
            this.DialogTitle.Location = new System.Drawing.Point(12, 7);
            this.DialogTitle.Name = "DialogTitle";
            this.DialogTitle.Size = new System.Drawing.Size(183, 25);
            this.DialogTitle.TabIndex = 3;
            this.DialogTitle.Text = "Authentication request";
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
            this.pctclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctclose.Image = global::Cheetah.Properties.Resources.Closes;
            this.pctclose.Location = new System.Drawing.Point(368, 12);
            this.pctclose.Name = "pctclose";
            this.pctclose.Size = new System.Drawing.Size(20, 16);
            this.pctclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctclose.TabIndex = 138;
            this.pctclose.TabStop = false;
            this.pctclose.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 27);
            this.textBox1.TabIndex = 141;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(89, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 27);
            this.textBox2.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 147;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 148;
            this.label2.Text = "Password :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.checkBox1.Location = new System.Drawing.Point(89, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 23);
            this.checkBox1.TabIndex = 149;
            this.checkBox1.Text = "Remember my login details";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(87, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 15);
            this.linkLabel1.TabIndex = 150;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Delete my login details for this URL";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.Gold;
            this.OKButton.ButtonText = "OK";
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.OKButton.ForceUppercase = false;
            this.OKButton.ForeColor = System.Drawing.Color.Black;
            this.OKButton.Location = new System.Drawing.Point(211, 140);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(86, 26);
            this.OKButton.TabIndex = 146;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBttn.BackColor = System.Drawing.Color.Gold;
            this.CancelBttn.ButtonText = "CANCEL";
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CancelBttn.ForceUppercase = false;
            this.CancelBttn.ForeColor = System.Drawing.Color.Black;
            this.CancelBttn.Location = new System.Drawing.Point(303, 140);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(86, 26);
            this.CancelBttn.TabIndex = 145;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(90, 83);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.PasswordChar = '*';
            this.waterMarkTextBox2.Size = new System.Drawing.Size(291, 25);
            this.waterMarkTextBox2.TabIndex = 140;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "Password";
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(90, 46);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(291, 25);
            this.waterMarkTextBox1.TabIndex = 139;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "Username";
            // 
            // CheetahAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 178);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pctclose);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.DialogTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheetahAuthentication";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        internal System.Windows.Forms.Label DialogTitle;
        internal System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.PictureBox pctclose;
        public WaterMarkTextBox waterMarkTextBox1;
        public WaterMarkTextBox waterMarkTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroToolkit.MetroButton CancelBttn;
        private MetroToolkit.MetroButton OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}