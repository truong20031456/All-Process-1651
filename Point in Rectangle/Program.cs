using System;

namespace RectangleApp
{
    public class Point
    {
        // Private fields for x and y
        private int x;
        private int y;

        // Public properties with getters and setters
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        // Override ToString for better representation
        public override string ToString()
        {
            return $"Point ({X}, {Y})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 3);
            Point p1 = new Point(3, 4);

            // You can access the properties like this:
            Console.WriteLine($"Point p: X = {p.X}, Y = {p.Y}");
            Console.WriteLine($"Point p1: X = {p1.X}, Y = {p1.Y}");

            // Or use the overridden ToString method for a better representation
            Console.WriteLine(p);
            Console.WriteLine(p1);
        }
    }
}
