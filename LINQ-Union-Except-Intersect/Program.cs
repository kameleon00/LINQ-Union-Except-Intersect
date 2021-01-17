using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Union_Except_Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            /*U nastavku zadatka definisati klasu Predmeti i kolekciju predmeta. 
            Zatim ispisati brojeve indeksa studenata koji su položili odreĎene predmete, studente koji nisu položili
            nijedan predmet i ispisati sve brojeve indeksa iz kolekcije studenti i predmeti. Zatim primenom
            join upita ispisati osnovne podatke o studentima koji su položili predmete iz kolekcije predmeti.*/


            List<Predmeti> predmeti = new List<Predmeti>()
            {
                new Predmeti("OOP", 3, "213/2016"),
                new Predmeti("BP", 3, "114/2015"),
                 new Predmeti("IPA", 5, "309/2014"),
                 new Predmeti("PA", 3, "19/2015"),
                 new Predmeti("PPP", 5, "82/2014"),
                 new Predmeti("PRV", 6, "155/2013"),
                 new Predmeti("EP", 3, "68/2016"),
                 new Predmeti("OOP", 3, "55/2016"),
                 new Predmeti("BP", 3, "132/2014"),
                 new Predmeti("PA", 3, "68/2016"),
                 new Predmeti("EP", 3, "158/2016"),
                 new Predmeti("PA", 3, "387/2016"),
                 new Predmeti("PPP", 3, "258/2016")
            };
            List<Student> stud = new List<Student>()
            {
                new Student("Mika", 1997, "210/2016", 9),
                new Student("Pera", 1996, "132/2014", 7.8),
                new Student("Marko", 1995, "98/2013", 6.12),
                 new Student("Nikola", 1998, "106/2016", 8.80),
                 new Student("Sara", 1995, "301/2013", 9.7),
                 new Student("Sanja", 1994, "489/2013",7.00),
                 new Student("Milos", 1998, "68/2016", 10),
                 new Student("Nemanja", 1994, "155/2013", 8.6),
                 new Student("Zika", 1998, "55/2016", 6.70),
                new Student("Uros", 1998, "158/2016", 9.50),
            };

            var indeksiStudenata = from i in stud
                                   select i.BrIndeksa;   //IZ KLASE STUDENT
            var indeksiPredmeta = from ip in predmeti
                                  select ip.IndeksPolozenog;  //IZ KLASE PREDMETI


            var jesuPolozili = indeksiPredmeta.Intersect(indeksiStudenata); //a. Intersect() izdvaja podatke koji su zajednički za više kolekcija.
                Console.WriteLine("Indeksi studenata koji su polozili predmet su: ");
            foreach (var s in jesuPolozili)
                Console.WriteLine(s);
            Console.WriteLine("==================================================");

            var nisuPolozili = indeksiPredmeta.Except(indeksiStudenata); //. Except() izdvaja elemente koji se nalaze u jednoj, a ne nalaze u drugoj kolekciji.
            Console.WriteLine("Indeksi studenata koji nisu polozili nijedan predmet su:");
           foreach (var s in nisuPolozili)
                Console.WriteLine(s);
            Console.WriteLine("==================================================");

            var sviIndeksi = indeksiPredmeta.Union(indeksiStudenata); //Union() operator se koristi da se izdvoje jedinstveni podaci koji su zajednički za više kolekcija.
            Console.WriteLine("Indeksi svih studenata: ");
            foreach (var s in sviIndeksi)
                Console.WriteLine(s);
            Console.WriteLine("==================================================");


            var rez = from s in stud
                      join p in predmeti on s.BrIndeksa equals p.IndeksPolozenog
                      select new
                      {
                          s.BrIndeksa,
                          s.Ime,
                          s.Godiste,
                          s.ProsecnaOcena,
                          p.Naziv
                      };
            Console.WriteLine("Podaci o studentima koji su položili predmet:");
            foreach (var student in rez)
                Console.WriteLine(student);
            Console.ReadKey();
        }
    }
}
