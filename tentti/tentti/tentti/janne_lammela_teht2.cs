using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna sana");
            string sana = Console.ReadLine();
            sana = sana.ToLower();

            for (int i = 1; i < sana.Length+1; i++) 
            {
                if (i % 2 == 0)
                {

                } else
                {
                    Console.WriteLine(sana[i - 1]);
                }
            }

        }
    }
}
