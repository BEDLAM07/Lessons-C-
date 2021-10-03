using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown; // узнаем какую стрелку нажал пользователь
            Turtle.PenUp();// поднимаем перо

            GraphicsWindow.BrushColor = "Red"; // цвет кисти

            var eat = Shapes.AddRectangle( 15, 15); // переменная для хранения "еды" для черепахи. Команда для рисования квадратика 10*10
            //стартовая позиция "еды"
            int x = 200;
            int y = 200;
            Shapes.Move( eat, x, y ); // команда для перемещения "еды"

            Random rand = new Random(); // конструкция для произвольного смещения в пространстве

            // цикл движение черепахи без изменения направления
            while (true)
            {
                Turtle.Move( 10 );
                if(Turtle.X >= x && Turtle.X <= x + 10 && Turtle.Y >= y && Turtle.Y <= y + 10)
                {
                    x = rand.Next(0, GraphicsWindow.Width); // принимает значение от 0 до ширины экрана
                    y = rand.Next(0, GraphicsWindow.Height); // принимает значение от 0 до высоты экрана
                    Shapes.Move( eat, x, y );
                    Turtle.Speed++; // увеличиваемым скорость черепахи после каждого столкновения на 1
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            //Узнаем какую клавишу нажал пользователь
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;// при нажатие клавиши "Вверх" угол черепахи равен 0 градусов
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;// при нажатии клавиши "Вправо" угол черепахи равен 90 градусов
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;// при нажатии клавиши "Вниз" угол черепахи равен 180 градусов
            }
            else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;// при нажатии клавиши "Налево" угол черепахи равен 270 градусов
            }
        }
    }
}
