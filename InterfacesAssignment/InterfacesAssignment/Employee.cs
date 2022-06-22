using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
        public class Employee : IQuittable
        {
            public void SayName()
            {
                Console.WriteLine(firstName + "" + lastName);
            }

            public void Quit()
            {
                 Console.WriteLine("The list for first quartal.");
            }
    } 
}
