namespace Cheetah.Forms
{
    partial class SendReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pctfeed = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctbug = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctsend = new System.Windows.Forms.PictureBox();
            this.pctclose = new System.Windows.Forms.PictureBox();
            this.tab1 = new System.Windows.Forms.Label();
            this.pnlbug = new System.Windows.Forms.Panel();
            this.txtproblem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldes = new System.Windows.Forms.Label();
            this.pnlfeedback = new System.Windows.Forms.Panel();
            this.txtfeedback = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctclose)).BeginInit();
            this.pnlbug.SuspendLayout();
            this.pnlfeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pctfeed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pctbug);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctsend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 90);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(121, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Report feedback";
            // 
            // pctfeed
            // 
            this.pctfeed.Image = global::Cheetah.Properties.Resources.Feedback1;
            this.pctfeed.Location = new System.Drawing.Point(145, 12);
            this.pctfeed.Name = "pctfeed";
            this.pctfeed.Size = new System.Drawing.Size(48, 48);
            this.pctfeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctfeed.TabIndex = 4;
            this.pctfeed.TabStop = false;
            this.pctfeed.Click += new System.EventHandler(this.pctfeed_Click);
            this.pctfeed.MouseEnter += new System.EventHandler(this.pctfeed_MouseEnter);
            this.pctfeed.MouseLeave += new System.EventHandler(this.pctfeed_MouseLeave);
            this.pctfeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctfeed_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Report bug";
            // 
            // pctbug
            // 
            this.pctbug.Image = global::Cheetah.Properties.Resources.Bug1;
            this.pctbug.Location = new System.Drawing.Point(44, 12);
            this.pctbug.Name = "pctbug";
            this.pctbug.Size = new System.Drawing.Size(48, 48);
            this.pctbug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbug.TabIndex = 2;
            this.pctbug.TabStop = false;
            this.pctbug.Click += new System.EventHandler(this.pctbug_Click);
            this.pctbug.MouseEnter += new System.EventHandler(this.pctbug_MouseEnter);
            this.pctbug.MouseLeave += new System.EventHandler(this.pctbug_MouseLeave);
            this.pctbug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctbug_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send";
            // 
            // pctsend
            // 
            this.pctsend.Enabled = false;
            this.pctsend.Image = global::Cheetah.Properties.Resources.mail1;
            this.pctsend.Location = new System.Drawing.Point(356, 12);
            this.pctsend.Name = "pctsend";
            this.pctsend.Size = new System.Drawing.Size(48, 48);
            this.pctsend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctsend.TabIndex = 0;
            this.pctsend.TabStop = false;
            this.pctsend.Click += new System.EventHandler(this.pctsend_Click);
            this.pctsend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctsend_MouseDown);
            this.pctsend.MouseEnter += new System.EventHandler(this.pctsend_MouseEnter);
            this.pctsend.MouseLeave += new System.EventHandler(this.pctsend_MouseLeave);
            this.pctsend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctsend_MouseUp);
            // 
            // pctclose
            // 
            this.pctclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctclose.BackColor = System.Drawing.Color.Transparent;
            this.pctclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctclose.Image = global::Cheetah.Properties.Resources.Closes;
            this.pctclose.Location = new System.Drawing.Point(415, 12);
            this.pctclose.Name = "pctclose";
            this.pctclose.Size = new System.Drawing.Size(20, 16);
            this.pctclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctclose.TabIndex = 140;
            this.pctclose.TabStop = false;
            this.pctclose.Click += new System.EventHandler(this.pctclose_Click);
            this.pctclose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctclose_MouseDown);
            this.pctclose.MouseEnter += new System.EventHandler(this.pctclose_MouseEnter);
            this.pctclose.MouseLeave += new System.EventHandler(this.pctclose_MouseLeave);
            this.pctclose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctclose_MouseUp);
            // 
            // tab1
            // 
            this.tab1.AutoSize = true;
            this.tab1.BackColor = System.Drawing.Color.Transparent;
            this.tab1.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.ForeColor = System.Drawing.Color.Black;
            this.tab1.Location = new System.Drawing.Point(7, 7);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(98, 25);
            this.tab1.TabIndex = 143;
            this.tab1.Text = "Report bug";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlbug
            // 
            this.pnlbug.BackColor = System.Drawing.Color.Transparent;
            this.pnlbug.Controls.Add(this.txtproblem);
            this.pnlbug.Controls.Add(this.textBox1);
            this.pnlbug.Controls.Add(this.txtdes);
            this.pnlbug.Controls.Add(this.txtpage);
            this.pnlbug.Controls.Add(this.label4);
            this.pnlbug.Controls.Add(this.label3);
            this.pnlbug.Controls.Add(this.lbldes);
            this.pnlbug.Location = new System.Drawing.Point(0, 51);
            this.pnlbug.Name = "pnlbug";
            this.pnlbug.Size = new System.Drawing.Size(447, 334);
            this.pnlbug.TabIndex = 149;
            this.pnlbug.SizeChanged += new System.EventHandler(this.pnlbug_SizeChanged);
            this.pnlbug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlbug_MouseDown);
            // 
            // txtproblem
            // 
            this.txtproblem.BackColor = System.Drawing.Color.White;
            this.txtproblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtproblem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtproblem.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproblem.ForeColor = System.Drawing.Color.Black;
            this.txtproblem.Items.AddRange(new object[] {
            "Unspecified",
            "Crash",
            "Can\'t log in",
            "Blank page",
            "Can\'t load page",
            "Content missing",
            "Appearance wrong",
            "Content missing",
            "Plugin missing",
            "Other problem",
            "Web favicon doesn\'t show",
            "Not responding",
            "Memory Leak"});
            this.txtproblem.Location = new System.Drawing.Point(125, 16);
            this.txtproblem.Name = "txtproblem";
            this.txtproblem.Size = new System.Drawing.Size(157, 21);
            this.txtproblem.TabIndex = 157;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 23);
            this.textBox1.TabIndex = 158;
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.White;
            this.txtdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdes.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.ForeColor = System.Drawing.Color.Black;
            this.txtdes.Location = new System.Drawing.Point(124, 73);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(299, 246);
            this.txtdes.TabIndex = 153;
            this.txtdes.TextChanged += new System.EventHandler(this.txtdes_TextChanged);
            this.txtdes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdes_KeyDown);
            this.txtdes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtdes_MouseDown);
            // 
            // txtpage
            // 
            this.txtpage.BackColor = System.Drawing.Color.White;
            this.txtpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpage.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpage.ForeColor = System.Drawing.Color.Black;
            this.txtpage.Location = new System.Drawing.Point(124, 43);
            this.txtpage.Name = "txtpage";
            this.txtpage.ReadOnly = true;
            this.txtpage.Size = new System.Drawing.Size(299, 25);
            this.txtpage.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 151;
            this.label4.Text = "Desciption :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 150;
            this.label3.Text = "Page address :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.BackColor = System.Drawing.Color.Transparent;
            this.lbldes.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.ForeColor = System.Drawing.Color.Black;
            this.lbldes.Location = new System.Drawing.Point(29, 15);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(89, 19);
            this.lbldes.TabIndex = 149;
            this.lbldes.Text = "My problem :";
            this.lbldes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlfeedback
            // 
            this.pnlfeedback.BackColor = System.Drawing.Color.Transparent;
            this.pnlfeedback.Controls.Add(this.txtfeedback);
            this.pnlfeedback.Controls.Add(this.label7);
            this.pnlfeedback.ForeColor = System.Drawing.Color.Transparent;
            this.pnlfeedback.Location = new System.Drawing.Point(0, 51);
            this.pnlfeedback.Name = "pnlfeedback";
            this.pnlfeedback.Size = new System.Drawing.Size(447, 334);
            this.pnlfeedback.TabIndex = 156;
            this.pnlfeedback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlfeedback_MouseDown);
            // 
            // txtfeedback
            // 
            this.txtfeedback.BackColor = System.Drawing.Color.White;
            this.txtfeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfeedback.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeedback.ForeColor = System.Drawing.Color.Black;
            this.txtfeedback.Location = new System.Drawing.Point(19, 43);
            this.txtfeedback.Multiline = true;
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(404, 276);
            this.txtfeedback.TabIndex = 153;
            this.txtfeedback.SizeChanged += new System.EventHandler(this.txtfeedback_SizeChanged);
            this.txtfeedback.TextChanged += new System.EventHandler(this.txtfeedback_TextChanged);
            this.txtfeedback.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfeedback_KeyDown);
            this.txtfeedback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtfeedback_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 19);
            this.label7.TabIndex = 150;
            this.label7.Text = "Type your feedback here, it can be good, bad, or recommendation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 5);
            this.panel2.TabIndex = 157;
            // 
            // SendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlbug);
            this.Controls.Add(this.pnlfeedback);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.pctclose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendReport";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report bug";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SendReport_FormClosed);
            this.Load += new System.EventHandler(this.SendReport_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendReport_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctclose)).EndInit();
            this.pnlbug.ResumeLayout(false);
            this.pnlbug.PerformLayout();
            this.pnlfeedback.ResumeLayout(false);
            this.pnlfeedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctsend;
        private System.Windows.Forms.PictureBox pctclose;
        internal System.Windows.Forms.Label tab1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctbug;
        private System.Windows.Forms.Panel pnlbug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pctfeed;
        internal System.Windows.Forms.TextBox txtdes;
        internal System.Windows.Forms.TextBox txtpage;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Panel pnlfeedback;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtfeedback;
        internal System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.ComboBox txtproblem;
        private System.Windows.Forms.TextBox textBox1;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        //private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}