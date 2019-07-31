using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flamastry
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosczestawow;
            int numbers = 0;
            string napis;
            List<string> zestawy = new List<string>();

            while(true)
            {
                ilosczestawow = Int32.Parse(Console.ReadLine());
                if (ilosczestawow <= 50 && ilosczestawow >= 1) break;

                Console.WriteLine("Podaj wartosc od 1 do 50");
            }

            for (int i = 0; i < ilosczestawow; i++)
            {
                zestawy.Add(Console.ReadLine());
            }


            foreach (string zestaw in zestawy)
            {
                napis = "";
                for (int j = 0; j < zestaw.Length; j++)
                {
                    numbers = 0;
                    for (int i = 1; i < zestaw.Length; i++)
                    {
                        if (j + i == zestaw.Length)
                        {

                            break;
                        }
                        else if (zestaw[j] == zestaw[j + i]) numbers += 1; else break;
                    }
                    if (numbers == 1)
                    {
                        napis = napis + zestaw[j] + zestaw[j];
                    }
                    else if (numbers == 0)
                    {
                        napis = napis + zestaw[j];
                    }
                    else napis = napis + zestaw[j] + (numbers + 1);

                    j += numbers;
                    //Console.WriteLine(numbers);

                }
                Console.WriteLine(napis);
            }
            Console.ReadLine();
        }
    }
}
