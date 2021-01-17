using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Union_Except_Intersect
{
    class Student
    {
        private string ime;
        private int godiste;
        private string brIndeksa;
        private double prosecnaOcena;

        public string Ime { get => ime; set => ime = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string BrIndeksa { get => brIndeksa; set => brIndeksa = value; }
        public double ProsecnaOcena { get => prosecnaOcena; set => prosecnaOcena = value; }


        public Student(string ime, int godiste, string brIndeksa, double prosecnaOcena)
        {
            this.ime = ime;
            this.godiste = godiste;
            this.brIndeksa = brIndeksa;
            this.prosecnaOcena = prosecnaOcena;
        }

        public override string ToString()
        {
            return "Student " + ime + ", " + brIndeksa + " ima srednju ocenu: " + prosecnaOcena;
        }
    }
}
