using System;

namespace TextReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            // Call the End method and store the result in a variable
            int result = End(a, b);

            // Print the result to the console
            Console.WriteLine("Result: " + result);
        }

        // This is your End method, but it should be static since you are calling it from a static context (Main method).
        public static int End(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
