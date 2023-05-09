using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class FileLocalTypes
    {
       
    }

    public class FileLocalTypesClass
    {
        public static string GetTitle() => "Title from FileLocalTypes.cs";
    }

    internal static class InternalClassFromFileLocalTypes
    {
        public static string GetTitle() => FileLocalTypesClass.GetTitle();
    }
}
