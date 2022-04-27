using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt2_1
{
    class janne_lammela_kt2
    {
        static void Main()
        {
            double dLampo;
            Console.Write("Mikä on lämpötila? ");
            dLampo = double.Parse(Console.ReadLine());

            if (dLampo >= 39)
            {
                Console.WriteLine("Liian kuuma.");
            }
            else if (dLampo >= 11)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (dLampo >= 0)
            {
                Console.WriteLine("Haalea");
            }
            else if (dLampo >= -30)
            {
                Console.WriteLine("Pakkasta");
            }
            else if (dLampo <= -31)
            {
                Console.WriteLine("Liian kylmä");
            }
        }

    }
}
