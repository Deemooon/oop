using System;
using System.Linq;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] a = new int[10];
            Random rand = new Random();
            int i = 0;
            for (i = 0; i < 10; ++i)
            {
                a[i] = rand.Next(-7, 7);
                Console.Write("{0,4}", a[i]);
            }
            Console.WriteLine();
            int k = 0;
            Console.WriteLine(" Введите число");
            double C = int.Parse(Console.ReadLine());
            for (i = 0; i < 10; ++i)
                if (a[i] > C)
                    k++;
            Console.WriteLine("Количество чисел больше чем ({0}) = {1}", C, k);

            Console.Write("Число элементов: ");
            int t = int.Parse(Console.ReadLine());
            int[] arr = new int[t];
            Console.Write("Массив: ");
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int z = 0; z < arr.Length; z++)
            {
                arr[z] = r.Next(-10, 10);
                Console.Write(arr[z] + ", ");
            }
            var max = arr.Max();
            Console.WriteLine("");
            Console.WriteLine("Максимальный элемент: " + max);
            Console.ReadLine();


        }
    }
}
