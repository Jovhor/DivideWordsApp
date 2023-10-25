using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWordsApp
{
    class Program
    {

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                Print(word);
            }
            return words;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            SplitText(line);
            Console.ReadKey();
        }
    }
}
