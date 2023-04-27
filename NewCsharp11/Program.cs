using NewCsharp11;
using System.Numerics;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/01/31");

        Console.WriteLine("Use INumber Interface : ");
        new ClassINumberInterface().testINumberInterface();
        Console.WriteLine();

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/07");

        new AbstractingOverStaticMembersOld().PrintTypeFuel();
        Console.WriteLine();

        Console.WriteLine("Use Abstracting Over Static Members : ");
        //قابلیت ارسال کلاس به متد
        Console.WriteLine("Bus Is GasolineFuel : " + new AbstractingOverStaticMembers().PrintTypeFuel(new Bus()));
        Console.WriteLine("Peride Is GasolineFuel : " + new AbstractingOverStaticMembers().PrintTypeFuel(new Peride()));

        Console.WriteLine();

        Console.WriteLine("Use Raw String Literals : ");
        new RawStringLiterals().RawStringLiteralsOld();
    }
}