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
            Employee employee= new Employee();
            IQuittable quit = new Employee();
            
            //Call method Quit() from IQuittable
            quit.Quit(employee);

            //Employee list
            employee.FullName = new List<string>() { "Matt Smith", "John Callas", " Tom Perry" };
            //employee.ID = new List<int>() { 5432, 1124, 8765 };

            foreach (string FullName in employee.FullName)
            {
                employee.SayName(FullName);
            }
            Console.ReadLine();
        }
    }
}
