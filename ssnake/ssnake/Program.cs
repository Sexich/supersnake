using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine lineUp = new HorizontalLine(0, 20, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 20, 20, '+');
            VerticalLine lineLeft = new VerticalLine(0, 0, 20, '+');
            VerticalLine lineRight = new VerticalLine(20, 0, 20, '+');
            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();

            Point p = new Point(5, 6, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}
