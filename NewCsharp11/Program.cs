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

        Console.WriteLine();

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/21");
        Console.WriteLine();

        Console.WriteLine("Use File Local Types : ");
        Console.WriteLine(InternalClassFromFileLocalTypes.GetTitle());
        Console.WriteLine(InternalClassFromFileLocalTypes1.GetTitle());

        Console.WriteLine();
        Console.WriteLine("Use List Patterns : ");
        int[] array = new int[] { 1, 2, 3, 4 };
        Console.WriteLine("Input Array : " + String.Join(',', array));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMach(array));
        Console.WriteLine();
        int[] array1 = new int[] { 1, 2, 3, 5 };
        Console.WriteLine("Input Array : " + String.Join(',', array1));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMach(array1));
        Console.WriteLine();
        int[] array2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Input Array : " + String.Join(',', array2));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMach(array2));
        Console.WriteLine();
        int[] array3 = new int[] { 6, 2, 8, 4 };
        Console.WriteLine("Input Array : " + String.Join(',', array3));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachCheckDiscard(array3));
        Console.WriteLine();
        int[] array4 = new int[] { 6, 3, 8, 4 };
        Console.WriteLine("Input Array : " + String.Join(',', array4));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachCheckDiscard(array4));
        Console.WriteLine();
        int[] array5 = new int[] { 1, 2, 3, 4 };
        Console.WriteLine("Input Array : " + String.Join(',', array5));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachCheckDiscard1(array5));
        Console.WriteLine();
        int[] array6 = new int[] { 1, 2, 7, 4 };
        Console.WriteLine("Input Array : " + String.Join(',', array6));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachCheckDiscard1(array6));
        Console.WriteLine();
        int[] array7 = new int[] { 6, 7, 8 };
        Console.WriteLine("Input Array : " + String.Join(',', array7));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkAtLeastTwoMembersOfYourChoice(array7));
        Console.WriteLine();
        int[] array8 = new int[] { 6 };
        Console.WriteLine("Input Array : " + String.Join(',', array8));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkAtLeastTwoMembersOfYourChoice(array8));
        Console.WriteLine();
        int[] array9 = new int[] { 0, 42, 42, 0 };
        Console.WriteLine("Input Array : " + String.Join(',', array9));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkSetWhoseFirstAndLastMembersZero(array9));
        Console.WriteLine();
        int[] array10 = new int[] { 0, 2, 2 };
        Console.WriteLine("Input Array : " + String.Join(',', array10));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkSetWhoseFirstAndLastMembersZero(array10));
        Console.WriteLine();
        int[] array11 = new int[] { 0, 3, 4, 5 };
        Console.WriteLine("Input Array : " + String.Join(',', array11));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkLogicalActions(array11));
        Console.WriteLine();
        int[] array12 = new int[] { 0, 1, 2, 5 };
        Console.WriteLine("Input Array : " + String.Join(',', array12));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkLogicalActions(array12));
        Console.WriteLine();
        int[] array13 = new int[] { 9, -1, -2 };
        Console.WriteLine("Input Array : " + String.Join(',', array13));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkItsFirstMemberIsPositiveNumbers(array13));
        Console.WriteLine();
        int[] array14 = new int[] { 0, 1, 2, 5 };
        Console.WriteLine("Input Array : " + String.Join(',', array14));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkItsFirstMemberIsPositiveNumbers(array14));
        Console.WriteLine();
        int[] array15 = new int[] { 0, -5, 2 };
        Console.WriteLine("Input Array : " + String.Join(',', array15));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkComparison(array15));
        Console.WriteLine();
        int[] array16 = new int[] { 0, 1, 2 };
        Console.WriteLine("Input Array : " + String.Join(',', array16));
        Console.WriteLine("array is mach ? " + new ListPatterns().ListPatternMachChkComparison(array16));

        Console.WriteLine();

        Console.WriteLine("Use Required Member : ");
        Console.WriteLine("Setting the value of the property that has the Required : ");
        new RequiredMemberNew() { age = 10 };
        new RequiredMemberOld();
        new RequiredMemberNew1(10);

    }
}
