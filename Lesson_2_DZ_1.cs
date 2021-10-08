//Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1

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
            int[] MyArray = new int[10] {1, 0, 2, 0, 3, 0, 4, 0, 5, 0 };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Исходный массив: ");
            Console.ResetColor();

            foreach (int i in MyArray) // поочередный перебор элементов коллекции от начала до конца с помощью цикла foreach
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[{0}]", i, "\t\t");
                Console.ResetColor();
            }
            //Цикл, с помощью которого находим нули и сжимаеи массив

            // объявляем переменные 
            int s = 9,
                n = 0;

            while (n < s)
            {
                if (MyArray[n] == 0)
                {
                    s--;
                    for (int j = n; j < s; j++)
                    {
                        MyArray[j] = MyArray[j + 1];
                    }
                }
                else
                {
                    n++;
                }

            }
            Console.WriteLine();

            //Дописываем в массив  значения -1 до исходного размера
            for (int i = s; i < 10; i++)
            {
                MyArray[i] = -1;
            }
            //Выводим новый массив
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Новый массив: ");
            Console.ResetColor();

            foreach (int i in MyArray)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[{0}]", i, "\t\t");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}