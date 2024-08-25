using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class Zreb : IZreb
    {
        public DateTime casovniZigZreba {  get; set; }
        public bool izveden {  get; set; }
        public List<Kombinacija> vplacaneKombinacije = new List<Kombinacija>();
        public int dobitniSklad {  get; set; }
        public List<DobitnaKombinacija> dobitneKombinacije = new List<DobitnaKombinacija> ();
        public int koncniSaldo {  get; set; }
        public List<int> izzrebanaStevila = new List<int> ();

        public void vplaciloKombinacije(Kombinacija kombinacija)
        {
            vplacaneKombinacije.Add(kombinacija);
        }

        public void nakljucnaVplacila()
        {
            throw new NotImplementedException();
        }

        public void priprava(DateTime datumZreba)
        {
            casovniZigZreba = datumZreba;
        }

        public void izvedba()
        {
            throw new NotImplementedException();
        }
    }
}
