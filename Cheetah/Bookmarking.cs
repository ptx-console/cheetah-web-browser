using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Specialized;
using Microsoft.VisualBasic;

namespace Cheetah
{
    public class Bookmarking
    {
        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Cheetah\bookmarks.data";
        public static StringCollection AllBookItems = new StringCollection();
        public static string Name(int index)
        {
            if (string.IsNullOrEmpty(AllBookItems[index]) == false)
            {
            return AllBookItems[index].Split(Convert.ToChar("|")).GetValue(0).ToString().Replace("(*~)", "|");
            }
            else {
                return string.Empty;
            }
        }
        public static void Add(string name, string url, string base64, bool save = true)
        {
            AllBookItems.Add(name.Replace("|", "(*~)") + "|" + url.Replace("|", "(*~)") + "|" + base64);
            Uri _t = new Uri(url);
            string path = Application.StartupPath + @"\Properties\" + _t.Host + ".png";
            if (save == true)
            {
                SaveAll();
            }
            path = null;
            _t = null;
        }
        public static void initialize()
        {
            AllBookItems.Clear();
            try
            {
                if (System.IO.File.Exists(Path) == false)
                    System.IO.File.WriteAllText(Path, string.Empty);
                foreach (string s in File.ReadAllLines(Path))
                {
                    AllBookItems.Add(s);
                }
            }
            catch
            {
                File.Create(Path);
            }
        }
        public static string ImageToBase64(Image image,
  System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            ms.Close();
            ms.Dispose();
            ms = null;
            return image;
        }
        public static Image Favicon(int i)
        {
            return Base64ToImage(AllBookItems[i].Split(Convert.ToChar("|"))[2]);
        }

        public static int GetItemsCount()
        {
            return AllBookItems.Count;
        }
        public static string Url(int index)
        {
            if (string.IsNullOrEmpty(AllBookItems[index]) == false)
            {
                return AllBookItems[index].Split(Convert.ToChar("|")).GetValue(1).ToString().Replace("(*~)", "|");
            }
            else {
                return "";
            }
        }

        public static void SaveAll()
        {
            string filedata = "";

            foreach (string s in AllBookItems)
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
            try
            {
                File.WriteAllText(Path, filedata);
            }
            catch { }
            filedata = null;
        }
        public static void Clear()
        {
            AllBookItems.Clear();
            SaveAll();
        }
        public static void Delete(int index,bool save = false)
        {
            AllBookItems.RemoveAt(index);
            if (save == true)
            {
                SaveAll();
            }
        }
    }
    public class FavItem
    {
        private string _name;
        private string _url;
        private string base64img;
        public string Name
        {
            get{ return _name; }
            set { _name = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        public Image Favicon
        {
            get { return Bookmarking.Base64ToImage(base64img); }
            set { base64img = Bookmarking.ImageToBase64(value, System.Drawing.Imaging.ImageFormat.Png); }
        }
        public void Import(string name, string url, string b64)
        {
            Name = name;
            _url = url;
            base64img = b64;
        }
    }
}
