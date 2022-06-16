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
            Class1 obj = new Class1();    //makes an object of Class1, object instatiation

            Console.WriteLine("We have an simple equation: x + y.");
            Console.WriteLine("Enter the x value, an positive whole number");
            int userValueX = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the y value. You may also choose to not enter anything for the value y.");
            //string userValueY = Console.ReadLine();  //make this variable string and use ReadLine to get user input


            //if (userValueY == " ") //use '=='for comparision, '='assigns value
            //{
            //    int result = obj.Add(userValueX);

            //}

            //else               
            //{
            //    int userValueZ = Convert.ToInt32(userValueY); //new variable set equal to the converted userValueY
            //    int result1 = obj.Add(userValueX, userValueZ);

            //}

            try 
            {
                Console.WriteLine("Enter the y value. You may also choose to not enter anything for the value y.");
                int userValueY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your x and y value added together equal" + obj.Add(userValueX, userValueY)); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Your only number choosn is " + userValueX);
            }
            finally
            {
                Console.ReadLine();
            }
     
        }
    }
}
