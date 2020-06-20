using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 0; j < 20; i += 3, j++)
            {
                Console.WriteLine(i);
            }
            string pass = "root";
            string UserPass;
            do
            {

                Console.Write("Введите пароль: ");
                UserPass = Console.ReadLine();

                if (pass == UserPass)
                {
                    Console.Write("Пароль верный !");
                    break;
                }
                else
                {
                    Console.Write("Пароль не верный, попробуйте ещё раз !\n");
                }
            }
            while (true);
        }
    }
}
