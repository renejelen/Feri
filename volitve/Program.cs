using System;
using volitve;

namespace volitve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kandidat> kandidati = new List<Kandidat>();

            Stranka stranka1 = new Stranka("NZS", kandidati);
            Stranka stranka2 = new Stranka("Svoboda", kandidati);

            List<Stranka> stranke = new List<Stranka>();

            stranke.Add(stranka1);
            stranke.Add(stranka2);

            Kandidat kandidat1 = new Kandidat("Franc", 40, stranka1);
            Kandidat kandidat2 = new Kandidat("Saša", 53, stranka2);

            kandidati.Add(kandidat1);
            kandidati.Add(kandidat2);


            Volilec volilec1 = new Volilec("Rene", 20, kandidat1, 'M');
            Volilec volilec2 = new Volilec("Cvetka", 19, kandidat1, 'Z');

            List<Volilec> volilci = new List<Volilec>();
            volilci.Add(volilec1); 
            volilci.Add(volilec2);

            Volitve volitve = new Volitve(stranke, kandidati, volilci);

            foreach(Stranka stranka in stranke)
            {
                Console.WriteLine($"Stranka {stranka.ime} in njeni kandidati:");
                foreach(Kandidat kandidat in stranka.kandidati)
                {
                    Console.WriteLine($"Ime: {kandidat.ime}, Starost: {kandidat.starost}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Volilci nad 18 let starosti:");
            foreach (Volilec volilec in volitve.volilniUpravicenci()) 
            {
                Console.WriteLine($"{volilec.ime}, {volilec.starost}");
            }

            volitve.najstarejsiKandidat();
            volitve.kandidatIzbrStranke(stranka2);
            volitve.izvedba();
            volitve.rezultati();
            volitve.udelezba();
            volitve.delezPosameznegaSpola();
        }
    }
}