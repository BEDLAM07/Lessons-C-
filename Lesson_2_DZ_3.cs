//Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SR_DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            // рандомное заполнение массива
            const int M = 100;
            const int N = 100;

            Random rnd = new Random();

            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(0, 100);
            }
            //Console.WriteLine($"Массив заполнен случайными {arr.Length} элементами"); // вывод служебного сообщения (раскомментируй в случае необходимости)
            foreach (int n in arr)
            {
               //Console.Write($" {n}"); // вывод массива в консоль (раскомментируй в случае необходимости)
            }
            //Console.WriteLine();


            int
                number,
                count = 0;
            // осуществляем проверку диапазона введенных данных пользователем
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введите от 0 до 100: ");
                if (!Int32.TryParse(Console.ReadLine(), out number));
                {
                    if (number < 100 || number < 100)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!! Вы ввели число в не заданного диапазона");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }

            }
            Console.WriteLine();

            // считаем сколько раз введенное число встретилось в массиве
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == number)
                {
                    count++;
                }


            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Ваше число {number} встречается в массиве {count} раз(а).");
            Console.ResetColor();

            Console.ReadLine();
        }


    }
}











