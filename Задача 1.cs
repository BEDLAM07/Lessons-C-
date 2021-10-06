//Даны целые положительные числа A, B, C. Значение этих чисел программа должна запрашивать у пользователя. 
//На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C. Квадраты не накладываются друг на друга. 
//Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
//Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни одного квадрата со стороной С 
//(например, если значение С превышает размер сторон прямоугольника).

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
            // вводим данные с клавиатуры
            Console.Write("Введите пожалуйста значение длины A прямоугольника: ");
            int a = Convert.ToInt32(Console.ReadLine()); // конвертируем переменную a типа string в тип int
            Console.Write("Введите пожалуйста значение ширины B прямоугольника: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пожалуйста значение стороны квадрата C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // считаем кол-во квадратов в прямоугольнике
            if (c > a || c > b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Значение стороны квадрата С превышает размер сторон прямоугольника. Пожалуйста введите корректное значение! ");
            }
            else
            {
                int Num = (a / c) * (b / c); // считаем кол-во квадратов в прямоугольники
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Кол-во квадратов в прямоугольнике: " + Num);
            }

            // считаем кол-во свободной площади прямоугольника
            int NumberSquares = (a / c) * (b / c);
            int S = (a * b) - NumberSquares * Convert.ToInt32(Math.Pow(c, 2));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();

            Console.Write("Площадь незанятой части прямоугольника равна: " + S);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
