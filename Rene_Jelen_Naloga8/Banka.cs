using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rene_Jelen_Naloga8
{
    public class Banka
    {
        private string _naziv;
        public string naziv { get { return _naziv; } set { _naziv = value; } }

        private List<Komitent> _komitent;
        public List<Komitent> komitenti { get { return _komitent; } set { _komitent = value; } }

        public event Obvestilo? uspesenObrok;
        public event Obvestilo? neuspesenObrok;
        public event Obvestilo? obvestiRubez;

        public Banka(string naziv)
        {
            _naziv = naziv;
            _komitent = new List<Komitent>();
        }

        public void DodajKomitenta(Komitent komitent)
        {
            komitenti.Add(komitent);
        }

        public void PoberiObrok(Komitent komitent, double obrok)
        {
            if (komitent.stanje >= obrok)
            {
                komitent.ZmanjsajStanje(obrok);
                uspesenObrok?.Invoke($"{komitent.ime} {komitent.priimek} prejme obvestilo: Pobrali smo vam obrok - Vrednost obroka: {obrok} €. Vase stanje je: {komitent.stanje} €.", "");
            }
            else
            {
                neuspesenObrok?.Invoke($"{komitent.ime} {komitent.priimek} prejme obvestilo: Obrok neuspesen - Vase stanje je prenizko: {komitent.stanje} €, obrok je {obrok}€.", "");
                obvestiRubez?.Invoke($"Neuspesno placilo obroka - Komitent {komitent.ime} {komitent.priimek} ni placal obroka.", "Prosim, odpeljite mu avto.");
            }
        }
    }
}
