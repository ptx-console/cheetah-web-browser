using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Transitions;
using System.Drawing;
using Cheetah;
namespace FastColoredTextBoxNS
{
    public partial class FindForm : Form
    {
        public static string RegexSpecSymbolsPattern = @"[\^\$\[\]\(\)\.\\\*\+\|\?\{\}]";
        bool firstSearch = true;
        Place startPlace;
        FastColoredTextBox tb;

        #region "Custom form"
        private void MoveControl(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        string ButtonSender;

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

        #region "Close effect"
        private void pctclose_MouseEnter(object sender, EventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.cls;
        }

        private void pctclose_MouseLeave(object sender, EventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.cls1;
        }

        private void pctclose_MouseUp(object sender, MouseEventArgs e)
        {
            pctclose.Image = Cheetah.Properties.Resources.cls2;
        }
        #endregion

        public FindForm(FastColoredTextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            CloseTimer.Enabled = true;
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void FindNext()
        {
            try
            {
                string pattern = tbFind.Text;
                RegexOptions opt = cbMatchCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
                if (!cbRegex.Checked)
                    pattern = Regex.Replace(pattern, RegexSpecSymbolsPattern, "\\$0");
                if (cbWholeWord.Checked)
                    pattern = "\\b" + pattern + "\\b";
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                if (firstSearch)
                {
                    startPlace = range.Start;
                    firstSearch = false;
                }
                //
                range.Start = range.End;
                if (range.Start >= startPlace)
                    range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                else
                    range.End = startPlace;
                //
                foreach (var r in range.GetRanges(pattern, opt))
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //
                if (range.Start >= startPlace && startPlace > Place.Empty)
                {
                    tb.Selection.Start = new Place(0, 0);
                    FindNext();
                    return;
                }
                CheetahMessage f = new CheetahMessage();
                f.Title = "Warning!";
                f.Message = "Not found";
                f.CancelVisible = false;
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                CheetahMessage f = new CheetahMessage();
                f.Title = "Error!";
                f.Message = ex.Message;
                f.CancelVisible = false;
                f.ShowDialog();
            }
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                FindNext();
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\x1b')
            {
                Hide();
                e.Handled = true;
                return;
            }
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            tbFind.Focus();
            ResetSerach();
        }

        void ResetSerach()
        {
            firstSearch = true;
        }

        private void cbMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            ResetSerach();
        }

        private void FindForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Width - BorderWidth > e.Location.X && e.Location.X > BorderWidth && e.Location.Y > BorderWidth)
                    MoveControl(this.Handle);
                else
                {
                    if (this.WindowState != FormWindowState.Maximized)
                        ResizeForm(resizeDir);
                }
            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                if (ButtonSender == "Cancel")
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                else if (ButtonSender == "OK")
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                else
                    this.Close();
            }

        }

        private void FindForm_Load(object sender, EventArgs e)
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
    }
}