using System;

namespace Text
{
    /// <summary>
    /// Class to count the number of words in a camel case string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Count the number of words in a camel case string.
        /// </summary>
        /// <param name="s">The string to count the words in.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s == "")
            {
                return -1;
            }
            int count = 1;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}