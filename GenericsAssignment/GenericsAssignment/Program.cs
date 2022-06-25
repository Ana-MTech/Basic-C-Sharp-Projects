using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> Things1 = new Employee<string>();
  
            Employee<int> Things2 = new Employee<int>();
 
            Things1.things = new List<string>() { "John Willis", "Tom Perry", "Any Smith" };

            Things2.things = new List<int>() { 1, 2, 3 };

            foreach (string things in Things1.things)
            {
                Console.WriteLine(things);
            }

            foreach (int things in Things2.things)
            {
                Console.WriteLine(things);
            }
            Console.ReadLine();
        }
    }
}
