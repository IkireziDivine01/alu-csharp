using System;

namespace Text
{
    /// <summary>
    /// Provides string utility methods.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Counts the number of words in a camel case string.
        /// Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">The camel case string to evaluate.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1; // At least one word if string is non-empty

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
