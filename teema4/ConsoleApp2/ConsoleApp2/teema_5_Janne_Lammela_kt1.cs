using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class kt2
    {
        static int iPalautusArvo(int iArvo)
        {
            int iPalautus;
            if (iArvo >= 1)
            {
                iPalautus = 1;
            } else if (iArvo == 0){
                iPalautus = 0;
            } else
            {
                iPalautus = -1;
            }
            return iPalautus;
        }
        static void Main(string[] args)
        {
            int iArvo, iPalautus;
            bool bProsessi;

            Console.Write("Anna kokonaisluku: ");
            bProsessi = int.TryParse(Console.ReadLine(), out iArvo);
            while (bProsessi == false)
            {
                Console.WriteLine("Antamasi merkki ei ollut kokonaisluku.");
                Console.Write("Anna numero: ");
                bProsessi = int.TryParse(Console.ReadLine(), out iArvo);
            }
            iPalautus = iPalautusArvo(iArvo);
            
            switch (iPalautus)
            {
                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;
                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;
            }

        }
    }
}
