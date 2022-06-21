using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
                Class1 obj = new Class1();

                Console.WriteLine("x : 2 = y");
                Console.WriteLine("Enter the x value, an positive whole number");
                int userValue = Convert.ToInt32(Console.ReadLine());
                obj.Division(userValue / 2);

                Console.WriteLine("10 / 5:");
                int y = 10;
                int z = 5;
                obj.Division1( y / z );
               

            Console.ReadLine();

        }
    }
}
