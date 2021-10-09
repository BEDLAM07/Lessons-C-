//В двумерном массиве порядка M на N поменяйте местами заданные столбцы

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
            const int M = 10;
            const int N = 10;
            Random rnd = new Random();
            int[] array1 = new int[N];
            int[,] array2 = new int[M, N];
            for (int i = 0; i < M; ++i)
                for (int j = 0; j < N; ++j)
                    array2[i, j] = rnd.Next(0, 10);

            int ind = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Массив array1");
            Console.WriteLine();
            foreach (int n in array2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format(n + " | "));
                Console.ResetColor();
                if (++ind % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
            int r1 = 0,
                r2 = 1;

            // вводим номер строк
            bool ifParse1,
                ifParse2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\nВведите номер столба в массиве array1 от 0 до {M - 1}: ") ;
            ifParse1 = Int32.TryParse(Console.ReadLine(), out r1);
            Console.Write($"\nВведите номер столба в массиве array2 от 0 до {M - 1}: ");
            ifParse2 = Int32.TryParse(Console.ReadLine(), out r2);

            //проверяем корректность ввода данных
            if (ifParse1 == false || ifParse2 == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"Ошибка! Вы указали неправильные координаты");
                Console.ResetColor();
                Console.WriteLine();
            }

            else
            {
                for (int i = 0; i < array1.Length; ++i)
                {
                    array1[i] = array2[r1, i];
                }
                // Копирует диапазон элементов из одного массива в другой массив
                Array.Copy(array2, r2 * N, array2, r1 * N, N);
                for (int i = 0; i < array2.GetLength(0); ++i)
                {
                    array2[r2, i] = array1[i];
                }
            }
            Console.WriteLine();

            // Выводим измененный массив
            ind = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Массив array2");
            Console.WriteLine();
            foreach (int n in array2)
            {
                Console.Write(String.Format(n + " | "));
                if (++ind % 10 == 0)
                    Console.WriteLine();
            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}