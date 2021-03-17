using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestProjectSimbirSoft
{
    class Remove
    {
        public static string RemoveJS(string text)
        {
            Regex regexJS = new Regex(@"(?s)<script.*?(/>|</script>)", RegexOptions.IgnoreCase);
            Regex regexST = new Regex(@"(?s)<style.*?(/>|</style>)", RegexOptions.IgnoreCase);
            Regex regex = new Regex(@"&#+\d",RegexOptions.IgnoreCase);
            Regex regexNumber = new Regex(@"\d");
            text = regexJS.Replace(text, " ");
            text = regexST.Replace(text, " ");
            text = regex.Replace(text, " ");
            text = regexNumber.Replace(text, " ");
            return text;
        }
    }
}
