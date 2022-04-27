using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt2_1
{
    class janne_lammela_kt1
    {
        static void Main()
        {
            int iNumero; 
            Console.WriteLine("Mikä koe numero?");
            iNumero = int.Parse(Console.ReadLine());
            Console.Clear();
            if (iNumero < 11 && iNumero > 3)
            {
                if (iNumero >= 9)
                {
                    Console.WriteLine("Erinomainen!");
                }
                else if (iNumero >= 7)
                {
                    Console.WriteLine("Kelpo");
                }
                else if (iNumero >= 5)
                {
                    Console.WriteLine("Tyydyttävä");
                }
                else if (iNumero == 4)
                {
                    Console.WriteLine("Heikko");
                }
            }
            else
            {
                Console.WriteLine("Laita oikea numero.");
            }
            
        }
    }
}
