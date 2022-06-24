using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
        class Employee : Person, IQuittable
        
    {
        public List<int> ID { get; set; }
            
        public void Quit(Employee employee) //Quit method
            {
                 Console.WriteLine("The list oy employees.");
            }
    } 
}
