using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ssnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );

            // отрисовка рамки
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineLeft = new VerticalLine(0, 0, 24, '+');
            VerticalLine lineRight = new VerticalLine(78, 0, 24, '+');
            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();

            // отрисовка точек змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
          
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
