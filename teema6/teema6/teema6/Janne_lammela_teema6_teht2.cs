using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teema6
{
    using System.IO;
    class Program
    {
         
        static void ArvoJaTallennaTiedostoon()
        {
            string file = "C:/test/hakemisto/datat1.txt";
            Random rnd = new Random();
            double dluku = 0;
            dluku = rnd.NextDouble() * (1.4 - 5.4) + 1.4;
            StreamWriter sw = new StreamWriter(file);

            for (int i = 0; i < 40; i++)
            {

                dluku = rnd.NextDouble() * (5.8 - 1.4) + 1.4;
                dluku = Math.Round((double)dluku, 1);
                sw.WriteLine(dluku);
                
            }

            sw.Close();

            LueTiedostosta(file);
        }

        static void LueTiedostosta(string file)
        {
            double[] dTaulu = new double[40];
            double dluku = 0;
            int index = 0;
            StreamReader sr = new StreamReader(file);
            while (sr.EndOfStream == false)
            {
                dTaulu[index] = double.Parse(sr.ReadLine());
                index++;
            }
            sr.Close();
            TulostaTiedot(file, dTaulu);
        }

        static void TulostaTiedot(string file, double[] dTaulu)
        {
            foreach (double luku in dTaulu)
            {
                Console.WriteLine(luku);
            }
            Console.WriteLine("summa: " + dTaulu.Sum());
            Console.WriteLine("keskiarvo: " + dTaulu.Average());
            Console.WriteLine("minimiarvo : " + dTaulu.Min());
            Console.WriteLine("maksimiarvo: " + dTaulu.Max());

        }

        static void Main()
        {
            if (Directory.Exists("C:\\test") == false)
            {
                Directory.CreateDirectory("C:\\test");
            }
           


            if (Directory.Exists("C:\\test\\hakemisto") == false)
            {
                Directory.CreateDirectory("C:\\test\\hakemisto");
            }
            FileStream fs = null;
            if (File.Exists("C:\\test\\hakemisto\\datat1.txt") == false)
            {
                fs = File.Create("C:\\test\\hakemisto\\datat1.txt");
            }

            if (fs != null)
                {
                    fs.Close();
                }
            

            ArvoJaTallennaTiedostoon();
            


        }
    }
}
