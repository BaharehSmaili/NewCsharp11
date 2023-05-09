using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public  class FileLocalTypes1
    {
        
    }
    file class FileLocalTypesClass
    {
        public static string GetTitle() => "Title from FileLocalTypes1.cs";
    }

    internal static class InternalClassFromFileLocalTypes1
    {
        public static string GetTitle() => FileLocalTypesClass.GetTitle();
    }
}
