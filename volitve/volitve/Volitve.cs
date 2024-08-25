using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volitve
{
    public class Volitve
    {
        public List<Stranka> strankaList { get; set; }
        public List<Kandidat> kandidatList { get; set; }
        public List<Volilec> volilecList { get; set; }

        public Volitve(List<Stranka> strankaList, List<Kandidat> kandidatList, List<Volilec> volilecList)
        {
            this.strankaList = strankaList;
            this.kandidatList = kandidatList;
            this.volilecList = volilecList;
        }

        public List<Volilec> volilniUpravicenci()
        {
            return volilecList.Where(v => v.starost >= 18).ToList();
        }

        public void najstarejsiKandidat()
        {
            var najstarejsiKandidat = kandidatList.OrderByDescending(k =>  k.starost).FirstOrDefault();
            if(najstarejsiKandidat != null)
            {
                Console.WriteLine($"\nNajstarejsi kandidat: {najstarejsiKandidat.ime}, {najstarejsiKandidat.starost}");
            }
        }

        public void kandidatIzbrStranke(Stranka stranka)
        {
            var izbranKandidat = kandidatList.Where(k => k.stranka.ime == stranka.ime).ToList();

            Console.WriteLine($"\nKandidati stranke {stranka.ime}:");
            foreach (Kandidat k in izbranKandidat)
            {
                Console.WriteLine($"{k.ime}, {k.stranka.ime}");
            }
        }

        public void izvedba()
        {
            Random rand = new Random();
            Console.WriteLine("\nRezultati volitev:");
            foreach (Volilec v in volilniUpravicenci())
            {
                v.glas = kandidatList[rand.Next(kandidatList.Count)];
                v.glas.steviloGlasov++;
                Console.WriteLine($"Volilec {v.ime} je glasoval za {v.glas.ime} {v.glas.stranka.ime}");
            }
        }

        public void rezultati()
        {
            var steviloGlasov = volilecList.Count(v => v.glas != null);
            Console.WriteLine("\nRezultati volitev:");

            foreach(Kandidat kandidat in kandidatList.OrderByDescending(k => k.steviloGlasov)) 
            {
                double procentniDelez = (double)kandidat.steviloGlasov / steviloGlasov*100;
                Console.WriteLine($"{kandidat.ime} ({kandidat.stranka.ime}): {kandidat.steviloGlasov}");
            }
        }

        public void udelezba()
        {
            double udelezba = (double)volilecList.Count(v => v.glas != null) / volilecList.Count * 100;
            Console.WriteLine($"\nUdelezba na volitvah: {udelezba:F2}%");
        }

        public void delezPosameznegaSpola()
        {
            var zmagovalec = kandidatList.OrderByDescending(c => c.steviloGlasov).First();
            var moskiVolilci = volilecList.Count(v => v.glas.ime == zmagovalec.ime && v.spol == 'M');
            var zenskiVolilci = volilecList.Count(v => v.glas.ime == zmagovalec.ime && v.spol == 'Z');
            var volilciZmagovalca = moskiVolilci + zenskiVolilci;

            double malePercentage = (double)moskiVolilci / volilciZmagovalca * 100;
            double femalePercentage = (double)zenskiVolilci / volilciZmagovalca * 100;

            Console.WriteLine($"\nZmagovalec: {zmagovalec.ime}");
            Console.WriteLine($"Moski volilci zmagovalca: {malePercentage:F2}%");
            Console.WriteLine($"Zenski volilci zmagovalca: {femalePercentage:F2}%");
        }

        public void beriIzDatoteke(string path)
        {
            var lines = File.ReadAllLines(path);
            Stranka currStranka = null;

            foreach (var line in lines) 
            {
                if(line.StartsWith("Party:"))
                {
                    string imeStranke = line.Substring(6).Trim();
                    currStranka = new Stranka(imeStranke, kandidatList);
                }

                else if(line.StartsWith("Candidate:"))
                {
                    var podatkiKandidata = line.Substring(10).Split(',');
                    var kandidat = new Kandidat(podatkiKandidata[0].Trim(), int.Parse(podatkiKandidata[1].Trim()), currStranka);
                }

                else if(line.StartsWith("Voter:"))
                {
                    var podatkiVolilca = line.Substring(16).Split(",");
                    Volilec volilec = new Volilec(podatkiVolilca[0].Trim(), int.Parse(podatkiVolilca[1].Trim()), null, char.Parse(podatkiVolilca[3].Trim()));
                }
            }
        }
    }
}
