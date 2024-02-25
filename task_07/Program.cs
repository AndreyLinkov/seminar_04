// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

namespace task_07
{
    class Program
    {
        public static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }

        public static void ReverseArray(int[] array, int[] reverseArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }
        }

        static void Main()
        {
            Console.Clear();

            Random random = new Random();
            int[] array = new int[random.Next(5, 10)];
            FillArray(array);
            Console.WriteLine(string.Join(", ", array));
            // Более простой способ разворота массива

            // Array.Reverse(array);
            // Console.WriteLine(string.Join(", ", array));

            int[] reverseArray = new int[array.Length];
            ReverseArray(array, reverseArray);
            Console.WriteLine(string.Join(", ", reverseArray));
        }
    }
}