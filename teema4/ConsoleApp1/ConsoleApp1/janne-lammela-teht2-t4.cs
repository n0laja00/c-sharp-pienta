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
            Random rnd = new Random();
            int[] iTaulu = new int[10];

            int iluku;
            for(int i = 0; i < iTaulu.Length; i++)
            {
                iluku = rnd.Next(1, 6) * 2;
                iTaulu[i] = iluku;
            }
            for (int i = 0; i < iTaulu.Length; i++)
            {
                Console.Write(iTaulu[i]+ "\t");
            }



        }
    }
}
