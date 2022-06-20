using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)

        {
            Class1 obj = new Class1();

            obj.Add(firstNumber: 123, secondNumber: 55);

            int n = 5;
            int n1 = 2;

            obj.Add(n, n1);
            //Console.WriteLine("The value: {0}", n + n1);
            Console.ReadLine();
       
        }

    }

}
