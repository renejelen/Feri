using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2018
{
    public class Igralec
    {
        public string ime {  get; set; }
        public string priimek { get; set; }
        public int letoRojstva { get; set; }

        public Igralec()
        {
            ime = "";
            priimek = "";
            letoRojstva = 0;
        }

        public Igralec(string ime, string priimek, int letoRojstva)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.letoRojstva = letoRojstva;
        }
    }
}
