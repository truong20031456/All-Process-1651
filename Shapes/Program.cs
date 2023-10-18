namespace Shapes
{
    
    internal class Program
    {
        public interface IDrawable
        {
            void Draw();
        }
        public class Retangle : IDrawable
        {
            public void Draw()
            {
                Console.WriteLine("ve ");
            }
        }
        public class Circle : IDrawable
        {
            public void Draw()
            {
                Console.WriteLine("ve hinh trong");
            }
        }

        static void Main(string[] args)
        {
            IDrawable d = new Retangle();
            d.Draw();
            IDrawable drawable = new Circle();
            drawable.Draw();
            
        }
    }
}