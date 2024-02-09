using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    
    
    public class Program
    {
        public struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Display()
            {
                Console.Write($"{X}, {Y}");
            }
        }

        static void Main(string[] args)
        {
            Point p = new Point(1,101);
            Point p1 = new Point(2, 102);
            Console.Write("Point1");
            p.Display();
            Console.WriteLine("point2");
            p1.Display();

            p.X = 1;
            Console.WriteLine("Modified Point 1:");
            p.Display(); Console.WriteLine("Modified Point 1:");
           

        }
    }
}
