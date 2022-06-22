using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();

            person.firstName = "Sample";
            Console.WriteLine("firstName");

            person.lastName = "Student";
            Console.WriteLine("lastName");

            person.SayName();      
           
            Console.ReadLine();
        }
    }
}
