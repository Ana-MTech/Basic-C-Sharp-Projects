using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mary ";
            string lastName = "Cotter";
            string IDNumber = " 23-453-333";
            string name = firstName + lastName + IDNumber;
            Console.WriteLine(name);
            Console.WriteLine();
            
            // another way to concatenate strings below
            // string name = string.Concat ("firstName, lastName, IDNumber);

            string info = "Ann Smith";
            info = info.ToUpper();
            Console.WriteLine(info);
            Console.WriteLine();

            StringBuilder mySB = new StringBuilder();
            mySB.Append("The String object is immutable.");
            mySB.Append("Every time you use one of the methods in the System.String class, ");
            mySB.Append("you create a new string object in memory, which requires a new allocation of space for that new object.");           
            Console.WriteLine(mySB);

            Console.ReadLine();
        }
    }
}
