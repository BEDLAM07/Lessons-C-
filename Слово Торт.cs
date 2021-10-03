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
        static void WriteT(int size)
        {
            Turtle.Angle = 0;//угол черепахи - ориентир наверх
            Turtle.Move(size);// проезжаем на 60 единиц
            //Turtle.TurnLeft();
            Turtle.Angle = 270;// поворот на 270 градусов (налево)
            Turtle.Move(20);//поворот налево
            Turtle.Angle = 90;// угол 90 градусов (принцип часов)
            Turtle.Move(40);
        }
        static void WriteO(int size)
        {
            Turtle.Angle = 0;// градус направления
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void WriteP(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Angle = 0;// градус направления
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(30);
                Turtle.TurnRight();
            }

        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            //координаты
            Turtle.X = 200;
            Turtle.Y = 200;

            //Торт
            WriteT(60);

            //меняем координаты
            Turtle.X = 260;
            Turtle.Y = 200;
            WriteO(30);

            //меняем координаты
            Turtle.X = 350;
            Turtle.Y = 200;
            WriteP(30);


            //меняем координаты
            Turtle.X = 450;
            Turtle.Y = 200;
            WriteT(30);

        }
    }
}
