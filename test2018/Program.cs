using System;

namespace test2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Igralec igralec1 = new Igralec();
            Igralec igralec2 = new Igralec("rene","jelen",2004);
            Igralec igralec3 = new Igralec("mario", "luigi", 1997);

            List<Igralec> igralci = new List<Igralec>();
            igralci.Add(igralec1);
            igralci.Add(igralec2);
            igralci.Add(igralec3);

            Trener trener1 = new Trener();
            Trener trener2 = new Trener("Nejc","Kocmut");

            Ekipa ekipa1 = new Ekipa();
            Ekipa ekipa2 = new Ekipa(igralci, trener2, "NK Maribor");

            ekipa1.dodajIgralca(igralec2);
            ekipa1.dodajIgralca(igralec3);

            ekipa2.odstraniIgralca(igralec1);

            Console.WriteLine("Povprecna starost ekipe: " + ekipa1.starostEkipe());
            Console.Write("Igralci NK Maribor: ");
            Console.WriteLine(ekipa2.izpisEkipe());

            string path = @"/vse_ekipe.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"ekipa1, {trener2.ime} {trener2.priimek}, {ekipa1.izpisEkipe()}");
            }
        }
    }
}