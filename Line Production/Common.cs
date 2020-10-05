using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.Win32;

public enum State
{
    P,
    F
}

namespace Line_Production
{
    public partial class Common
    {
        public static void WriteRegistry(string path, string keyName, string content)
        {
            var key = Registry.CurrentUser.CreateSubKey(path);
            if (!string.IsNullOrEmpty(keyName) && !string.IsNullOrEmpty(content))
            {
                key.SetValue(keyName, content);
                key.Close();
            }
        }

        public static string GetValueRegistryKey(string path, string keyName)
        {
            var key = Registry.CurrentUser.CreateSubKey(path);
            string value = null;
            if (key is object)
            {
                if (key.GetValue(keyName) is object)
                {
                    value = key.GetValue(keyName).ToString();
                    key.Close();
                    return value;
                }
            }

            return null;
        }

        public static bool Validate_qty(string qty)
        {
            var objRegExp = new System.Text.RegularExpressions.Regex(@"^\d+$");
            return objRegExp.Match(qty).Success;
        }

        public static string FindApplication(string NameSoft)
        {
            string astring = null;
            foreach (Process p in Process.GetProcesses())
            {
                string h = p.MainWindowTitle.ToString();
                if (h.Length > 0)
                {
                    if (h.Contains(NameSoft))
                    {
                        astring = h;
                    }
                }
            }

            return astring;
        }

        public static bool IsRunning(string nameSoft)
        {
            if (nameSoft is null)
            {
                return false;
            }

            Process[] p;
            p = Process.GetProcesses();
            foreach (var pro in p)
            {
                if (pro.MainWindowTitle.Contains(nameSoft))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Ghi log
        /// </summary>
        /// <param name="path">Đường dẫn</param>
        /// <param name="content">Nội dung cần ghi log</param>
        public static void WriteLog(string path, StringBuilder content)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.Write(content.ToString());
            }
        }
    }
}