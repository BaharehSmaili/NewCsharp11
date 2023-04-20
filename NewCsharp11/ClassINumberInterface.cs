using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    internal class ClassINumberInterface
    {
        public void testINumberInterface()
        {
            var ints = new int[] { 1, 2, 3, 4, 5 };
            var doubles = new double[] { 1.3, 2.8, 3.5, 4.2, 5.1 };

            Console.WriteLine(Sum(ints));
            Console.WriteLine(Sum(doubles));

            Console.WriteLine(Avg(ints));
            Console.WriteLine(Avg(doubles));
        }

        T Sum<T>(T[] values) where T : INumber<T>
        {
            T result = T.Zero;
            foreach (T value in values)
            {
                result += value;
            }
            return result;
        }

        T Avg<T>(T[] values) where T : INumber<T>
        {
            var sum = Sum(values);
            T count = T.Zero;
            for (int i = 0; i < values.Length; i++)
            {
                count += T.One;
            }
            return sum / count;

        }
    }
}
