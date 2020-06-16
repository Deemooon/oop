using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("Оба числа четные. Их сумма: " + (a + b));
            }
            else if (a % 2 != 0 || b % 2 != 0)
            {
                Console.WriteLine("Одно из чисел нечетное. Их произведение: " + (a * b));
            }
        }
    }
}
