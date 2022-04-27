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
            float fD;
            int iToimitus;
            double dPi = Math.PI;

            Console.Write("Mikä on ympyrän säde? ");
            fD = float.Parse(Console.ReadLine());
            float fR = fD / 2;

            Console.Write("Lasketaanko ympyrän piiri (1) vai pinta-ala (2)?");
            iToimitus = int.Parse(Console.ReadLine());

            switch(iToimitus)
            {
                case 1:
                    Console.WriteLine("Piiri on: 2*{0}*{1} = {2}", Math.Round(dPi, 6), fR, 2 * dPi * fR);
                    break;
                case 2:
                    Console.WriteLine("Pinta-ala on: {0}*{1}^2 = {2}", Math.Round(dPi, 6), fR, dPi * Math.Pow(fR,2));
                    break;
                default:
                    break;
            }

        }

    }
}
