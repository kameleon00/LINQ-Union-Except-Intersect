using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Union_Except_Intersect
{
    class Predmeti
    {
        private string naziv;
        private int semestar;
        private string indeksPolozenog;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public int Semestar
        {
            get { return semestar; }
            set { semestar = value; }
        }
        public string IndeksPolozenog
        {
            get { return indeksPolozenog; }
            set { indeksPolozenog = value; }
        }
        public Predmeti(string n, int s, string i)
        {
            naziv = n;
            semestar = s;
            indeksPolozenog = i;
        }
        public override string ToString()
        {
            return "Predmet " + naziv + " iz " + semestar + ". " + ". Indeks studenta koji je polozio ovaj predmet: " + indeksPolozenog;
        }
    }
}
