using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class Utf8StringLiterals
    {
        public void GetEncodingOld(String str)
        {
            var utf8 = System.Text.Encoding.UTF8.GetBytes(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(utf8[i]);
            }

        }

        public void GetEncoding()
        {
            var utf8 = "ABC"u8;
            for (int i = 0; i < utf8.Length; i++)
            {
                Console.WriteLine(utf8[i]);
            }

        }
    }
}
