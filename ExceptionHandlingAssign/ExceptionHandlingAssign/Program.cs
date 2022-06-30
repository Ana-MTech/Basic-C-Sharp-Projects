using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please, enter your age.");
                int yourAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine("You were born before " + yourAge + " and your birth year is " + DateTime.Today.AddYears(-yourAge).ToString("yyyy"));

                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Please, enter your age.");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter whole number only, no null or negative values.");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter an whole number. The null and negative values are not allowd.");
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured. please contact your System Administrator.");
            }
            finally  //finally Readline to keep program open even if program ends prematurely
            {
                Console.ReadLine();
            }
        }
    }
}
