using System;
using System.Collections.Generic;
using System.Linq;

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
                var dublicates = new Dictionary<int, int>();
                Console.WriteLine("Вводите числа через enter (если хотите завершить, введите \"-1\"): ");
                int value;
                while ((value = InputInt()) != -1)
                {
                    if (dublicates.ContainsKey(value))
                    {
                        dublicates[value]++;
                    }
                    else
                    {
                        dublicates.Add(value, 1);
                    }
                }

                Console.WriteLine("Вывод всех дублирующихся чисел среди введенных:");
                foreach (var d in dublicates.Where(kvp => kvp.Value > 1))
                {
                    Console.Write($"{d.Key} ");
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static int InputInt(int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var inputInt))
                {
                    if (inputInt <= max && inputInt >= min)
                        return inputInt;
                    Console.Write($"Введеное значение должно быть в диапазоне {min}-{max}: ");
                    continue;
                }
                Console.WriteLine("Введено некорректное значение! Попробуйте еще раз ввести число (int)");
            }
        }
    }
}
