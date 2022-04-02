using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");

            Console.WriteLine("Person 1");
            Console.WriteLine("");

            Console.WriteLine("Hourly rate?");
            Console.WriteLine("15");
            Console.WriteLine("");

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.WriteLine("");

            Console.WriteLine("Person 2");
            Console.WriteLine("");

            Console.WriteLine("Hourly rate?");
            Console.WriteLine("20");

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.WriteLine("");

            int weeksInyear1 = 52;
            int hWork = 40;
            int hourlyRate1 = 15;
            int hourlyRate2 = 20;

            Console.WriteLine("Annual salary of Person 1");
            int product1 = hourlyRate1 * hWork * weeksInyear1;
            Console.WriteLine(product1);
            Console.WriteLine("");

            Console.WriteLine("Annual salary of Person 2");
            int product2 = hourlyRate2 * hWork * weeksInyear1;
            Console.WriteLine(product2);
            Console.WriteLine("");

            Console.ReadLine();

            //int num1 = 0;
            //int num2 = 50;
            //Console.WriteLine("We will now multiply one number with 50. In order to do so please provide an number and then press enter.");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //int product = num1 * num2;
            //Console.WriteLine("The result is: " + product);
            //Console.WriteLine("");


            //string yourCourse = Console.ReadLine();
            //Console.WriteLine("Your course is: " + yourCourse);
            //Console.WriteLine("");

            //Console.WriteLine("What page number?");
            //string pageNumber = Console.ReadLine();
            //int pageNo = Convert.ToInt32(pageNumber);
            //Console.WriteLine("Your page number is: " + pageNo);
            //Console.WriteLine("");

            //Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            //string needHelp = Console.ReadLine();
            //bool nHelp = Convert.ToBoolean(needHelp);
            //Console.WriteLine("Help needed: " + nHelp);
            //Console.WriteLine("");

            //Console.WriteLine("Where there any positive experiences you'd like to share? Please provide specifics.");
            //string posExperience = Console.ReadLine();
            //Console.WriteLine("Your answer: " + posExperience);
            //Console.WriteLine("");

            //Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            //string otherFeedback = Console.ReadLine();
            //Console.WriteLine("Your feedback: " + otherFeedback);
            //Console.WriteLine("");


        }
    }

}
