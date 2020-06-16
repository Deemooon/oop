using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое количество минут");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость одной минуты");
            int priceMinute = Convert.ToInt32(Console.ReadLine()); ;
            int res = 0;
            Console.WriteLine("Введите номер дня недели");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day == 6 || day == 7)
            {
                res = Convert.ToInt32((minute * priceMinute) * 0.85);
                Console.WriteLine("Стоимость звонка = {0} рублей", res);
            }
            else if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
            {
                res = minute * priceMinute;
                Console.WriteLine("Стоимость звонка = {0} рублей", res);
            }
            else
            {
                Console.WriteLine("Нет такого дня недели");
            }
        }
    }
}
