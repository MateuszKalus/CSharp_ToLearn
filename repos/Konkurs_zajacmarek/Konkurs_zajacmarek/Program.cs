using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konkurs_zajacmarek
{
    class Program
    {
        static void Main(string[] args)
        {
            A[] tablicaA = new A[5];

            List<A> listaA = new List<A>();
            List<B> listaB = new List<B>();
            Random random = new Random();

            string[] tablicaStringow = { "AAAAA", "BBBBBB", "CCCC", "DDDDD", "EEEEEEEEE"};
            for (int i = 0; i < 5; i++)
            {
                listaA.Add(new A() { liczba = random.Next(2, 101), napis = tablicaStringow[i] } );
                listaB.Add(new B() { liczba1 = listaA[i].liczba*2, liczba2 = listaA[i].napis.Length});
               
                Console.WriteLine($"Obiekt {i}: {listaA[i].liczba}  {listaA[i].napis}");
            }

            listaB.Sort();

            foreach (var item in listaB)
            {
                Console.WriteLine($"{item.liczba1} {item.liczba2}");
            }
            Console.ReadLine();
        }
    }
}
