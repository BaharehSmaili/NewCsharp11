using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class ListPatterns
    {
        public void ListPatternsMethod()
        {
            int[] collection = { 1, 2, 3, 4 };
            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine("Index = " + i + " Value = " + collection[i]);
            }
        }

        public bool ListPatternMach(int[] array)
        {
            int[] KeyArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Key Array : " + String.Join(',', KeyArray) +" Pattern Is [1, 2, 3, 4]");
            if (array is [1, 2, 3, 4])
                return true;
            return false;
        }


        public bool ListPatternMachCheckDiscard(int[] array)
        {
            /*"اگر نیاز به صرفه نظر کردن از عناصر خاصی در یک توالی بود از قالب زیر استفاده میکنیم :"
            "[_, 2, _, 4]"
            "لیست بالا به معنای نیاز به انطباق با چهار عدد است که حتما باید دومین و چهارمین آن‌ها اعداد 2 و 4 باشند؛ اما مقدار اولین و سومین آن‌ها، مهم نیست."
            */
            int[] KeyArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Key Array : " + String.Join(',', KeyArray) + " Pattern Is [_, 2, _, 4]");
            if (array is [_, 2, _, 4])
                return true;
            return false;
        }

        public bool ListPatternMachCheckDiscard1(int[] array)
        {
            /*
             * معنای تعریف یک توالی نامشخص، اما خاتمه یافته‌ای با عنصر 3 است و سپس صرفنظر کردن از آخرین عنصر آرایه
             * [.., 3, _]
             */
            int[] KeyArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Key Array : " + String.Join(',', KeyArray) + " Pattern Is [.., 3, _]");
            if (array is [.., 3, _])
                return true;
            return false;
        }

        public bool ListPatternMachChkAtLeastTwoMembersOfYourChoice(int[] array)
        {
            /*
             * الگوی انطباق با مجموعه‌ای که حداقل دو عضو دلخواهی را دارد
             * [_, _, ..]
             */
            Console.WriteLine("Pattern Is [_, _, ..]");
            if (array is [_, _, ..])
                return true;
            return false;
        }

        public bool ListPatternMachChkSetWhoseFirstAndLastMembersZero(int[] array)
        {
            /*
             * الگوی انطباق با مجموعه‌ای که اولین و آخرین عضو آن صفر
             * [0, .., 0]
             */
            Console.WriteLine("Pattern Is [0, .., 0]");
            if (array is [0, .., 0])
                return true;
            return false;
        }

        public bool ListPatternMachChkLogicalActions(int[] array)
        {
            /*
             *  اعمال منطقی
             * هر مجموعه‌ی چهارتایی که عنصر دوم آن، بزرگتر و یا مساوی 2 باشد، معتبر شناخته می‌شود 
             * [_, >= 2, _, _]
             */
            Console.WriteLine("Pattern Is [_, >= 2, _, _]");
            if (array is [_, >= 2, _, _])
                return true;
            return false;
        }

        public bool ListPatternMachChkItsFirstMemberIsPositiveNumbers(int[] array)
        {
            /*
             *  اعمال منطقی
             * الگوی انطباق با مجموعه‌ای را که اولین عضو آن یک عدد مثبت است 
             * [> 0, ..]
             */
            Console.WriteLine("Pattern Is [> 0, ..]");
            if (array is [> 0, ..])
                return true;
            return false;
        }

        public bool ListPatternMachChkComparison(int[] array)
        {
            /*
             *  اعمال منطقی
             * الگوی انطباق با مجموعه‌ای که دومین عضو آن، یکی از دو عدد 5 و منهای 5 می‌تواند 
             * [_, 5 or -5, ..]
             */
            Console.WriteLine("Pattern Is [_, 5 or -5, ..]");
            if (array is [_, 5 or -5, ..])
                return true;
            return false;
        }

        public static class ListPatternsMatching
        {
            public static void Test()
            {
                Console.WriteLine(CheckSwitch(new[] { 1, 2, 10 }));          // prints 1
                Console.WriteLine(CheckSwitch(new[] { 1, 2, 7, 3, 3, 10 })); // prints 1
                Console.WriteLine(CheckSwitch(new[] { 1, 2 }));              // prints 2
                Console.WriteLine(CheckSwitch(new[] { 1, 3 }));              // prints 3
                Console.WriteLine(CheckSwitch(new[] { 1, 3, 5 }));           // prints 4
                Console.WriteLine(CheckSwitch(new[] { 2, 5, 6, 7 }));        // prints 50
            }

            public static int CheckSwitch(int[] values)
                => values switch
                {
                    [1, 2, .., 10] => 1,
                    [1, 2] => 2,
                    [1, _] => 3,
                    [1, ..] => 4,
                    [..] => 50
                };
            /*
                - اولین الگوی تعریف شده‌ی در متد CheckSwitch، به معنای انطباق با هر توالی است که با 1 و 2 شروع می‌شود و سپس می‌تواند شامل هر نوع توالی دلخواهی باشد (صرفنظر از مقدار و یا ترتیب این مقادیر) و در نهایت با عدد 10 خاتمه پیدا می‌کند.
                - دومین الگوی تعریف شده، تنها یک آرایه‌ی دو عضوی با مقادیر مشخص 1 و 2 را می‌پذیرد.
                - توالی قابل انطباق با سومین الگوی تعریف شده، از دو عضو تشکیل می‌شود. اولین عضو آن حتما باید 1 باشد و مقدار دومین عضو آن مهم نیست.
                - توالی قابل انطباق با چهارمین الگوی تعریف شده، از یک یا چند عضو دلخواه تشکیل می‌شود که اولین عضو آن حتما باید عدد 1 باشد.
                - هر توالی تعریف شده‌ای با پنجمین الگوی تعریف شده، انطباق پیدا می‌کند.
             */
        }
    }
}
