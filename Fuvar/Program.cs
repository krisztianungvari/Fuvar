using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fuvar
{
    class Program
    {
        static List<Fuvar> fuvarok = new List<Fuvar>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat03();
            Feladat04();
            Feladat05();
            Feladat06();
            Feladat07();
            Feladat08();

            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }

        private static void Feladat08()
        {
            Console.WriteLine("8.feladat: hibak.txt");
        }

        private static void Feladat07()
        {
            double leghosszabb = 0;
            int ujid = 0;
            double ujtav = 0;
            double ujviteldij = 0;
            Console.WriteLine("7. feladat: Leghosszabb fuvar:\t");
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Idotartam > leghosszabb)
                {
                    leghosszabb = fuvar.Idotartam;
                    ujid = fuvar.Taxi_id;
                    ujtav = fuvar.Tavolsag;
                    ujviteldij = fuvar.Viteldij;
                }
            }
            Console.WriteLine($"\tFuvar hossza: {leghosszabb} másodperc");
            Console.WriteLine($"\tTaxi azonosítója: {ujid}");
            Console.WriteLine($"\tMegtett táv: {ujtav:F1} km");
            Console.WriteLine($"\tViteldíj: {ujviteldij}$");

        }

        private static void Feladat06()
        {
            double osszkm = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                    osszkm += fuvar.Tavolsag * 1.6;   
            }
            Console.WriteLine($"6. feladat: {osszkm:F2} km");

        }

        private static void Feladat05()
        {
            Console.WriteLine("5. feladat:\t");
            int bk = 0;
            int kp = 0;
            int ismeretlen = 0;
            int free = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Fizetesmod == "bankkártya")
                {
                    bk++;
                }
                if (fuvar.Fizetesmod == "készpénz")
                {
                    kp++;
                }
                if (fuvar.Fizetesmod == "ingyenes")
                {
                    free++;
                }
                if (fuvar.Fizetesmod == "ismeretlen")
                {
                    ismeretlen++;
                }
              
            }
            Console.WriteLine($"\tbankkártya: {bk} fuvar");
            Console.WriteLine($"\tkészpénz: {kp} fuvar");
            Console.WriteLine($"\tingyenes: {free} fuvar");
            Console.WriteLine($"\tismeretlen: {ismeretlen} fuvar");
            
        }

        private static void Feladat04()
        {
            int utazasok = 0;
            double bevetel = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Taxi_id == 6185)
                {
                    bevetel += fuvar.Viteldij;
                    utazasok++;
                }
            }
            Console.WriteLine($"4. feladat: {utazasok} fuvar alatt {bevetel} $");
        }

        private static void Feladat03()
        {
            Console.WriteLine($"3. feladat: {fuvarok.Count} fuvar");
        }

        private static void Beolvasas()
        {
            foreach (string  fuvar in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(fuvar));
            }
        }
    }
}
