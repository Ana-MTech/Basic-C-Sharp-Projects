using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourAge = 0;
            Console.WriteLine("What is your age?");
            yourAge = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("");    

            Console.WriteLine("Have you ever had a DUI violation? [i.e., for driving under the influence of alcohol]");
            Console.WriteLine(" Please answer \"true\" or \"false\".");
            string DUIviolation = Console.ReadLine();
            bool DUIv = Convert.ToBoolean(DUIviolation);
            
            Console.WriteLine("");

            int speedingTicket = 0;
            Console.WriteLine("How many speeding tickets have you had?");
            speedingTicket = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("");

            Console.WriteLine("In order to determine if applicants qualifies for car insurance, all of the following requirements need to be met!");
            Console.WriteLine("Applicants must be over 15 years old, not have any DUIs and not have more than 3 speeding tickets.");
            Console.WriteLine("Qulified?");

            bool result = (yourAge > 15 && DUIv == false && speedingTicket > 3);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
