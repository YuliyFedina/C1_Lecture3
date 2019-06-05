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
            var myString = Console.ReadLine();
            var dictionary = new Dictionary<char, int>();
            foreach (var t in myString)
            {
                if (dictionary.ContainsKey(t))
                {
                    dictionary[t]++;
                }
                else
                {
                    dictionary.Add(t,1);
                }
            }

            foreach (KeyValuePair<char, int> keyValue in dictionary)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }

            
           
        }
    }
}
