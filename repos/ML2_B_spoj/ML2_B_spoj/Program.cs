using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML2_B_spoj
{
    class Program
    {
        static int Main(string[] args)
        {
            List<int> segmentlist = new List<int>();
            int iterations = int.Parse(Console.ReadLine());

            for (int j = 0; j < iterations; j++)
            {
                 segmentlist.Add(int.Parse(Console.ReadLine()));
            }

               


            for (int i = 0; i < iterations; i++)
            {


                ClockStatement statement = new ClockStatement(segmentlist[i]);

                statement.CreateMinStatement();
                Console.Write($"{statement.A}{statement.B}:{statement.C}{statement.D} ");

                statement.Clear();

                statement.CreateMaxStatement();
                Console.WriteLine($"{statement.A}{statement.B}:{statement.C}{statement.D}");

            }
            //Console.ReadLine();
                     return 0;
        }
    }

    class DigitCreator
    {
        public List<Digit> digitList = new List<Digit>();

        public DigitCreator()
        {
            digitList.Add(new Digit(0, 6));
            digitList.Add(new Digit(1, 2));
            digitList.Add(new Digit(2, 5));
            digitList.Add(new Digit(3, 5));
            digitList.Add(new Digit(4, 4));
            digitList.Add(new Digit(5, 5));
            digitList.Add(new Digit(6, 6));
            digitList.Add(new Digit(7, 3));
            digitList.Add(new Digit(8, 7));
            digitList.Add(new Digit(9, 6));

        }
    }

    class Digit : IComparable
    {
        public int Value { get; set; }
        public int SegmNum { get; set; }

        public Digit(int digit, int segm)
        {
            Value = digit;
            SegmNum = segm;
        }

        public int CompareTo(object obj)
        {
            var arg = (Digit)obj;

            if (arg.Value < Value)
                return 1;
            else if (arg.Value == Value)
                return 0;
            else return -1;
        }
    }

    class ClockStatement
    {
        static DigitCreator digits = new DigitCreator();

        public int SegmentNumber { get; set; }
        public int SegmentNumberStatic { get; set; }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }



        public ClockStatement(int segments)
        {
            SegmentNumberStatic = segments;
            SegmentNumber = SegmentNumberStatic;

        }

        public void CreateMinStatement()
        {
            int koncz = 0;
            int bhelper;

            for (int a = 1; a <= 5; a++)
            {
                if (koncz == 1) break;
                if (SegmentNumber > digits.digitList[a].SegmNum && (SegmentNumber - digits.digitList[a].SegmNum) > 5 && (SegmentNumber - digits.digitList[a].SegmNum) <= 20)
                {
                    SegmentNumber -= digits.digitList[a].SegmNum;

                    if (a == 1) bhelper = 5;
                    else bhelper = 0;
                    A = a;


                    for (int b = bhelper; b < 10; b++)
                    {
                        if (koncz == 1) break;

                        if (SegmentNumber > digits.digitList[b].SegmNum && (SegmentNumber - digits.digitList[b].SegmNum) > 3 && (SegmentNumber - digits.digitList[b].SegmNum) <= 13)
                        {
                            SegmentNumber -= digits.digitList[b].SegmNum;
                            B = b;

                            for (int c = 0; c <= 5; c++)
                            {
                                if (koncz == 1) break;
                                if (SegmentNumber > digits.digitList[c].SegmNum && (SegmentNumber - digits.digitList[c].SegmNum) > 1 && (SegmentNumber - digits.digitList[c].SegmNum) < 8)
                                {
                                    SegmentNumber -= digits.digitList[c].SegmNum;
                                    C = c;

                                    for (int d = 0; d <= 9; d++)
                                    {
                                        if (SegmentNumber - digits.digitList[d].SegmNum == 0)
                                        {
                                            //SegmentNumber -= digits.digitList[c].SegmNum;
                                            D = d;

                                            koncz = 1;
                                            break;

                                        }
                                        else continue;
                                    }

                                }
                                else continue;
                            }

                        }
                        else continue;

                    }




                }
                else continue;

            }

        }
        public void CreateMaxStatement()
        {
            int koncz = 0;
            int bhelper;

            for (int a = 5; a >= 1; a--)
            {
                if (koncz == 1) break;
                if (SegmentNumber > digits.digitList[a].SegmNum && (SegmentNumber - digits.digitList[a].SegmNum) > 5 && (SegmentNumber - digits.digitList[a].SegmNum) <= 20)
                {
                    SegmentNumber -= digits.digitList[a].SegmNum;

                    
                    A = a;
                    if (A == 1) bhelper = 5;
                    else bhelper = 1;
                    //Console.WriteLine(SegmentNumber);

                    for (int b = 9; b >= bhelper; b--)
                    {
                        if (koncz == 1) break;

                        if (SegmentNumber > digits.digitList[b].SegmNum && (SegmentNumber - digits.digitList[b].SegmNum) > 3 && (SegmentNumber - digits.digitList[b].SegmNum) <= 13)
                        {
                            SegmentNumber -= digits.digitList[b].SegmNum;
                            B = b;

                            for (int c = 5; c >= 0; c--)
                            {
                                if (koncz == 1) break;
                                if (SegmentNumber > digits.digitList[c].SegmNum && (SegmentNumber - digits.digitList[c].SegmNum) > 1 && (SegmentNumber - digits.digitList[c].SegmNum) < 8)
                                {
                                    //Console.WriteLine(SegmentNumber);
                                    SegmentNumber -= digits.digitList[c].SegmNum;
                                    C = c;
                                    //Console.WriteLine(SegmentNumber);
                                    for (int d = 9; d >= 0; d--)
                                    {
                                        if (SegmentNumber - digits.digitList[d].SegmNum == 0)
                                        {
                                            //Console.WriteLine(SegmentNumber);
                                            //SegmentNumber -= digits.digitList[c].SegmNum;
                                            D = d;
                                            //Console.WriteLine(D);
                                            koncz = 1;
                                            break;

                                        }
                                        else continue;
                                    }

                                }
                                else continue;
                            }

                        }
                        else continue;

                    }




                }
                else continue;

            }

        }

        public void Clear()
        {
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            SegmentNumber = SegmentNumberStatic;
        }
    }
}