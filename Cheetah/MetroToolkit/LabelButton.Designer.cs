namespace Cheetah.MetroToolkit
{
    partial class LabelButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMain.ForeColor = System.Drawing.Color.Gray;
            this.LabelMain.Location = new System.Drawing.Point(1, 0);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(82, 13);
            this.LabelMain.TabIndex = 1;
            this.LabelMain.Text = "LABEL BUTTON";
            this.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelMain);
            this.Name = "LabelButton";
            this.Size = new System.Drawing.Size(86, 13);
            this.Load += new System.EventHandler(this.LabelButton_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelButton_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelMain;

    }
}
