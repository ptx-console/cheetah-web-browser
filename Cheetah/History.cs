using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using Microsoft.VisualBasic;
using System.Drawing;

namespace Cheetah
{
    public class History
    {
        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Cheetah\history.data";
        public static StringCollection AllHisItems = new StringCollection();
        public static string Name(int index)
        {
            if (string.IsNullOrEmpty(AllHisItems[index]) == false)
            {
                try
                {
                    return AllHisItems[index].Split(Convert.ToChar("|")).GetValue(0).ToString().Replace("(*~)", "|");
                }
                catch { return ""; }
            }
            else
            {
                return ""; 
            }
        }
        public static void Add(string name, string url, DateTime date, string base64, bool save = false)
        {
            string _name = name.Replace("|", "(*~)").Replace(Constants.vbNewLine, " - ");
            string _url = url.Replace("|", "(*~)");
            AllHisItems.Add(_name + "|" + _url + "|" + date.ToString() + "|" + base64);
            if (save == true)
            {
                SaveAll();
            }
            _name = null;
            _url = null;
        }
        public static void initialize()
        {
            AllHisItems.Clear();

            if (!File.Exists(Path))
            {
                File.WriteAllText(Path, string.Empty);
            }
            else
            {
                string[] contents = File.ReadAllLines(Path);
                foreach (string s in contents)
                {
                    AllHisItems.Add(s);
                }
                contents = null;
            }
        }
        public static int GetItemsCount()
        {
            return AllHisItems.Count;
        }
        public static string Url(int index)
        {
            if (string.IsNullOrEmpty(AllHisItems[index]) == false)
            {
                try
                {
                    return AllHisItems[index].Split(Convert.ToChar("|")).GetValue(1).ToString().Replace("(*~)", "|");
                }
                catch { return ""; }
            }
            else
            {
                return ""; 
            }
        }

        public static string Date(int index)
        {
            if (string.IsNullOrEmpty(AllHisItems[index]) == false)
            {
                try 
                {
                    return AllHisItems[index].Split(Convert.ToChar("|")).GetValue(2).ToString().Replace("(*~)", "|");
                    }
                catch { return ""; }
            }
            else
            {
                return DateTime.Now.ToString() ; 
            }
        }
        public static void SaveAll()
        {
            string filedata = "";
            try
            {
                foreach (string s in AllHisItems)
                {
                    if (string.IsNullOrEmpty(filedata) == true)
                    {
                        filedata = s;
                    }
                    else
                    {
                        filedata = filedata + Constants.vbNewLine + s;
                    }
                }
            }
            catch { }
            File.WriteAllText(Path, filedata);
            filedata = null;
        }
        public static void Clear()
        {
            AllHisItems.Clear();
            SaveAll();
        }
        public static Image Favicon(int i)
        {
            return Bookmarking.Base64ToImage(AllHisItems[i].Split(Convert.ToChar("|"))[3]);
        }
        public static void Delete(int index,bool save = true)
        {
            AllHisItems.RemoveAt(index);
            if (save == true)
            {
                SaveAll();
            }
        }      
    }
    public class HisItem
    {
            string _name;
            string _url;
            string _date;
            string base64img;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Url
            {
                get { return _url; }
                set { _url = value; }
            }
            public string Date
            {
                get { return _date; }
                set { _date = value; }
            }

            public Image Favicon
            {
                get { return Bookmarking.Base64ToImage(base64img); }
                set { base64img = Bookmarking.ImageToBase64(value, System.Drawing.Imaging.ImageFormat.Png); }
            }
            public void Import(string n, string u, string d, string b)
            {
                this.Name = n;
                this.Url = u;
                this.Date = d;
                this.base64img = b;
            }
    }
}

