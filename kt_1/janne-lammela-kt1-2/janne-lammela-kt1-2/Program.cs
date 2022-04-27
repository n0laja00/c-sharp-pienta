using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt1_2
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
