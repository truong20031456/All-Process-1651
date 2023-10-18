using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramdom_game
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Random rnd = new Random();
            Console.WriteLine(rnd.Next(11));



            /* string[] words = Console.ReadLine().Split(' ');
             Random rnd = new Random();
             for (int pos1 = 0; pos1 < words.Length; pos1++)
             {
                 int pos2 = rnd.Next(words.Length);
                 words[pos1] = words[pos2];
             }

             Console.WriteLine(string.Join(Environment.NewLine, words));*/


            /* *Demo 3*/


            /*  Random rnd = new Random();
                  for (int i = 0; i < 50; i++)
                  {
                      Console.WriteLine(rnd.Next(1, 99));

                  }*/
        }
    }
}
