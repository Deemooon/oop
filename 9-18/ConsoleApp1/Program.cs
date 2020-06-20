using System;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер месяца");
            int mounthId = Convert.ToInt32(Console.ReadLine());
            switch (mounthId)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Это первый квартал");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Это второй квартал");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Это третий квартал");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Это четвертый квартал");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует");
                    break;
            }
            Console.WriteLine("Введите число от 1 до 10");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 4:
                case 6:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Это составное число");
                    break;
                case 1:
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Это простое число");
                    break;
                default:
                    Console.WriteLine("Число не входит в заданный диапазон");
                    break;
            }

            Console.WriteLine("Введите номер месяца");
            int mounth = Convert.ToInt32(Console.ReadLine());
            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода данных");
                    break;
            }
            Console.WriteLine("Введите номер автобуса из предложенных (2, 3, 10, 7, 18, 40, 8, 12, 20)");
            int busId = Convert.ToInt32(Console.ReadLine());
            switch (busId)
            {
                case 2:
                    Console.WriteLine("Конечная остановка: Детский сад Бал бала");
                    break;
                case 3:
                    Console.WriteLine("Конечная остановка: Ж/д вокзал Нур-Султан 1");
                    break;
                case 10:
                    Console.WriteLine("Конечная остановка: Международный аэропорт");
                    break;
                case 7:
                    Console.WriteLine("Конечная остановка: ЖК Жагалау-4");
                    break;
                case 18:
                    Console.WriteLine("Конечная остановка: Стела Звезда Астаны");
                    break;
                case 40:
                    Console.WriteLine("Конечная остановка: Клинико-реабилитационный комплекс");
                    break;
                case 8:
                    Console.WriteLine("Конечная остановка: Болашак");
                    break;
                case 12:
                    Console.WriteLine("Конечная остановка: Международный аэропорт");
                    break;
                case 20:
                    Console.WriteLine("Конечная остановка: Агрогородок");
                    break;
                default:
                    Console.WriteLine("Нет данных по этому маршруту");
                    break;
            }
            Console.WriteLine("Введите номер месяца");
            int holidaysMonth = Convert.ToInt32(Console.ReadLine());
            switch (holidaysMonth)
            {
                case 1:
                    Console.WriteLine("Январь: \n" +
                        "1 и 2 января - Новый год \n" +
                        "7 января - Рождество Христово \n");
                    break;
                case 2:
                    Console.WriteLine("Февраль: \n" +
                        "Праздников нет \n");
                    break;
                case 3:
                    Console.WriteLine("Март: \n" +
                        "8 марта - Международный женский день \n" +
                        "21, 22 и 23 марта - Наурыз \n");
                    break;
                case 4:
                    Console.WriteLine("Апрель: \n" +
                        "Прадзников нет \n");
                    break;
                case 5:
                    Console.WriteLine("Май: \n" +
                        "1 мая - Праздник единства народа Казахстана \n" +
                        "7 мая - День защитника Отечества \n" +
                        "9 мая - День Победы \n");
                    break;
                case 6:
                    Console.WriteLine("Июнь: \n" +
                        "4 июня	День государственных символов Республики Казахстан \n");
                    break;
                case 7:
                    Console.WriteLine("Июль: \n" +
                        "6 июля	День Столицы \n" +
                        "31 июля - Первый день Курбан-айта \n");
                    break;
                case 8:
                    Console.WriteLine("Август: \n" +
                        "30 августа - День Конституции РК \n");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь: \n" +
                        "5 сентября	День языков народа Казахстана \n");
                    break;
                case 10:
                    Console.WriteLine("Октябрь: \n" +
                        "Праздников нет \n");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь: \n" +
                        "Праздников нет \n");
                    break;
                case 12:
                    Console.WriteLine("Декабрь: \n" +
                        "1 декабря - День Первого Президента РК \n" +
                        "16 и 17 декабря - День Независимости \n");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода данных");
                    break;
            }

            Console.WriteLine("Введите номер месяца");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число в этом месяце");
            int d = Convert.ToInt32(Console.ReadLine());
            if ((d >= 21 && m == 3) || (d <= 20 && m == 4))
            {
                Console.WriteLine("Овен");
            }
            else if ((d >= 21 && m == 4) || (d <= 20 && m == 5))
            {
                Console.WriteLine("Телец");
            }
            else if ((d >= 21 && m == 5) || (d <= 21 && m == 6))
            {
                Console.WriteLine("Близнецы");
            }
            else if ((d >= 22 && m == 6) || (d <= 22 && m == 7))
            {
                Console.WriteLine("Рак");
            }
            else if ((d >= 23 && m == 7) || (d <= 23 && m == 8))
            {
                Console.WriteLine("Лев");
            }
            else if ((d >= 24 && m == 8) || (d <= 23 && m == 9))
            {
                Console.WriteLine("Дева");
            }
            else if ((d >= 24 && m == 9) || (d <= 23 && m == 10))
            {
                Console.WriteLine("Весы");
            }
            else if ((d >= 24 && m == 10) || (d <= 22 && m == 11))
            {
                Console.WriteLine("Скорпион");
            }
            else if ((d >= 23 && m == 11) || (d <= 21 && m == 12))
            {
                Console.WriteLine("Стрелец");
            }
            else if ((d >= 22 && m == 12) || (d <= 20 && m == 1))
            {
                Console.WriteLine("Козерог");
            }
            else if ((d >= 21 && m == 1) || (d <= 18 && m == 2))
            {
                Console.WriteLine("Водолей");
            }
            else
            {
                Console.WriteLine("Рыбы");
            }

            Console.WriteLine("Введите букву из алфавита");
            string letter = Console.ReadLine();
            switch (letter)
            {
                case "а":
                    Console.WriteLine("Порядковый номер этой буквы: 1");
                    break;
                case "б":
                    Console.WriteLine("Порядковый номер этой буквы: 2");
                    break;
                case "в":
                    Console.WriteLine("Порядковый номер этой буквы: 3");
                    break;
                case "г":
                    Console.WriteLine("Порядковый номер этой буквы: 4");
                    break;
                case "д":
                    Console.WriteLine("Порядковый номер этой буквы: 5");
                    break;
                case "е":
                    Console.WriteLine("Порядковый номер этой буквы: 6");
                    break;
                case "ё":
                    Console.WriteLine("Порядковый номер этой буквы: 7");
                    break;
                case "ж":
                    Console.WriteLine("Порядковый номер этой буквы: 8");
                    break;
                case "з":
                    Console.WriteLine("Порядковый номер этой буквы: 9");
                    break;
                case "и":
                    Console.WriteLine("Порядковый номер этой буквы: 10");
                    break;
                case "й":
                    Console.WriteLine("Порядковый номер этой буквы: 11");
                    break;
                case "к":
                    Console.WriteLine("Порядковый номер этой буквы: 12");
                    break;
                case "л":
                    Console.WriteLine("Порядковый номер этой буквы: 13");
                    break;
                case "м":
                    Console.WriteLine("Порядковый номер этой буквы: 14");
                    break;
                case "н":
                    Console.WriteLine("Порядковый номер этой буквы: 15");
                    break;
                case "о":
                    Console.WriteLine("Порядковый номер этой буквы: 16");
                    break;
                case "п":
                    Console.WriteLine("Порядковый номер этой буквы: 17");
                    break;
                case "р":
                    Console.WriteLine("Порядковый номер этой буквы: 18");
                    break;
                case "с":
                    Console.WriteLine("Порядковый номер этой буквы: 19");
                    break;
                case "т":
                    Console.WriteLine("Порядковый номер этой буквы: 20");
                    break;
                case "у":
                    Console.WriteLine("Порядковый номер этой буквы: 21");
                    break;
                case "ф":
                    Console.WriteLine("Порядковый номер этой буквы: 22");
                    break;
                case "х":
                    Console.WriteLine("Порядковый номер этой буквы: 23");
                    break;
                case "ц":
                    Console.WriteLine("Порядковый номер этой буквы: 24");
                    break;
                case "ч":
                    Console.WriteLine("Порядковый номер этой буквы: 25");
                    break;
                case "ш":
                    Console.WriteLine("Порядковый номер этой буквы: 26");
                    break;
                case "щ":
                    Console.WriteLine("Порядковый номер этой буквы: 27");
                    break;
                case "ъ":
                    Console.WriteLine("Порядковый номер этой буквы: 28");
                    break;
                case "ы":
                    Console.WriteLine("Порядковый номер этой буквы: 29");
                    break;
                case "ь":
                    Console.WriteLine("Порядковый номер этой буквы: 30");
                    break;
                case "э":
                    Console.WriteLine("Порядковый номер этой буквы: 31");
                    break;
                case "ю":
                    Console.WriteLine("Порядковый номер этой буквы: 32");
                    break;
                case "я":
                    Console.WriteLine("Порядковый номер этой буквы: 33");
                    break;
                default:
                    Console.WriteLine("Такого буквы не существует");
                    break;
            }
            Console.WriteLine("Кубы первых 10 простых чисел");
            int[] numbers = new int[10] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            double[] cubedNumbers = numbers
                .Select(number => Math.Pow(number, 3))
                .ToArray();

            Console.WriteLine(String.Join(", ", cubedNumbers));
        }


    }
}


