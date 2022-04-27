using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janne_lammela_kt1_4
{
    class Program
    {
        static void Main()
        {
            int iPaino;
            double dPituus;
            string sNimi;

            Console.WriteLine("Tervetuloa BMI laskuriin! Paina Enteriä jatkaaksesi!");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Console.Clear();

            Console.Write("Anna nimesi: ");
            sNimi = Console.ReadLine();

            Console.Write("Anna painosi kilon tarkkuudella: ");
            iPaino = int.Parse(Console.ReadLine());



            Console.Write("Anna pituutesi metreinä: ");
            dPituus = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(sNimi + ", pituutesi on: " + dPituus + " ja painosi on " + iPaino);
            Console.WriteLine("BMI-arvonne on: " + iPaino / Math.Pow(dPituus, 2));
        }
    }
}
