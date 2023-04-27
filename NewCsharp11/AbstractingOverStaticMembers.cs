using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public interface Icar
    {
        static abstract bool IsGasolineFuel(); //سوخت بنزینی؟
    }

    public class AbstractingOverStaticMembersOld
    {
        public void PrintTypeFuel()
        {
            Console.WriteLine("Bus Is GasolineFuel : " + Bus.IsGasolineFuel());
            Console.WriteLine("Peride Is GasolineFuel : " + Peride.IsGasolineFuel());
        }
    }

    public class AbstractingOverStaticMembers
    {
        public string PrintTypeFuel<T>(T car) where T : Icar
        {
            return T.IsGasolineFuel().ToString();
        }
    }

    public class Bus : Icar
    {
        public static bool IsGasolineFuel() => false;
    }

    public class Peride : Icar
    {
        public static bool IsGasolineFuel() => true;
    }
}
