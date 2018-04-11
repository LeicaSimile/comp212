using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringExtensions
{
    // Extension methods must be static within a static class
    public static class StringExtensions
    {
        // Extension method for strings (note parameter keywords "this string")
        public static string StartCase(this string strpar)
        {
            StringBuilder capitalizedString = new StringBuilder();
            string[] words = strpar.Split();

            foreach (string word in words)
            {
                capitalizedString.Append(Regex.Replace(word, @"^\w", m=>m.Value.ToUpper()) + " ");
            }
            return capitalizedString.ToString();
        }
    }
}
