using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kt2
    {
        static void LuoTaulukko()
        {
            float[] fTaulukko = new float[7];
            KysyArvotTaulukkoon(fTaulukko);
        }

        static void KysyArvotTaulukkoon(float[] fTaulukko)
        {
            Console.WriteLine("Anna taulukkoon arvoja.");
            int i;
            float fNumero;

            for ( i = 0; i < fTaulukko.Length; i++)
            {
                bool bProsessi = float.TryParse(Console.ReadLine(), out fNumero);
                while (bProsessi == false)
                {
                    Console.WriteLine("Ei ollut numero. Tsekkaa pilkku");
                    
                    bProsessi = float.TryParse(Console.ReadLine(), out fNumero);
                }

                fTaulukko[i] = fNumero;
            }
            LajitteleTaulukko(fTaulukko);
        }

        static void LajitteleTaulukko(float[] fTaulukko)
        {
            Array.Sort(fTaulukko);
            TulostaTiedot(fTaulukko);
        }

        static void TulostaTiedot(float[] fTaulukko)
        {
            Console.WriteLine(fTaulukko[0] + " on pienin arvo ja " + fTaulukko[fTaulukko.Length - 1] + " on korkein");
        }

        static void Main()
        {
            LuoTaulukko();

        }
    }
}
