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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(2, 6, '$');
            p3.Draw();

            Point p4 = new Point(3, 8, '@');
            p4.Draw();

            HorizontalLine line1 = new HorizontalLine(5, 10, 8, '+');
            line1.Draw();

            VerticalLine line2 = new VerticalLine(4, 8, 20, '+');
            line2.Draw();

            Console.ReadLine();
        }
    }
}
