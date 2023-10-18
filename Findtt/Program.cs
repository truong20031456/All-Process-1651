using System.Xml;

namespace Findtt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//5
            int[] number = new int[n];
        
               
          
            for(int i = 1; i < n;i++)
            {
                number[i] += i;

            }
            for(int i = 1; i < n; i++) {
                Console.WriteLine(number[i]);
            }
            
        }
            
}

            /* for (int i = 0; i < n; i++)
             {

                 number[i] += i;
                 Console.WriteLine(i);
                 *//*Console.WriteLine(i);*//*

             }*/
            /* foreach (int i in number)
             {
                 Console.WriteLine(i);

             }
       */

        }
  
