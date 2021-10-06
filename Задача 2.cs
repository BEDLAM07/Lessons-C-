//Начальный вклад в банке равен 10000 грн. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (
//P — вещественное число, 0 < P < 25). Значение Р программа должна получать у пользователя. 
//По данному P определить через сколько месяцев размер вклада превысит 11000 грн., 
//и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).

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
            double start_sum = 10000;
            int month = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Начальная сумма вклада в банке: " + start_sum);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите процент вклада: ");
            int p = Convert.ToInt32(Console.ReadLine());
            while (start_sum < 11000)
            {
                start_sum += Math.Round(start_sum) * p / 100;
                month++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Ваша сумма {0} рублей. ", start_sum);
            Console.WriteLine();
            Console.WriteLine("Кол-во прошедших месяцев: {0}. ", month);

            Console.ResetColor();
            Console.ReadLine();

        }
    }
}
