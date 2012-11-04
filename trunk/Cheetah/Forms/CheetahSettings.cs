using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Qios.DevSuite.Components;
using Transitions;

namespace Cheetah.Forms
{
    public partial class CheetahSettings : Form
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

        public CheetahSettings()
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
            MinimizeFootprint();
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
        string[] c
        {
            get { return (string[])comboBox1.Tag; }
        }
        private void CheetahSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NewTab == "Custom new tab")
                NTcustom.Checked = true;
            else if (Properties.Settings.Default.NewTab == "Open Blank Page")
                NTBlank.Checked = true;
            else if (Properties.Settings.Default.NewTab == "Open Praken Home")
                NTPrakenHome.Checked = true;

            if (Properties.Settings.Default.PopupOpenInWindow == true)
                RBpopupwindow.Checked = true;
            else
                RBpopuptab.Checked = true;
            comboBox1.Tag = new string[Encoding.GetEncodings().Length];
            for (int w = 0; w < Encoding.GetEncodings().Length; w++)
            {
                comboBox1.Items.Add(Encoding.GetEncodings()[w].GetEncoding().EncodingName);
                c.SetValue(Encoding.GetEncodings()[w].Name, w);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            List<String> temp = c.ToList();
            comboBox1.SelectedIndex = temp.IndexOf(Properties.Settings.Default.Encoding);
            temp.Clear();
            temp = null;
            //startBehaviour.SelectedIndex = Properties.Settings.Default.startpage;
            customPage.Text = Properties.Settings.Default.customstartpage;
            txthomepage.Text = Properties.Settings.Default.Homepage;
            CBUA.SelectedIndex = CBUA.Items.IndexOf(Properties.Settings.Default.browsermode);
            //newtabaction.SelectedIndex = Properties.Settings.Default.newtabaction;
            txtcustomnewtab.Text = Properties.Settings.Default.newtabcustompage;
            pref.SetItemChecked(0, Properties.Settings.Default.usejavascript);
            pref.SetItemChecked(1, Properties.Settings.Default.allowplugins);
            pref.SetItemChecked(2, Properties.Settings.Default.loadimage);
            appearance.SetItemChecked(1, Properties.Settings.Default.UseAero);
            appearance.SetItemChecked(0, Properties.Settings.Default.smoothscrolling);
            textBox1.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.custompluginspath);
            checkBox1.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.custompluginspath);
            textBox1.Text = Properties.Settings.Default.custompluginspath;
            checkedListBox1.SetItemChecked(0, Properties.Settings.Default.allowinsecure);
            checkedListBox1.SetItemChecked(1, Properties.Settings.Default.javascriptwindows);
            checkedListBox1.SetItemChecked(2, Properties.Settings.Default.javascriptclipboard);
            checkedListBox1.SetItemChecked(3, Properties.Settings.Default.webgl);
            checkedListBox1.SetItemChecked(4, Properties.Settings.Default.webaudio);
            checkedListBox1.SetItemChecked(5, Properties.Settings.Default.websecurity);
            CBBlockpopup.Checked = Properties.Settings.Default.BlockPopup;
            txtUA.Text = Properties.Settings.Default.Useragent;
            if (Properties.Settings.Default.DownloadsFolder == "{default}")
                customdownpath.Checked = false;
            else
            {
                customdownpath.Checked = true;
                downpath.Text = Properties.Settings.Default.DownloadsFolder;
            }
            i = true;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            encodname.Text = (string)((string[])comboBox1.Tag)[comboBox1.SelectedIndex];
        }
        bool i = false;

        private void customPage_TextChanged(object sender, EventArgs e)
        {
            if (i == true)
                Properties.Settings.Default.customstartpage = customPage.Text;
        }

        private void pref_SelectedValueChanged(object sender, EventArgs e)
        {
            if (i == false)
                return;
            Properties.Settings.Default.usejavascript = pref.GetItemChecked(0);
            Properties.Settings.Default.allowplugins = pref.GetItemChecked(1);
            Properties.Settings.Default.loadimage = pref.GetItemChecked(2);
            Properties.Settings.Default.BlockPopup = pref.GetItemChecked(3);
        }

        private void appearance_SelectedValueChanged(object sender, EventArgs e)
        {
            if (i == false)
                return;
            Properties.Settings.Default.smoothscrolling = appearance.GetItemChecked(0);
            Properties.Settings.Default.UseAero = appearance.GetItemChecked(1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                f.Description = "Select the folder which contains the plugins";
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    textBox1.Text = f.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (i == false)
                return;
            Properties.Settings.Default.custompluginspath = textBox1.Text;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (i == false)
                return;
            Properties.Settings.Default.allowinsecure = checkedListBox1.GetItemChecked(0);
            Properties.Settings.Default.javascriptwindows = checkedListBox1.GetItemChecked(1);
            Properties.Settings.Default.javascriptclipboard = checkedListBox1.GetItemChecked(2);
            Properties.Settings.Default.webgl = checkedListBox1.GetItemChecked(3);
            Properties.Settings.Default.webaudio = checkedListBox1.GetItemChecked(4);
            Properties.Settings.Default.websecurity = checkedListBox1.GetItemChecked(5);
        }

        private void lblgeneral_Click(object sender, EventArgs e)
        {
            pnlgeneral.Visible = true;
            Transition.run(pnladvanced, "Height", 0, new TransitionType_EaseInEaseOut(600));
            Transition.run(pnlgeneral, "Height", 429, new TransitionType_EaseInEaseOut(600));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveSetings();
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            CloseTimer.Enabled = true;
            //this.Close();
        }

        private void SaveSetings()
        {
            Properties.Settings.Default.usejavascript = pref.GetItemChecked(0);
            Properties.Settings.Default.allowplugins = pref.GetItemChecked(1);
            Properties.Settings.Default.loadimage = pref.GetItemChecked(2);
            Properties.Settings.Default.smoothscrolling = appearance.GetItemChecked(0);
            Properties.Settings.Default.UseAero = appearance.GetItemChecked(1);
            Properties.Settings.Default.allowinsecure = checkedListBox1.GetItemChecked(0);
            Properties.Settings.Default.javascriptwindows = checkedListBox1.GetItemChecked(1);
            Properties.Settings.Default.javascriptclipboard = checkedListBox1.GetItemChecked(2);
            Properties.Settings.Default.webgl = checkedListBox1.GetItemChecked(3);
            Properties.Settings.Default.webaudio = checkedListBox1.GetItemChecked(4);
            Properties.Settings.Default.websecurity = checkedListBox1.GetItemChecked(5);
            try
            {
                Properties.Settings.Default.browsermode = CBUA.SelectedItem.ToString();
            }
            catch { }
            Properties.Settings.Default.Useragent = txtUA.Text;
            Properties.Settings.Default.BlockPopup = CBBlockpopup.Checked;

            if (RBpopupwindow.Checked == true)
                Properties.Settings.Default.PopupOpenInWindow = true;
            else
                Properties.Settings.Default.PopupOpenInWindow = false;

            if (opendefault.Checked == true)
                Properties.Settings.Default.startpage = "Open default";
            else if (openPrakenHome.Checked == true)
                Properties.Settings.Default.startpage = "Open Praken Home";
            else if (RBBlankpage.Checked == true)
                Properties.Settings.Default.startpage = "Open Blank Page";
            else if (customstartpage.Checked == true)
                Properties.Settings.Default.startpage = "Custom start page";

            //new tab
            if (NTPrakenHome.Checked == true)
                Properties.Settings.Default.NewTab = "Open Praken Home";
            else if (NTBlank.Checked == true)
                Properties.Settings.Default.NewTab = "Open Blank Page";
            else if (NTcustom.Checked == true)
                Properties.Settings.Default.NewTab = "Custom new tab";
            UserAgent();
            Properties.Settings.Default.Homepage = txthomepage.Text;
            Properties.Settings.Default.Encoding = encodname.Text;
            if (customdownpath.Checked == true)
                Properties.Settings.Default.DownloadsFolder = "{default}";
            else
                Properties.Settings.Default.DownloadsFolder = downpath.Text;
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Cheetah.Properties.Resources.cls;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Cheetah.Properties.Resources.cls1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Cheetah.Properties.Resources.cls1;
        }

        private void CheetahSettings_MouseDown(object sender, MouseEventArgs e)
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

        private void lbladvanced_Click(object sender, EventArgs e)
        {
            
            pnladvanced.Visible = true;
            Transition.run(pnladvanced, "Height", 454, new TransitionType_EaseInEaseOut(600));
            Transition.run(pnlgeneral, "Height", 0, new TransitionType_EaseInEaseOut(600));
        }
        public void UserAgent()
        {
            Properties.Settings.Default.browsermode = CBUA.SelectedText;
            string s = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) ";
            if (Properties.Settings.Default.browsermode == "Google Chrome")
                Properties.Settings.Default.Useragent = s + "Chrome/20.0.1092.0 Safari/536.6";
            else if (Properties.Settings.Default.browsermode == "Safari")
                Properties.Settings.Default.Useragent = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/534.54.16 (KHTML, like Gecko) Version/5.1.4 Safari/534.54.16";
            else if (Properties.Settings.Default.browsermode == "Mozilla Firefox")
                Properties.Settings.Default.Useragent = "Mozilla/5.0 (Windows NT 6.2; rv:13.0) Gecko/20100101 Firefox/13.0";
            else if (Properties.Settings.Default.browsermode == "Opera")
                Properties.Settings.Default.Useragent = "Opera/9.99 (Windows NT 5.1; U; en-US) Presto/9.9.9";
            else if (Properties.Settings.Default.browsermode == "Internet Explorer")
                Properties.Settings.Default.Useragent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            else if (Properties.Settings.Default.browsermode == "iPad")
                Properties.Settings.Default.Useragent = "Mozilla/5.0 (iPad; CPU OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";
            else
                Properties.Settings.Default.Useragent = s + "Cheetah/" + Application.ProductVersion.ToString() + " Chrome/20.0.1092.0 Safari/536.6";
        }

        private void CheetahSettings_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (opendefault.Checked == true)
            {
                Properties.Settings.Default.startpage = "Open default";
            }
            else if (openPrakenHome.Checked == true)
            {
                Properties.Settings.Default.startpage = "Open Praken Home";
            }
            else if (RBBlankpage.Checked == true)
            {
                Properties.Settings.Default.startpage = "Open Blank Page";
            }
            else if (customstartpage.Checked == true)
            {
                Properties.Settings.Default.startpage = "Custom start page";
            }

            //new tab
            if (NTPrakenHome.Checked == true)
            {
                Properties.Settings.Default.NewTab = "Open Praken Home";
            }
            else if (NTBlank.Checked == true)
            {
                Properties.Settings.Default.NewTab = "Open Blank Page";
            }
            else if (NTcustom.Checked == true)
            {
                Properties.Settings.Default.NewTab = "Custom new tab";
            }
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f is Form1)
            //    {
            //        foreach (Control c in (f as Form1).TabC.Controls)
            //            if (c is QTabPage)
            //                ((CheetahView)(c as QTabPage).Controls[0]).Preferences = new WebPreferences() { Javascript = Properties.Settings.Default.usejavascript, Plugins = Properties.Settings.Default.allowplugins, LoadImagesAutomatically = Properties.Settings.Default.loadimage, SmoothScrolling = Properties.Settings.Default.smoothscrolling, AllowInsecureContent = Properties.Settings.Default.allowinsecure, WebAudio = Properties.Settings.Default.webaudio, WebGL = Properties.Settings.Default.webgl, CanScriptsAccessClipboard = Properties.Settings.Default.javascriptclipboard, CanScriptsOpenWindows = Properties.Settings.Default.javascriptwindows, CanScriptsCloseWindows = Properties.Settings.Default.javascriptwindows, WebSecurity = Properties.Settings.Default.websecurity };
            //    }
            //}
        }

        private void opendefault_CheckedChanged(object sender, EventArgs e)
        {
            customPage.Enabled = false;
        }

        private void openPrakenHome_CheckedChanged(object sender, EventArgs e)
        {
            customPage.Enabled = false;
        }

        private void RBBlankpage_CheckedChanged(object sender, EventArgs e)
        {
            customPage.Enabled = false;
        }

        private void customstartpage_CheckedChanged(object sender, EventArgs e)
        {
            customPage.Enabled = true;
        }

        private void NTPrakenHome_CheckedChanged(object sender, EventArgs e)
        {
            txtcustomnewtab.Enabled = false;
        }

        private void NTBlank_CheckedChanged(object sender, EventArgs e)
        {
            txtcustomnewtab.Enabled = false;
        }

        private void NTcustom_CheckedChanged(object sender, EventArgs e)
        {
            txtcustomnewtab.Enabled = true;
        }

        private void QTabControl1_ActivePageChanged(object sender, QTabPageChangeEventArgs e)
        {

        }

        private void CBUA_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) ";
            if (CBUA.SelectedItem == "Cheetah")
                txtUA.Text = s + "Cheetah/" + Application.ProductVersion.ToString() + " Chrome/20.0.1092.0 Safari/536.6";
            else if (CBUA.SelectedItem == "Google Chrome")
                txtUA.Text = s + "Chrome/20.0.1092.0 Safari/536.6";
            else if (CBUA.SelectedItem == "Safari")
                txtUA.Text = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/534.54.16 (KHTML, like Gecko) Version/5.1.4 Safari/534.54.16";
            else if (CBUA.SelectedItem == "Mozilla Firefox")
                txtUA.Text = "Mozilla/5.0 (Windows NT 6.2; rv:12.0) Gecko/20100101 Firefox/13.0";
            else if (CBUA.SelectedItem == "Opera")
                txtUA.Text = "Opera/9.99 (Windows NT 5.1; U; en-US) Presto/9.9.9";
            else if (CBUA.SelectedItem == "Internet Explorer")
                txtUA.Text = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            else
                txtUA.Text = "Mozilla/5.0 (iPad; CPU OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";
        }

        private void CBUA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUA.ReadOnly = !(CBUA.SelectedText == "Custom");
        }

        private void CBBlockpopup_CheckedChanged(object sender, EventArgs e)
        {
            if (CBBlockpopup.Checked == false)
            {
                RBpopuptab.Enabled = true;
                RBpopupwindow.Enabled = true;
            }
            else
            {
                RBpopuptab.Enabled = false;
                RBpopupwindow.Enabled = false;
            }
        }

        private void RBpopuptab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                if (ButtonSender == "Cancel")
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                else if (ButtonSender == "OK")
                    Application.ExitThread();
                else
                    this.Close();
            }
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Cheetah";
            if (CBDeleteData.GetItemChecked(0))
            {
                File.Delete(folder + @"\history.data");
                History.initialize();
            }
            if (CBDeleteData.GetItemChecked(1))
            {
                File.Delete(folder + @"\bookmarks.data");
                Bookmarking.initialize();
            }
            if (CBDeleteData.GetItemChecked(2))
                File.Delete(folder + @"\Cookies)");
            if (CBDeleteData.GetItemChecked(3))
                Directory.Delete(folder + @"\Cache");
            if (CBDeleteData.GetItemChecked(4))
                Directory.Delete(folder + @"\Local Storage");
            MessageBox.Show("Operation finished!");
        }

        private void metroButton1_Load(object sender, EventArgs e)
        {

        }

        private void customdownpath_CheckedChanged(object sender, EventArgs e)
        {
            downpath.Enabled = customdownpath.Checked;
        }
    }
}
