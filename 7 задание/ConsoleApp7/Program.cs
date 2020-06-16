using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд");
            TimeSpan second = TimeSpan.FromSeconds(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("{0} д. {1} ч. {2} м. {3} с.", second.Days, second.Hours, second.Minutes, second.Seconds);
        }
    }
}

