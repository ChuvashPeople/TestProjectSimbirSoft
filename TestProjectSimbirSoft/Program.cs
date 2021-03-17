using System;
using System.IO;
using System.Collections;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = Console.ReadLine();
            string path = @"D:\html\html.txt";
            

            string inputPath = @"D:\html\input.txt";

            var ret = Sorting.SortPage(Parsing.ParsePage(DLR.DownloadLoadRead(path, link)));

            using (StreamWriter strw = new StreamWriter(inputPath, false))
            {
                foreach (var item in ret)
                {
                    strw.WriteLine(item);
                }
            }
        }
    }
}
