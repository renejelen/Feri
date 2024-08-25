using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class DobitnaKombinacija : Kombinacija
    {
        public int vrednostDobitka {  get; set; }
        public int steviloIzrebanihSt {  get; set; }
        public List<int> izrebanaStevila = new List<int>();
    }
}
