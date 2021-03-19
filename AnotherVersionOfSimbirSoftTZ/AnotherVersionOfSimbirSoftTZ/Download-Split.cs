using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AnotherVersionOfSimbirSoftTZ
{
    class Download_Split
    {
        public static void DownloadSplit(string link,string path, out int count)
        {
            Regex rg = new Regex(@"<\w+>",RegexOptions.IgnoreCase);

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, path);
            }

            count = File.ReadLines(path).Count();

            char ch = 'a';
            string str = ".txt";
            string newPath = ch.ToString() + str;

            
            
            using (StreamReader sR = new StreamReader(path))
            {
                for (int i = 0; i < count; i++)
                {
                    using (StreamWriter sW = new StreamWriter(newPath,false))
                    {
                        sW.WriteLine(sR.ReadLine());
                    }
                    if (newPath[0].Equals('Z'))
                    {
                        ch = 'a';
                        newPath = String.Concat(ch, newPath);
                    }
                    if (newPath[0].Equals('z'))
                    {
                        ch = 'A';
                        newPath = String.Concat(ch, newPath);
                    }
                    else
                    {
                        ch = newPath[0];
                        ch++;
                        newPath = newPath.Substring(1);
                        newPath = String.Concat(ch, newPath);
                    }             
                }
            }

            

        }
       
    }
}
