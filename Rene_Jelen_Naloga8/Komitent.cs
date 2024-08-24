using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rene_Jelen_Naloga8
{
    public class Komitent
    {
        private string _ime;
        public string ime { get { return _ime; } set { _ime = value; } }

        private string _priimek;
        public string priimek { get { return _priimek; } set { _priimek = value; } }

        private double _stanje;
        public double stanje { get { return _stanje; } set { _stanje = value; } }

        private double _kredit;
        public double kredit { get { return _kredit; } set { _kredit = value; } }

        public event Obvestilo? uspesnoObvestilo;
        public event Obvestilo? neuspesnoObvestilo;

        public Komitent(string ime, string priimek, double stanje, double kredit)
        {
            _ime = ime;
            _priimek = priimek;
            _stanje = stanje;
            _kredit = kredit;
        }

        public void PrijaviSeNaObvestilo(Obvestilo uspesnoObvestilo, Obvestilo neuspesnoObvestilo)
        {
            uspesnoObvestilo += uspesnoObvestilo;
            neuspesnoObvestilo += neuspesnoObvestilo;
        }

        public void PrejmiUspesnoObvestilo(string message, string additionalInfo)
        {
            uspesnoObvestilo?.Invoke(message, additionalInfo);
        }

        public void PrejmiNeuspesnoObvestilo(string message, string additionalInfo)
        {
            neuspesnoObvestilo?.Invoke(message, additionalInfo);
        }

        public void ZmanjsajStanje(double znesek)
        {
            stanje -= znesek;
            kredit -= znesek;
        }
    }
}
