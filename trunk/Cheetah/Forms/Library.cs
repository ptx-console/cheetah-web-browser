using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Qios.DevSuite.Components;
using Transitions;

namespace Cheetah.Forms
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
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
        }
        List<HisItem> HistoryData = new List<HisItem>();
        List<FavItem> FavData = new List<FavItem>();
        #region "Custom form"
        private void MoveControl(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
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
        private void Library_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Bookmarking.GetItemsCount(); i++)
            {
                FavItem toadd = new FavItem();
                toadd.Import(Bookmarking.Name(i), Bookmarking.Url(i), Bookmarking.ImageToBase64(Bookmarking.Favicon(i), System.Drawing.Imaging.ImageFormat.Png));
                FavData.Add(toadd);
            }
            for (int i = 0; i < History.GetItemsCount(); i++)
            {
                HisItem toadd = new HisItem();
                toadd.Import(History.Name(i), History.Url(i), History.Date(i), Bookmarking.ImageToBase64(History.Favicon(i), System.Drawing.Imaging.ImageFormat.Png));
                HistoryData.Add(toadd);
            }
            historydatagridview.DataSource = HistoryData;
            bookmarksdatagridview.DataSource = FavData;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            CloseTimer.Enabled = true;
        }

        private void metroButton1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in bookmarksdatagridview.SelectedRows)
            {
                int index = FavData.IndexOf((FavItem)r.DataBoundItem);
                bookmarksdatagridview.CurrentCell = null;
                Bookmarking.Delete(index);
                FavData.RemoveAt(index);
            }
            Bookmarking.SaveAll();
            bookmarksdatagridview.DataSource = null;
            bookmarksdatagridview.DataSource = FavData;
        }

        private void metroButton2_Load(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Bookmarking.Clear();
            FavData.Clear();
            bookmarksdatagridview.DataSource = null;
            bookmarksdatagridview.DataSource = FavData;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in historydatagridview.SelectedRows)
            {
                try
                {
                    int index = HistoryData.IndexOf((HisItem)r.DataBoundItem);
                    History.Delete(index);
                    historydatagridview.CurrentCell = null;
                    HistoryData.Remove((HisItem)r.DataBoundItem);
                }
                catch { }
            }
            History.SaveAll();
            historydatagridview.DataSource = null;
            historydatagridview.DataSource = HistoryData;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            History.Clear();
            HistoryData.Clear();
            historydatagridview.DataSource = null;
            historydatagridview.DataSource = HistoryData;
        }

        private void Library_MouseDown(object sender, MouseEventArgs e)
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

        private void lblCheetah_MouseDown(object sender, MouseEventArgs e)
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

        private void QTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            QTabPage t = QTabControl1.GetPageWithButtonAtPoint(e.Location);
            try
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
            catch
            {
                
            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                this.Close();
            }
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is Form1)
                    (f as Form1).RefreshBookmarksAndHistory(true);
        }

        private void NavBook()
        {
            Form1 f = null;
            foreach (Form frm in Application.OpenForms)
            {
                try { f = ((Form1)(frm)); break; }
                catch { }
            }
            foreach (DataGridViewRow b in bookmarksdatagridview.SelectedRows)
            {
                if (f != null)
                {
                    f.AddTab(((FavItem)b.DataBoundItem).Url);
                }
            }
        }
        private void btnNavBook_Click(object sender, EventArgs e)
        {
            NavBook();  
        }

        private void NavHis()
        {
            Form1 f = null;
            foreach (Form frm in Application.OpenForms)
            {
                try { f = ((Form1)(frm)); break; }
                catch { }
            }
            foreach (DataGridViewRow b in historydatagridview.SelectedRows)
            {
                if (f != null)
                {
                    f.AddTab(((HisItem)b.DataBoundItem).Url);
                }
            }
        }
        private void btnNavHis_Click(object sender, EventArgs e)
        {
            NavHis();
        }

        private void Find(bool ishis = true)
        {
            DataGridView curd = (DataGridView)QTabControl1.ActiveTabPage.Controls[0];

            string text;
            if (ishis)
                text = txtFindHis.Text;
            else
                text = txtFindBook.Text;
            //buttonX7.Visible = !string.IsNullOrEmpty(text);
            foreach (DataGridViewRow o in curd.Rows)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[curd.DataSource];
                    curd.CurrentCell = null;

                    cm.SuspendBinding();
                    if (o.DataBoundItem is FavItem)
                    {
                        if ((((FavItem)o.DataBoundItem).Name.Contains(text) | ((FavItem)o.DataBoundItem).Url.Contains(text)) == true)
                            o.Visible = true;
                        else
                            o.Visible = false;
                    }
                    if (o.DataBoundItem is HisItem)
                    {
                        if ((((HisItem)o.DataBoundItem).Name.Contains(text) | ((HisItem)o.DataBoundItem).Url.Contains(text) | ((HisItem)o.DataBoundItem).Date.Contains(text)) == true)
                            o.Visible = true;
                        else
                            o.Visible = false;
                    }
                    cm.ResumeBinding();
                }
                else
                    o.Visible = true;
            }
        }
        private void txtFindBook_TextChanged(object sender, EventArgs e)
        {
            Find(false);
        }

        private void txtFindHis_TextChanged(object sender, EventArgs e)
        {
            Find();
        }

        private void bookmarksdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in bookmarksdatagridview.SelectedRows)
            {
                int index = FavData.IndexOf((FavItem)r.DataBoundItem);
                txtNameBook.Text = ((FavItem)r.DataBoundItem).Name;
                txtUrlBook.Text = ((FavItem)r.DataBoundItem).Url;
            }
        }

        private void historydatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in historydatagridview.SelectedRows)
            {
                int index = HistoryData.IndexOf((HisItem)r.DataBoundItem);
                txtNameHis.Text = ((HisItem)r.DataBoundItem).Name;
                txtUrlHis.Text = ((HisItem)r.DataBoundItem).Url;
            }
        }

        private void historydatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NavHis();
        }

        private void bookmarksdatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NavBook();
        }
    }
}
