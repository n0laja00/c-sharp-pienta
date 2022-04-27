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
        static void Tallenna(string sParam)
        {
            string file = "C:/test/hakemisto/parametrit.txt";
            StreamWriter sw = new StreamWriter(file);

            for (int i = 0; i < sParam.Length; i++)
            {
                char c = sParam[i];
                if (Char.IsWhiteSpace(c) == true)
                {
                    sw.Write("\r");
                    
                } else
                {
                    sw.Write(c);
                    
                }
            }

            sw.Close();
            LueJaTulosta(file);
        }

        static void LueJaTulosta(string file)
        {
            StreamReader sr = new StreamReader(file);
            string sParam;
            while(sr.EndOfStream == false)
            {
                sParam = sr.ReadLine();
                Console.WriteLine(sParam);
            }
            sr.Close();
        }
        static void Main()
        {
            string sParam = "";
            Console.Write("Anna minulle parametreja! ");

            sParam = Console.ReadLine();
            sParam  = sParam.ToLower();
            bool b = String.IsNullOrWhiteSpace(sParam);


            if (b == true )
            {
                Console.WriteLine("Ei parametreja");
            }
            else
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
                if (File.Exists("C:\\test\\hakemisto\\parametrit.txt") == false)
                {
                    fs = File.Create("C:\\test\\hakemisto\\parametrit.txt");
                }

                if (fs != null)
                {
                    fs.Close();
                }

                Tallenna(sParam);
            }


            


        }
    }
}
