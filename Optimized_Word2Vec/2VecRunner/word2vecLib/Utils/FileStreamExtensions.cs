﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word2vecLib.Utils
{
    public static class FileStreamExtensions
    {
        /// <summary>
        /// Reads a Word from the FileStream. A ' ' or a '\r' is the end of the Word.
        /// </summary>
        /// <param name="stream">The default, Input Stream from THIS object.</param>
        /// <returns>String</returns>
        public static string ReadWord(this FileStream stream)
        {
            var messageBuilder = new List<byte>();
            int abyte;
            while ((abyte = stream.ReadByte()) != -1)
            {
                byte byteAsInt = (byte)abyte;
                if (byteAsInt == '\r' || byteAsInt == ' ' || stream.Position == stream.Length)
                {
                    break;
                }
                messageBuilder.Add(byteAsInt);
            }
            return Encoding.UTF8.GetString(messageBuilder.ToArray());
        }
        
        /// <summary>
        /// Reads a Int from the FileStream. A ' ', '\n' or a '\r' is the end of the Int.
        /// </summary>
        /// <param name="stream">The default, Input Stream from THIS object.</param>
        /// <returns>Int</returns>
        public static int ReadInt32(this FileStream stream)
        {
            byte[] bytes = new byte[1];
            StringBuilder builder = new StringBuilder();
            while (stream.Read(bytes, 0, 1) != -1)
            {
                if (bytes[0] == ' ' || bytes[0] == '\n' || bytes[0] == '\r')
                    break;

                builder.Append((char)bytes[0]);
            }
            return Int32.Parse(builder.ToString());
        }
    }
}
