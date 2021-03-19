using System;
using System.Diagnostics;
using System.Text;

namespace AnotherVersionOfSimbirSoftTZ
{
    class Program
    {
        static void Main(string[] args)
        {
            long before = GC.GetTotalMemory(false);

            char ch = 'a';
            string str = ".txt";
            string newPath = ch.ToString() + str;

            string path = "newHtml.txt";
            string link = @"https://www.simbirsoft.com/";
            int count;
            
            Download_Split.DownloadSplit(link, path,out count);

            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine(Read.ReadMethod(newPath));
                
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

            long after = GC.GetTotalMemory(false);
            double consumedInMegabytes = (double)(after - before) / (1024 * 1024);
            Console.WriteLine(consumedInMegabytes);
        }
    }
}
