using System;
using System.Collections.Generic;

namespace Ex2
{
    static class Program
    {
        //Считать строку с консоли. Создать словарь, где ключом будет символ строки,
        //а значением - количество данных символов в считанной строке
        private static void Main()
        {
            Console.WriteLine("Введите строку");
            QuantityEachSymbolInLine(Console.ReadLine());
        }
        private static Dictionary<char, int> FormingDictionary(string myString)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (var t in myString)
            {
                if (dictionary.ContainsKey(t))
                {
                    dictionary[t]++;
                }
                else
                {
                    dictionary.Add(t, 1);
                }
            }
            return dictionary;
        }

        private static void OutputDictionary(Dictionary<char, int> dictionary)
        {
            foreach (var keyValue in dictionary)
            {
                var value = Convert.ToString(keyValue.Value);
                var lastSymbol = value.Substring(value.Length - 1);
                string a;

                if (lastSymbol == "2" || lastSymbol == "3" || lastSymbol == "4")
                {
                    a = "a";
                }
                else
                {
                    a = null;
                }
           
                Console.WriteLine($"символ {keyValue.Key} встречается {keyValue.Value} раз{a}");
            }
        }

        private static void QuantityEachSymbolInLine(string myString)
        {
            var dictionary = FormingDictionary(myString);
            OutputDictionary(dictionary);
        }
    }
}
