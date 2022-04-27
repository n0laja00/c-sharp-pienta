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
            int[] iLotto = new int[8];
            Random rnd = new Random();
            int o;
            int[] iNumbers = new int[41];
            int number = 1;
            int iRandomised;

            for (int i = 0; i < iNumbers.Length; i++)
            {
                iNumbers[i] = number;
                number++;
            }

            for (int i = 0; i < iLotto.Length; i++)
            {
                iRandomised = rnd.Next(1, (41 - i));
                iLotto[i] = iNumbers[iRandomised];
                iNumbers = iNumbers.Where((source, index) => index != iRandomised).ToArray();

            }

            Array.Sort(iLotto, 0, 7);

            for (int i = 0; i < iLotto.Length; i++)
            {
                
                if (i == 7)
                {
                    Console.WriteLine("+ " + iLotto[i]);
                }
                else
                {
                    Console.Write(iLotto[i] + " ");
                }
            }
        }
    }
}
