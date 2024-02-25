// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

namespace task_06
{
    class Program
    {
        public static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
            }
        }

        public static int EvenNumber(int[] array)
        {
            int count = 0;
            foreach (int el in array)
            {
                if (el % 2 == 0)
                    count++;
            }
            return count;
        }

        static void Main()
        {
            Console.Clear();

            Random random = new Random();
            int[] array = new int[random.Next(5, 10)];

            FillArray(array);
            Console.WriteLine(string.Join(", ", array));

            int evenNum = EvenNumber(array);
            Console.WriteLine($"Количество четных чисел в массиве = {evenNum}");
        }
    }
}