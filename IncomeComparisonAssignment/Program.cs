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

            int hourlyRate1 = 0;
            Console.WriteLine("Haurly rate?");
            hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int hoursWork1 = 0;
            Console.WriteLine("Hours worked per week?");
            hoursWork1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Person 2");
            Console.WriteLine("");

            int hourlyRate2 = 0;
            Console.WriteLine("Haurly rate?");
            hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int hoursWork2 = 0;
            Console.WriteLine("Hours worked per week?");
            hoursWork2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int weeksInyear = 52;

            Console.WriteLine("Annual salary of Person 1");
            int annualSalary1 = hourlyRate1 * hoursWork1 * weeksInyear;
            Console.WriteLine(annualSalary1);
            Console.WriteLine("");

            Console.WriteLine("Annual salary of Person 2");
            int annualSalary2 = hourlyRate2 * hoursWork2 * weeksInyear;
            Console.WriteLine(annualSalary2);
            Console.WriteLine("");





            //Console.WriteLine("Hourly rate?");
            //Console.WriteLine("15");
            //Console.WriteLine("");

            //Console.WriteLine("Hours worked per week?");
            //Console.WriteLine("40");
            //Console.WriteLine("");

            //Console.WriteLine("Person 2");
            //Console.WriteLine("");

            //Console.WriteLine("Hourly rate?");
            //Console.WriteLine("20");
            //Console.WriteLine("");

            //Console.WriteLine("Hours worked per week?");
            //Console.WriteLine("40");
            //Console.WriteLine("");

            //int weeksInyear = 52;
            //int hWork = 40;
            //int hourlyRate1 = 15;
            //int hourlyRate2 = 20;

            //Console.WriteLine("Annual salary of Person 1");
            //int annualSalary1 = hourlyRate1 * hWork * weeksInyear;
            //Console.WriteLine(annualSalary1);
            //Console.WriteLine("");

            //Console.WriteLine("Annual salary of Person 2");
            //int annualSalary2 = hourlyRate2 * hWork * weeksInyear;
            //Console.WriteLine(annualSalary2);
            //Console.WriteLine("");

            Console.WriteLine("Person 1 makes more money than Person 2");
            bool trueOrfalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrfalse);
            Console.WriteLine("");

            Console.ReadLine();

           

        }
    }

}
