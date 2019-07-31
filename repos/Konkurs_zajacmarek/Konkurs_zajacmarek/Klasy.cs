using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Konkurs_zajacmarek
{
    class A
    {
        public int liczba { get; set; }
        public string napis { get; set; }
             
    }

    public class B : IComparable<B>
    {
        
        public int liczba1 { get; set; }
        public int liczba2 { get; set; }

        public int CompareTo(B other)
        {

            B obj = other;

            if (liczba2 > obj.liczba2) return 1;
            else if (liczba2 == obj.liczba2) return 0;
            else return -1;
        }
    }
}
