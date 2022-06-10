using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Program
    {
       // public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number to do some basic math operation.");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();    //makes an object of Class1, object instatiation
            int result = obj.Add(userValue, 5);
            result = obj.Multiply(result, 1);
            result = obj.Subtract(result, 2);

            Console.WriteLine("User value + 5, result * by 1 and than result - 2 is: " + result);
            Console.ReadLine();
        }
    }
}
