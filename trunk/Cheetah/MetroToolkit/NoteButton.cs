﻿using System;
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
    public partial class NoteButton : UserControl
    {
        public NoteButton()
        {
            SizeChanged += NoteButton_SizeChanged;
            MouseUp += NoteButton_MouseUp;
            MouseLeave += NoteButton_MouseLeave;
            MouseEnter += NoteButton_MouseEnter;
            MouseDown += NoteButton_MouseDown;
            Load += NoteButton_Load;
            InitializeComponent();
        }

        string ButtonT = "BUTTON";
        bool ForceCase = true;
        [Description("Sets the text of the NoteButton."), DefaultValue("BUTTON")]
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
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), BackColor, BackColor);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Lime, Width - 1, 0, Width - 1, Height);
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

        private void NoteButton_Load(object sender, EventArgs e)
        {
            //Dim P As New Pen(BackColor, Width)
            //this.CreateGraphics().DrawRectangle(P, 0, 0, Width, Height)
            //Dim G As New LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.Gray, Color.Black)
            //this.CreateGraphics().FillRectangle(G, ClientRectangle)
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), BackColor, BackColor);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Lime, Width - 1, 0, Width - 1, Height);
        }

        private void NoteButton_MouseDown(object sender, MouseEventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.ForestGreen, Color.ForestGreen);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.ForestGreen, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.ForestGreen, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.ForestGreen, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.ForestGreen, Width - 1, 0, Width - 1, Height);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
        }

        private void NoteButton_MouseEnter(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), Color.LimeGreen, Color.LimeGreen);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.LimeGreen, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.LimeGreen, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.LimeGreen, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.LimeGreen, Width - 1, 0, Width - 1, Height);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
        }

        private void NoteButton_Leave(object sender, EventArgs e)
        {

        }

        private void NoteButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.IsDisposed)
                return;
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), BackColor, BackColor);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Lime, Width - 1, 0, Width - 1, Height);
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

        private void NoteButton_SizeChanged(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), BackColor, BackColor);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Lime, Width - 1, 0, Width - 1, Height);
        }

        private void NoteButton_MouseLeave(object sender, EventArgs e)
        {
            LinearGradientBrush G = new LinearGradientBrush(new Point(0, Width), new Point(0, Height), BackColor, BackColor);
            this.CreateGraphics().FillRectangle(G, ClientRectangle);
            SolidBrush TextPen = new SolidBrush(ForeColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle R = new Rectangle(new Point(0, 0), ClientRectangle.Size);
            this.CreateGraphics().DrawString(ButtonT, Font, TextPen, R, stringFormat);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, Width, 0);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, Height - 1, Width, Height - 1);
            this.CreateGraphics().DrawLine(Pens.Lime, 0, 0, 0, Height);
            this.CreateGraphics().DrawLine(Pens.Lime, Width - 1, 0, Width - 1, Height);
        }
    }
}
