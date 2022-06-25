using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week you workout the most?");
                //check if string user input exist in the enum Weekday
                Weekday day = (Weekday)Enum.Parse(typeof(Weekday), Console.ReadLine());
                //Print result 
                Console.WriteLine("You workout mostly on " + day);
            }
            //If no proper weekday input, display error message.
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
    //enum class Weekday
    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
