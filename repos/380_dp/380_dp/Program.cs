using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _380_dp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = System.IO.File.ReadAllLines(@"C:\Libraries\enable1.txt");
            Dictionary<string, string> wordsMorse = new Dictionary<string, string>();
            string theWord = "cat";
            foreach (var item in words)
            {
                
                wordsMorse.Add(item, MorseChars.Translate(item));
            }

            do
            {
                //theWord = Console.ReadLine();

                var keys = wordsMorse.Where(item => item.Value.Equals("...---..."))
                .Select(item => item.Key);

                Console.WriteLine(keys.Count());

                //if (wordsMorse.ContainsValue(theWord)) { }//Console.WriteLine(keys.ToString());
                //else Console.WriteLine("Nie ma takiego słowa w słowniku!");

            } while (true);
            Console.ReadLine();
        }
    }

    static class MorseChars
    {
        static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static string morseCharsStr = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..";
        static string[] morseChars = morseCharsStr.Split(' ');
        static public Dictionary<char, string> Chars = new Dictionary<char, string>();

        static MorseChars()
        {

            for (int i = 0; i < letters.Length; i++)
            {
                Chars.Add(letters[i], morseChars[i]);
            }
        }

        static public string Translate(string letters)
        {
            string morse = "";
            foreach (var item in letters)
            {
                morse = morse + Chars[item];
            }

            return morse;
        }

    }
}
