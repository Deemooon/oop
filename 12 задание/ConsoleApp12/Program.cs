using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            bool T = false;
            if (n > 0 && n < 4) T = true;
            else if (n % 2 != 0)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        T = false; break;
                    }
                    else T = true;
                }
            }
            else T = false;

            if (T) Console.WriteLine("Является простым числом");
            else Console.WriteLine("Не является простым числом");

            //Delay
            Console.ReadKey();
        }
    }
}
