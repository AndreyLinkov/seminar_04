// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

namespace task_05
{
    class Program
    {
        public static bool CheckInput(string input)
        {
            if (int.TryParse(input, out int number))
            {
                int even = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    even += int.Parse(input[i].ToString());
                }
                if (even%2==0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        static void Main()
        {
            Console.Clear();
            bool inputError = true;
            do
            {
                Console.Write("Введите целое число: ");
                string input = Console.ReadLine()!;
                if (input=="q")
                {
                    inputError = false;
                }
                else
                {
                    inputError = CheckInput(input);
                }

            } while (inputError);
        }
    }
}