using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment2
{
    class Program
    {
        static public void Main()
        //static public void result(int x, int y, int[] n)
        {
           
            Console.WriteLine("We have an simple equation: x + y.");
            Console.WriteLine("Enter the x value.");
            int userValueX = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the y value. You may also choose to not enter anything for the value y.");
           // OptionalMethodWithDefaultValue(10);
            int userValueY = Convert.ToInt32(Console.ReadLine());
     
            Class1 obj = new Class1();    //makes an object of Class1, object instatiation
            int result = obj.Add(userValueX, userValueY );
            //int result1 = obj.Add2(userValueY, n );

            foreach ( int no in n)
            {
                result += no;
            }


            Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
            
        }
    }
}
