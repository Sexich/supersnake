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

            List<char> numList = new List<char>();
            numList.Add( '%' );
            numList.Add( '^' );
            numList.Add( 'û' );

            char x = numList[0];
            char y = numList[1];
            char z = numList[2];

            foreach( char i in numList)
            {
                Console.WriteLine(i);
            }

            /*numList.RemoveAt( 0 );*/

            List<Point> pList = new List<Point>();
            pList.Add( p1 );
            pList.Add( p2 );
            pList.Add( p3 );
            pList.Add( p4 );

            Console.ReadLine();
        }
    }
}
