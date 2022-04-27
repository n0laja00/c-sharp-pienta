using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt1_5
{
    class Program
    {
        static void Main()
        {
            double dPi = Math.Round(Math.PI, 6);
            double dHalkaisija;

            Console.Write("Anna ympyrän halkaisija: ");

            dHalkaisija = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Annoit halkaisijaksi: " + dHalkaisija);
            Console.WriteLine("Ympyrän piiri on " + 2 * dPi * (dHalkaisija / 2) + "ja sen pinta-ala on " + dPi * Math.Pow(dHalkaisija / 2, 2));


        }
    }
}
