using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentti
{
    using System.IO;
    class Program
    {

        static void ArvoTaulukkoon()
        {
            Random rnd = new Random();

            int[] iTaulukko = new int[104];

            for (int i = 0; i < iTaulukko.Length; i++)
            {
                iTaulukko[i] = rnd.Next(9, 30);
                
            }

            TallennaTiedostoon(iTaulukko);
        }
        static void TallennaTiedostoon(int[] iTaulukko)
        {
            string file = "C:/test/hakemisto/numerot.txt";
            StreamWriter sw = new StreamWriter(file);
            

            for (int i = 0; i < iTaulukko.Length; i++)
            {
                int numero = iTaulukko[i];
                sw.WriteLine(numero);
            }
            sw.Close();
            LueLuvutJaTulostaParittomat(file);
        }
        static void LueLuvutJaTulostaParittomat(string file)
        {
            StreamReader sr = new StreamReader(file);
            int numero = 0;
            Console.WriteLine("Tulostetaan parittomat: ");
            while (sr.EndOfStream == false)
            {
                numero = int.Parse(sr.ReadLine());
                if (numero % 2 == 1)
                {
                
                    Console.WriteLine(numero);
                } else
                {

                }
            }
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
            if (File.Exists("C:\\test\\hakemisto\\numerot.txt") == false)
            {
                fs = File.Create("C:\\test\\hakemisto\\numerot.txt");
            }

            if (fs != null)
            {
                fs.Close();
            }
            ArvoTaulukkoon();
        }
    }
}
