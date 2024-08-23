using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2018
{
    public class Ekipa
    {
        public List<Igralec> igralci = new List<Igralec>();
        public Trener trenerEkipe = new Trener();
        public string imeEkipe {  get; set; }

        public Ekipa() 
        {
            igralci = new List<Igralec>();
            trenerEkipe = new Trener();
            imeEkipe = "";
        }

        public Ekipa(List<Igralec> igralci, Trener trenerEkipe, string imeEkipe)
        {
            this.igralci = igralci;
            this.trenerEkipe = trenerEkipe;
            this.imeEkipe = imeEkipe;
        }

        public void dodajIgralca(Igralec dodanIgralec)
        {
            igralci.Add(dodanIgralec);
        }

        public void odstraniIgralca(Igralec izbranIgralec)
        {
            igralci.RemoveAll(i => i.ime == izbranIgralec.ime && i.priimek == izbranIgralec.priimek);
        }

        public double starostEkipe() 
        {
            int currYear = DateTime.Now.Year;
            return igralci.Average(i => currYear - i.letoRojstva);
        }

        public string izpisEkipe()
        {
            string igralciString = "";
            foreach (Igralec igralec in igralci) 
            {
                igralciString += igralec.ime + " " + igralec.priimek + ", ";
            }

            igralciString = igralciString.TrimEnd(',', ' ');
            return igralciString;
        }
    }
}
