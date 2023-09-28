using System;

namespace LABWORK2309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1, 4.2 + Домашнее задание 4.1");
            int day, year;
            Console.Write("Введите год: ");
            year = Convert.ToInt32(Console.ReadLine());
            DateTime data = Convert.ToDateTime($"01.01.{year}");
            if (year % 4 == 0 & (year % 100 != 0 | year % 400 == 0))
            {
                Console.WriteLine("Вы ввели високосный год");
                Console.Write("Введите значение от 1 до 366: ");
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 366)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
                else
                {
                    data = data.AddDays(day - 1);
                    Console.WriteLine($"Число {day} соответствуе дате: {data:d MMMM} {year} года");
                }
                Console.WriteLine("Нажмите любую кнопку для завершения");
            }
            else
            {
                Console.WriteLine("Вы ввели невисокосный год");
                Console.Write("Введите значение от 1 до 365: ");
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 365)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                    Console.WriteLine("Нажмите любую кнопку для завершения");
                }
                else
                {
                    data = data.AddDays(day - 1);
                    Console.WriteLine($"Число {day} соответствует дате: {data:d MMMM} {year} года");
                }
                Console.WriteLine("Нажмите любую кнопку для завершения");
            }
            Console.ReadKey();







        }

    }
}
