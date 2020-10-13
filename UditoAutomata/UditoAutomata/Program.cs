using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UditoAutomata
{
    class Program
    {
        static string[] NevekTMB=new string[19];
        static int[] ArakTMB = new int[19];
        static int[] DarabTMB = new int[19];
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n------------------\n");
            Feladat2(); Console.WriteLine("\n------------------\n");
            Feladat3(); Console.WriteLine("\n------------------\n");
            Feladat4(); Console.WriteLine("\n------------------\n");
            Feladat5(); Console.WriteLine("\n------------------\n");
            Feladat6(); Console.WriteLine("\n------------------\n");
            Feladat7();
            Console.ReadKey();
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat: tartalmazás kérdése");
            Console.Write("Kérem adjn meg egy szt ami a termékben van: ");
            string Reszlet = Console.ReadLine().ToLower();
            for (int i = 0; i < NevekTMB.Length; i++)
            {
                if(NevekTMB[i].ToLower().Contains(Reszlet))
                {
                    Console.WriteLine("{0}", NevekTMB[i]);
                }
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Kérjen be egy termék nevet a felhasznalotól és" +
                " keresse meg mennyibe kerül a termék");
            Console.Write("Kérem adja meg a termék nevét: ");
            string Kulcsszo = Console.ReadLine().ToLower().Replace(" ", "").Replace("-","");
            //Fapados kereső
            for (int i = 0; i < NevekTMB.Length; i++)
            {
                if (Kulcsszo == NevekTMB[i].ToLower().Replace(" ", "").Replace("-", ""))
                {
                    Console.WriteLine("{0} : {1}", NevekTMB[i], ArakTMB[i]);
                }
            }
            //keresési tétel
            int Szamlalo = 0;
            while (Szamlalo < NevekTMB.Length && Kulcsszo != NevekTMB[Szamlalo].ToLower().Replace(" ", "").Replace("-", ""))
            {
                Szamlalo++;
            }
            if (Szamlalo == NevekTMB.Length)
            {
                Console.WriteLine("Nincs ilyen termék a listában");
            }
            else
            {
                Console.WriteLine("{0} : {1}", NevekTMB[Szamlalo], ArakTMB[Szamlalo]);

            }
        }
        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: hány olyan termék volt ami 240 Ft-ba került");
            int db = 0;
            for (int i = 0; i < ArakTMB.Length; i++)
            {
                if(ArakTMB[i]==240)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi termék ára 240Ft: {0}",db);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: Határozza meg a legdrágább és a legolcsobb üditőt, névvel árral");
            int MaxAr = int.MinValue;
            string MaxNev = "cica";
            for (int i = 0; i < NevekTMB.Length; i++)
            {
                if (MaxAr < ArakTMB[i])
                {
                    MaxAr = ArakTMB[i];
                    MaxNev = NevekTMB[i];
                }
            }
            Console.WriteLine("\tA legdrágább üditő ára: {0}\n\tA legdrágább üditő: {1}", MaxAr, MaxNev);
            int MinAr = int.MaxValue;
            string MinNev = "cica0,1";
            for (int i = 0; i < NevekTMB.Length; i++)
            {
                if (ArakTMB[i] < MinAr)
                {
                    MinAr = ArakTMB[i];
                    MinNev = NevekTMB[i];
                }
            }
            Console.WriteLine("\tA legolcsóbb üditő ára: {0}\n\tA legolcsóbb üditő: {1}", MinAr, MinNev);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: bevétel");
            int Bevetel = 0;
            int OsszeBevetel =0;
            for (int i = 0; i < ArakTMB.Length; i++)
            {
                Bevetel = (25 - DarabTMB[i]) * ArakTMB[i];
                OsszeBevetel += Bevetel;
                Console.WriteLine("\t{0, -20} : {1} ", NevekTMB[i], Bevetel);
            }
            Console.WriteLine("\tAz össz bevétel: {0} Ft",OsszeBevetel) ;
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: Mennyit kell fizetni, ha minden üditővől " +
                "veszek egyet ");//Összegzési tétel
            int Szum = 0;
            for (int i = 0; i < ArakTMB.Length; i++)
            {
                Szum += ArakTMB[i];
            }
            Console.WriteLine("\tEnnyibe kerülne ha minden üditőből vennék egyet: {0}",Szum);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: Adatok feltöltése");
            NevekTMB = new string[19] { "Coca-Cola", "Coca-Cola Light", "Coca-Cola Cherry", "Fanta Narancs", "Fanta Citrom", "Cappy Alma", "Cappy Narancs", "Cappy Körte", "Naturaqua Mentes", "Naturaqua Bubis", "Nestea Citrom", "Nestea Barack", "Nestea Menta", "Monster Red", "Monster Green", "Monster Pink", "Monster Blue", "Kinley Gyömbér", "Kinley Tonik" };
            ArakTMB = new int[19] { 250, 240, 260, 240, 240, 280, 280, 280, 220, 220, 260, 260, 260, 340, 340, 340, 380, 280, 280 };
            DarabTMB = new int[19] { 8, 15, 8, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 20, 20, 20, 20, 10, 10 };
        }
    }
}
