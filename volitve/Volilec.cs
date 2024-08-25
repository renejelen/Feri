using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volitve
{
    public class Volilec
    {
        public string ime {  get; set; }
        public int starost { get; set; }
        public Kandidat glas { get; set;}
        public char spol { get; set; }

        public Volilec(string ime, int starost, Kandidat glas, char spol)
        {
            this.ime = ime;
            this.starost = starost;
            this.glas = glas;
            this.spol = spol;
        }
    }
}
