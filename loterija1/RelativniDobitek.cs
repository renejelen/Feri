using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class RelativniDobitek : Dobitek
    {
        public override int steviloIzzrebanih { get; set; }
        public int odstotekDobitka { get; set; }
    }
}
