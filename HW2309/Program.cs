using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2309
{
    internal class Program
    {
        enum Days
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите подряд числа последовательности через Enter:");
            bool flag = true;
            int i = 0;
            int[] nums = new int[10];
            do
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if (i > 0 && nums[i] < nums[i - 1])
                {
                    flag = false;
                    break;
                }
            }
            while (i++ < 9);
            if (flag)
            {
                Console.WriteLine("Последовательность упорядочена");
            }
            else
            {
                Console.WriteLine($"Последовательность сбилась на числе {nums[i]} под индексом {i}");
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("///////////");

            Console.WriteLine("Задание 2");
            int k = 0;
            Console.Write("Введите целое число от 6 до 14: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                bool flag1 = int.TryParse(Console.ReadLine(), out k);
                if (flag1 == false)
                {
                    Console.WriteLine("Вы ввели неправильное число");
                }

            }
            finally
            {
                switch (k)
                {
                    case 6:
                        Console.WriteLine("Ваша карта 6");
                        break;
                    case 7:
                        Console.Write("Ваша карта 7");
                        break;
                    case 8:
                        Console.WriteLine("Ваша карта 8");
                        break;
                    case 9:
                        Console.WriteLine("Ваша карта 9");
                        break;
                    case 10:
                        Console.WriteLine("Ваша карта 10");
                        break;
                    case 11:
                        Console.WriteLine("Ваша карта Валет");
                        break;
                    case 12:
                        Console.WriteLine("Ваша карта Дама");
                        break;
                    case 13:
                        Console.WriteLine("Ваша карта Король");
                        break;
                    case 14:
                        Console.WriteLine("Ваша карта туз");
                        break;
                    default:
                        Console.WriteLine("Вы ввели число, которое не подлежит ни одной карте");
                        break;
                }
            }

            Console.WriteLine("///////////////");

            Console.WriteLine("Задание 3");
            Console.WriteLine("INPUT: ");
            string text = Console.ReadLine().ToLower();

            switch (text)
            {
                case "jabroni":
                    Console.Write("OUTPUT:\nPatron Tequila\n");
                    break;
                case "school сounselor":
                    Console.Write("OUTPUT:\nAnything with Alcohol\n");
                    break;
                case "programmer":
                    Console.Write("OUTPUT:\nHipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.Write("OUTPUT:\nMoonshine\n");
                    break;
                case "politician":
                    Console.Write("OUTPUT:\nCristal\n");
                    break;
                default:
                    Console.Write("OUTPUT:\nBeer\n");
                    break;
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();
            
            Console.WriteLine("Задание 5");
            Console.Write("Введите номер дня недели: ");
            try
            {
                int day = Convert.ToInt32(Console.ReadLine());
                if (0 < day & day < 8)
                {
                    Console.WriteLine($"Неделя под порядковым номером {day}: {((Days)day)}");
                }
                else
                {
                    Console.WriteLine("Нет дня с таким порядковым номером");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
