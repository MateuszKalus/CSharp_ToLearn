using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA05_BIB_spoj
{
    class Program
    {
        static int Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            List<string[]> listazmiennych = new List<string[]>();

            for (int u = 0; u < iterations; u++)
            {
                string los = Console.ReadLine();
                string[] napis = Console.ReadLine().Split(' ');


                listazmiennych.Add(napis);



                //= Console.ReadLine().Split(' ');
            }



            for (int i = 0; i < iterations; i++)
            {
                //string repeats = Console.ReadLine();
                string[] zmienna = listazmiennych[i];

                List<PozycjanaLiscie> cartvalue = new List<PozycjanaLiscie>();
                //ZlozenieKart zlozenie = new ZlozenieKart();
                List<PozycjanaLiscie> results = new List<PozycjanaLiscie>();

                for (int k = 0; k < zmienna.Length; k++)
                {
                    cartvalue.Add(new PozycjanaLiscie(k, int.Parse(zmienna[k])));
                }



                while (cartvalue.Count != 1)
                {
                    cartvalue.Sort();
                    //Console.WriteLine(cartvalue[0].numer);
                    if (cartvalue[0].Numer > cartvalue[1].Numer)
                    {
                        results.Add(new PozycjanaLiscie(cartvalue[1].Numer + 1, cartvalue[0].Numer + 1));
                    }
                    else
                    {
                        results.Add(new PozycjanaLiscie(cartvalue[0].Numer + 1, cartvalue[1].Numer + 1));
                    }
                    //results.Add(new PozycjanaLiscie(cartvalue[0].Numer+1, cartvalue[1].Numer+1));
                    //Console.WriteLine($"{results[0].numer} {results[0].wartosc}");

                    




                        if (cartvalue[0].Numer > cartvalue[1].Numer)
                        {
                            cartvalue[1].Zlozenie(cartvalue[0]);

                            cartvalue.RemoveAt(0);
                        }
                        else
                        {
                            cartvalue[0].Zlozenie(cartvalue[1]);

                            cartvalue.RemoveAt(1);
                        }
                    

                    //repeats += 1;
                }
                Console.WriteLine(PozycjanaLiscie.czas);
                PozycjanaLiscie.czas = 0;


                foreach (var item in results)
                {
                    if (item.wartosc > item.Numer) Console.WriteLine($"{item.Numer} { item.wartosc}");
                    else Console.WriteLine($"{item.wartosc} {item.Numer}");
                }




                //Console.ReadLine();
            }



            return 0;
        }
    }

    class ZlozenieKart
    {
        public ZlozenieKart(PozycjanaLiscie poz1, PozycjanaLiscie poz2)
        {

        }

    }



    //}

    class PozycjanaLiscie : IComparable
    {
        private int numer;
        public int Numer
        {
            get
            {
                return numer;

            }
            set
            {
                numer = value;
            }
        }
        public int wartosc { get; private set; }

        public static int czas = 0;
        public PozycjanaLiscie(int nr, int val)
        {
            numer = nr;// +1, żeby na liście pierwszy dodany element miał numer 1, a nie 0
            wartosc = val;
        }

        public void Zlozenie(PozycjanaLiscie drugi)
        {
            wartosc = wartosc + drugi.wartosc;
            czas += wartosc;
        }


        public int CompareTo(object obj)
        {
            var arg = (PozycjanaLiscie)obj;

            if (wartosc > arg.wartosc)
                return 1;
            else if (wartosc == arg.wartosc)
                return 0;
            else return -1;
        }
    }
}

