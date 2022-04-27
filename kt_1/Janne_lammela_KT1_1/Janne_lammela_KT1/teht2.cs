using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janne_lammela_KT1
{
    class Program
    {
        static void Main()
        {
            string sEtunimi;
            string sSukunimi;

            Console.Write("Anna Etunimi: ");
            sEtunimi = Console.ReadLine();

            Console.Write("Anna Sukunimi: ");
            sSukunimi = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nimesi on " + sEtunimi + " " + sSukunimi);
        }
    }
}
