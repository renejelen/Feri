using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public class LoterijaSlovenije
    {
        public List<Loterija> loterijeSlovenije = new List<Loterija>();

        public void zrebNajvecjiSklad(List<Zreb> seznamZrebov)
        {
            var najvecjiSklad = seznamZrebov.OrderByDescending(s => s.dobitniSklad).FirstOrDefault();
        }

        public void izvedeniZrebi(List<Zreb> seznamZrebov)
        {
            var izvedeniZrebi = seznamZrebov.Where(s => s.casovniZigZreba < DateTime.Now).ToList();
        }

        public void najpogostejsaStevila(Zreb zrebSlo)
        {
            var najpogostejsaStevila = zrebSlo.vplacaneKombinacije.SelectMany(k => k.izbranaStevila).GroupBy(s => s).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
        }
    }
}
