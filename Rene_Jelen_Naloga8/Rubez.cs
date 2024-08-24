using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rene_Jelen_Naloga8
{
    public class Rubez
    {
        public void PrijaviSeNaObvestilo(Banka banka)
        {
            banka.obvestiRubez += PrejmiObvestilo;
        }

        public void PrejmiObvestilo(string message, string additionalInfo)
        {
            Console.WriteLine($"Rubez prejme obvestilo: {message} {additionalInfo}");
        }
    }
}
