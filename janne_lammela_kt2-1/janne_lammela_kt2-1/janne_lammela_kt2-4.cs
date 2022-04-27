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
            int iLuku1;
            int iLuku2;
            string sToimitus;
            Console.Write("Anna luku: ");
            iLuku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            iLuku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valitse lasku toimitus: jako, plus, miinus, kerto");
            sToimitus = Console.ReadLine();

            switch(sToimitus)
            {
                case "jako":
                    Console.WriteLine("{0} / {1} = {2}", iLuku1, iLuku2, iLuku1 / iLuku2);
                    break;
                case "plus":
                    Console.WriteLine("{0} + {1} = {2}", iLuku1, iLuku2, iLuku1 + iLuku2);
                    break;
                case "miinus":
                    Console.WriteLine("{0} - {1} = {2}", iLuku1, iLuku2, iLuku1 - iLuku2);
                    break;
                case "kerto":
                    Console.WriteLine("{0} * {1} = {2}", iLuku1, iLuku2, iLuku1 * iLuku2);
                    break;
                default:
                    Console.WriteLine("Yritä uudelleen");
                    break;
            }
            
        }

    }
}
