using System;
using System.Collections.Generic;
using Rene_Jelen_Naloga8;

public delegate void Obvestilo(string message, string additionalInfo);

class Program
{
    static void Main()
    {
        Komitent ana = new Komitent("Ana", "Novak", 900, 1000);
        Komitent boris = new Komitent("Boris", "Kranjc", 1000, 1500);

        Banka banka = new Banka("Nova Banka");
        banka.DodajKomitenta(ana);
        banka.DodajKomitenta(boris);

        Rubez rubez = new Rubez();
        rubez.PrijaviSeNaObvestilo(banka);

        banka.uspesenObrok += (message, additionalInfo) => Console.WriteLine(message);
        banka.neuspesenObrok += (message, additionalInfo) => Console.WriteLine(message);

        banka.PoberiObrok(ana, 500);
        banka.PoberiObrok(boris, 500);
        banka.PoberiObrok(ana, 500);
    }
}