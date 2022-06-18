using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("x + 5 = y. Enter the x value.");
            //int userValue = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();    //makes an object of Class1, object instatiation

            //get first number and call first method
            Console.WriteLine("x + 5 = y. Enter the x value in order to see result");
            
            //Console.WriteLine("Enter a number.");
            int UserValue = Convert.ToInt32(Console.ReadLine());
            int result = obj.Add(UserValue, 5);

            //get second number and call first method
            Console.WriteLine("x - 2.45 = y. Enter the x value in order to see result");

            //Console.WriteLine("Enter another number.");
            int UserValue2 = Convert.ToInt32(Console.ReadLine());
            decimal result2 = obj.Subtract(UserValue2, 2.45m);

            //get third number and call first method
            Console.WriteLine("x : 1 = y. Enter the x value in order to see result");

            //Console.WriteLine("Enter a third number.");
            int UserValue3 = Convert.ToInt32(Console.ReadLine());
            int result3 = obj.Division(UserValue3, 1);

            //get fourth number,but save as a string, and call fourth method          
            Console.WriteLine("Enter a fourth number.");
            string UserValue4 = Console.ReadLine();
            int result4 = obj.stringMethod(UserValue4);

            //here we use Console.WriteLine to return the result of the each method

            Console.WriteLine("The result of the first method is: " + result);
            Console.WriteLine("The result of the second method is: " + result2);
            Console.WriteLine("The result of the third method is: " + result3);
            Console.WriteLine("The result of the fourth method is: " + result4);

            Console.ReadLine();
        }
    }
}
