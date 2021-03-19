using System;
using System.IO;
using System.Diagnostics;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            long before = GC.GetTotalMemory(false);
            Console.Write("Введите ссылку на страницу: ");
            string link = Console.ReadLine();
            string path = @"D:\html\html.txt"; //Указать путь к файлу, в который будет сохраняться html-страница
            string newPath = @"D:\html\newHtml.txt";
            Sort.SortPage(Parse.ParsePage(DownLoad_Read.DownloadRead(path, link)));
            //SplitDownload.GeneralMethod(link, newPath);
            long after = GC.GetTotalMemory(false);
            double consumedInMegabytes = (double)(after - before) / (1024 * 1024);
            Console.WriteLine(consumedInMegabytes);

        }
    }
}
