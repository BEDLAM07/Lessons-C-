//Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)

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
            // рандомно заполняем массив случайными значениями
            const int M = 10;
            const int N = 10;

            Random rnd = new Random();

            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-10, 10);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Случайный массив из {arr.Length} элементов: ");
            Console.ResetColor();
            Console.WriteLine();

            foreach (int n in arr)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[{0}]" + " ", n);
                Console.ResetColor();
            }
            Console.WriteLine();

            // форматируем вывод
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Массив после сортировки: ");
            Console.ResetColor();
            Console.WriteLine();

            // Сортирует элементы в одномерном массиве c помощью метода Array.Sort
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i + " | ");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}


