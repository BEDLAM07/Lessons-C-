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
            Turtle.Speed = 9;


            // вверх на 100
            Turtle.Move(100);
            Turtle.TurnRight();

            //вправо 100
            Turtle.Move(100);
            Turtle.TurnRight();

            //вниз 100
            Turtle.Move(100);
            Turtle.TurnLeft();

            // вправо 100
            Turtle.Move(100);
            Turtle.TurnRight();

            //разворот на 180 градусов вверх 100
            Turtle.Turn(180);
            Turtle.Move(100);

            //разворот на 90 градусов вправо 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот на 90 градусов вниз 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот вправо 100
            Turtle.TurnLeft();
            Turtle.Move(100);

            //разворот вверх 100
            Turtle.TurnLeft();
            Turtle.Move(100);

            //разворот на 90 градусов вправо 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот на 90 градусов вниз 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот вправо 100
            Turtle.TurnLeft();
            Turtle.Move(100);

            //разворот вверх 100
            Turtle.TurnLeft();
            Turtle.Move(100);

            //разворот на 90 градусов вправо 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот на 90 градусов вниз 100
            Turtle.Turn(90);
            Turtle.Move(100);

            //разворот вправо 100
            Turtle.TurnLeft();
            Turtle.Move(100);

        }
    }
}
