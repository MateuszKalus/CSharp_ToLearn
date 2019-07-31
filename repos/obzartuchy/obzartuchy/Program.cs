using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obzartuchy
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosczestawow = Int32.Parse(Console.ReadLine());

            List<ZestawDanych> zestawy = new List<ZestawDanych>();

            for (int i=0; i<ilosczestawow; i++)
            {
                zestawy.Add(new ZestawDanych());

            }

            Console.WriteLine("Wyniki: ");

            for (int i = 0; i < ilosczestawow; i++)
            {
                Console.WriteLine(zestawy[i].ObliczIloscPudelek());

            }

            Console.ReadKey();
        }
    }

    class ZestawDanych
    {
        int iloscciastek = 0;
        public int ilosczawodnikow;
        public int wielkoscpudelka;
        List<Zawodnik> zawodnicy = new List<Zawodnik>();

        public ZestawDanych()
        {
            string[] ciag = Console.ReadLine().Split(' ');
            ilosczawodnikow = Int32.Parse(ciag[0]);
            wielkoscpudelka = Int32.Parse(ciag[1]);



            for (int i=0; i<ilosczawodnikow; i++)
            {
                zawodnicy.Add(new Zawodnik());
            }
        }

        public int ObliczIloscPudelek()
        {
            foreach (Zawodnik zawodnik in zawodnicy)
            {

                iloscciastek += 24 * 3600 / zawodnik.czas;

            }

            if (iloscciastek % wielkoscpudelka != 0) return iloscciastek / wielkoscpudelka + 1;
            else return iloscciastek / wielkoscpudelka;

        }
    }

    class Zawodnik
    {
        public int czas;
        public Zawodnik()
        {
            czas = Int32.Parse(Console.ReadLine());
        }
    }
}
