using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    public partial class Control
    {
        public static string model;
        public static string strname = "";
        private static string h;
        public static string GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public static object WriteTextFile(string filePath, string textline)               // ghi tiep du lieu vao file
        {
            if (File.Exists(filePath) == true)
            {
                StreamWriter w;
                w = File.AppendText(filePath);
                w.WriteLine(textline);
                w.Flush();
                w.Close();
            }
            else
            {
                MessageBox.Show("File Does Not Exist");
                Environment.Exit(0);
            }

            return 0;
        }

        public static string ReadTextFile(string filePath, int lineNumber)   // nhap duong dan file va dong can doc
        {
            using (var file = new StreamReader(filePath))
            {
                string line;
                // doc nhung Line trong text file khong can truy nhap'
                for (int i = 1, loopTo = lineNumber - 1; i <= loopTo; i++)
                {
                    if (file.ReadLine() is null)
                    {
                        line = " ";
                    }
                }
                // doc Line trong text file can truy nhap
                line = file.ReadLine();
                // Succeded!
                return line;
                file.Close();
            }
        }

        public static int CounterlineTextFile(string File_Path)   // nhap duong dan file va dong can doc
        {
            string counterLine = 0.ToString();
            if (File.Exists(File_Path) == true)                              // xac nhan duong dan ton tai hay khong
            {
                var objReader = new StreamReader(File_Path);                   // mo file theo duong dan
                while (!string.IsNullOrEmpty(objReader.ReadLine()))
                    counterLine = (Conversions.ToDouble(counterLine) + 1d).ToString();                                        // doc theo tung dong file text
                objReader.Close();                                                        // dong file text da mo
            }
            else
            {
                MessageBox.Show(File_Path + " Not found");
                Environment.Exit(0);
            }

            return Conversions.ToInteger(counterLine);
        }

        public static void ReplaceLine(string filePath, int LineNumber, string NewLine)
        {
            string Databin = "";
            using (var file = new StreamReader(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                for (int i = 0, loopTo = lines.Length - 1; i <= loopTo; i++)
                {
                    if (i == LineNumber - 1)
                    {
                        lines[i] = NewLine;
                    }

                    Databin = Databin + lines[i] + '\r' + '\n';
                }
            }

            File.Delete(filePath);
            File.WriteAllText(filePath, Databin);
        }

        public static string ReadAllLine(string filePath)
        {
            string Databin = "";
            using (var file = new StreamReader(filePath))
            {
                Databin = file.ReadToEnd();
            }

            return Databin;
        }

        public static string Findapplication(string namesoft)
        {
            string i;
            foreach (var p in Process.GetProcesses())
            {
                h = p.MainWindowTitle.ToString(); // lay tung title cua tung process
                if (h.Length != 0) // chi kiem tra title cua process khac ki tu trang
                {
                    i = Strings.InStr(h, namesoft, 0).ToString(); // kiem tra trong file name ( title ) cua process co chua ki tu setsoftware hay khong
                    if (Conversions.ToBoolean(i) == true) // neu co ten co nghia la dung
                    {
                        strname = h; // lay ten phan mem bo vao bien strnamesoft de kich hoat
                    }
                }
            }
            // MsgBox(strname)

            return strname;
        }

        public static string findwords(string filepath, string words)
        {
            string line;
            int count = 0;
            using (var file = new StreamReader(filepath))
            {
                line = file.ReadToEnd();
                file.Close();
            }

            for (int i = 1, loopTo = line.Length; i <= loopTo; i += 2)
            {
                if (Strings.InStr(Strings.Mid(line, i, words.Length + 1), words, 0) != 0)
                {
                    count = count + 1;
                }
            }

            return count.ToString();
        }
    }
}
