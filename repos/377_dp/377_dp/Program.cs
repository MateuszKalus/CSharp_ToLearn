using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _377_dp
{

    class Program
    {

        static void Main(string[] args)
        {
            int ilerazy = Int32.Parse(Console.ReadLine());

            string[] datas = new string[1000];
            for (int i = 0; i < ilerazy; i++)
            {
                Analizator analizator = new Analizator();
                Skrzynia skrzynia = new Skrzynia();
                Pudelko pudelko = new Pudelko();
                
                string wej_napis = Console.ReadLine();

                datas = wej_napis.Split(',');

                /*
                int dlugosctablicy = datas.Length;
                for (int i = 0; i < datas.Length-1; i++)
                {

                }
                */
                skrzynia.Przypisz(Int32.Parse(datas[0]), Int32.Parse(datas[1]), Int32.Parse(datas[2]));
                pudelko.Przypisz(Int32.Parse(datas[3]), Int32.Parse(datas[4]), Int32.Parse(datas[5]));

                
                Console.WriteLine(analizator.Oblicz(skrzynia, pudelko));

                //Console.WriteLine();
                Console.ReadLine();
            }
                                  
        }
       
    }

    class Prostokat
    {

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Z { get; private set; }

        public void Przypisz(int xw, int yw, int zw)
        {

            X = xw;
            Y = yw;
            Z = zw;
        }
    }

    class Skrzynia : Prostokat
    {

    }

    class Pudelko : Prostokat
    {

    }

    class Analizator
    {

        List<Obiekt> B = new List<Obiekt>();
        List<int> LastEq = new List<int>();

        public string Oblicz(Skrzynia skrzynia, Pudelko pudelko) 
        {
            List<int> A = new List<int> { pudelko.X, pudelko.Y, pudelko.Z };
            List<int> skrz = new List<int> { skrzynia.X, skrzynia.Y, skrzynia.Z };
            /*
            Obiekt[] obiekt = new Obiekt[6];

            obiekt[0] = new Obiekt(pudelko.X, pudelko.Y, pudelko.Z);
            obiekt[1] = new Obiekt(pudelko.X, pudelko.Z, pudelko.Y);
            obiekt[2] = new Obiekt(pudelko.Y, pudelko.X, pudelko.Z);
            obiekt[3] = new Obiekt(pudelko.Y, pudelko.Z, pudelko.X);
            obiekt[4] = new Obiekt(pudelko.Z, pudelko.Y, pudelko.X);
            obiekt[5] = new Obiekt(pudelko.Z, pudelko.X, pudelko.Y);
            */
            Permutuj(A);
            for (int i = 0; i < B.Count; i++)
            {

                LastEq.Add((skrz[0] / B[i].x) * (skrz[1] / B[i].y) * (skrz[2] / B[i].z));
            }

            //foreach (var arg in B)
            //{
            //    Console.WriteLine($"{arg.x} {arg.y} {arg.z}");
            //}
            return LastEq.Max().ToString();
        }

        public void Permutuj(List<int> A)
        {
            int a = A.Count;

            if (a == 1)
            {
                B.Add(new Obiekt(A));
             //   foreach (var arg in A)
             //   {
             //       Console.WriteLine(arg);
             //   }

            }

            else
            {
                for (int i = 0; i < a; i++)
                {
                    int temp;
                    temp = A[i];
                    A[i] = A[a - 1];
                    A[a - 1] = temp;

                    Permutuj(a - 1, A);

                    temp = A[i];
                    A[i] = A[a - 1];
                    A[a - 1] = temp;
                }
            }
        }

        public void Permutuj(int a, List<int> A)
        {
            if (a == 1)
            {
                B.Add(new Obiekt(A));

            }

            else
            {
                for (int i = 0; i < a; i++)
                {
                    int temp;
                    temp = A[i];
                    A[i] = A[a - 1];
                    A[a - 1] = temp;

                    Permutuj(a - 1, A);

                    temp = A[i];
                    A[i] = A[a - 1];
                    A[a - 1] = temp;
                }
            }
        }

        class Obiekt 
        {
            public int x, y, z;
            public Obiekt(List<int> A)
            {
                x = A[0];
                y = A[1];
                z = A[2];
            }

        }
    }



}
