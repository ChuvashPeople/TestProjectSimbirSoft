using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace TestProjectSimbirSoft
{
    class DLR
    {
        public static string DownloadLoadRead(string path, string link)
        {
            string text = "";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(link, path);
                }

                using (StreamReader str = new StreamReader(path))
                {
                    text = str.ReadToEnd();
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Пожалуйста, введите корректную ссылку.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Не правильно указан путь к файлу.");
            }

            return text;
        }
    }
}
