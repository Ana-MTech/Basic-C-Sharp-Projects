using System;


namespace DailyReportForStudent
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");

            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.WriteLine("");

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNo = Convert.ToInt32(pageNumber);
            Console.WriteLine("Your page number is: " + pageNo);
            Console.WriteLine("");

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool nHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine("Help needed: " + nHelp);
            Console.WriteLine("");
                
            Console.WriteLine("Where there any positive experiences you'd like to share? Please provide specifics.");
            string posExperience = Console.ReadLine();
            Console.WriteLine("Your answer: " + posExperience);
            Console.WriteLine("");

            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Your feedback: " + otherFeedback);
            Console.WriteLine("");

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int hStudy = Convert.ToInt32(hoursStudy);
            Console.WriteLine("Hours studying: " + hStudy);
            Console.WriteLine("");

            Console.WriteLine("Thank you for your responses. An Instructor will respond shortly. Have great day!");
            Console.ReadLine();
     
           
         
        }
    }
}
