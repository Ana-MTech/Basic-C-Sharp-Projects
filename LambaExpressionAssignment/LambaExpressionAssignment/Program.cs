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

            List<string> joeList = employee.firstName.Where(x => x == "Joe").ToList();

            foreach (string joe in joeList)
            {
                Console.WriteLine("\n"+joe);
            }

            List<int> aboveFive = employee.ID.Where(x => x > 5).ToList();



            //List<Employee> Employees = new List<Employee>();
            //List<string> firstNames = new List<string>()
            //{
            //    "Ann", "Joe", "Jason", "Ema", "Luke", "Math", "Joe", "Mary", "Rob", "Lee"
            //};

            //List<string> lastNames = new List<string>()
            //{
            //    "Smith", "Jones", "Taylor", "Brown", "Wilson", "Johnson", "Davies", "Cooper", "Lewis", "Wright"
            //};

            //List<int> IDs = new List<int>()
            //{
            //    3456542, 2347649, 8509003, 28394755, 23459584, 39303495, 39393903, 94857857, 9383833, 83700213
            //};

            //List<int> indexes = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            ////foreach (int index in indexes)
            //for (int i = 0; < firstNames.Length; i++)
            //{
            //    Employee Emplojeeobj = new Employee();
            //    Emplojeeobj.firstName = firstNames[i];
            //    Emplojeeobj.lastName = lastNames[i];
            //    Emplojeeobj.ID = IDs[i];
            //    Employees.Add(Emplojeeobj);
            //}

            //foreach (Employee Employee in Employees)
            //{
            //    Console.WriteLine(Employee.firstName + " " + Employee.lastName + " " + Employee.ID);

            //}


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

            //foreach (Employee employee in listEmployees.FindAll(x => (x.Name == "Joe")).ToList()) ;
            //{
            //    Console.WriteLine(Employee.Name + Employee.Surname);
            //}

           Console.ReadLine();

        }
    }
}
           
            


