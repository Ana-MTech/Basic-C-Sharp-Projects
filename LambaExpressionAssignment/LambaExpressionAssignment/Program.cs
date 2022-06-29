using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = new List<string>()
            {
                "Ann", "Joe", "Jason", "Ema", "Luke", "Math", "Joe", "Mary", "Rob", "Lee"
            };

            employee.lastName = new List<string>()
            {
                "Smith", "Jones", "Taylor", "Brown", "Wilson", "Johnson", "Davies", "Cooper", "Lewis", "Wright"
            };

            employee.ID = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            //count of employee.firstName string that are "Joe"
            int count = employee.firstName.Count(x => x == "Joe");

            //create list > joeList from employee.firstName that contain "Joe"
            List<string> joeList = employee.firstName.Where(x => x == "Joe").ToList();

            //create a list from employee.ID where ID is above 5
            List<int> aboveFive = employee.ID.Where(x => x > 5).ToList();

            //loop that prints a list of employee data from the list aboveFive
            for (int i = aboveFive[0] - 1; i < aboveFive[0] + aboveFive.Count - 1; i++)
            {
                Console.WriteLine(employee.ID[i] + " " + employee.firstName[i] + " " + employee.lastName[i]);
            }

            //loop that prints a list of employee data from the list joeList
            foreach (string joe in joeList)
            {
                Console.WriteLine("\n"+joe);
            }

            Console.ReadLine();

            //List<Employee> listEmployees = new List<Employee>();
            //listEmployees.Add(new Employee("John", "Taylor", 1));
            //listEmployees.Add(new Employee("Ann", "Smith", 2));
            //listEmployees.Add(new Employee("Jason", "Jones", 3));
            //listEmployees.Add(new Employee("Joe", "Brown", 4));
            //listEmployees.Add(new Employee("Luke", "Wilson", 5));
            //listEmployees.Add(new Employee("Math", "Johnson", 6));
            //listEmployees.Add(new Employee("Joe", "Davies", 7));
            //listEmployees.Add(new Employee("Mary", "Cooper", 8));
            //listEmployees.Add(new Employee("Rob", "Lewis", 9));
            //listEmployees.Add(new Employee("Lee", "Wright", 10));

        }
    }
}
           
            


