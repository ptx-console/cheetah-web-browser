using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Cheetah.Forms;

namespace Cheetah
{
    public partial class UpdaterC : Form
    {
        string DownloadLink;
        public UpdaterC()
        {
            InitializeComponent();
        }
        void g()
        {
            
            Timer pictimer6 = new Timer();
            pictimer6.Interval = 1;
            pictimer6.Start();
            Point p6 = new Point();
            Point op6 = new Point();
            op6 = label1.Location;
            p6 = label1.Location;
            p6.X = op6.X - 30;
            pictimer6.Tick += delegate
            {
                label1.Location = p6;
                p6.X += 1;
                if (p6.X == op6.X)
                {
                    pictimer6.Stop();
                    pictimer6.Dispose();
                }
            };
            Timer pictimer7 = new Timer();
            pictimer7.Interval = 1;
            pictimer7.Start();
            Point p7 = new Point();
            Point op7 = new Point();
            op7 = label2.Location;
            p7 = label2.Location;
            p7.X = op7.X - 30;
            pictimer7.Tick += delegate
            {
                label2.Location = p7;
                p7.X += 1;
                if (p7.X == op7.X)
                {
                    pictimer7.Stop();
                    pictimer7.Dispose();
                }
            };
            Timer pictimer8 = new Timer();
            pictimer8.Interval = 1;
            pictimer8.Start();
            Point p8 = new Point();
            Point op8 = new Point();
            op8 = button1.Location;
            p8 = button1.Location;
            p8.X = op8.X - 30;
            pictimer8.Tick += delegate
            {
                button1.Location = p8;
                p8.X += 1;
                if (p8.X == op8.X)
                {
                    pictimer8.Stop();
                    pictimer8.Dispose();
                }
            };
            Timer pictimer9 = new Timer();
            pictimer9.Interval = 1;
            pictimer9.Start();
            Point p9 = new Point();
            Point op9 = new Point();
            op9 = button2.Location;
            p9 = button2.Location;
            p9.X = op9.X - 30;
            pictimer9.Tick += delegate
            {
                button2.Location = p9;
                p9.X += 1;
                if (p9.X == op9.X)
                {
                    pictimer9.Stop();
                    pictimer9.Dispose();
                }
            };
            Timer pictimer10 = new Timer();
            pictimer10.Interval = 1;
            pictimer10.Start();
            Point p10 = new Point();
            Point op10 = new Point();
            op10 = progressBar1.Location;
            p10 = progressBar1.Location;
            p10.X = op10.X - 30;
            pictimer10.Tick += delegate
            {
                progressBar1.Location = p10;
                p10.X += 1;
                if (p10.X == op10.X)
                {
                    pictimer10.Stop();
                    pictimer10.Dispose();
                }
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (downloader != null)
            {
                downloader.CancelAsync();
                downloader.Dispose();
            }
            this.Close();
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
        private const int HTTOPRIGHT = 14;
        private const int HTTOPLEFT = 13;
        private void MoveControl(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        #endregion
        private void UpdaterC_MouseDown(object sender, MouseEventArgs e)
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
        }
        private void UpdaterC_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Timer tmr = new Timer();
            tmr.Interval = 1;
            tmr.Tick += new EventHandler(delegate { Opacity += 0.05; if (Opacity == 1) { tmr.Stop(); tmr.Dispose(); } });
            tmr.Start();
            g();
            label1.Text = "Current Version: " + Application.ProductVersion.ToString();
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                using (WebClient wbc = new WebClient())
                {
                    wbc.DownloadFileCompleted += new AsyncCompletedEventHandler(wbc_DownloadFileCompleted);

                    wbc.DownloadFileAsync(new Uri("http://gt-web-software.webs.com/Cheetah.txt"), Application.StartupPath + @"\_temp.txt");
                }
            }
            else
            {
                MessageCheetah f = new MessageCheetah();
                f.Title = "Warning!";
                f.Message = "An active network connection is required for the update operation to function. Please check your connection settings and try again.";
                f.CancelVisible = false;
                f.ShowDialog();
            
                this.Close();
            }
        }
        int VersionNum;

        void wbc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string[] updc = System.IO.File.ReadAllLines(Application.StartupPath + @"\_temp.txt");
                VersionNum = Convert.ToInt32(((string)updc.GetValue(0)).Replace(".", ""));
                label2.Text = "Latest Version: " + (string)updc.GetValue(0);
                int CurVersion = Convert.ToInt32(Application.ProductVersion.ToString().Replace(".", ""));
                if (updc.Length > 1)
                    DownloadLink = (string)updc.GetValue(1);
                t = updc;
                if (CurVersion < VersionNum)
                {
                    label1.Text = "A new update is available for downloading";
                    button1.Enabled = true;
                    System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
                    timer1.Interval = 20;
                    timer1.Enabled = true;
                    timer1.Tick += timer1_Tick;
                    timer1.Start();
                }
                else
                    label1.Text = "Cheetah is up to date";
                System.IO.File.Delete(Application.StartupPath + @"\_temp.txt");
            }
            catch (Exception ex)
            {
                MessageCheetah f = new MessageCheetah();
                f.Title = "Error!";
                f.Message = "An error occured and the update operation could not be successfully completed. \r\n error:" + ex.Message;
                f.CancelVisible = false;
                f.ShowDialog();
            }
        }
        string[] t;
        WebClient downloader;
        void ShowChanges(string[] updc)
        {
            label3.Text = "Changes: \r\n";
            for (int i = 2; i < updc.Length; i++)
            {
                label3.Text = label3.Text + updc.GetValue(i).ToString() + "\r\n";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Height <= 287)
            {
                this.Height = this.Height + 3;
                this.Invalidate();
            }
            else
            {
                (sender as Timer).Enabled = false;
                ShowChanges(t);
            }
        }
        string dest;
        private void button1_Click(object sender, EventArgs e)
        {
            downloader = new WebClient();
            label1.Text = "Starting download...";
            dest = System.IO.Path.GetTempPath() + @"\setup.exe";
            downloader.DownloadFileAsync(new Uri(DownloadLink), dest);
            downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloader_DownloadProgressChanged);
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
        }
        void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
                return;
            progressBar1.Value = progressBar1.MaxValue;
            MessageCheetah f = new MessageCheetah();
            f.Title = "Warning!";
            f.Message = "You now need to close Cheetah so that the update successfully completes. The Setup window will be shown to you. Follow the steps provided to complete the installation.";
            f.CancelVisible = false;
            f.ShowDialog();

            Process.Start(dest);
        }

        void downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label1.Text = e.BytesReceived + " bytes received out of " + e.TotalBytesToReceive + " (" + e.ProgressPercentage + "%)";
            progressBar1.MaxValue = (int)e.TotalBytesToReceive;
            progressBar1.MinValue = 0;
            progressBar1.Value = (int)e.BytesReceived;
        }
    }
}
