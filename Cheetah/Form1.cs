using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ChromiumEngine;
using ChromiumEngine.WindowsForms;
using Qios.DevSuite.Components;
using ChromiumEngine.WindowsForms.EventArgs;

namespace Cheetah
{
    public partial class Form1 : Form
    {
        private const int HTTOPRIGHT = 14;
        private const int HTCAPTION = 0x2;
        public Form1()
        {
            if (System.Environment.OSVersion.Version.Major > 5 && IsAero())
            {
                ExtendMargins(10, 37, 10, 100, true, true);
                SetStyle(ControlStyles.ResizeRedraw, true);
                InitializeComponent();
                DoubleBuffered = true;
                bool result = true;
                if (Properties.Settings.Default.UseAero)
                {
                    if (result)
                        this.BackColor = Color.Black;
                    else
                        TabC.BackColor = Color.FromArgb(102, 203, 234);
                }
                else
                    TabC.BackColor = Color.FromArgb(102, 203, 234);
            }
            else
            {
                InitializeComponent();
                TabC.BackColor = Color.FromArgb(235, 232, 215);
            }
            
        }
        #region Extend Frame
        #region Constants
        // windowpos
        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_NOREDRAW = 0x0008;
        private const int SWP_NOACTIVATE = 0x0010;
        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int SWP_HIDEWINDOW = 0x0080;
        private const int SWP_NOCOPYBITS = 0x0100;
        private const int SWP_NOOWNERZORDER = 0x0200;
        private const int SWP_NOSENDCHANGING = 0x0400;
        // redraw
        private const int RDW_INVALIDATE = 0x0001;
        private const int RDW_INTERNALPAINT = 0x0002;
        private const int RDW_ERASE = 0x0004;
        private const int RDW_VALIDATE = 0x0008;
        private const int RDW_NOINTERNALPAINT = 0x0010;
        private const int RDW_NOERASE = 0x0020;
        private const int RDW_NOCHILDREN = 0x0040;
        private const int RDW_ALLCHILDREN = 0x0080;
        private const int RDW_UPDATENOW = 0x0100;
        private const int RDW_ERASENOW = 0x0200;
        private const int RDW_FRAME = 0x0400;
        private const int RDW_NOFRAME = 0x0800;
        // frame
        private const int FRAME_WIDTH = 8;
        private const int CAPTION_HEIGHT = 30;
        private const int FRAME_SMWIDTH = 4;
        private const int CAPTION_SMHEIGHT = 24;
        // misc
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_RESTORE = 0xF120;
        private const int SC_MAXIMIZE = 0xF030;
        private const int SM_SWAPBUTTON = 23;
        private const int WM_GETTITLEBARINFOEX = 0x033F;
        private const int VK_LBUTTON = 0x1;
        private const int VK_RBUTTON = 0x2;
        private const int KEY_PRESSED = 0x1000;
        private const int BLACK_BRUSH = 4;
        // proc
        private const int WM_CREATE = 0x0001;
        private const int WM_NCCALCSIZE = 0x83;
        private const int WM_NCHITTEST = 0x84;
        private const int WM_SIZE = 0x5;
        private const int WM_PAINT = 0xF;
        private const int WM_TIMER = 0x113;
        private const int WM_ACTIVATE = 0x6;
        private const int WM_NCMOUSEMOVE = 0xA0;
        private const int WM_NCMOUSEHOVER = 0x02A0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCLBUTTONUP = 0xA2;
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        private const int WM_NCRBUTTONDOWN = 0xA4;
        private const int WM_NCRBUTTONUP = 0xA5;
        private const int WM_NCRBUTTONDBLCLK = 0xA6;
        private const int WM_DWMCOMPOSITIONCHANGED = 0x031E;
        private const int WVR_ALIGNTOP = 0x0010;
        private const int WVR_ALIGNLEFT = 0x0020;
        private const int WVR_ALIGNBOTTOM = 0x0040;
        private const int WVR_ALIGNRIGHT = 0x0080;
        private const int WVR_HREDRAW = 0x0100;
        private const int WVR_VREDRAW = 0x0200;
        private const int WVR_REDRAW = (WVR_HREDRAW | WVR_VREDRAW);
        private const int WVR_VALIDRECTS = 0x400;
        private static IntPtr MSG_HANDLED = new IntPtr(0);
        #endregion

        #region Enums
        private enum HIT_CONSTANTS : int
        {
            HTERROR = -2,
            HTTRANSPARENT = -1,
            HTNOWHERE = 0,
            HTCLIENT = 1,
            HTCAPTION = 2,
            HTSYSMENU = 3,
            HTGROWBOX = 4,
            HTMENU = 5,
            HTHSCROLL = 6,
            HTVSCROLL = 7,
            HTMINBUTTON = 8,
            HTMAXBUTTON = 9,
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17,
            HTBORDER = 18,
            HTOBJECT = 19,
            HTCLOSE = 20,
            HTHELP = 21
        }

        private enum PART_TYPE : int
        {
            WP_MINBUTTON = 15,
            WP_MAXBUTTON = 17,
            WP_CLOSEBUTTON = 18,
            WP_RESTOREBUTTON = 21
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            internal int X;
            internal int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SIZE
        {
            public int cx;
            public int cy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            internal RECT(int X, int Y, int Width, int Height)
            {
                this.Left = X;
                this.Top = Y;
                this.Right = Width;
                this.Bottom = Height;
            }
            internal int Left;
            internal int Top;
            internal int Right;
            internal int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct PAINTSTRUCT
        {
            internal IntPtr hdc;
            internal int fErase;
            internal RECT rcPaint;
            internal int fRestore;
            internal int fIncUpdate;
            internal int Reserved1;
            internal int Reserved2;
            internal int Reserved3;
            internal int Reserved4;
            internal int Reserved5;
            internal int Reserved6;
            internal int Reserved7;
            internal int Reserved8;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
            public MARGINS(int Left, int Right, int Top, int Bottom)
            {
                this.cxLeftWidth = Left;
                this.cxRightWidth = Right;
                this.cyTopHeight = Top;
                this.cyBottomHeight = Bottom;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NCCALCSIZE_PARAMS
        {
            internal RECT rect0, rect1, rect2;
            internal IntPtr lppos;
        }
        #endregion

        #region API
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hdc, ref MARGINS marInset);

        [DllImport("dwmapi.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DwmDefWindowProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam, ref IntPtr result);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndAfter, int x, int y, int cx, int cy, uint flags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PtInRect([In] ref RECT lprc, Point pt);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetClientRect(IntPtr hWnd, ref RECT r);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateSolidBrush(int crColor);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll")]
        private static extern int FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr);

        [DllImport("gdi32.dll")]
        private static extern IntPtr GetStockObject(int fnObject);

        [DllImport("user32.dll")]
        private static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool InflateRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);
        #endregion

        #region Fields
        private bool _bPaintWindow = false;
        private bool _bDrawCaption = false;
        private bool _bIsCompatible = false;
        private bool _bIsAero = false;
        private bool _bPainting = false;
        private bool _bExtendIntoFrame = false;
        private int _iCaptionHeight = CAPTION_HEIGHT;
        private int _iFrameHeight = FRAME_WIDTH;
        private int _iFrameWidth = FRAME_WIDTH;
        private int _iFrameOffset = 100;
        private int _iStoreHeight = 0;
        private RECT _tClientRect = new RECT();
        private MARGINS _tMargins = new MARGINS();
        private RECT[] _tButtonSize = new RECT[3];
        #endregion

        #region Properties
        private int CaptionHeight
        {
            get { return _iCaptionHeight; }
        }

        private int FrameWidth
        {
            get { return _iFrameWidth; }
        }

        private int FrameHeight
        {
            get { return _iFrameHeight; }
        }
        #endregion

        #region Methods
        private void ExtendMargins(int left, int top, int right, int bottom, bool drawcaption, bool intoframe)
        {
            // any negative value causes whole window client to extend
            if (left < 0 || top < 0 || right < 0 || bottom < 0)
            {
                _bPaintWindow = true;
                _tMargins.cyTopHeight = -1;
            }
            // only caption can be extended
            else if (intoframe)
            {
                _tMargins.cxLeftWidth = 0;
                _tMargins.cyTopHeight = top;
                _tMargins.cxRightWidth = 0;
                _tMargins.cyBottomHeight = 0;
            }
            // normal extender
            else
            {
                _tMargins.cxLeftWidth = left;
                _tMargins.cyTopHeight = top;
                _tMargins.cxRightWidth = right;
                _tMargins.cyBottomHeight = bottom;
            }
            _bExtendIntoFrame = intoframe;
            _bDrawCaption = drawcaption;
            _bIsCompatible = IsCompatableOS();
            _bIsAero = IsAero();
        }

        private void GetFrameSize()
        {
            if (this.MinimizeBox)
                _iFrameOffset = 100;
            else
                _iFrameOffset = 40;
            switch (this.FormBorderStyle)
            {
                case FormBorderStyle.Sizable:
                    {
                        _iCaptionHeight = CAPTION_HEIGHT;
                        _iFrameHeight = FRAME_WIDTH;
                        _iFrameWidth = FRAME_WIDTH;
                        break;
                    }
                case FormBorderStyle.Fixed3D:
                    {
                        _iCaptionHeight = 27;
                        _iFrameHeight = 4;
                        _iFrameWidth = 4;
                        break;
                    }
                case FormBorderStyle.FixedDialog:
                    {
                        _iCaptionHeight = 25;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.FixedSingle:
                    {
                        _iCaptionHeight = 25;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.FixedToolWindow:
                    {
                        _iFrameOffset = 20;
                        _iCaptionHeight = 21;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.SizableToolWindow:
                    {
                        _iFrameOffset = 20;
                        _iCaptionHeight = 26;
                        _iFrameHeight = 4;
                        _iFrameWidth = 4;
                        break;
                    }
                default:
                    {
                        _iCaptionHeight = CAPTION_HEIGHT;
                        _iFrameHeight = FRAME_WIDTH;
                        _iFrameWidth = FRAME_WIDTH;
                        break;
                    }
            }
        }

        private HIT_CONSTANTS HitTest()
        {
            RECT windowRect = new RECT();
            Point cursorPoint = new Point();
            RECT posRect;
            GetCursorPos(ref cursorPoint);
            GetWindowRect(this.Handle, ref windowRect);
            cursorPoint.X -= windowRect.Left;
            cursorPoint.Y -= windowRect.Top;
            int width = windowRect.Right - windowRect.Left;
            int height = windowRect.Bottom - windowRect.Top;

            posRect = new RECT(0, 0, FrameWidth, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOPLEFT;

            posRect = new RECT(width - FrameWidth, 0, width, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOPRIGHT;

            posRect = new RECT(FrameWidth, 0, width - (FrameWidth * 2) - _iFrameOffset, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOP;

            posRect = new RECT(FrameWidth, FrameHeight, width - ((FrameWidth * 2) + _iFrameOffset), _tMargins.cyTopHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTCAPTION;

            posRect = new RECT(0, FrameHeight, FrameWidth, height - FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTLEFT;

            posRect = new RECT(0, height - FrameHeight, FrameWidth, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOMLEFT;

            posRect = new RECT(FrameWidth, height - FrameHeight, width - FrameWidth, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOM;

            posRect = new RECT(width - FrameWidth, height - FrameHeight, width, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOMRIGHT;

            posRect = new RECT(width - FrameWidth, FrameHeight, width, height - FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTRIGHT;

            return HIT_CONSTANTS.HTCLIENT;
        }

        public bool IsAero()
        {
            if (!Properties.Settings.Default.UseAero)
                return false;
            else
            {
                bool enabled = false;
                DwmIsCompositionEnabled(out enabled);
                return enabled;
            }
        }

        public bool IsCompatableOS()
        {
            return (Environment.OSVersion.Version.Major >= 6);
        }

        private void FrameChanged()
        {
            RECT rcClient = new RECT();
            GetWindowRect(this.Handle, ref rcClient);
            // force a calc size message
            SetWindowPos(this.Handle,
                         IntPtr.Zero,
                         rcClient.Left, rcClient.Top,
                         rcClient.Right - rcClient.Left, rcClient.Bottom - rcClient.Top,
                         SWP_FRAMECHANGED);
        }

        private void InvalidateWindow()
        {
            RedrawWindow(this.Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_UPDATENOW | RDW_INVALIDATE | RDW_ERASE);
        }

        private void PaintThis(IntPtr hdc, RECT rc)
        {
            RECT clientRect = new RECT();
            GetClientRect(this.Handle, ref clientRect);
            if (_bExtendIntoFrame)
            {
                clientRect.Left = _tClientRect.Left - _tMargins.cxLeftWidth;
                clientRect.Top = _tMargins.cyTopHeight;
                clientRect.Right -= _tMargins.cxRightWidth;
                clientRect.Bottom -= _tMargins.cyBottomHeight;
            }
            else if (!_bPaintWindow)
            {
                clientRect.Left = _tMargins.cxLeftWidth;
                clientRect.Top = _tMargins.cyTopHeight;
                clientRect.Right -= _tMargins.cxRightWidth;
                clientRect.Bottom -= _tMargins.cyBottomHeight;
            }
            if (!_bPaintWindow)
            {
                int clr;
                IntPtr hb;
                using (ClippingRegion cp = new ClippingRegion(hdc, clientRect, rc))
                {
                    if (IsAero())
                    {
                        FillRect(hdc, ref rc, GetStockObject(BLACK_BRUSH));
                    }
                    else
                    {
                        clr = ColorTranslator.ToWin32(Color.FromArgb(0xC2, 0xD9, 0xF7));
                        hb = CreateSolidBrush(clr);
                        FillRect(hdc, ref clientRect, hb);
                        DeleteObject(hb);
                    }
                }
                clr = ColorTranslator.ToWin32(this.BackColor);
                hb = CreateSolidBrush(clr);
                FillRect(hdc, ref clientRect, hb);
                DeleteObject(hb);
            }
            else
            {
                FillRect(hdc, ref rc, GetStockObject(BLACK_BRUSH));
            }
            if (_bExtendIntoFrame && _bDrawCaption)
            {
                Rectangle captionBounds = new Rectangle(4, 4, rc.Right, CaptionHeight);
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    using (Font fc = new Font("Segoe UI", 12, FontStyle.Regular))
                    {
                        SizeF sz = g.MeasureString(this.Text, fc);
                        int offset = (rc.Right - (int)sz.Width) / 2;
                        if (offset < 2 * FrameWidth)
                            offset = 2 * FrameWidth;
                        captionBounds.X = offset;
                        captionBounds.Y = 4;
                        using (StringFormat sf = new StringFormat())
                        {
                            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                            sf.FormatFlags = StringFormatFlags.NoWrap;
                            sf.Alignment = StringAlignment.Near;
                            sf.LineAlignment = StringAlignment.Near;
                            using (GraphicsPath path = new GraphicsPath())
                            {
                                g.SmoothingMode = SmoothingMode.HighQuality;
                                path.AddString(this.Text, fc.FontFamily, (int)fc.Style, fc.Size, captionBounds, sf);
                                g.FillPath(Brushes.Black, path);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0021:
                    
                    break;
            }
            if (_bIsCompatible)
            {
                CustomProc(ref m);
            }
            else
            {

                base.WndProc(ref m);
            }
        }

        protected void CustomProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                    {
                        PAINTSTRUCT ps = new PAINTSTRUCT();
                        if (!_bPainting)
                        {
                            _bPainting = true;
                            BeginPaint(m.HWnd, ref ps);
                            PaintThis(ps.hdc, ps.rcPaint);
                            EndPaint(m.HWnd, ref ps);
                            _bPainting = false;
                            base.WndProc(ref m);
                        }
                        else
                        {
                            base.WndProc(ref m);
                        }
                        break;
                    }
                case WM_CREATE:
                    {
                        GetFrameSize();
                        FrameChanged();
                        m.Result = MSG_HANDLED;
                        base.WndProc(ref m);
                        break;
                    }
                case WM_NCCALCSIZE:
                    {
                        if (m.WParam != IntPtr.Zero && m.Result == IntPtr.Zero)
                        {
                            if (_bExtendIntoFrame)
                            {
                                NCCALCSIZE_PARAMS nc = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));
                                nc.rect0.Top -= (_tMargins.cyTopHeight > CaptionHeight ? CaptionHeight : _tMargins.cyTopHeight);
                                nc.rect1 = nc.rect0;
                                Marshal.StructureToPtr(nc, m.LParam, false);
                                m.Result = (IntPtr)WVR_VALIDRECTS;
                            }
                            base.WndProc(ref m);
                        }
                        else
                        {
                            base.WndProc(ref m);
                        }
                        break;
                    }
                case WM_SYSCOMMAND:
                    {
                        UInt32 param;
                        if (IntPtr.Size == 4)
                            param = (UInt32)(m.WParam.ToInt32());
                        else
                            param = (UInt32)(m.WParam.ToInt64());
                        if ((param & 0xFFF0) == SC_RESTORE)
                        {
                            this.Height = _iStoreHeight;
                        }
                        else if (this.WindowState == FormWindowState.Normal)
                        {
                            _iStoreHeight = this.Height;
                        }
                        base.WndProc(ref m);
                        break;
                    }
                case WM_NCHITTEST:
                    {
                        if (m.Result == (IntPtr)HIT_CONSTANTS.HTNOWHERE)
                        {
                            IntPtr res = IntPtr.Zero;
                            if (DwmDefWindowProc(m.HWnd, (uint)m.Msg, m.WParam, m.LParam, ref res))
                                m.Result = res;
                            else
                                m.Result = (IntPtr)HitTest();
                        }
                        else
                            base.WndProc(ref m);
                        break;
                    }
                case WM_DWMCOMPOSITIONCHANGED:
                case WM_ACTIVATE:
                    {
                        DwmExtendFrameIntoClientArea(this.Handle, ref _tMargins);
                        m.Result = MSG_HANDLED;
                        base.WndProc(ref m);
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        break;
                    }
            }
        }
        #endregion

        #region Clipping Region
        /// <summary>Clip rectangles or rounded rectangles</summary>
        internal class ClippingRegion : IDisposable
        {
            #region Enum
            private enum CombineRgnStyles : int
            {
                RGN_AND = 1,
                RGN_OR = 2,
                RGN_XOR = 3,
                RGN_DIFF = 4,
                RGN_COPY = 5,
                RGN_MIN = RGN_AND,
                RGN_MAX = RGN_COPY
            }
            #endregion

            #region API
            [DllImport("gdi32.dll")]
            private static extern int SelectClipRgn(IntPtr hdc, IntPtr hrgn);

            [DllImport("gdi32.dll")]
            private static extern int GetClipRgn(IntPtr hdc, [In, Out]IntPtr hrgn);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

            [DllImport("gdi32.dll")]
            private static extern int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, CombineRgnStyles fnCombineMode);

            [DllImport("gdi32.dll")]
            private static extern int ExcludeClipRect(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool DeleteObject(IntPtr hObject);
            #endregion

            #region Fields
            private IntPtr _hClipRegion;
            private IntPtr _hDc;
            #endregion

            #region Methods
            public ClippingRegion(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect)
            {
                CreateRectangleClip(hdc, cliprect, canvasrect);
            }

            public ClippingRegion(IntPtr hdc, RECT cliprect, RECT canvasrect)
            {
                CreateRectangleClip(hdc, cliprect, canvasrect);
            }

            public ClippingRegion(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect, uint radius)
            {
                CreateRoundedRectangleClip(hdc, cliprect, canvasrect, radius);
            }

            public ClippingRegion(IntPtr hdc, RECT cliprect, RECT canvasrect, uint radius)
            {
                CreateRoundedRectangleClip(hdc, cliprect, canvasrect, radius);
            }

            public void CreateRectangleClip(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect)
            {
                _hDc = hdc;
                IntPtr clip = CreateRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRectangleClip(IntPtr hdc, RECT cliprect, RECT canvasrect)
            {
                _hDc = hdc;
                IntPtr clip = CreateRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRoundedRectangleClip(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect, uint radius)
            {
                int r = (int)radius;
                _hDc = hdc;
                // create rounded regions
                IntPtr clip = CreateRoundRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom, r, r);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRoundRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom, r, r);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                // add it in
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRoundedRectangleClip(IntPtr hdc, RECT cliprect, RECT canvasrect, uint radius)
            {
                int r = (int)radius;
                _hDc = hdc;
                // create rounded regions
                IntPtr clip = CreateRoundRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom, r, r);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRoundRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom, r, r);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                // add it in
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void Release()
            {
                if (_hClipRegion != IntPtr.Zero)
                {
                    // remove region
                    SelectClipRgn(_hDc, IntPtr.Zero);
                    // delete region
                    DeleteObject(_hClipRegion);
                }
            }

            public void Dispose()
            {
                Release();
            }
            #endregion
        }
        #endregion

        #endregion
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

        private void MoveControl(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
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

        #region "Sub right menu tab"
        public void res(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Maximized;
            }
            else
            {
                base.WindowState = FormWindowState.Normal;
            }
        }

        public void clo(object sender, EventArgs e)
        {
            this.Close();
        }
        public void min(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        public void max(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Maximized;
            }
            else
            {
                base.WindowState = FormWindowState.Normal;
            }
        }
        public void AddNewTab(object sender, EventArgs e)
        {
            //ONewTab.PerformClick();
        }

        public void ReloadTab(QTabPage Tab)
        {
            ((WebDisplay)Tab.Controls[0]).Reload();
        }

        public void DuplicateTab(QTabPage Tab)
        {
            WebDisplay current = Browser;
            WebDisplay nextweb = (WebDisplay)Tab.Controls[0];//Controls(0);
            QTabPage Tabs = new QTabPage();
            string s = nextweb.Url.ToString().Replace(" ", "%20");
            //AddTab(s);
            //Browser.WebView.loadBackForwardListFromOtherView(nextweb.WebView);
        }

        public void closeothertab()
        {
            QTabPage t = default(QTabPage);
            while (!(TabC.Controls.TabPagesCount == 1))
            {
                try
                {
                    t = TabC.GetPreviousAccessibleTabPage(null, false);
                    if (!t.Equals(TabC.GetPageWithButtonAtPoint(btnCloseTab.Location)))
                    {
                        CloseTab(t);
                    }
                }
                catch
                {
                }
                try
                {
                    t = TabC.GetNextAccessibleTabPage(null, false);
                    if (!t.Equals(TabC.GetPageWithButtonAtPoint(btnCloseTab.Location)))
                    {
                        CloseTab(t);
                    }

                }
                catch
                {
                }
                //MinimizeFootprint();
            }

        }
        public void DoOverflow()
        {
            try
            {
                int AvailbaleSpace = TabC.Width - TabC.TabStripTopConfiguration.StripPadding.Left - 135;
                if (AvailbaleSpace > TabC.TabStripTop.TabButtons.Count * 200)
                {
                    TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize = new Size(200, TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize.Height);
                    TabC.TabStripTopConfiguration.ButtonConfiguration.MinimumSize = TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize;
                }
                else
                {
                    byte m = (byte)(AvailbaleSpace % TabC.Controls.TabPagesCount);
                    QPadding s = TabC.TabStripTopConfiguration.StripPadding;
                    TabC.TabStripTopConfiguration.StripPadding = new QPadding(s.Left, s.Top, s.Bottom, 135 - m);
                    int width = AvailbaleSpace / TabC.Controls.TabPagesCount;
                    TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize = new Size(width, TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize.Height);
                    TabC.TabStripTopConfiguration.ButtonConfiguration.MinimumSize = TabC.TabStripTopConfiguration.ButtonConfiguration.MaximumSize;
                }
                int left = TabC.TabStripTop.TabButtons[TabC.TabStripTop.TabButtons.Count - 1].Left + TabC.TabStripTop.TabButtons[TabC.TabStripTop.TabButtons.Count - 1].Width;
                btnaddtab.Left = left;
                btnCloseTab.Left = TabC.ActiveTabPage.TabButton.Left + TabC.ActiveTabPage.TabButton.Width - btnCloseTab.Width - 3;
                this.Refresh();

                Application.DoEvents();
            }
            catch
            { }

        }
        public void CloseTab(QTabPage Tab)
        {
            //CType(Tab.Controls(0), WebDisplay).Dispose()
            Tab.Controls[0].Dispose();
            TabC.Controls.Remove(Tab);

            btnCloseTab.Visible = false;
            DoOverflow();

        }
        #endregion

        #region "TabC"
        private void TabC_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            QTabPage tab = TabC.GetPageWithButtonAtPoint(e.Location);
            try
            {
                if (tab.Equals(null))
                {
                    btnCloseTab.Visible = true;
                }
            }
            catch
            {
                //btnCloseTab.Visible = False
                return;
            }
            int left = tab.TabButton.Left + tab.TabButton.Width - btnCloseTab.Width - 3;
            if (!(btnCloseTab.Left == left))
            {
                btnCloseTab.Left = left;
            }
            if (btnCloseTab.Visible == false)
            {
                btnCloseTab.Visible = true;
            }

        }
        private void TabC_MouseLeave(object sender, System.EventArgs e)
        {
            QTabPage t = TabC.GetPageWithButtonAtPoint(new Point(MousePosition.X - this.Left - SystemInformation.HorizontalResizeBorderThickness, MousePosition.Y - this.Top - SystemInformation.CaptionHeight));
            try
            {
                if (!t.Equals(null))
                {
                    return;
                }
            }
            catch
            {
                //btnCloseTab.Visible = False
            }
            //if (toclear.Count > 0)
            //{
            //    foreach (PictureBox p in toclear)
            //    {
            //        p.Dispose();
            //    }
            //    toclear.Clear();
            //}
        }

        private void TabC_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            QTabPage t = TabC.GetPageWithButtonAtPoint(e.Location);
            try
            {
                if (!t.Equals(null))
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Middle)
                    {
                        if (TabC.TabStripTop.TabButtons.Count > 1)
                        {
                            CloseTab(TabC.GetPageWithButtonAtPoint(btnCloseTab.Location));
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                    if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        ContextMenu x = CMTab;

                        //if (((QTabPage)t).PrivateBrowsing == true)
                        //{
                        //    CMIncogTab.Checked = true;
                        //}
                        //else
                        //{
                        //    CMIncogTab.Checked = false;
                        //}
                        if (TabC.TabStripTop.TabButtons.Count > 1)
                        {
                            CMCloseother.Enabled = true;
                        }
                        else
                        {
                            CMCloseother.Enabled = false;
                        }
                        x.Show((Control)sender, e.Location);

                        //pnlsurf.Visible = false;
                        //pnlsec.Visible = false;
                    }
                }
            }
            catch
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

                    //pnlsurf.Visible = false;
                    //pnlsec.Visible = false;
                }

                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ContextMenu x = CMTabspace;
                    CMTrestore.Enabled = (base.WindowState == FormWindowState.Maximized);
                    CMTmaximize.Enabled = (base.WindowState == FormWindowState.Normal);
                    x.Show((Control)sender, e.Location);

                    //pnlsurf.Visible = false;
                    //pnlsec.Visible = false;
                }
            }
        }
        private void TabC_ControlAdded(object sender, ControlEventArgs e)
        {
            QTabPage Tab = new QTabPage();
            //btnaddtab.Left = TabC.ActiveTabPage.TabButton.Width
            btnaddtab.Left = Tab.TabButton.Left + Tab.TabButton.Width - 5;
            DoOverflow();
        }

        private void TabC_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnaddtab.Left -= TabC.ActiveTabPage.TabButton.Width;
            DoOverflow();
        }
        #endregion

        internal WebDisplay Browser
        {
            get { try { return (WebDisplay)TabC.ActiveTabPage.Controls[0]; } catch { return null; } }
        }

        public bool IsURL(string text)
        {
            if (text.StartsWith("about:") && text.Contains(" ") == false)
            {
                return true;
            }
            if (text.StartsWith("file:///"))
                return true;
            return (Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute));
        }

        public void AddTab(string u = "")
        { 
            QTabPage tbp = new QTabPage();
            tbp.Text = "No Title";
            WebDisplay view = new WebDisplay();
            WebPreferences prefs = new WebPreferences();
            prefs.UniversalAccessFromFileUrlsAllowed = false;
            prefs.WebGLDisabled = false;
            view.Preferences = prefs;
            view.InitializeEngine("about:blank");
            view.Focus();
            tbp.Controls.Add(view);
            TabC.Controls.Add(tbp);
            TabC.ActiveTabPage = tbp;
            view.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            if (panel1.Visible == false)
            {
                view.Size = new System.Drawing.Size(tbp.Width, tbp.Height);
                view.Location = new Point(0, 0);
            }
            else
            {
                view.Size = new System.Drawing.Size(tbp.Width, tbp.Height - panel1.Height);
                view.Location = new Point(0, panel1.Height);
            }
            //ShowNavBar(view);
            if (!string.IsNullOrEmpty(u))
                if (u.Contains("\\") && !u.StartsWith("file://"))
                    view.OpenDocument();
                else if (IsURL(u))
                    view.Navigate(u);
                else
                    Search(u);
            OnTabChangedTriggered();
            DoOverflow();
            AddEvents(view);
            FaviconCollection.Add(view, Properties.Resources.favicons);
            view.Disposed += delegate(object sender, EventArgs e) { FaviconCollection.Remove((WebDisplay)sender); };
            //AddContextMenus(view);
           btnaddtab.Left = tbp.TabButton.Left + tbp.TabButton.Width - 5;
        }

        internal void AddEvents(WebDisplay dis)
        {
            dis.DocumentComplete += dis_DocumentComplete;
            dis.BeginFrameLoading += dis_BeginDocumentLoading;
            dis.StatusChanged += dis_StatusChanged;
            dis.DocumentTitleChanged += delegate(WebDisplay sender, DocumentTitleChangedEventArgs e) { sender.Parent.Text = e.Title; };
            dis.BeginFrameLoading += dis_BeginFrameLoading;
            dis.FrameComplete +=dis_FrameComplete;
            dis.NewWindowRequested += dis_NewWindowRequested;
            dis.AddressChanged += dis_AddressChanged;
            dis.ShowJSDialog += dis_ShowJSDialog;
        }
        internal Dictionary<WebDisplay, Image> FaviconCollection = new Dictionary<WebDisplay, Image>();
        private void dis_FrameComplete(WebDisplay sender, FrameCompleteEventArgs e)
        {
            if (sender.Equals(Browser))
            {
                dis_StatusChanged(sender, new StatusMessageEventArgs(string.Empty, ChromiumEngine.Enum.StatusMessageType.Text));
                pictureBox5.Image = Properties.Resources.Refresh;
                faviconpct.Image = FaviconCollection[sender];
            }
        }

        void dis_BeginFrameLoading(WebDisplay sender, BeginFrameLoadingEventArgs e)
        {
            if (sender.Equals(Browser))
            {
                dis_StatusChanged(sender, new StatusMessageEventArgs("Loading " + e.Frame.Url, ChromiumEngine.Enum.StatusMessageType.Text));
                pictureBox5.Image = Properties.Resources.stop;
                faviconpct.Image = Properties.Resources.loading;
                ImageAnimator.Animate(faviconpct.Image, delegate { faviconpct.Invalidate(); });
                    
            }
        }

        void dis_AddressChanged(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.AddresseChangedEventArgs e)
        {
            try
            {
                if (sender.Equals(Browser))
                    txturl.Text = e.Url;
            }
            catch { }
        }

        void dis_BeginDocumentLoading(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.BeginFrameLoadingEventArgs e)
        {
            //try
            //{
                if (sender.Equals(Browser))
                {
                    //faviconpct.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = Properties.Resources.stop;
                    faviconpct.Image = Properties.Resources.loading;
                    FaviconCollection[sender] = Properties.Resources.favicons;
                    ImageAnimator.Animate(faviconpct.Image, delegate { faviconpct.Invalidate(); });
                    
                }
                BackgroundWorker bcw = new BackgroundWorker() { WorkerSupportsCancellation = true };
                    bcw.DoWork += delegate
                    {
                        Image favicon = sender.GetFaviconImageFromDocument();
                        (sender.Parent as QTabPage).Icon = Icon.FromHandle(((Bitmap)favicon).GetHicon());
                        if (sender.Equals(Browser))
                        {
                            FaviconCollection[sender] = favicon;
                            faviconpct.Image = favicon;
                        }
                        History.Add(sender.DocumentTitle, sender.Url, DateTime.Now, Bookmarking.ImageToBase64(favicon, System.Drawing.Imaging.ImageFormat.Icon));
                        bcw.Dispose();
                    };
                    bcw.RunWorkerAsync();
            //}
            //catch { }
        }

        void dis_ShowJSDialog(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.ShowJSDialogEventArgs e)
        {
            switch (e.Type)
            {
                case ChromiumEngine.Enum.JSDialogType.Alert:
                    MessageBox.Show(e.Message, "The current page says:");
                    break;
                case ChromiumEngine.Enum.JSDialogType.Confirm:
                    e.Result = MessageBox.Show(e.Message, "The current page asks:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK;
                    break;
                case ChromiumEngine.Enum.JSDialogType.Prompt:
                    e.PromptInputText = Microsoft.VisualBasic.Interaction.InputBox(e.Message, "The page requests the following:", e.DefaultPromptInputText);
                    e.Result = true;
                    break;
            }
            e.Handled = true;
        }

        void dis_NewWindowRequested(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.NewWindowRequestEventArgs e)
        {
            AddTab(e.Url);
        }

        void dis_StatusChanged(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.StatusMessageEventArgs e)
        {
            try
            {
                status.Visible = !string.IsNullOrWhiteSpace(e.Text);
                if (status.Visible == false)
                    return;
                if (e.Text.Length < 51)
                    status.Text = e.Text;
                else
                    status.Text = e.Text.Substring(0, 51) + "...";
            }
            catch { }
        }


        void dis_DocumentComplete(WebDisplay sender, ChromiumEngine.WindowsForms.EventArgs.UrlEventArgs e)
        {
            try
            {
                if (sender.Equals(Browser))
                    pictureBox5.Image = Properties.Resources.Refresh;
                txturl.Text = e.Url;
                if (e.Url.StartsWith("https://"))
                {
                    txturl.BackColor = Color.LightGreen;
                    textBox2.BackColor = Color.LightGreen;
                }
                else
                {
                    txturl.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                }
             }
            catch { }
        }
        internal void OnTabChangedTriggered()
        {
            int posx = button1.Width + 4 + TabC.Controls.TabPagesCount * (TabC.TabStripTopConfiguration.ButtonSpacing + TabC.TabStripTopConfiguration.ButtonConfiguration.MinimumSize.Width);
            if (!(posx > this.Width - 128))
                btnaddtab.Left = posx;
            else
                btnaddtab.Left = this.Width - btnaddtab.Width - 2;
        }

        private void Search(string term)
        {
            if (Cheetah.Properties.Settings.Default.SearchEngine == "Amazon")
            {
                Browser.Navigate("www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Yahoo!")
            {
                Browser.Navigate("us.search.yahoo.com/search?p=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Ask")
            {
                Browser.Navigate("www.ask.com/web?q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Bing")
            {
                Browser.Navigate("www.bing.com/search?q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "AOL")
            {
                Browser.Navigate("www.earch.aol.com/aol/search?enabled_terms=&s_it=comsearch50&q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Youtube")
            {
                Browser.Navigate("www.youtube.com/results?search_query=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Wikipedia")
            {
                Browser.Navigate("en.wikipedia.org/wiki/" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Dictionary")
            {
                Browser.Navigate("www.dictionary.reference.com/browse/" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Twitter")
            {
                Browser.Navigate("twitter.com/#!/search/" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Facebook")
            {
                Browser.Navigate("www.facebook.com/search/results.php?q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "MySpace")
            {
                Browser.Navigate("www.myspace.com/search/myspace?q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Microsoft")
            {
                Browser.Navigate("search.microsoft.com/results.aspx?form=MSHOME&mkt=en-us&setlang=en-us&q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Apple")
            {
                Browser.Navigate("www.apple.com/search/?q=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Megavideo")
            {
                Browser.Navigate("megavideo.com/?c=videos&s=" + term);
            }
            else if (Cheetah.Properties.Settings.Default.SearchEngine == "Brothersoft")
            {
                Browser.Navigate("search.brothersoft.com/" + term);
            }
            else
            {
                Browser.Navigate("www.google.com/search?q=" + term);
            }
        }

        private void btnaddtab_Click(object sender, EventArgs e)
        {
            AddTab("about:blank");
        }

        private void txturl_KeyDown(object sender, KeyEventArgs e)
        {
            //WebDisplay wb = Browser;
            if (e.Shift && e.Control && e.KeyCode == Keys.Enter)
            {
                if ((!txturl.Text.EndsWith(".org")) && txturl.Text.StartsWith("www."))
                    Browser.Navigate(txturl.Text + ".org");
                else if ((txturl.Text.EndsWith(".org") && (!txturl.Text.StartsWith("www."))))
                    Browser.Navigate("www." + txturl.Text);
                else if (!(txturl.Text.EndsWith(".org") && txturl.Text.StartsWith("www.")))
                    Browser.Navigate("www." + txturl.Text + ".org");
                Browser.Select();
            }
            else if (e.Control && e.KeyCode == Keys.Enter)
            {
                if ((!txturl.Text.EndsWith(".com")) && txturl.Text.StartsWith("www."))
                {
                    string s = txturl.Text + ".com";
                    Browser.Navigate(s);
                }
                else if ((txturl.Text.EndsWith(".com") && (!txturl.Text.StartsWith("www."))))
                {
                    string s = "www." + txturl.Text;
                    Browser.Navigate(s);
                }
                else if (!(txturl.Text.EndsWith(".com") && txturl.Text.StartsWith("www.")))
                {
                    string s = "www." + txturl.Text + ".com";
                    Browser.Navigate(s);
                }
                Browser.Select();
            }
            else if (e.Shift && e.KeyCode == Keys.Enter)
            {
                if ((!txturl.Text.EndsWith(".net")) && txturl.Text.StartsWith("www."))
                    Browser.Navigate(txturl.Text + ".net");
                else if ((txturl.Text.EndsWith(".net") && (!txturl.Text.StartsWith("www."))))
                    Browser.Navigate("www." + txturl.Text);
                else if (!(txturl.Text.EndsWith(".net") && txturl.Text.StartsWith("www.")))
                    Browser.Navigate("www." + txturl.Text + ".net");
                Browser.Select();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (IsURL(txturl.Text))
                    Browser.Navigate(txturl.Text);
                else if (txturl.Text == "cheetah:credits")
                    Browser.Navigate(Application.StartupPath + "/Sources/credit.html");
                else if (txturl.Text == "cheetah:license")
                    Browser.Navigate(Application.StartupPath + "/Sources/license.html");
                else if (txturl.Text == "cheetah:plugins")
                    Browser.Navigate(Application.StartupPath + "/Sources/plugin.html");
                else if (txturl.Text == "cheetah:blank")
                    Browser.Navigate("about:blank");
                else if (txturl.Text == "cheetah:home")
                    Browser.Navigate(Application.StartupPath + "/Sources/start.htm");
                else
                    Search(txturl.Text);
                Browser.Select();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddTab("http://google.com/");
            RefreshBookmarksAndHistory();
            txturl.AutoCompleteCustomSource = Program.autocompletedata;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Browser.IsLoading)
                Browser.StopNavigation();
            else
                Browser.Reload();
        }
        #region controlbox
        private void btnclose_Click(object sender, EventArgs e)
        {
            btnclose.Image = Properties.Resources.cls2;
            this.Close();
        }

        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            btnclose.Image = Properties.Resources.cls;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.Image = Properties.Resources.cls1;
        }
        private void btnmaximize_Click(object sender, EventArgs e)
        {
            btnmaximize.Image = Properties.Resources.rest2;
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnmaximize_MouseHover(object sender, EventArgs e)
        {
            btnmaximize.Image = Properties.Resources.rest;
        }

        private void btnmaximize_MouseLeave(object sender, EventArgs e)
        {
            btnmaximize.Image = Properties.Resources.rest1;
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            btnminimize.Image = Properties.Resources.min2;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnminimize_MouseHover(object sender, EventArgs e)
        {
            btnminimize.Image = Properties.Resources.min;
        }

        private void btnminimize_MouseLeave(object sender, EventArgs e)
        {
            btnminimize.Image = Properties.Resources.min1;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (TabC.Controls.TabPagesCount == 1)
                this.Close();
            else
                TabC.ActiveTabPage.Close();
        }

        public void RefreshBookmarksAndHistory(bool u = false)
        {
            bool res = false;
            foreach (Form f in Application.OpenForms)
                if (f is Form1 && f.Equals(this) == false && u == false)
                {
                    this.txturl.AutoCompleteCustomSource = ((Form1)f).txturl.AutoCompleteCustomSource;
                    res = true;
                    break;
                }
            if (res == false)
            {
                txturl.AutoCompleteCustomSource = Program.autocompletedata;
            }
            BackgroundWorker refreshbookandhisasync = new BackgroundWorker();
            refreshbookandhisasync.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                BookmarksBar.Items.Clear();
                if (Bookmarking.GetItemsCount() != 0)
                    for (int i = 0; i < Bookmarking.GetItemsCount(); i++)
                    {
                        ToolStripButton but = new ToolStripButton() { Text = Bookmarking.Name(i), ToolTipText = Bookmarking.Url(i), Image = Bookmarking.Favicon(i) };
                        if (but.Text.Length > 24)
                            but.Text = but.Text.Substring(0, 24) + "...";
                        but.MouseDown += delegate(object o, MouseEventArgs args1) { if (args1.Button == System.Windows.Forms.MouseButtons.Middle) { AddTab((o as ToolStripButton).ToolTipText); } if (args1.Button == System.Windows.Forms.MouseButtons.Left) { Browser.Navigate((o as ToolStripItem).ToolTipText); } };
                        BookmarksBar.Items.Add(but);
                    }

                else
                {
                    BookmarksBar.Items.Add(new ToolStripLabel("This is the bookmarks bar. You have added no bookmarks so far! "));
                }
                e = null;
                (sender as BackgroundWorker).Dispose();
            };
            refreshbookandhisasync.RunWorkerAsync();

        }

        private void TabC_ActivePageChanged(object sender, QTabPageChangeEventArgs e)
        {
            if (Browser == null)
                return;
            try
            {
                if (!Browser.IsLoading)
                    pictureBox5.Image = Properties.Resources.Refresh;
                else
                    pictureBox5.Image = Properties.Resources.stop;
                txturl.Text = Browser.Url;
                if (Browser.Url.StartsWith("https://"))
                {
                    txturl.BackColor = Color.LightGreen;
                    textBox2.BackColor = Color.LightGreen;
                }
                else
                {
                    txturl.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                }
                faviconpct.Image = FaviconCollection[Browser];
            }
            catch { }
        }


        private void status_SizeChanged(object sender, EventArgs e)
        {
            (sender as Control).Left = pictureBox5.Left - (sender as Control).Width;
        }

        private void txturl_DragEnter(object sender, DragEventArgs e)
        {
           e.Effect = DragDropEffects.Copy;
        }

        private void txturl_DragDrop(object sender, DragEventArgs e)
        {
            txturl.Text = (string)e.Data.GetData(typeof(String));
        }

        private void txturl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        ColorAnimator currentlyanimating = null;
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            if (currentlyanimating != null)
            {
                if (currentlyanimating.IsDisposed == false)
                    currentlyanimating.Dispose();
                currentlyanimating = null;
            }
            ColorAnimator an = new ColorAnimator((sender as Control));
            currentlyanimating = an;
            an.Animate(210,210,226, true);
            //Transitions.Transition.run(pictureBox5.BackColor, "B", Convert.ToByte(255), Convert.ToByte(0), new Transitions.TransitionType_Acceleration(2000));
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentlyanimating != null)
            {
                if (currentlyanimating.IsDisposed == false)
                    currentlyanimating.Dispose();
                currentlyanimating = null;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox5.BackColor = Color.Teal;
            }
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (currentlyanimating != null)
            {
                if (currentlyanimating.IsDisposed == false)
                    currentlyanimating.Dispose();
                currentlyanimating = null;
            }
            ColorAnimator an = new ColorAnimator((sender as Control));
            currentlyanimating = an;
            an.Animate(255, 255, 255);
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                pictureBox5.BackColor = Color.FromArgb(0, 210, 210, 226);
        }
    }
    public class ColorAnimator : IDisposable 
    {
        private Control con;
        private Timer tim;
        public ColorAnimator(Control c)
        {
            con = c;
        }
        internal bool IsDisposed = false;
        public void Animate(int r = 255, int g = 255, int b = 255, bool reverse = false)
        {
            Timer tm = new Timer() { Interval = 1 };
            tim = tm;
            int sb = Convert.ToInt32(con.BackColor.B);
            int sg = Convert.ToInt32(con.BackColor.G);
            int sr = Convert.ToInt32(con.BackColor.R);
            tm.Tick += delegate 
            {
                if (!reverse)
                    if (sb < b)
                    {
                        sb++;
                    }
                    else { }
                else
                    if (sb > b)
                    {
                        sb--;
                    }
                    else { }
                if (!reverse)
                    if (sg < g)
                    {
                        sg++;
                    }
                    else { }
                else
                    if (sg > g)
                    {
                        sg--;
                    }
                    else { }
                if (!reverse)
                    if (sr < r)
                    {
                        sr++;
                    }
                    else { }
                else
                    if (sr > r)
                    {
                        sr--;
                    }
                    else { }
                if (!reverse)
                    if (sb >= b && sg >= g && sr >= r)
                    {
                        Dispose();
                        return;
                    }
                    else { }
                else
                    if (sb <= b && sg <= g && sr <= r)
                    {
                       Dispose();
                       return;
                    }
                con.BackColor = Color.FromArgb(sr, sg, sb);
            };
            tm.Start();
        }

        public void Dispose()
        {
            con = null;
            tim.Dispose();
            tim = null;
            IsDisposed = true;
            GC.Collect();
        }
    }
}
