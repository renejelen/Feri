using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2018
{
    public class Trener
    {
        public string ime {  get; set; }
        public string priimek { get; set; }

        public Trener() 
        {
            ime = "";
            priimek = "";
        }

        public Trener(string ime, string priimek)
        {
            this.ime = ime;
            this.priimek = priimek;
        }
    }
}
