using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;
namespace Cheetah.MetroToolkit
{
    [DefaultEvent("Click")]
    public partial class LabelButton : UserControl
    {
        [DefaultValue("Label Text"), Description("Sets the text of the button")]
        public string LabelText { get; set; }
        public LabelButton()
        {
            InitializeComponent();
            Paint += LabelButton_Paint;
            Load += LabelButton_Load;
            // This call is required by the designer.
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void LabelMain_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this, e);
        }

        private void LabelButton_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LabelText))
            {
                LabelText = "LABELBUTTON";
            }
            this.ForeColor = Color.Silver;
            this.Invalidate();
        }

        private void LabelButton_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                LabelMain.Text = LabelText;
                LabelMain.Font = this.Font;
                LabelMain.ForeColor = this.ForeColor;
                LabelMain.BackColor = this.BackColor;

            }
            catch  
            {
            }
        }

        private void LabelMain_MouseEnter(object sender, EventArgs e)
        {
            Transition T = new Transition(new TransitionType_EaseInEaseOut(400));
            T.add(this, "ForeColor", Color.Black);
            T.add(LabelMain, "ForeColor", Color.Black);
            T.run();
        }

        private void LabelMain_MouseLeave(object sender, EventArgs e)
        {
            Transition T = new Transition(new TransitionType_EaseInEaseOut(400));
            T.add(this, "ForeColor", Color.Silver);
            T.add(LabelMain, "ForeColor", Color.Silver);
            T.run();
        }
    }
}
