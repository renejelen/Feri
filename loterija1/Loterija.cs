using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class Loterija
    {
        event LoterijaObvestilo noviIzzrebi;

        public string ime {  get; set; }
        public int maksimalniSklad {  get; set; }
        public List<Zreb> seznamZrebanj = new List<Zreb>();
        public List<SkupekStevil> naborStevil = new List<SkupekStevil>();
        public int steviloIzzrebanihSt {  get; set; }
        public int cenaKombinacije {  get; set; }
        public List<Dobitek> dobitki =  new List<Dobitek>();
        public int garantiranSklad { get; set; }

        public Loterija()
        {
            ime = "";
            maksimalniSklad = 0;
            seznamZrebanj = new List<Zreb>();
            naborStevil = new List<SkupekStevil>();
            steviloIzzrebanihSt = 0;
            cenaKombinacije = 0;
            dobitki = new List<Dobitek>();
            garantiranSklad = 0;
        }
        public Loterija(string ime, int maksimalniSklad, List<Zreb> seznamZrebanj, List<SkupekStevil> naborStevil, int steviloIzzrebanihSt, int cenaKombinacije, List<Dobitek> dobitki, int garantiranSklad)
        {
            this.ime = ime;
            this.maksimalniSklad = maksimalniSklad;
            this.seznamZrebanj = seznamZrebanj;
            this.naborStevil = naborStevil;
            this.steviloIzzrebanihSt = steviloIzzrebanihSt;
            this.cenaKombinacije = cenaKombinacije;
            this.dobitki = dobitki;
            this.garantiranSklad = garantiranSklad;
        }
    }
}
