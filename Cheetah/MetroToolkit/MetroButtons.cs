using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Cheetah.MetroToolkit
{
    public partial class MetroButtons : UserControl
    {
        string ButtonT = "BUTTON";
        bool ForceCase = true;
        public MetroButtons()
        {
            SizeChanged += MetroButton_SizeChanged;
            MouseUp += MetroButton_MouseUp;
            MouseLeave += MetroButton_MouseLeave;
            MouseEnter += MetroButton_MouseEnter;
            MouseDown += MetroButton_MouseDown;
            Load += MetroButton_Load;
            InitializeComponent();
        }
        [Description("Sets the text of the MetroButton."), DefaultValue("BUTTON")]
        public string ButtonText
        {
            get { return ButtonT; }
            set
            {
                if (ForceUppercase == true)
                    value = value.ToUpper();
                ButtonT = value;
                Refresh();
            }
        }

        [Description("Defines whether or not the button text is automatically made uppercase.")]
        public bool ForceUppercase
        {
            get { return ForceCase; }
            set { ForceCase = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.WhiteSmoke);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
            //Dim p As New Drawing2D.GraphicsPath()
            //p.StartFigure()
            //p.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
            //p.AddLine(10, 0, Width - 10, 0)
            //p.AddArc(New Rectangle(Width - 10, 0, 10, 10), -90, 90)
            //p.AddLine(Width, 10, Width, Height - 10)
            //p.AddArc(New Rectangle(Width - 10, Height - 10, 10, 10), 0, 90)
            //p.AddLine(Width - 10, Height, 10, Height)
            //p.AddArc(New Rectangle(0, Height - 10, 10, 10), 90, 90)
            //p.CloseFigure()
            //Region = New Region(p)
        }

        private void MetroButton_Load(object sender, EventArgs e)
        {
            //Dim P As New Pen(BackColor, Width)
            //this.CreateGraphics().DrawRectangle(P, 0, 0, Width, Height)
            //Dim G As New LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.Gray, Color.Black)
            //this.CreateGraphics().FillRectangle(G, ClientRectangle)
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.WhiteSmoke);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
        }

        private void MetroButton_MouseDown(object sender, MouseEventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.LightGray);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
        }

        private void MetroButton_MouseEnter(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.LightGray, Color.Gainsboro);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
        }

        private void MetroButton_Leave(object sender, EventArgs e)
        {

        }

        private void MetroButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.IsDisposed)
                return;
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.WhiteSmoke);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
        }
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private void MetroButton_SizeChanged(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.WhiteSmoke);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
        }

        private void MetroButton_MouseLeave(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.Gainsboro, Color.WhiteSmoke);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Silver, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height);
        }
    }
}
