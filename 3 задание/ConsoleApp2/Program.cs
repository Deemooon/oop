using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели");
            int dayId = Convert.ToInt32(Console.ReadLine());
            switch (dayId)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Это будний день");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Это Выходной день");
                    break;
                default:
                    Console.WriteLine("В неделе всего семь дней");
                    break;
            }
        }
    }
}
