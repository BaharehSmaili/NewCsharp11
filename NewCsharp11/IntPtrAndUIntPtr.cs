using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class IntPtrAndUIntPtr
    {
        public void sampleOld(int a, int b)
        {
            System.UIntPtr aa = 1;
            System.IntPtr bb = 1;
        }

        public void sample()
        {
            uint aa = 1;
            nuint bb = 1;

            Console.WriteLine("New System.UIntPtr = nuint And System.IntPtr = uint ");
        }
    }
}
