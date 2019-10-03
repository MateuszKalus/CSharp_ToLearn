using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _375_dp { 

    class Program
    {
        static void Main(string[] args)
        {
            List<Number> numbers = new List<Number>();
            string ddd = "010100010";


            for (int i = 0; i < ddd.Length; i++)
            {
                //Console.WriteLine(ddd[i]);
                numbers.Add(new Number(i, ddd[i], ddd.Length));
            }

            foreach (var item in numbers)
            {
                //Console.WriteLine(item.Value);
            }

            int stringlength = ddd.Length;
            int sum;

            while (true) {
                sum = 0;
                foreach (var item in numbers)
                {
                    sum += item.Value;

                }

                if (sum == stringlength * 2) break;

                foreach (var item in numbers)
                {
                    //Console.Write(item.Value);
                }

                for (int i = 0; i < ddd.Length; i++)
                {
                    
                    if (numbers[i].Value == 1)
                    {
                        Console.WriteLine("HELLO");
                        if (numbers[i].FirstOrLast == -1)
                        {
                            numbers[i - 1].Odwroc();
                            numbers[i + 1].Odwroc();
                            Console.Write(i);
                            numbers[i].Value = 2;
                            break;
                        }
                        else if (numbers[i].FirstOrLast == 0)
                        {
                            numbers[i + 1].Odwroc();
                            Console.Write(i);
                            numbers[i].Value = 2;
                            break;
                        }
                        else
                        {
                            numbers[i - 1].Odwroc();
                            Console.Write(i);
                            numbers[i].Value = 2;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(ddd);
            Console.ReadLine();
        }
    }

    class Number
    {
        public int Value { get; set; }
        public int Pos { get; set; }
        public int FirstOrLast { get; set; }

        public Number(int pos, int num, int length)
        {
            Value = num;
            Pos = pos;

            Console.WriteLine(Value);
            if (Pos == 0) FirstOrLast = 0;
            else if (Pos == length) FirstOrLast = 1;
            else FirstOrLast = -1;
        }

        public void Odwroc()
        {
            if (Value == 1) Value = 0;
            else if (Value == 0) Value = 1;
        }
    }
}
