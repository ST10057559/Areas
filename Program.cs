using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("");
        }
    }
    class rectangle : Shape
    {
        int b = 12;
        int h = 6;
        public override void Area()
        {
            Console.WriteLine("The  area of the rectangle is : " + b * h);
        }
    }
    class Triangle : Shape
    {
        int b = 12;
        int h = 6;
        public override void Area()
        {
            Console.WriteLine("The area of the Triangle is : " + b * h / 2);
        }

    }
    class Parallellogram : Shape
    {
        int b = 8;
        int h = 10;
        public override void Area()
        {
            Console.WriteLine("The area of the parallellogram is : " + b * h);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Shape();
            Shape myrectangle = new rectangle();
            Shape myTriangle = new Triangle();
            Shape myParallellogram = new Parallellogram();

            myShape.Area();
            myrectangle.Area();
            myTriangle.Area();
            myParallellogram.Area();

            Console.ReadKey();


        }
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

