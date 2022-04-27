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
        static void Main()
        {
            string nimi = "";
            Console.Write("Anna nimi (max 18 merkkiä). ");

            nimi = Console.ReadLine();

            while(nimi.Length > 18)
            {
                Console.Write("Anna nimi uudelleen (max 18 merkkiä). ");
                nimi = Console.ReadLine();
            }
            if (Directory.Exists("C:\\test") == false)
            {
                Directory.CreateDirectory("C:\\test");
            }
            if (Directory.Exists("C:\\test\\hakemisto") == false)
            {
                Directory.CreateDirectory("C:\\test\\hakemisto");
            }
            FileStream fs = null;
            if (File.Exists("C:\\test\\hakemisto\\nimi.txt") == false)
            {
                fs = File.Create("C:\\test\\hakemisto\\nimi.txt");
            }

            if (fs != null)
            {
                fs.Close();
            }
            string file = "C:/test/hakemisto/nimi.txt";

            StreamWriter sw = new StreamWriter(file);

            for (int i = nimi.Length-1; i > -1; i--)
            {
                char c = nimi[i];
                for (int b = 0; b < i; b++)
                {
                    sw.Write("  ");
                   
                }
                sw.Write(" " + c + "\r");
                
            }
            sw.Close();





        }
    }
}
