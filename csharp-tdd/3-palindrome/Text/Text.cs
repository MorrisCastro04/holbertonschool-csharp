using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Check for null input
            if (s == null)
            {
                return true;
            }

            // Normalize the string: convert to lowercase and remove non-alphanumeric characters
            string cleaned = Regex.Replace(s.ToLower(), @"[^a-z0-9]", "");

            // Check if the cleaned string is equal to its reverse
            return cleaned == new string(cleaned.Reverse().ToArray());
        }
    }
}
