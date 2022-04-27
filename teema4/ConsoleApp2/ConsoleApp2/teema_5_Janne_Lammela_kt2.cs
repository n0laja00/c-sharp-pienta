using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kt2
    {
        
        static int KysyKoko()
        {
            Console.WriteLine("Kuinka iso taulukko? ");
            bool bProsessi;
            int iArvo;

            bProsessi = int.TryParse(Console.ReadLine(), out iArvo);
            while (bProsessi == false)
            {
                Console.WriteLine("Antamasi merkki ei ollut kokonaisluku.");
                Console.Write("Anna numero: ");
                bProsessi = int.TryParse(Console.ReadLine(), out iArvo);
            }
            return iArvo;

        }

        static int[] LuoTaulukko( int iKoko)
        {
            int[] iTaulukko = new int[iKoko];
            return iTaulukko;
        }

        static void ArvoArvosanat(int[] iT, int iKoko)
        {
            Random rnd = new Random();

            iT[1] = rnd.Next(0, 6);

            for (int i = 0; i < iKoko; i++)
            {
                iT[i] = rnd.Next(0, 6);
            }
            
            
        }

        static int TutkiHylatyt(int[] iTaulukko)
        {
            int iMaara = 0;
            for (int i = 0; i < iTaulukko.Length; i++)
            {                
                if (iTaulukko[i] == 0)
                {
                    iMaara++;
                };
            }
            return iMaara;
        }

        static void Tulosta(int iMaara, int[] iTaulukko)
        {
            Console.Clear();
            foreach (int luku in iTaulukko)
            {
                Console.WriteLine(luku);
            }
            Console.WriteLine(iMaara + " oppilasta sai numeron 0.");
        }

        static void Main()
        {
            int[] iTaulukko;
            int iKoko = KysyKoko();
            iTaulukko = LuoTaulukko(iKoko);

             ArvoArvosanat(iTaulukko, iKoko);



            int iMaara = TutkiHylatyt(iTaulukko);
            Tulosta(iMaara, iTaulukko);
        }
    }
}
