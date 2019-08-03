using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _276_dp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napis = Console.ReadLine().Split(' ');

            Dane data = new Dane(Int32.Parse(napis[0]), Int32.Parse(napis[1]));

            data.Licz();

            Console.WriteLine(Dane.licznik);
            Console.ReadKey();
        }
    }

    class Dane
    {
        public static int licznik = 0;

        public int Year { get; private set; }
        public int ToYear { get; private set; }

        public Dane(int x, int y)
        {
            Year = x;
            ToYear = y;
        }

        public void Licz()
        {

            for (int i = Year; i <= ToYear; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 900 == 200 || i % 900 == 600)
                        {
                            licznik += 1;
                        }
                        else licznik += 0;
                    }
                    else licznik += 1;

                }
                else licznik += 0;
            }
        }
    }
}
