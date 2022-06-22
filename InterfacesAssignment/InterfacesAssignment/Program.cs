using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable file1 = new Employee();
            Employee file2 = new Employee();


            //file2.firstName = "Name";
            //file2.lastName = "Surname";

            file2.SayName();
            file1.Quit();
            Console.ReadLine();
        }
    }
}
