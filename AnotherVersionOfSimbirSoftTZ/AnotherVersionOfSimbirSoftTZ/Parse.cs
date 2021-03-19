using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherVersionOfSimbirSoftTZ
{
    class Parse
    {
        public static string[] ParseMethod(string oldText)
        {
            string text = "";

            char[] r = { ' ', ',', '.', '!', '?', '"', ';',
                ':', '[', ']', '(', ')', '\n', '\r', '\t',
                '«', '»', '—','/', '©','-', '\\','+',' ','&','.','·','‑' };

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
