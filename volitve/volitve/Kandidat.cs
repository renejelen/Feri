using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volitve
{
    public class Kandidat
    {
        public string ime {  get; set; }
        public int starost { get; set; }
        public Stranka stranka { get; set; }
        public int steviloGlasov { get; set; }

        public Kandidat(string ime, int starost, Stranka stranka)
        {
            this.ime = ime;
            this.starost = starost;
            this.stranka = stranka;
        }
    }
}
