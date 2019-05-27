using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilinator
{
    public static class IOExtension
    {
        public static bool EndOfFile(this BinaryReader br)
        {
            return !(br.BaseStream.Position < br.BaseStream.Length);
        }

        public static string ReadBlitzString(this BinaryReader br)
        {
            int len = br.ReadInt32();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                sb.Append((char) br.ReadByte());
            }

            return sb.ToString();
        }

        public static void WriteBlitzString(this BinaryWriter bw, string s)
        {
            if (s == null)
                s = "";

            bw.Write(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                bw.Write((byte)s[i]);
            }
        }
    }
}
