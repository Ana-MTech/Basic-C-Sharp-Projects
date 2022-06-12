using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    public class Class1
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


    //public class Class1
    //{
        public decimal Subtract(decimal num3, decimal num4)
        {
            return num3 - num4;
        }

    //}

    //public class Class1
    //}
        public int Division (int num5, int num6)
        { 
            return num5 / num6;
        }

        public void GetResults()
        {
            Console.WriteLine("y = " + this.Add + "\n" +
                "y1 = " + this.Subtract + "\n" +
                "y3 = " + this.Division + "\n");

        }

    }

}   

