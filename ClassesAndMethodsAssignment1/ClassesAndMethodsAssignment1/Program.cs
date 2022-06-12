using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    public class Program
    {
        // public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("x + 5 = y. Enter the x value.");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();    //makes an object of Class1, object instatiation
            int result = obj.Add(userValue, 5);
            Class1 obj1 = obj.Subtract(userValue, 2,45);
            Class1 obj3 = obj.Division(userValue, 1);
            //result = obj.Multiply(result, 1);
            //result = obj.Subtract(result, 2);

            Add.GetResults();
            Subtract.getResults();
            Division.getResults();
        

            Console.ReadLine();
        }
    }
}
