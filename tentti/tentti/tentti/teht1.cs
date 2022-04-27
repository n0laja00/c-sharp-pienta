using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentti
{
    class Program
    {
        static void LueArvot(int iKoko)
        {

            string dKoko = (iKoko).ToString("#.00");
            Console.WriteLine(dKoko);
            
        }

        static void Tulosta(int iKoko)
        {
  
        }
        static void Main()
        {
            int iKoko0 = 0;
            int iKoko1 = 0;
            Console.Write("Anna numero ");
            iKoko0 = int.Parse(Console.ReadLine());
            Console.Write("Anna numero ");
            iKoko1 = int.Parse(Console.ReadLine());

            LueArvot(iKoko0);
            LueArvot(iKoko1);

            Console.WriteLine(iKoko1);
            Console.WriteLine(iKoko0);

        }
    }
}
