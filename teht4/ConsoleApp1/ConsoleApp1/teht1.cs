using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class teht1
    {
        static void Main(string[] args)
        {
            double[] dTaulu = new double[3];
            double dSumma;
            double dKa;

            Console.Write("Anna kolme double lukua: ");
            for(int i = 0; i <= dTaulu.Length; i++)
            {
                dTaulu[i] = double.Parse(Console.ReadLine());
            }

            dSumma = dTaulu.Sum();
            dKa = dTaulu.Average();

            Console.WriteLine("KA: " + dKa);
            Console.WriteLine("Summa: " + dSumma);

        }
    }
}
