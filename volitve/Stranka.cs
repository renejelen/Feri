using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volitve
{
    public class Stranka
    {
        public string ime {  get; set; }
        public List<Kandidat> kandidati {  get; set; }

        public Stranka(string ime, List<Kandidat> kandidati)
        {
            this.ime = ime;
            this.kandidati = kandidati;
        }
    }
}
