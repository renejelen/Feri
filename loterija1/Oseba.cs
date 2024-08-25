using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class Oseba
    {
        public string ime {  get; set; }
        public string priimek { get; set; }

        public Oseba(string Ime, string Priimek) 
        {
            ime = Ime;
            priimek = Priimek;
        }
    }
}
