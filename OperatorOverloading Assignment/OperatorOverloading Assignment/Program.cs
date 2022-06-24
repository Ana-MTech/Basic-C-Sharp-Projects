using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ID1 = new Employee();

            ID1.FirstName = "Mary";
            ID1.LastName = "Smith";
            ID1.ID = 23487651;

            Employee ID2 = new Employee();

            ID2.FirstName = "Patrick";
            ID2.LastName = "Shea";
            ID2.ID = 55556327;

            if (ID1 == ID2)
                Console.WriteLine("Same ID");
            else
                Console.WriteLine(""ifferent ID);

            Console.ReadLine();
        }
    }
}
