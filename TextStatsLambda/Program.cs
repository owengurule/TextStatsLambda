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
            //print the # of chracters, #words # vowels, # consonants, # special characters

            int numChars = input.Length;
            int numWords = input.Split(' ').ToList().Count;
            //declare intergers to hold the # of character types
            int numVowels = 0;
            int numCons = 0;
            int numSpec = 0;

            
            //looped through all letters, print output
            Console.WriteLine(input);
            Console.WriteLine("# Chars: " + numChars);
            Console.WriteLine("# Words: " + numWords);
            Console.WriteLine("# Vowels: " + numVowels);
            Console.WriteLine("# Consonants: " + numCons);
            Console.WriteLine("# Spec Chars: " + numSpec);
        }
        
        }
}
