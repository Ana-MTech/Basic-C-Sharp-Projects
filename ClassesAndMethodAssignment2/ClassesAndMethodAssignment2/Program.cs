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
        {
           
            Console.WriteLine("We have an simple equation: x + y.");
            Console.WriteLine("Enter the x value.");
            int userValueX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y value. You may also choose to not enter anything for the value y.");
             userValueY = " ";

            if (userValueY = " ")
            {
                int result = obj.Add(userValueX);              
            }

            else if (userValueY > 0)              
            {
                int userValueY = Convert.ToInt32(Console.ReadLine());
                int result1 = obj.Add(userValueX, userValueY);                   
            }


            
           // OptionalMethodWithDefaultValue(10);
          
     
            Class1 obj = new Class1();    //makes an object of Class1, object instatiation
            Console.WriteLine(userValueX);
            //int result = obj.Add(userValueX, userValueY );


            //int result1 = obj.Add(userValueY, n );




            Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
            
        }
    }
}
