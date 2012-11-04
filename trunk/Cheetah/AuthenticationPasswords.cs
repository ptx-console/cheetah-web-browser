using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Cheetah
{
    public static class AuthenticationPasswords
    {
        private static List<AuthenticationObject> data = new List<AuthenticationObject>();
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Cheetah\authentication.data";
        public static void Initialize()
        {
            data.Clear();
            if (!File.Exists(path))
                File.WriteAllText(path, string.Empty);
            string[] d = File.ReadAllLines(path);
            foreach (string a in d)
            {
                if (!string.IsNullOrWhiteSpace(a))
                {
                    string[] toadd = a.Split(Convert.ToChar("~"));
                    data.Add(new AuthenticationObject(toadd[0], toadd[1], new Uri(toadd[2])));
                }
            }
            d = null;
        }
        public static void Add(string user, string pass, Uri url)
        {
            data.Add(new AuthenticationObject(user, pass, url));
            StreamWriter wr = File.AppendText(path);
            wr.Write("\r\n" + user + "~" + pass + "~" + url.ToString());
            wr.Close();
            wr.Dispose();
        }
        public static void Remove(AuthenticationObject o)
        {
            data.Remove(o);
            Save();
        }
        public static void ReplaceDataForUrl(string user, string pass, Uri url)
        {
            foreach (AuthenticationObject obj in data)
            {
                if (obj.Url.Equals(url))
                {
                    data.Remove(obj);
                    data.Add(new AuthenticationObject(user, pass, url));
                    break;
                }
            }
            Save();
        }
        public static void Save()
        {
            File.WriteAllText(path, string.Empty);
            string towrite = string.Empty;
            foreach (AuthenticationObject o in data)
            {
                towrite = towrite + o.Username + "~" + o.Password + "~" + o.Url.ToString() + "\r\n";
            }
            File.WriteAllText(path, towrite);
            towrite = null;
        }
        public static bool HasData(Uri u, out AuthenticationObject o)
        {
            foreach (AuthenticationObject obj in data)
            {
                if (obj.Url.Equals(u))
                {
                    o = obj;
                    return true;
                }
            }
            o = null;
            return false;
        }
    }
    public class AuthenticationObject
    {
        public string Username;
        public string Password;
        public Uri Url;
        public AuthenticationObject(string u, string p, Uri ur)
        {
            Username = u;
            Password = p;
            Url = ur;
        }
    }
}
