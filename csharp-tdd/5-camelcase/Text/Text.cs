using System;

namespace Text
{
    public class Str
    {
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