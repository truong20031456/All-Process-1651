using System;
using System.Security.Cryptography.X509Certificates;

namespace RectangleApp
{


    public class Rectangle

    {
        private Point X;
        private Point Y;

        public Point TopLeft { get { return X; } set { X = value; } }
        public Point BottomRight { get { return Y; } set { Y = value; } }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = TopLeft.X <= point.X && BottomRight.X >= point.X;
            bool isInVertical = TopLeft.Y <= point.Y && BottomRight.Y >= point.Y;
            bool isInRectangle = isInHorizontal && isInVertical;
            return isInRectangle;
        }
    }
}
    
