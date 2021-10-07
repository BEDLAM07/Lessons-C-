//Дано целое число N большее 0, найти число, полученное при прочтении числа N справа налево. 
//Например, если было введено число 345, то программа должна вывести число 543.

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
            int n,
                obratnoe = 0;
            string res = " ";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите пожалуйста значение числа N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            for (; n > 9;)
            {
                res += (n % 10).ToString(); //метод ToString возвращает строку, представляющую текущий объект.
                n = n / 10;
            }
            res += n.ToString();
            obratnoe = Convert.ToInt32(res);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Число справа налево: { res }");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
