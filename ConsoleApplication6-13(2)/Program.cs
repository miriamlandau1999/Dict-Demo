using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6_13_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>();
            alphabet.AddRange("abcdefghijklmnopqrstuvwxyz");
            string alph = "abcdefghijklmnopqrstuvwxyz";
            string word = "Hello world";
            
            Dictionary<char, int> alphabets = new Dictionary<char, int>();
            for(int i = 0; i < alph.Length; i++)
            {
                alphabets.Add(alph[i], i);
            }
            Dictionary<int, char> word2 = new Dictionary<int, char>();
            for(int i = 0; i < word.Length; i++)
            {
                word2.Add(i, word[i]);
            }

            

            foreach (char c in alphabet)
            {
                int x = 0;
                foreach (char a in word)
                {
                    if (a == c)
                    {
                        x++;
                    }
                }
                Console.WriteLine($"There are {x} {c}s in word");
            }
            Console.ReadKey(true);
        }
       
    }
}
