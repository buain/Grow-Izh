using System;
using System.Collections.Generic;

namespace Task1._3
{
    class Program
    {
        private static void Main(string[] args)
        {
            string word1 = "Microsoft";
            string word2 = "Владимир";
            string result = Add(word1, word2);
            Console.WriteLine(result);

            Console.ReadKey(); // Delay       
        }

        ///<summary>
        ///Алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, исключая повторяющиеся символы
        ///</summary>
        ///<param name="first">Первая строка</param>
        ///<param name="second">Вторая строка</param>
        private static string Add(string first, string second)
        {
            string input = first + second;
            string output = string.Empty;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 0;
                    output += ch;
                }
            }
            return output;
        }
    }
}
