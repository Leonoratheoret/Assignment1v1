using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {

            foreach (var line in lines)
            {
                foreach (Match m in Regex.Matches(line, @"[^\s.*]?\w*[^\s.*]"))
                {
                    yield return m.ToString();
                }
            }

        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            foreach (var res in resolutions)
            {
                string[] resses = res.Split(" ");
                foreach (var oploesning in resses)
                {
                    var pattern = "(?<first>[0-9]{2,})x(?<second>[0-9]{2,})";

                    var match = Regex.Match(oploesning, pattern);

                    var first = "";
                    var second = "";

                    if (match.Success)
                    {
                        first = match.Groups["first"].Value;
                        second = match.Groups["second"].Value;
                    }
                    var res1 = Int32.Parse(first);
                    var res2 = Int32.Parse(second);

                    yield return (res1, res2);
                }
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            //did not managed to make this Regex 
            
            throw new NotImplementedException();

        }
    }
}
