using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class AllowNewLinesInAllInterpolations
    {
        public void Print(string nameAndFamily)
        {
            Console.WriteLine($" my name is : {nameAndFamily
                .ToLower()
                .Replace('.', ' ')
                .ToUpperInvariant()}");
        }
        public void PrintSeason(int month)
        {
            // switch expression in string interpolation
            string season = $"The season is {month switch
            {
                1 or 2 or 12 => "Winter",
                > 2 and < 6 => "Spring",
                > 5 and < 9 => "Summer",
                > 8 and < 12 => "Autumn",
                _ => "unknown. Wrong month number",
            }}.";

            Console.WriteLine(season);
        }

    }
}
