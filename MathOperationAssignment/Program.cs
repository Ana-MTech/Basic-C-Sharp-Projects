using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 50;
            Console.WriteLine("We will now multiply one number with 50. In order to do so please provide an number and then press enter.");
            num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * num2;
            Console.WriteLine("The result is: " + product);
            Console.WriteLine("");

            int num3 = 0;
            int num4 = 25;
            Console.WriteLine("We will now add one number to 25. In order to do so please provide an number and then press enter.");
            num3 = Convert.ToInt32(Console.ReadLine());
            int total = num3 + num4;
            Console.WriteLine("The result is: " + total);
            Console.WriteLine("");

            int num5 = 0;
            double num6 = 12.5;
            Console.WriteLine("We will now divide your input with 12.5. In order to do so please provide an number and then press enter.");
            num5 = Convert.ToInt32(Console.ReadLine());
            double quotient = num5 / num6;
            Console.WriteLine("The result is: " + quotient);
            Console.WriteLine("");

            int num7 = 0;
            int num8 = 50;
            Console.WriteLine(" Now, we checking if your input is greater than 50. In order to do so please provide an number and then press enter.");
            num7 = Convert.ToInt32(Console.ReadLine());
            bool trueOrfalse = num7 > num8;
            Console.WriteLine("The result is: " + trueOrfalse.ToString());
            Console.WriteLine("");

            int num9 = 0;
            int num10 = 7;
            Console.WriteLine(" Now, we will print to the console the remainder of your input divides by 7, if any.");
            num9 = Convert.ToInt32(Console.ReadLine());
            int remainder = num9 % num10;
            Console.WriteLine("The result is: " + remainder);
            Console.WriteLine("");


            Console.ReadLine();


      
        }
    }
}
