using System;

namespace TestProjectSimbirSoft
{
    class Parse
    {
        public static string[] ParsePage(string oldText)
        {
            string text = "";

            char[] r = { ' ', ',', '.', '!', '?', '"', ';',
                ':', '[', ']', '(', ')', '\n', '\r', '\t', 
                '«', '»', '—','/', '©','-', '\\','+',' ','&','.','·','‑' };

            oldText = Remove.RemoveWithRegex(oldText);
            
            for (int i = 0; i < oldText.Length; i++)
            {
                if (oldText[i].Equals('<'))
                {
                    while (!oldText[i].Equals('>'))
                    {
                        i++;
                    }
                    if (oldText[i].Equals('>'))
                    {
                        text += " ";
                    }
                }
                else
                {
                    text += oldText[i];
                }
            }

            text = text.ToUpper();
            string[] mas = text.Split(r, StringSplitOptions.RemoveEmptyEntries);

            return mas;
        }
    }
}
