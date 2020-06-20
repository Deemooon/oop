ноusing System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Введите номер месяца: ");
int x=int.Parse(Console.ReadLine());
            if (x >= 3 && x <= 5) Console.WriteLine("Весна")
            elif (x >= 6 && x <= 8) Console.WriteLine("Лето")
     
            if (x >= 9 && x <= 11) Console.WriteLine("Осень")
            else
            if (x == 12 || x <= 2) Console.WriteLine("Зима")
        }
    }
}
