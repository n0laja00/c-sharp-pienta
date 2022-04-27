using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt1_3
{
    class Program
    {
        static void Main()
        {
            int iLuku1 = 10;
            int iLuku2 = 5;

            Console.WriteLine("Summa:\t {0} + {1} = {2}", iLuku1, iLuku2, iLuku1 + iLuku2);
            Console.WriteLine("Erotus:\t {0} - {1} = {2}", iLuku1, iLuku2, iLuku1 - iLuku2);
            Console.WriteLine("Osa:\t {0} / {1} = {2}", iLuku1, iLuku2, iLuku1 / iLuku2);
            Console.WriteLine("Tulo:\t {0} * {1} = {2}", iLuku1, iLuku2, iLuku1 * iLuku2);
            Console.WriteLine("Summa:\t {0} + {1}^2 = {2}", iLuku1, iLuku2, iLuku1 + Math.Pow(iLuku2, 2));
        }
    }
}
