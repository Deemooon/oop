using System;

namespace П__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№11");
            Console.Write("Числитель первой дроби: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Знаминатель первой дроби: ");
            int a2 = int.Parse(Console.ReadLine());
            if (a2 == 0)
            {
                Console.Write("Неверное построение дроби ");
                return;
            }
            Console.Write("Числитель второй дроби: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Знаминатель второй дроби: ");
            int b2 = int.Parse(Console.ReadLine());
            if (b2 == 0)
            {
                Console.Write("Неверное построение дроби ");
                return;
            }
            Console.WriteLine((a1 * b1) / (a2 * b2));

            Console.WriteLine("");
            Console.WriteLine("№12");
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} - четное ", num);
            }
            else
            {
                Console.WriteLine("{0} - не четное ", num);
            }

            Console.WriteLine("");
            Console.WriteLine("№13");
            Console.Write("Укажите время в минутах: ");
            int ty = Convert.ToInt32(Console.ReadLine());
            int hr = ty / 60;
            int min = ty - (hr * 60);
            Console.WriteLine("{0} = {1} часов {2} минут", ty, hr, min);

            Console.WriteLine("");
            Console.WriteLine("№14");
            Console.Write("Укажите расстояние в метрах: ");
            int ui = Convert.ToInt32(Console.ReadLine());
            int km = ui / 1000;
            int m = ui - (km * 1000);
            Console.WriteLine("{0} = {1} км {2} м", ui, km, m);

            Console.WriteLine("");
            Console.WriteLine("№15");
            Console.Write("Номер текущего месяца: ");
            int mon = int.Parse(Console.ReadLine());
            Console.Write("Время года: ");
            if (mon > 2 && mon < 6)
            {
                Console.WriteLine("Весна");
            }
            if (mon > 5 && mon < 9)
            {
                Console.WriteLine("Лето");
            }
            if (mon > 8 && mon < 12)
            {
                Console.WriteLine("Осень");
            }
            if ((mon > 11 && mon < 13) || (mon > 0 && mon < 3))
            {
                Console.WriteLine("Зима");
            }
            if (mon > 12)
            {
                Console.WriteLine("Введите корректный номер (от 1 до 12)");
            }

            Console.WriteLine("");
            Console.WriteLine("№16");
            Console.WriteLine("Вопрос: сколько будет 5 + 7?");
            Console.WriteLine("1. 12");
            Console.WriteLine("2. 15");
            Console.WriteLine("3. 16");
            Console.Write("Ваш ответ: ");
            int ot = int.Parse(Console.ReadLine());
            if (ot == 1)
            {
                Console.WriteLine("Вы ответили правильно");
            }
            else
            {
                Console.WriteLine("Вы ошиблись");
            }

            Console.WriteLine("");
            Console.WriteLine("№17");
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Числа равны");
            }
            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }

            Console.WriteLine("");
            Console.WriteLine("№18");
            Console.Write("Числитель первой дроби: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("Знаминатель первой дроби: ");
            int c2 = int.Parse(Console.ReadLine());
            if (c2 == 0)
            {
                Console.Write("Неверное построение дроби ");
                return;
            }
            Console.Write("Числитель второй дроби: ");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("Знаминатель второй дроби: ");
            int d2 = int.Parse(Console.ReadLine());
            if (d2 == 0)
            {
                Console.Write("Неверное построение дроби ");
                return;
            }
            Console.WriteLine((c1 / d1) / (c2 / d2));
            Console.ReadLine();
        }
    }
}
