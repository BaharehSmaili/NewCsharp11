using NewCsharp11;
using System.Numerics;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/01/31");
        Console.WriteLine();

        Console.WriteLine("Use INumber Interface : ");
        new ClassINumberInterface().testINumberInterface();
        Console.WriteLine();

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/07");
        Console.WriteLine();

        new AbstractingOverStaticMembersOld().PrintTypeFuel();
        Console.WriteLine();

        Console.WriteLine("Use Abstracting Over Static Members : ");
        //قابلیت ارسال کلاس به متد
        Console.WriteLine("Bus Is GasolineFuel : " + new AbstractingOverStaticMembers().PrintTypeFuel(new Bus()));
        Console.WriteLine("Peride Is GasolineFuel : " + new AbstractingOverStaticMembers().PrintTypeFuel(new Peride()));

        Console.WriteLine();

        Console.WriteLine("Use Raw String Literals : ");
        new RawStringLiterals().RawStringLiteralsOld();

        Console.WriteLine();

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/14");
        Console.WriteLine();

        Console.WriteLine("Use Allow New Lines In All Interpolations : ");
        new AllowNewLinesInAllInterpolations().Print("Bahareeh.Smaili");
        new AllowNewLinesInAllInterpolations().PrintSeason(5);

        Console.WriteLine();

        Console.WriteLine("""Use Utf8 String Literals : String ="ABC" """);
        Console.WriteLine("old : ");
        new Utf8StringLiterals().GetEncodingOld("ABC");
        Console.WriteLine("new : ");
        new Utf8StringLiterals().GetEncoding();

        Console.WriteLine();

        Console.WriteLine("Use IntPtr And UIntPtr : ");
        new IntPtrAndUIntPtr().sample();

        Console.WriteLine();
        Console.WriteLine("Use Auto Default Structs : ");
        new AutoDefaultStructs().PrintCar("Pride");
    }
}