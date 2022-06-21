using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();

            obj.FirstName = "Sample";
            Console.WriteLine("FirstName");

            obj.LastName = "Student";
            Console.WriteLine("LastName");

            //call the superclass method SayName() on the Employee object
            Employee person = new Employee();
            person.SayName();

              
            Console.ReadLine();
        }
    }
}
