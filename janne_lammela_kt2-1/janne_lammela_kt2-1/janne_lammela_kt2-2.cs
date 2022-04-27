using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt2_1
{
    class janne_lammela_kt2
    {
        enum Kuukausi { tammikuu = 1, helmikuu, maaliskuu, huhtikuu, toikokuu, kesäkuu, heinäkuu, elokuu, syyskyy, lokakuu, marraskuu, joulukuu };
        
        static void Main()
        {
            int iKk; 
            Console.Write("Mikä kuukausi on? (Anna Numero): ");
            iKk = int.Parse(Console.ReadLine());
            
            switch(iKk)
            {
                case 1:
                case 2:
                    Console.WriteLine("Kuukausi on " + (Kuukausi)iKk + " ja on talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Kuukausi on " + (Kuukausi)iKk + " ja on kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Kuukausi on " + (Kuukausi)iKk + " ja on kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Kuukausi on " + (Kuukausi)iKk + " ja on syksy");
                    break;
                case 12:
                    Console.WriteLine("Kuukausi on " + (Kuukausi)iKk + " ja on talvi");
                    break;
                default:
                    Console.WriteLine("Anna oikea numero.");
                    break;

            }
        }

    }
}
