using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word2vecLib.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a String to a Byte[].
        /// </summary>
        /// <param name="input">The String input.</param>
        /// <returns>Byte[] that represents the String.</returns>
        public static byte[] GetBytes(this string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }
        
        /// <summary>
        /// Converts a Byte[] to a String.
        /// </summary>
        /// <param name="bytes">The String input.</param>
        /// <returns>String that represents the Byte[].</returns>
        public static string GetString(this byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        /// <summary>
        /// Cleans a String that has unwanted Chars.
        /// </summary>
        /// <param name="word">The String input.</param>
        /// <returns>String that represents the String.</returns>
        public static string Clean(this string word)
        {
            return word.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace("\"", "").ToLower().Trim();
        }

        public static IEnumerable<string> DeferredSplit(this string word, char delimiter)
        {
            var buf = new StringBuilder();
            foreach (var ch in word)
            {
                if (ch == delimiter)
                {
                    yield return buf.ToString();
                    buf.Length = 0;
                }
                else
                    buf.Append(ch);
            }
            if (buf.Length != 0)
                yield return buf.ToString();
        }
    }
}
