using System;
using System.Collections.Generic;

namespace Ramlist
{
    internal class Program
    {
        public class Ramdomlist
        {
           
            


         
          
            
          

          /*  public ramdonlist()
            {
                list = new List<string>();
            }

            public void Add(string name)
            {
                list.Add(name);
            }

            public void Remove(string name)
            {
                list.Remove(name);
            }

           
            public override string ToString()
            {
                return string.Join(", ", list);
            }
        }
*/
        static void Main(string[] args)
        {
            ramdonlist ramlist = new ramdonlist();
            ramlist.Add("Item1"); 
            Console.WriteLine(ramlist.ToString());
        }
    }
}
