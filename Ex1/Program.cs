using System;

namespace Ex1
{
    class Program
    {
        //Сделать методы для считывания целых чисел, дробных чисел
        // Сделать методы для вывода на консоль этих типов данных,
        //массивов целых и дробных чисел (можно доработать любое ТЗ)
        static void Main()
        {
            do
            {
                Console.Write("Введите первое целое число: ");
                var firstInt = InputInt();
                Console.Write("Введите второе целое число: ");
                var secondInt = InputInt();
                Console.Write("Введите первое дробное число: ");
                var firstDouble = InputDouble();
                Console.Write("Введите второе дробное число: ");
                var secondDouble = InputDouble();

                var elementsInt = new int[2];
                elementsInt[0] = firstInt;
                elementsInt[1] = secondInt;

                var elementsDouble = new double[2];
                elementsDouble[0] = firstDouble;
                elementsDouble[1] = secondDouble;

                OutputInt(firstInt);
                OutputDouble(firstDouble);

                OutputArrayInt(elementsInt);
                OutputArrayDouble(elementsDouble);

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

        private static double InputDouble(double min = double.MinValue, double max = double.MaxValue)
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out var inputDouble))
                {
                    if (inputDouble <= max && inputDouble >= min)
                        return inputDouble;
                    Console.Write($"Введеное значение должно быть в диапазоне {min}-{max}: ");
                    continue;
                }
                Console.WriteLine("Введено некорректное значение! Попробуйте еще раз ввести число (Double)");
            }
        }

        private static void OutputInt(int x)
        {
            Console.WriteLine($"Целое число: {x}");
        }

        private static void OutputDouble(double x)
        {
            Console.WriteLine($"Дробное число: {x:F2}");
        }

        private static void OutputArrayInt(int[] arrayInt)
        {
            Console.Write($"Массив целых чисел");
            foreach (var element in arrayInt)
            {
                Console.Write($" {element} ");
            }
            Console.WriteLine();
        }

        private static void OutputArrayDouble(double[] arrayDouble)
        {
            Console.Write("Массив дробных чисел: ");
            foreach (var element in arrayDouble)
            {
                Console.Write($" {element,5:F2} ");
            }
            Console.WriteLine();
        }
    }
}
