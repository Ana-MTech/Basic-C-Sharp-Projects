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

        public decimal Subtract(decimal num3, decimal num4)
        {
            return num3 - num4;
        }

        public int Division (int num5, int num6)
        { 
            return num5 / num6;
        }

        public int stringMethod (string num7)  // takes in a string as the parametar
        {
            int num8 = Convert.ToInt32(num7);
            return num8;   // returns the integer
        }
    }

}   

