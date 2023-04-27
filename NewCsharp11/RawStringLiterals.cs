using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class RawStringLiterals
    {
        public void RawStringLiteralsOld()
        {
            Console.WriteLine(@"The old use of the ""double quotation"" test with @");
            Console.WriteLine("The old use of the \"double quotation\" test with back slash and quotation");
            Console.WriteLine("""The new use of the "double quotation" test with C# 11""");
            var oldJson = "{color: \"green\",value: \"#0f0\"}";
            Console.WriteLine("Old json : " + oldJson);
            var newJson = """ 
                            {
                            color: "green",
                            value: "#0f0"
                            } 
                          """;
            Console.WriteLine("New json : " + newJson);

            double avg = 18.30;
            var newJsonUseParams = $$""" 
                            {
                            average: "{{avg}}"
                            } 
                          """;
            Console.WriteLine("New json Use Params : " + newJsonUseParams);

        }
    }
}
