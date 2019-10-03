using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsFormTest
{
    class Ksiazka
    {
        public Ksiazka(string tytul, string autor, int rok, double cena)
        {
            Id = licznikId + 1;
            Tytul = tytul;
            Autor = autor;
            Rok = rok;
            Cena = cena;
            licznikId++;
            
        }
        public static int licznikId = 0;
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }
        public double Cena { get; set; }
    }
}
