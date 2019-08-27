using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Ex3
{
    class Program
    {
        //Считывать с консоли числа, пока не будет введено число "-1",
        //среди введенных чисел вывести все дублирующиеся
        static void Main()
        {
            do
            {
                var duplicates = new Dictionary<int, int>();
                Console.WriteLine("Вводите числа через enter (если хотите завершить, введите \"-1\"): ");
                int value;
                while ((value = Helper.InputInt()) != -1)
                {
                    if (duplicates.ContainsKey(value))
                    {
                        duplicates[value]++;
                    }
                    else
                    {
                        duplicates.Add(value, 1);
                    }
                }

                Console.WriteLine("Вывод всех дублирующихся чисел среди введенных:");
                OutputDuplicates(duplicates);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void OutputDuplicates(Dictionary<int, int> duplicates)
        {
            foreach (var d in duplicates.Where(kvp => kvp.Value > 1))
            {
                Console.Write($"{d.Key} ");
            }
        }
    }
}
