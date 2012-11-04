using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace Cheetah.Forms
{
    public partial class SendReport : Form
    {
        string ButtonSender;
        #region "Custom form"
        private void MoveControl(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        [DllImport("psapi.dll")]
        private static extern int EmptyWorkingSet(IntPtr hwProc);
        private static void MinimizeFootprint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }
        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        #region "Window Behavior"

        private const int BorderWidth = 6;

        private ResizeDirection _resizeDir = ResizeDirection.None;
        public enum ResizeDirection
        {
            None = 0,
            Left = 1,
            TopLeft = 2,
            Top = 4,
            TopRight = 8,
            Right = 16,
            BottomRight = 32,
            Bottom = 64,
            BottomLeft = 128
        }

        private ResizeDirection resizeDir
        {
            get { return _resizeDir; }
            set
            {
                _resizeDir = value;

                //Change cursor
                switch (value)
                {
                    case ResizeDirection.Left:
                        this.Cursor = Cursors.SizeWE;

                        break;
                    case ResizeDirection.Right:
                        this.Cursor = Cursors.SizeWE;

                        break;
                    case ResizeDirection.Top:
                        this.Cursor = Cursors.SizeNS;

                        break;
                    case ResizeDirection.Bottom:
                        this.Cursor = Cursors.SizeNS;

                        break;
                    case ResizeDirection.BottomLeft:
                        this.Cursor = Cursors.SizeNESW;

                        break;
                    case ResizeDirection.TopRight:
                        this.Cursor = Cursors.SizeNESW;

                        break;
                    case ResizeDirection.BottomRight:
                        this.Cursor = Cursors.SizeNWSE;

                        break;
                    case ResizeDirection.TopLeft:
                        this.Cursor = Cursors.SizeNWSE;

                        break;
                    default:
                        this.Cursor = Cursors.Default;
                        break;
                }
            }
        }

        private void ResizeForm(ResizeDirection direction)
        {
            int dir = -1;
            switch (direction)
            {
                case ResizeDirection.Left:
                    dir = HTLEFT;
                    break;
                case ResizeDirection.TopLeft:
                    dir = HTTOPLEFT;
                    break;
                case ResizeDirection.Top:
                    dir = HTTOP;
                    break;
                case ResizeDirection.TopRight:
                    dir = HTTOPRIGHT;
                    break;
                case ResizeDirection.Right:
                    dir = HTRIGHT;
                    break;
                case ResizeDirection.BottomRight:
                    dir = HTBOTTOMRIGHT;
                    break;
                case ResizeDirection.Bottom:
                    dir = HTBOTTOM;
                    break;
                case ResizeDirection.BottomLeft:
                    dir = HTBOTTOMLEFT;
                    break;
            }

            if (dir != -1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, dir, 0);
            }

        }
        public bool HighSecurity = false;
        public static void MoveForm(IntPtr Handle)
        {
            ReleaseCapture();
            int Status = SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #region "Constants"
        // windowpos
        private const int HTCAPTION = 0x2;
        private const int SWP_NOSIZE = 0x1;
        private const int SWP_NOMOVE = 0x2;
        private const int SWP_NOZORDER = 0x4;
        private const int SWP_NOREDRAW = 0x8;
        private const int SWP_NOACTIVATE = 0x10;
        private const int SWP_FRAMECHANGED = 0x20;
        private const int SWP_SHOWWINDOW = 0x40;
        private const int SWP_HIDEWINDOW = 0x80;
        private const int SWP_NOCOPYBITS = 0x100;
        private const int SWP_NOOWNERZORDER = 0x200;
        private const int SWP_NOSENDCHANGING = 0x400;
        // redraw
        private const int RDW_INVALIDATE = 0x1;
        private const int RDW_INTERNALPAINT = 0x2;
        private const int RDW_ERASE = 0x4;
        private const int RDW_VALIDATE = 0x8;
        private const int RDW_NOINTERNALPAINT = 0x10;
        private const int RDW_NOERASE = 0x20;
        private const int RDW_NOCHILDREN = 0x40;
        private const int RDW_ALLCHILDREN = 0x80;
        private const int RDW_UPDATENOW = 0x100;
        private const int RDW_ERASENOW = 0x200;
        private const int RDW_FRAME = 0x400;
        private const int RDW_NOFRAME = 0x800;
        // frame
        private const int FRAME_WIDTH = 8;
        private const int CAPTION_HEIGHT = 30;
        private const int FRAME_SMWIDTH = 4;
        private const int CAPTION_SMHEIGHT = 24;
        // misc
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_RESTORE = 0xf120;
        private const int SC_MAXIMIZE = 0xf030;
        private const int SM_SWAPBUTTON = 23;
        private const int WM_GETTITLEBARINFOEX = 0x33f;
        private const int VK_LBUTTON = 0x1;
        private const int VK_RBUTTON = 0x2;
        private const int KEY_PRESSED = 0x1000;
        private const int BLACK_BRUSH = 4;
        // proc
        private const int WM_CREATE = 0x1;
        private const int WM_NCCALCSIZE = 0x83;
        private const int WM_NCHITTEST = 0x84;
        private const int WM_SIZE = 0x5;
        private const int WM_PAINT = 0xf;
        private const int WM_TIMER = 0x113;
        private const int WM_ACTIVATE = 0x6;
        private const int WM_NCMOUSEMOVE = 0xa0;
        private const int WM_NCMOUSEHOVER = 0x2a0;
        private const int WM_NCLBUTTONDOWN = 0xa1;
        private const int WM_NCLBUTTONUP = 0xa2;
        private const int WM_NCLBUTTONDBLCLK = 0xa3;
        private const int WM_NCRBUTTONDOWN = 0xa4;
        private const int WM_NCRBUTTONUP = 0xa5;
        private const int WM_NCRBUTTONDBLCLK = 0xa6;
        private const int WM_DWMCOMPOSITIONCHANGED = 0x31e;
        private const int WVR_ALIGNTOP = 0x10;
        private const int WVR_ALIGNLEFT = 0x20;
        private const int WVR_ALIGNBOTTOM = 0x40;
        private const int WVR_ALIGNRIGHT = 0x80;
        private const int WVR_HREDRAW = 0x100;
        private const int WVR_VREDRAW = 0x200;
        private const int WVR_REDRAW = (WVR_HREDRAW | WVR_VREDRAW);
        private const int WVR_VALIDRECTS = 0x400;
        #endregion
        private static IntPtr MSG_HANDLED = new IntPtr(0);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int HTBORDER = 18;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        #endregion
        private const int HTTOPRIGHT = 14;
        #endregion
        public SendReport(string address)
        {
            InitializeComponent();
            txtpage.Text = address;
            txtproblem.Text = "Unspecified";

        }

        #region "Button effect"
        private void pctbug_MouseEnter(object sender, EventArgs e)
        {
            pctbug.Image = Cheetah.Properties.Resources.bug;
        }

        private void pctbug_MouseLeave(object sender, EventArgs e)
        {
            pctbug.Image = Cheetah.Properties.Resources.Bug1;
        }

        private void pctbug_MouseUp(object sender, MouseEventArgs e)
        {
            pctbug.Image = Cheetah.Properties.Resources.Bug1;
        }

        private void pctsend_MouseDown(object sender, MouseEventArgs e)
        {
            pctsend.Image = Cheetah.Properties.Resources.mail;
        }

        private void pctsend_MouseLeave(object sender, EventArgs e)
        {
            pctsend.Image = Cheetah.Properties.Resources.mail1;
        }

        private void pctsend_MouseUp(object sender, MouseEventArgs e)
        {
            pctsend.Image = Cheetah.Properties.Resources.mail1;
        }
        #endregion

        private void SendReport_Load(object sender, EventArgs e)
        {
            Transition.run(this, "Opacity", 1.0, new TransitionType_EaseInEaseOut(600));
            int val = 2;
            if (Environment.OSVersion.Version.Major > 5)
            {
                DwmSetWindowAttribute(this.Handle, 2, ref val, 4);
                MARGINS m = new MARGINS();
                m.cxLeftWidth = 0;
                m.cxRightWidth = 0;
                m.cyBottomHeight = 0;
                m.cyTopHeight = 1;
                DwmExtendFrameIntoClientArea(this.Handle, ref m);
            }
            MinimizeFootprint();
        }

        private void SendReport_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Width - BorderWidth > e.Location.X && e.Location.X > BorderWidth && e.Location.Y > BorderWidth)
                {
                    MoveControl(this.Handle);
                }
                else
                {
                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        ResizeForm(resizeDir);
                    }
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (panel1.Height == 90)
                    Transition.run(panel1, "Height", 0, new TransitionType_EaseInEaseOut(600));
                else
                {
                    ShowPanel();
                }
            }
        }

        private void pctsend_MouseEnter(object sender, EventArgs e)
        {
            pctsend.Image = Cheetah.Properties.Resources.mail;
        }

        private void pnlbug_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Width - BorderWidth > e.Location.X && e.Location.X > BorderWidth && e.Location.Y > BorderWidth)
                {
                    MoveControl(this.Handle);
                }
                else
                {
                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        ResizeForm(resizeDir);
                    }
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (panel1.Height == 90)
                    Transition.run(panel1, "Height", 0, new TransitionType_EaseInEaseOut(600));
                else
                {
                    ShowPanel();
                }
            }
        }

        private void pnlfeedback_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Width - BorderWidth > e.Location.X && e.Location.X > BorderWidth && e.Location.Y > BorderWidth)
                {
                    MoveControl(this.Handle);
                }
                else
                {
                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        ResizeForm(resizeDir);
                    }
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (panel1.Height == 90)
                    Transition.run(panel1, "Height", 0, new TransitionType_EaseInEaseOut(600));
                else
                {
                    ShowPanel();
                }
            }
        }

        private void pctfeed_MouseEnter(object sender, EventArgs e)
        {
            pctfeed.Image = Cheetah.Properties.Resources.Feedback;
        }

        private void pctfeed_MouseLeave(object sender, EventArgs e)
        {
            pctfeed.Image = Cheetah.Properties.Resources.Feedback1;
        }

        private void pctfeed_MouseUp(object sender, MouseEventArgs e)
        {
            pctfeed.Image = Cheetah.Properties.Resources.Feedback1;
        }

        #region "Close effect"
        private void pctclose_MouseEnter(object sender, EventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.CloseHover;
        }

        private void pctclose_MouseLeave(object sender, EventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.Closes;
        }

        private void pctclose_MouseUp(object sender, MouseEventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.Closes;
        }
        #endregion

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                if (ButtonSender == "Cancel")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else if (ButtonSender == "OK")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void pctclose_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pctclose_Click(object sender, EventArgs e)
        {
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            CloseTimer.Enabled = true;
        }

        private void pctbug_Click(object sender, EventArgs e)
        {
            tab1.Text = "Report bug";
            this.Text = "Report bug";
            txtdes.Focus();
            pnlbug.Visible = true;

            Transition.run(pnlbug, "Height", 334, new TransitionType_EaseInEaseOut(600));
            Transition.run(pnlfeedback, "Height", 0, new TransitionType_EaseInEaseOut(600));

            if (string.IsNullOrEmpty(txtdes.Text))
                pctsend.Enabled = false;
            else
                pctsend.Enabled = true;
        }

        private void pctfeed_Click(object sender, EventArgs e)
        {
            tab1.Text = "Report feedback";
            this.Text = "Report feedback";
            txtfeedback.Focus();
            pnlfeedback.Visible = true;
            Transition.run(pnlbug, "Height", 0, new TransitionType_EaseInEaseOut(600));
            Transition.run(pnlfeedback, "Height", 334, new TransitionType_EaseInEaseOut(600));

            if (string.IsNullOrEmpty(txtfeedback.Text))
                pctsend.Enabled = false;
            else
                pctsend.Enabled = true;
        }

        internal Form1 FindFirstInstanceOfForm1()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    return (Form1)f;
                }
            }
            return new Form1();
        }

        private void pctsend_Click(object sender, EventArgs e)
        {
            if (pnlbug.Height == 334)
            {
                tab1.Text = "Report bug - Sending..";
                this.Text = "Report bug - Sending..";
                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    smtpserver.Credentials = new System.Net.NetworkCredential("praken.surf@gmail.com", "CBESARckecil123");
                    smtpserver.Port = 587;
                    smtpserver.Host = "smtp.gmail.com";
                    smtpserver.EnableSsl = true;
                    mail = new MailMessage();
                    mail.From = new MailAddress("praken.surf@gmail.com");
                    mail.To.Add("praken.surf@gmail.com");
                    mail.Subject = txtproblem.SelectedItem.ToString();
                    mail.Body = "Link : " + txtpage.Text + "\r\n\r\n" + "Description : \r\n" + txtdes.Text;
                    smtpserver.Send(mail);
                    this.Close();

                }
                catch
                {
                    FindFirstInstanceOfForm1().Browser.Navigate(Application.StartupPath + "/Sources/error.html");
                }
            }
            else if (pnlfeedback.Height == 334)
            {
                tab1.Text = "Report feedback - Sending..";
                this.Text = "Report feedback - Sending.. ";

                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    smtpserver.Credentials = new System.Net.NetworkCredential("praken.surf@gmail.com", "CBESARckecil123");
                    smtpserver.Port = 587;
                    smtpserver.Host = "smtp.gmail.com";
                    smtpserver.EnableSsl = true;
                    mail = new MailMessage();
                    mail.From = new MailAddress("praken.surf@gmail.com");
                    mail.To.Add("praken.surf@gmail.com");
                    mail.Subject = "Feedback";
                    mail.Body = "Feedback : \r\n\r\n" + txtfeedback.Text;
                    smtpserver.Send(mail);
                    this.Close();

                }
                catch
                {
                    FindFirstInstanceOfForm1().Browser.Navigate(Application.StartupPath + "/Sources/error.html");
                }
            }
        }

        private void txtfeedback_TextChanged(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtfeedback.Text))
                    pctsend.Enabled = false;
                else
                    pctsend.Enabled = true;
            
        }

        private void txtdes_TextChanged(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtdes.Text))
                    pctsend.Enabled = false;
                else
                    pctsend.Enabled = true;
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void ShowPanel()
        {
            panel1.Visible = true;
            Transition.run(panel1, "Height", 90, new TransitionType_EaseInEaseOut(600));
        }

        private void txtdes_Enter(object sender, EventArgs e)
        {

        }

        private void txtdes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.LWin)
                ShowPanel();
        }

        private void txtdes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                ShowPanel();
        }

        private void txtfeedback_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                ShowPanel();
        }

        private void txtfeedback_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.LWin)
                ShowPanel();
        }

        private void pnlbug_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void txtfeedback_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void SendReport_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
