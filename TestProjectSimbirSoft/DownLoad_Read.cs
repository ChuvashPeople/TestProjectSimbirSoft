using System;
using System.Net;
using System.IO;

namespace TestProjectSimbirSoft
{
    class DownLoad_Read
    {
        public static string DownloadRead(string path, string link)
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
