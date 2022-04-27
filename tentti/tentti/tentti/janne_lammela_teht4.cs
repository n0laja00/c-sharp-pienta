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
            double dTMT = 32.68;
            int iP = 20;
            double dLapsiKorko = 0;
            bool bOnnistui;
            int iLapsiMaara = 0;
            double dTEP = 4.78;
            double dTEPTulo = 0;
            int iTEP = 0;
            string sVanhemmat = "s";

            bool stop = false;

            while (stop == false)
            {

                Console.WriteLine("Kuinka monta lasta sinulla on? Jos 0, anna 0.");
                bOnnistui = int.TryParse(Console.ReadLine(), out iLapsiMaara);
                while (bOnnistui == false)
                {
                    Console.WriteLine("Anna kokonaisluku");
                    Console.WriteLine("Kuinka monta lasta sinulla on? Jos 0, anna 0.");
                    bOnnistui = int.TryParse(Console.ReadLine(), out iLapsiMaara);
                }
                if (iLapsiMaara == 1)
                {
                    dLapsiKorko = 5.27;
                }
                else if (iLapsiMaara == 2)
                {
                    dLapsiKorko = 7.74;
                }
                else if (iLapsiMaara >= 3)
                {
                    dLapsiKorko = 9.98;
                }
                else
                {

                }

                dTMT = dTMT + dLapsiKorko;

                bOnnistui = false;

                Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistämiin palveluihin?");
                bOnnistui = int.TryParse(Console.ReadLine(), out iTEP);
                while (bOnnistui == false)
                {
                    Console.WriteLine("Anna kokonaisluku");
                    Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistämiin palveluihin?");
                    bOnnistui = int.TryParse(Console.ReadLine(), out iTEP);
                }

                if (iTEP > 0)
                {
                    dTEPTulo = iTEP * dTEP;
                }

                Console.WriteLine("Kuinka paljon olet tienannut tässä kuussa?");
                int ipalkka = 0;

                bOnnistui = int.TryParse(Console.ReadLine(), out ipalkka);

                double dTuloArvio = dTMT * iP + dTEPTulo;

                while (bOnnistui == false)
                {
                    Console.WriteLine("Anna kokonaisluku");
                    Console.WriteLine("Kuinka paljon olet tienannut tässä kuussa?");
                    bOnnistui = int.TryParse(Console.ReadLine(), out ipalkka);
                }
                if (ipalkka > 300)
                {
                    double dVahennys = ipalkka - 300;
                    dVahennys = dVahennys * 0.50;
                    dTuloArvio = dTuloArvio - dVahennys;
                }

                Console.WriteLine("Asutko vanhempiesi luona? (k/e)");
                sVanhemmat = Console.ReadLine();
                sVanhemmat = sVanhemmat.ToLower();
                if (sVanhemmat.Contains("e") || sVanhemmat.Contains("k"))
                {
                    bOnnistui = true;
                    if (sVanhemmat.Contains("k"))
                    {
                        dTuloArvio = dTuloArvio - dTuloArvio / 100 * 50;
                    }
                }
                else
                {
                    bOnnistui = false;
                }

                while (bOnnistui == false)
                {

                    Console.WriteLine("Yritä uudelleen.");
                    Console.WriteLine("Asutko vanhempiesi luona? (k/e)");
                    sVanhemmat = Console.ReadLine();
                    sVanhemmat = sVanhemmat.ToLower();
                    if (sVanhemmat.Contains("e") || sVanhemmat.Contains("k"))
                    {
                        bOnnistui = true;
                        if (sVanhemmat.Contains("k"))
                        {
                            dTuloArvio = dTuloArvio - dTuloArvio / 100 * 50;
                        }
                    }

                }


                Console.WriteLine("Lapsien määrä: " + iLapsiMaara);
                Console.WriteLine("Olet osallistunut työllistymistä edistäviin palveluihin: " + iTEP + " päivän verran.");
                Console.WriteLine("Asutko vanhempiesi luona (k/e): " + sVanhemmat);
                Console.WriteLine("Saat työmarkkinatukea noin: " + dTuloArvio + " Euroa kuussa.");

                string alusta;
                Console.WriteLine("Haluatko aloittaa alusta uusilla tiedoilla? (k/e)");
                alusta = Console.ReadLine();
                alusta = sVanhemmat.ToLower();
                if (alusta.Contains("e") || alusta.Contains("k"))
                {
                    bOnnistui = true;
                    if (alusta.Contains("e"))
                    {
                        stop = true;
                    }
                }
                else
                {
                    bOnnistui = false;
                }
                while (bOnnistui == false)
                {

                    Console.WriteLine("Yritä uudelleen.");
                    Console.WriteLine("Haluatko aloittaa alusta uusilla tiedoilla? (k/e)");
                    alusta = Console.ReadLine();
                    alusta = alusta.ToLower();
                    if (alusta.Contains("e") || alusta.Contains("k"))
                    {
                        bOnnistui = true;
                        if (alusta.Contains("e"))
                        {
                            stop = true;
                        }
                    }

                }
            }
        }
    }
}
