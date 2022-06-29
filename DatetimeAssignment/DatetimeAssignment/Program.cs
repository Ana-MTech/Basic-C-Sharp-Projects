using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The currant date and time: " + DateTime.Now);

            Console.WriteLine("Enter a number of hours that will be added on time now.");
            int passHours = Int32.Parse(Console.ReadLine());

            //data and time after the passHours has bneen added to DateTime.Now
            Console.WriteLine("In " + passHours + " it will be " + DateTime.Now.AddHours(passHours));
            Console.ReadLine();
        }
    }
}
