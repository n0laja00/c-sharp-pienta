using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kt2
    {
        public static class GlobalData
        {
            public static double[] dPisteTaulu = new double[0];

            public static double[] kopio;
        }
       static void KysyHypynPituus()
        {
            Console.Write("Kuinka pitkä hyppy oli? ");
            double dPituus;
            double KR_Piste = 0;

            bool bProsessi = double.TryParse(Console.ReadLine(), out dPituus);
            while (bProsessi == false || dPituus%0.5 != 0)
            {
                Console.WriteLine("Antamasi merkki ei ollut kokonaisluku tai se ei ole laitettu 0.5 välein. Tsekkaa, että pisteen sijaan on pilkku.");
                Console.Write("Anna numero: ");
                bProsessi = double.TryParse(Console.ReadLine(), out dPituus);
            }

            if (dPituus <= 90)
            {
                KR_Piste = 1;
            }
            KysyTuomareidenPisteet(dPituus, KR_Piste);
        }

        static void KysyTuomareidenPisteet(double dPituus, double KR_Piste)
        {
            double dPituus2 = dPituus;
            double KR_Piste2 = KR_Piste;

            double[] dTyyliPisteet = new double[5];

            Random rnd = new Random();
            double dArvio = 0;

            for(int i = 0; i < dTyyliPisteet.Length; i++)
            {
                dArvio = rnd.Next(0, 21);
                while (dArvio % 0.5 != 0)
                {
                    dArvio = rnd.Next(0, 21);
                }
                dTyyliPisteet[i] = dArvio;
            }

            LaskeHypynPisteet(dPituus2, KR_Piste2, dTyyliPisteet);
        }

        static void LaskeHypynPisteet(double dPituus, double KR_Piste, double[] dTyylipisteet)
        {
            double dPituus2 = dPituus;
            double KR_Piste2 = KR_Piste;
            
            foreach (int luku in dTyylipisteet)
            {
                Console.WriteLine(luku);
            }

            Array.Sort(dTyylipisteet);

            double dPisteet = (dPituus2 - KR_Piste2) * 1.8 + dTyylipisteet.Skip(1).Take(3).Sum() + 60;

            int iTauluPituus = GlobalData.dPisteTaulu.Length + 1;

            GlobalData.kopio = new double[iTauluPituus-1];

            GlobalData.dPisteTaulu.CopyTo(GlobalData.kopio, 0);
           
            GlobalData.dPisteTaulu = new double[iTauluPituus];
            GlobalData.kopio.CopyTo(GlobalData.dPisteTaulu, 0);

            GlobalData.dPisteTaulu[iTauluPituus - 1] = dPisteet;

            Tulosta(dPisteet);
        }

        static void Tulosta(double dPisteet)
        {
            Console.WriteLine(dPisteet);
            Console.WriteLine("Pistehistoria:");
            foreach (int luku in GlobalData.dPisteTaulu)
            {
                Console.WriteLine(luku);
            }
            Console.WriteLine("Paina jotain nappia jatkaaksesi.");
        }

        static void Main()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Tämä applikaatio laskee pituushypyn pisteet ja pitää historiaa globaalina arrayna.");
                KysyHypynPituus();
            }
                
        }
    }
}
