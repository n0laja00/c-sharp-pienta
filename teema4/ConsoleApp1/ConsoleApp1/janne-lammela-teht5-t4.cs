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
            double[,] dMittaus = new double[5, 4];
            double dKa = 0;

            for (int i = 0; i < dMittaus.GetLength(0); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Maanantai");
                    for (int o = 0; o < dMittaus.GetLength(1); o++)
                    {
                        Console.WriteLine("Mittaus:" +(o + 1));
                        dMittaus[i, o] = double.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                if (i == 1)
                {
                    Console.WriteLine("Tiistai");
                    for (int o = 0; o < dMittaus.GetLength(1); o++)
                    {
                        Console.WriteLine("Mittaus:" + (o + 1));
                        dMittaus[i, o] = double.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                if (i == 2)
                {
                    Console.WriteLine("Keskiviikko's measurements");
                    for (int o = 0; o < dMittaus.GetLength(1); o++)
                    {
                        Console.WriteLine("Mittaus:" + (o + 1));
                        dMittaus[i, o] = double.Parse(Console.ReadLine());
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine("Torstai");
                    for (int o = 0; o < dMittaus.GetLength(1); o++)
                    {
                        Console.WriteLine("Mittaus:" + (o + 1));
                        dMittaus[i, o] = double.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                if (i == 4)
                {
                    Console.WriteLine("Perjantai");
                    for (int o = 0; o < dMittaus.GetLength(1); o++)
                    {
                        Console.WriteLine("Mittaus" + (o + 1));
                        dMittaus[i, o] = double.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();

            }
            /**************************************************************************************************************************/
            for (int i = 0; i < dMittaus.GetLength(0); i++)
            {

                for (int o = 0; o < dMittaus.GetLength(1); o++)
                {
                    dKa = dKa + dMittaus[i, o];
                }
                if (i == 0)
                {
                    Console.WriteLine("Maanantai     \t : " + (dKa / dMittaus.GetLength(1)));
                } else if (i == 1)
                {
                    Console.WriteLine("Tiistai       \t : " + (dKa / dMittaus.GetLength(1)));
                }
                else if (i == 2)
                {
                    Console.WriteLine("Keskiviikko's\t : " + (dKa / dMittaus.GetLength(1)));
                }
                else if (i == 3)
                {
                    Console.WriteLine("Tostai      \t : " + (dKa / dMittaus.GetLength(1)));
                }
                else 
                {
                    Console.WriteLine("Perjantai   \t : " + (dKa / dMittaus.GetLength(1)));
                }

                dKa = 0;

            }



        }
    }
}
