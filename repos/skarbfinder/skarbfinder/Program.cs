using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarbfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            uint PP = 0;
            uint WZ = 0;

            int kierunekPP;
            int kierunekWZ;

            List<String> dane = new List<String>();

            dane.Add("0 1");
            dane.Add("0 2");
            
            

            foreach (string wskazanie in dane)
            {
                string[] dana = wskazanie.Split(' ');
                if (Int32.Parse(dana[0]) == 0) PP += UInt32.Parse(dana[1]);
                if (Int32.Parse(dana[0]) == 1) PP -= UInt32.Parse(dana[1]);
                if (Int32.Parse(dana[0]) == 2) WZ -= UInt32.Parse(dana[1]);
                if (Int32.Parse(dana[0]) == 3) WZ += UInt32.Parse(dana[1]);
            }

            if (PP >= 0) kierunekPP = 0; else kierunekPP = 1;
            if (WZ >= 0) kierunekWZ = 3; else kierunekWZ = 2;

            if (PP == 0 && WZ == 0)
            {
                Console.WriteLine("studnia");
            }
            else 
            {
                if (PP!=0) Console.WriteLine($"{kierunekPP} {PP}");
                if (WZ!=0) Console.WriteLine($"{kierunekWZ} {WZ}");
            }
            Console.ReadKey();
        }
    }
}
