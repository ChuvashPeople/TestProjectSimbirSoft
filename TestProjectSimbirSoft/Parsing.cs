using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectSimbirSoft
{
    class Parsing
    {
        public static string[] ParsePage(string oldText)
        {
            string text = "";

            char[] r = { ' ', ',', '.', '!', '?', '"', ';',
                ':', '[', ']', '(', ')', '\n', '\r', '\t', 
                '«', '»', '—','/', '©','-', '\\','+',' ','&','.','·' };

            oldText = Remove.RemoveJS(oldText);
            
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
