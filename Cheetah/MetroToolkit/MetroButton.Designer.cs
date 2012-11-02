namespace Cheetah.MetroToolkit
{
    partial class MetroButton
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
            this.SuspendLayout();
            // 
            // MetroButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MetroButton";
            this.Size = new System.Drawing.Size(86, 26);
            this.Load += new System.EventHandler(this.MetroButton_Load);
            this.SizeChanged += new System.EventHandler(this.MetroButton_SizeChanged);
            this.Leave += new System.EventHandler(this.MetroButton_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MetroButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MetroButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MetroButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MetroButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
