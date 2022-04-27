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
            if (Directory.Exists("C:\\test") == false)
            {
                Directory.CreateDirectory("C:\\test");
            }
            for ( int i = 0; i < 10; i++)
            {
                if (Directory.Exists("C:\\test\\hakemisto"+(i+1)) == false)
                {
                    Directory.CreateDirectory("C:\\test\\hakemisto" + (i + 1));
                }
            }


            
           

            string[] juurenhakemistot = Directory.GetDirectories("c:\\test\\");


            int iKansiomaara = Directory.GetDirectories("c:\\test\\").Count();
            Console.WriteLine(iKansiomaara);




            foreach (string hakemisto in juurenhakemistot)
            {

                Console.WriteLine(hakemisto);
            }

            

            for (int i = 0; i < iKansiomaara; i++)
            {
                Console.WriteLine("Poistetaan " + juurenhakemistot[i]);
                Directory.Delete(juurenhakemistot[i]);
                
            }
                
            


        }
    }
}
