using System;

namespace Text
{
    /// <summary>
    /// Class to find the first unique character in a string
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to find the first unique character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <returns>The index of the first unique character</returns>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
                return -1;

            int[] count = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}