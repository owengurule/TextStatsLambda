using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void TextStats(string input)
        {
            //standaradize my input
            input = input.ToLower();
            //print out the number of letters
            Console.WriteLine("# of letters: {0}", input.Length);
            //print out the number of words
            Console.WriteLine("# of words: {0}", input.Split(' ').Count());
            //print out the number of vowels
            Console.WriteLine("# of vowels: {0}", input.Where(x => "aeiou".Contains(x.ToString())));
            //print number of consonents
            Console.WriteLine("# of consonants: {0}", input.Where(x => "bcdfghjklmnpqrstvwxyz".Contains(x.ToString())));
            //print number of special characters
            Console.WriteLine("# of special characters: {0}", input.Count(x => "?.'/".Contains(x.ToString())));
            //print longest word
            Console.WriteLine("Longest word: {0}", input.Split(' ').OrderBy(x => x.Length).Last());
            //print shortest word
            Console.WriteLine("Shortest word: {0}", input.Split(' ').OrderBy(x => x.Length).First());
        }

        }
}
