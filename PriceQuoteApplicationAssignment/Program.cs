using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");

            int packageWeight = 0;
            Console.WriteLine("Please enter the package weight.");
            packageWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //string result = (time < 18) ? "Good day." : "Good evening.";


            if (packageWeight > 50)
            {
                break;
            }
            { 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            
        
            //Console.WriteLine("");       
           
            int packageWidth = 0;
            Console.WriteLine("Please enter the package width.");
            packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int packageHeight= 0;
            Console.WriteLine("Please enter the package height.");
            packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int packageLenght = 0;
            Console.WriteLine("Please enter the package lenght.");
            packageLenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (packageWidth + packageHeight + packageLenght > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.WriteLine("");

            int priceQuote = ((packageHeight * packageWidth * packageLenght * packageWeight) / 100);
                     
            Console.WriteLine("Your estimated total for shipping this package is: " + priceQuote + "£" );
            Console.WriteLine("");

            Console.ReadLine();


        //Console.WriteLine("How many hours did you study today?");
        //    string hoursStudy = Console.ReadLine();
        //int hStudy = Convert.ToInt32(hoursStudy);
        //Console.WriteLine("Hours studying: " + hStudy);
        //    Console.WriteLine("");



        }
    }
}
