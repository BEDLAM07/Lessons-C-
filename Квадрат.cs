using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9; // скорость
            int i = 0; // переменная для хранения кол-во повторений
            while(i < 4 ) // кол-во повторений
            {
            Turtle.Move(100);
            //Turtle.TurnRight();// управляем черепахой - вправо
                //Turtle.Turn(90); // задаем градусы явно
                Turtle.TurnLeft(); // поворот влево
            i++; // увеличиваем на 1;
            }


        }
    }
}
