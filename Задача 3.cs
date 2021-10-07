//Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
//при этом каждое число должно выводиться количество раз, равное его значению (например, число 3 выводится 123 3 раза). Например: если А = 3, а В = 7, 
//то программа должна сформировать в консоли следующий вывод:
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7

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
            int 
                a, 
                b, 
                count;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите пожалуйста значение A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пожалуйста значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            // проверка на корректность ввода данных (по условиям задачи А<B)
            if (a >= b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели некорректные данные (а > b)");
                Console.ResetColor();
                return;
            }

            //считаем кол-во столбцов
            count = b - a + 1;

            //вложенный цикл for
            for (; a <= b; a++)// обратите внимание инициализирующая часть (переменная) в данном цикле отсутствует
            {
                for (int i = 0; i < a; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{ a }" + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();

            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\ncount: {0} ", count);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}