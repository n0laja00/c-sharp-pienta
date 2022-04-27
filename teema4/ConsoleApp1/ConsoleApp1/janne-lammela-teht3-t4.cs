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
            Console.WriteLine("Anna pitkä lause");
            string sLause = Console.ReadLine();

            sLause = sLause.ToUpper();
            Console.WriteLine(sLause);
            sLause = sLause.Replace("A", "!");
            Console.WriteLine(sLause);
            sLause = sLause.Replace(" ", "");
            Console.WriteLine(sLause);

            StringBuilder uusiLause = new StringBuilder(sLause.Length * 2);
            uusiLause.Append(sLause[0]);
            for (int i = 1; i < sLause.Length; i++)
            {
                uusiLause.Append(' ');
                uusiLause.Append(sLause[i]);
            }
            uusiLause.ToString();
            Console.WriteLine(uusiLause);
        }
    }
}
