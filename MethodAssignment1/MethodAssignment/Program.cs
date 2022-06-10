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

            int obj = new Program();
            int result = obj.Add(userValue, 4);
            result = obj.Multiply(result, 1);
            result = obj.Substract(result, 2);

            //int programObject = new Program();
            //int result = programObject.Add(userValue, 4);
            //result = programObject.Multiply(result, 1);
            //result = programObject.Substract(result, 2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
