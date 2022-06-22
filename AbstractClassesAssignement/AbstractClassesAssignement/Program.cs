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
            person.lastName = "Student";
            person.SayName();
           
         
            Console.ReadLine();
        }
    }
}
