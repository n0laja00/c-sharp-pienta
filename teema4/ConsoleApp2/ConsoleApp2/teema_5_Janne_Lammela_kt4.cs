using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kt2
    {
        static string  Aloita()
        {
            string sParam;
            Console.WriteLine("Anna parametrejä");
            
            sParam = Console.ReadLine();
            return sParam.ToLower();
        }

        static void Tarkista(string sParam)
        {
            if (sParam.Contains("opettaja") == true)
            {
                Console.WriteLine("Koita saada opiskelijat oppimaan!");
            }
            else if (sParam.Contains("opiskelija"))
            {
                Console.WriteLine("Koita opiskella ahkerasti!");
            } else
            {
                Console.WriteLine("En ymmärrä.");
            }
        }

        static void ParamLaske(string sParam)
        {
            int iSanaMaara = 0, i = 0;


            while (i < sParam.Length && char.IsWhiteSpace(sParam[i]))
            { 
                i++; 
            }

            while (i < sParam.Length)
            {
                
                while (i < sParam.Length && !char.IsWhiteSpace(sParam[i]))
                {
                    i++;
                }
                    

                iSanaMaara++;

               
                while (i < sParam.Length && char.IsWhiteSpace(sParam[i]))
                {
                    i++;
                }
                    
            }
            Console.WriteLine("Annoit " + iSanaMaara + " parametria.");

        }
        static void Main()
        {
            string sParam;
            sParam = Aloita();
            Tarkista(sParam);
            ParamLaske(sParam);
            
        }
    }
}
